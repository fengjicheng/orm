using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
//友元程序集
using System.Runtime.CompilerServices;
//using  Q=Qhyhgf.Orm.ExpressionEx;
using Qhyhgf.Orm.ExpressionEx;
using Qhyhgf.Orm;
using Moq;

namespace Qhyhgf.Test
{

    //clr排列方式
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto)]
    public struct Student:System.IEquatable<Student>
    { 
        public string Name { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public string Sex { get; set; }
    
        public bool  Equals(Student other)
        {
           
            if (this.Address != other.Address || this.Name != other.Name || this.Age != other.Age || this.Sex != other.Sex)
            {
                return false;
            }
            return true;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        } 
    }
    class TestFastItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            var test = new Mock<TestFastItem>();
            test.SetupProperty(e =>e.ID);


            SqlQuery<TestFastItem>  context = DbContext<TestFastItem>.Get();
            foreach (var item in context)
            {
                item.ID= 1;
            }
           
            TestFastItem TestFastValue = new TestFastItem ();
            Type type = TestFastValue.GetType();
            PropertyInfo propersID = type.GetProperty("ID");
            PropertyInfo propersName = type.GetProperty("Name");
            ///快速反射测试Emit实现
            SetValueDelegate delegateID = FastMethodFactory.CreatePropertySetter(propersID);
            SetValueDelegate delegateName = FastMethodFactory.CreatePropertySetter(propersName);

            delegateID(TestFastValue, 4);
            delegateName(TestFastValue, "aaa");
            //快速反射测试Delegate.CreateDelegate实现
            Action<TestFastItem,int> setter = (Action<TestFastItem,int>) Delegate.CreateDelegate(
    typeof(Action<TestFastItem, int>), null, propersID.GetSetMethod());

            Student t1 = new Student(); ;
            t1.Age = 20;
            //动态类型
            dynamic d =t1;
            d = t1;
            Expre2Sql.DatabaseType = Orm.Config.DataSourceType.MysSql;
            //简单查询
            var sudent1 = Expre2Sql.Select<Student>();
            string str = sudent1.SqlStr;
            Int32 a = 2147483647;
            //溢出检测
            checked {

                a = a - 1;
            }
            a=  unchecked(a + 1);
            bool b= a.Equals(111);
            //查询单字段
            var sudent2 = Expre2Sql.Select<Student>(u=>u.Age);
            str = sudent2.SqlStr;
            //查询多个字段
            var sudent3 = Expre2Sql.Select<Student>(u =>new {
                u.Age,
                u.Address
            });
            //"查询单表，带where Like条件"
            var sudent4  = Expre2Sql.Select<Student>(u => u.Age).
                          Where(u => u.Name.Like("b"));
            str = sudent4.SqlStr;
            str = sudent1.GetHashCode().ToString();
        }
       
    }
}

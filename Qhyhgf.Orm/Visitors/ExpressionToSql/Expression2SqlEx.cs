namespace Qhyhgf.Orm.ExpressionEx
{
    /// <summary>
    /// 运算符扩展
    /// </summary>
	public static class Expression2SqlEx
	{
        /// <summary>
        /// like扩展
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="value"></param>
        /// <returns></returns>
		public static bool Like(this object obj, string value)
		{
			return true;
		}

		/// <summary>
		/// like '% _ _ _'
		/// </summary>
		public static bool LikeLeft(this object obj, string value)
		{
			return true;
		}

		/// <summary>
		/// like '_ _ _ %'
		/// </summary>
		public static bool LikeRight(this object obj, string value)
		{
			return true;
		}
        /// <summary>
        /// In实现
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="ary"></param>
        /// <returns></returns>
		public static bool In<T>(this object obj, params T[] ary)
		{
			return true;
		}
	}
}

namespace Cyjb.Compilers.Text;

/// <summary>
/// 表示源文件的标记。
/// </summary>
public sealed class SourceMark : IComparable<SourceMark>
{
	/// <summary>
	/// 源文件的索引。
	/// </summary>
	internal readonly int index;
	/// <summary>
	/// 当前标记是否有效。
	/// </summary>
	internal bool Valid = true;

	/// <summary>
	/// 使用指定的源文件索引初始化 <see cref="SourceMark"/> 类的新实例。
	/// </summary>
	/// <param name="index">源文件的索引。</param>
	internal SourceMark(int index)
	{
		this.index = index;
	}

	/// <summary>
	/// 获取对应的源文件索引。
	/// </summary>
	public int Index => index;

	#region IComparable<SourceMark> 成员

	/// <summary>
	/// 将当前对象与同一类型的另一个对象进行比较。
	/// </summary>
	/// <param name="other">要比较的对象。</param>
	/// <returns>一个值，指示要比较的对象的相对顺序。</returns>
	public int CompareTo(SourceMark? other)
	{
		if (other is null)
		{
			return 1;
		}
		return Index - other.Index;
	}

	/// <summary>
	/// 返回一个 <see cref="SourceMark"/> 对象是否小于另一个 <see cref="SourceMark"/> 对象。
	/// </summary>
	/// <param name="left">要比较的第一个对象。</param>
	/// <param name="right">要比较的第二个对象。</param>
	/// <returns>如果 <paramref name="left"/> 小于 <paramref name="right"/>，则为 <c>true</c>；否则为 <c>false</c>。</returns>
	public static bool operator <(SourceMark? left, SourceMark? right)
	{
		if (ReferenceEquals(left, right))
		{
			return false;
		}
		if (left is null)
		{
			return true;
		}
		return left.CompareTo(right) < 0;
	}

	/// <summary>
	/// 返回一个 <see cref="SourceMark"/> 对象是否小于等于另一个 <see cref="SourceMark"/> 对象。
	/// </summary>
	/// <param name="left">要比较的第一个对象。</param>
	/// <param name="right">要比较的第二个对象。</param>
	/// <returns>如果 <paramref name="left"/> 小于等于 <paramref name="right"/>，则为 <c>true</c>；否则为 <c>false</c>。</returns>
	public static bool operator <=(SourceMark? left, SourceMark? right)
	{
		if (ReferenceEquals(left, right) || left is null)
		{
			return true;
		}
		return left.CompareTo(right) <= 0;
	}

	/// <summary>
	/// 返回一个 <see cref="SourceMark"/> 对象是否大于另一个 <see cref="SourceMark"/> 对象。
	/// </summary>
	/// <param name="left">要比较的第一个对象。</param>
	/// <param name="right">要比较的第二个对象。</param>
	/// <returns>如果 <paramref name="left"/> 大于 <paramref name="right"/>，则为 <c>true</c>；否则为 <c>false</c>。</returns>
	public static bool operator >(SourceMark? left, SourceMark? right)
	{
		if (ReferenceEquals(left, right) || left is null)
		{
			return false;
		}
		return left.CompareTo(right) > 0;
	}

	/// <summary>
	/// 返回一个 <see cref="SourceMark"/> 对象是否大于等于另一个 <see cref="SourceMark"/> 对象。
	/// </summary>
	/// <param name="left">要比较的第一个对象。</param>
	/// <param name="right">要比较的第二个对象。</param>
	/// <returns>如果 <paramref name="left"/> 大于等于 <paramref name="right"/>，则为 <c>true</c>；否则为 <c>false</c>。</returns>
	public static bool operator >=(SourceMark? left, SourceMark? right)
	{
		if (ReferenceEquals(left, right))
		{
			return true;
		}
		if (left is null)
		{
			return false;
		}
		return left.CompareTo(right) >= 0;
	}

	#endregion // IComparable<SourceMark> 成员

}

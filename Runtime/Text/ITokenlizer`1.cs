namespace Cyjb.Text;

/// <summary>
/// 表示一个词法分析器。
/// </summary>
/// <seealso cref="Token{T}"/>
/// <typeparam name="T">词法单元标识符的类型，一般是一个枚举类型。</typeparam>
public interface ITokenlizer<T> : IDisposable, IEnumerable<Token<T>>
	where T : struct
{
	/// <summary>
	/// 读取输入流中的下一个词法单元并提升输入流的字符位置。
	/// </summary>
	/// <returns>输入流中的下一个词法单元。</returns>
	/// <exception cref="TokenlizerException">发现了未识别的字符。</exception>
	public abstract Token<T> Read();
}

using Cyjb.Text;

namespace Cyjb.Compilers.Lexers;

/// <summary>
/// 表示词法分析器的工厂。
/// </summary>
/// <typeparam name="T">词法单元标识符的类型，一般是一个枚举类型。</typeparam>
/// <typeparam name="TController">词法分析控制器的类型。</typeparam>
/// <remarks>关于如何构造自己的词法分析器，可以参考我的博文
/// <see href="http://www.cnblogs.com/cyjb/archive/p/LexerLexer.html">
/// 《C# 词法分析器（六）构造词法分析器》</see>。</remarks>
/// <seealso href="http://www.cnblogs.com/cyjb/archive/p/LexerLexer.html">
/// 《C# 词法分析器（六）构造词法分析器》</seealso>
public sealed class LexerFactory<T, TController> : ILexerFactory<T>
	where T : struct
	where TController : LexerController<T>, new()
{
	/// <summary>
	/// 动作处理器。
	/// </summary>
	private static readonly Action<Delegate, LexerController<T>> actionHandler =
		(Delegate action, LexerController<T> controller) =>
		{
			((Action<TController>)action)((TController)controller);
		};

	/// <summary>
	/// 词法分析器的数据。
	/// </summary>
	private readonly LexerData<T> lexerData;

	/// <summary>
	/// 使用指定的词法分析器数据初始化 <see cref="LexerFactory{T,TController}"/> 类的新实例。
	/// </summary>
	/// <param name="lexerData">词法分析器的数据。</param>
	public LexerFactory(LexerData<T> lexerData)
	{
		this.lexerData = lexerData;
	}

	/// <summary>
	/// 创建分析指定源文件的词法分析器。
	/// </summary>
	/// <param name="source">要读取的源文件。</param>
	/// <returns>指定源文件的词法分析器。</returns>
	/// <exception cref="ArgumentNullException"><paramref name="source"/> 为 <c>null</c>。</exception>
	/// <overloads>
	/// <summary>
	/// 创建分析指定源文件的词法分析器。
	/// </summary>
	/// </overloads>
	public ITokenizer<T> CreateTokenizer(string source)
	{
		ArgumentNullException.ThrowIfNull(source);
		return CreateTokenizer(new SourceReader(new StringReader(source)));
	}

	/// <summary>
	/// 创建分析指定源文件的词法分析器。
	/// </summary>
	/// <param name="source">要读取的源文件。</param>
	/// <returns>指定源文件的词法分析器。</returns>
	/// <exception cref="ArgumentNullException"><paramref name="source"/> 为 <c>null</c>。</exception>
	public ITokenizer<T> CreateTokenizer(SourceReader source)
	{
		ArgumentNullException.ThrowIfNull(source);
		TController controller = new();
		controller.Init(source, lexerData.Contexts, actionHandler, lexerData.Rejectable);
		if (lexerData.Rejectable)
		{
			if (lexerData.TrailingType == TrailingType.None)
			{
				return new TokenizerRejectable<T>(lexerData, controller, source);
			}
		}
		else
		{
			if (lexerData.TrailingType == TrailingType.None)
			{
				return new TokenizerSimpler<T>(lexerData, controller, source);
			}
			else if (lexerData.TrailingType == TrailingType.Fixed)
			{
				return new TokenizerFixedTrailing<T>(lexerData, controller, source);
			}
		}
		return new TokenizerRejectableTrailing<T>(lexerData, controller, source);
	}
}

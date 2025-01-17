﻿//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由工具生成。
//
// 对此文件的更改可能会导致不正确的行为，并且如果
// 重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cyjb.Compilers.Lexers;

namespace TestCompilers.Lexers;

public partial class TestProductionLexer 
{ 	/// <summary>
	/// 词法分析器的工厂。
	/// </summary>
	public static readonly ILexerFactory<ProductionKind> Factory = CreateLexerFactory();

	/// <summary>
	/// 创建词法分析器的工厂。
	/// </summary>
	[CompilerGeneratedAttribute]
	private static ILexerFactory<ProductionKind> CreateLexerFactory()
	{
		// 终结符数据
		TerminalData<ProductionKind>[] terminals = new[]
		{
			// 0: \d+|\w[\w\d]*
			new TerminalData<ProductionKind>(ProductionKind.Id),
			// 1: \(
			new TerminalData<ProductionKind>(ProductionKind.LBrace),
			// 2: \)
			new TerminalData<ProductionKind>(ProductionKind.RBrace),
			// 3: \+
			new TerminalData<ProductionKind>(ProductionKind.Plus),
			// 4: \*
			new TerminalData<ProductionKind>(ProductionKind.Star),
			// 5: \?
			new TerminalData<ProductionKind>(ProductionKind.Question),
			// 6: \s
			new TerminalData<ProductionKind>()
		};
		// 字符类信息
		// 0: [\p{Lu}\p{Ll}\p{Lt}\p{Lm}\p{Lo}\p{Mn}\p{Nd}\p{Pc}]
		// 1: [(]
		// 2: [)]
		// 3: [+]
		// 4: [*]
		// 5: [?]
		// 6: [\t-\r\u0085\p{Zs}\p{Zl}\p{Zp}]
		// 字符类索引
		uint[] indexes = new[]
		{
			8716421U
		};
		// 字符类列表
		int[] classes = new[]
		{
			-1, -1, -1, -1, -1, -1, -1, -1, -1, 6, 6, 6, 6, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
			-1, -1, -1, -1, -1, -1, -1, -1, 6, -1, -1, -1, -1, -1, -1, -1, 1, 2, 4, 3, -1, -1, -1, -1,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, 5, -1, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, 0,
			-1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, -1, -1, -1, -1, -1, 6
		};
		// 字符类 Unicode 类别
		Dictionary<UnicodeCategory, int> categories = new()
		{
			 { UnicodeCategory.LineSeparator, 6 },
			 { UnicodeCategory.ParagraphSeparator, 6 },
			 { UnicodeCategory.ConnectorPunctuation, 0 },
			 { UnicodeCategory.SpaceSeparator, 6 },
			 { UnicodeCategory.DecimalDigitNumber, 0 },
			 { UnicodeCategory.NonSpacingMark, 0 },
			 { UnicodeCategory.UppercaseLetter, 0 },
			 { UnicodeCategory.LowercaseLetter, 0 },
			 { UnicodeCategory.TitlecaseLetter, 0 },
			 { UnicodeCategory.OtherLetter, 0 },
			 { UnicodeCategory.ModifierLetter, 0 }
		};
		// 状态转移
		//    0  1  2  3  4  5  6 -> Symbols
		// 0  1  2  3  4  5  6  7
		// 1  1                   -> 0
		// 2                      -> 1
		// 3                      -> 2
		// 4                      -> 3
		// 5                      -> 4
		// 6                      -> 5
		// 7                      -> 6
		// 状态列表
		int[] states = new[]
		{
			0, -1, 0, 0, 7, -1, 1, 32,
			int.MinValue, -1, 1, 33, int.MinValue, -1, 1, 34,
			int.MinValue, -1, 1, 35, int.MinValue, -1, 1, 36,
			int.MinValue, -1, 1, 37, int.MinValue, -1, 1, 38,
			0, 1, 2, 3, 4, 5, 6
		};
		// 后继状态列表
		int[] next = new[]
		{
			1, 2, 3, 4, 5, 6, 7, 1
		};
		// 状态检查列表
		int[] check = new[]
		{
			0, 0, 0, 0, 0, 0, 0, 1
		};
		// 词法分析器的数据
		LexerData<ProductionKind> lexerData = new(null,
			terminals,
			new CharClassMap(indexes, classes, categories),
			states,
			next,
			check,
			TrailingType.None,
			false,
			false,
			typeof(TestProductionLexer));
		return new LexerFactory<ProductionKind, TestProductionLexer>(lexerData);
	}
}




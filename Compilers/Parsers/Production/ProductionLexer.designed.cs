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
using Cyjb.Compilers.Lexers;

namespace Cyjb.Compilers.Parsers.Production;

internal partial class ProductionLexer 
{
	/// <summary>
	/// 词法分析器的工厂。
	/// </summary>
	public static readonly ILexerFactory<ProductionKind> Factory = CreateLexerFactory();

	/// <summary>
	/// 创建词法分析器的工厂。
	/// </summary>
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	private static ILexerFactory<ProductionKind> CreateLexerFactory()
	{
		// 终结符数据
		TerminalData<ProductionKind>[] terminals = new[]
		{
			// 0: \(
			new TerminalData<ProductionKind>(ProductionKind.LBrace),
			// 1: \)
			new TerminalData<ProductionKind>(ProductionKind.RBrace),
			// 2: \+
			new TerminalData<ProductionKind>(ProductionKind.Plus),
			// 3: \*
			new TerminalData<ProductionKind>(ProductionKind.Star),
			// 4: \?
			new TerminalData<ProductionKind>(ProductionKind.Question),
			// 5: \s
			new TerminalData<ProductionKind>(),
			// 6: \d+|\w[\w\d]*
			new TerminalData<ProductionKind>(ProductionKind.Id, (ProductionLexer c) => c.SymbolAction())
		};
		// 字符类信息
		// 0: [(]
		// 1: [)]
		// 2: [+]
		// 3: [*]
		// 4: [?]
		// 5: [\t-\r\u0085\p{Zs}\p{Zl}\p{Zp}]
		// 6: [\p{Lu}\p{Ll}\p{Lt}\p{Lm}\p{Lo}\p{Mn}\p{Nd}\p{Pc}]
		// 字符类索引
		int[] indexes = new[]
		{
			8716421
		};
		// 字符类列表
		int[] classes = new[]
		{
			-1, -1, -1, -1, -1, -1, -1, -1, -1, 5, 5, 5, 5, 5, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
			-1, -1, -1, -1, -1, -1, -1, -1, 5, -1, -1, -1, -1, -1, -1, -1, 0, 1, 3, 2, -1, -1, -1, -1,
			6, 6, 6, 6, 6, 6, 6, 6, 6, 6, -1, -1, -1, -1, -1, 4, -1, 6, 6, 6, 6, 6, 6, 6,
			6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, -1, -1, -1, -1, 6,
			-1, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
			6, 6, 6, -1, -1, -1, -1, -1, 5
		};
		// 字符类 Unicode 类别
		Dictionary<UnicodeCategory, int> categories = new()
		{
			 { UnicodeCategory.LineSeparator, 5 },
			 { UnicodeCategory.ParagraphSeparator, 5 },
			 { UnicodeCategory.ConnectorPunctuation, 6 },
			 { UnicodeCategory.SpaceSeparator, 5 },
			 { UnicodeCategory.DecimalDigitNumber, 6 },
			 { UnicodeCategory.NonSpacingMark, 6 },
			 { UnicodeCategory.UppercaseLetter, 6 },
			 { UnicodeCategory.LowercaseLetter, 6 },
			 { UnicodeCategory.TitlecaseLetter, 6 },
			 { UnicodeCategory.OtherLetter, 6 },
			 { UnicodeCategory.ModifierLetter, 6 }
		};
		// 状态转移
		//    0  1  2  3  4  5  6 -> Symbols
		// 0  1  2  3  4  5  6  7
		// 1                      -> 0
		// 2                      -> 1
		// 3                      -> 2
		// 4                      -> 3
		// 5                      -> 4
		// 6                      -> 5
		// 7                    7 -> 6
		// 状态列表
		DfaStateData[] states = new[]
		{
			new DfaStateData(0, -1),
			new DfaStateData(int.MinValue, -1, 0),
			new DfaStateData(int.MinValue, -1, 1),
			new DfaStateData(int.MinValue, -1, 2),
			new DfaStateData(int.MinValue, -1, 3),
			new DfaStateData(int.MinValue, -1, 4),
			new DfaStateData(int.MinValue, -1, 5),
			new DfaStateData(1, -1, 6)
		};
		// 后继状态列表
		int[] next = new[]
		{
			1, 2, 3, 4, 5, 6, 7, 7
		};
		// 状态检查列表
		int[] check = new[]
		{
			0, 0, 0, 0, 0, 0, 0, 7
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
			typeof(ProductionLexer));
		return new LexerFactory<ProductionKind, ProductionLexer>(lexerData);
	}
}




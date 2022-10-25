﻿//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由工具生成。
//
// 对此文件的更改可能会导致不正确的行为，并且如果
// 重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using Cyjb.Compilers.Lexers;

namespace TestCompilers.Lexers;


/// <summary>
/// 测试词法单元的值。
/// </summary>
public partial class TestSymbolValueLexer 
{
	/// <summary>
	/// 词法分析器的工厂。
	/// </summary>
	public static readonly ILexerFactory<Calc> Factory = CreateLexerFactory();

	/// <summary>
	/// 创建词法分析器的工厂。
	/// </summary>
	[CompilerGeneratedAttribute]
	private static ILexerFactory<Calc> CreateLexerFactory()
	{
		// 终结符数据
		TerminalData<Calc>[] terminals = new[]
		{
			// 0: [0-9]+
			new TerminalData<Calc>(Calc.Id, 101, (TestSymbolValueLexer c) => c.DigitAction())
		};
		// 字符类信息
		// 0: [0-9]
		// 字符类索引
		int[] indexes = Array.Empty<int>();
		// 字符类列表
		int[] classes = new[]
		{
			-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
			-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
			-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
			-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
			-1, -1, -1, -1, -1, -1, -1, -1
		};
		// 状态转移
		//    0 -> Symbols
		// 0  1
		// 1  1 -> 0
		// 状态列表
		DfaStateData[] states = new[]
		{
			new DfaStateData(0, -1),
			new DfaStateData(1, -1, 0)
		};
		// 后继状态列表
		int[] next = new[]
		{
			1, 1
		};
		// 状态检查列表
		int[] check = new[]
		{
			0, 1
		};
		// 词法分析器的数据
		LexerData<Calc> lexerData = new(null,
			terminals,
			new CharClassMap(indexes, classes, null),
			states,
			next,
			check,
			TrailingType.None,
			false,
			false,
			typeof(TestSymbolValueLexer));
		return new LexerFactory<Calc, TestSymbolValueLexer>(lexerData);
	}
}



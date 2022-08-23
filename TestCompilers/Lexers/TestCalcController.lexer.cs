//------------------------------------------------------------------------------
// <auto-generated>
// �˴����ɹ������ɡ�
//
// �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
// �������ɴ��룬��Щ���Ľ��ᶪʧ��
// </auto-generated>
//------------------------------------------------------------------------------

using Cyjb.Compilers.Lexers;
using System;
using System.Collections.Generic;
using System.Globalization;
using Cyjb.Text;

namespace TestCompilers.Lexers;
public partial class TestCalcController 
{
	/// <summary>
	/// �ʷ��������Ĺ�����
	/// </summary>
	public static readonly ILexerFactory<Calc> Factory = CreateLexerFactory();

	/// <summary>
	/// �����ʷ��������Ĺ�����
	/// </summary>
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	private static ILexerFactory<Calc> CreateLexerFactory()
	{
		// ����������
		Dictionary<string, ContextData<Calc>> contexts = new()
		{
			 { "Initial", new ContextData<Calc>(0, "Initial") }
		};
		// �ս������
		TerminalData<Calc>[] terminals = new[]
		{
			// 0: \+
			new TerminalData<Calc>(Calc.Add),
			// 1: \-
			new TerminalData<Calc>(Calc.Sub),
			// 2: \*
			new TerminalData<Calc>(Calc.Mul),
			// 3: \/
			new TerminalData<Calc>(Calc.Div),
			// 4: \^
			new TerminalData<Calc>(Calc.Pow),
			// 5: \(
			new TerminalData<Calc>(Calc.LBrace),
			// 6: \)
			new TerminalData<Calc>(Calc.RBrace),
			// 7: \s
			new TerminalData<Calc>(),
			// 8: [0-9]+
			new TerminalData<Calc>(Calc.Id, (TestCalcController c) => c.DigitAction())
		};
		// �ַ�����Ϣ
		// 0: [+]
		// 1: [-]
		// 2: [*]
		// 3: [/]
		// 4: [^]
		// 5: [(]
		// 6: [)]
		// 7: [\t-\r \u0085\u00A0\u1680\u2000-\u200A\u2028\u2029\u202F\u205F\u3000]
		// 8: [0-9]
		// �ַ�������
		int[] indexes = new[]
		{
			8388740, 8781983
		};
		// �ַ����б�
		int[] classes = new[]
		{
			-1, -1, -1, -1, -1, -1, -1, -1, -1, 7, 7, 7, 7, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
			-1, -1, -1, -1, -1, -1, -1, -1, 7, -1, -1, -1, -1, -1, -1, -1, 5, 6, 2, 0, -1, 1, -1, 3,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
			-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1,
			-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
			-1, -1, -1, -1, -1, -1, -1, -1, -1, -1
		};
		// �ַ��� Unicode ���
		Dictionary<UnicodeCategory, int> categories = new()
		{
			 { UnicodeCategory.SpaceSeparator, 7 },
			 { UnicodeCategory.LineSeparator, 7 },
			 { UnicodeCategory.ParagraphSeparator, 7 },
			 { UnicodeCategory.Control, 7 }
		};
		// ״̬ת��
		//    0  1  2  3  4  5  6  7  8 -> Symbols
		// 0  1  2  3  4  5  6  7  8  9
		// 1                            -> 0
		// 2                            -> 1
		// 3                            -> 2
		// 4                            -> 3
		// 5                            -> 4
		// 6                            -> 5
		// 7                            -> 6
		// 8                            -> 7
		// 9                          9 -> 8
		// ״̬�б�
		DfaStateData[] states = new[]
		{
			new DfaStateData(0, -1),
			new DfaStateData(int.MinValue, -1, 0),
			new DfaStateData(int.MinValue, -1, 1),
			new DfaStateData(int.MinValue, -1, 2),
			new DfaStateData(int.MinValue, -1, 3),
			new DfaStateData(int.MinValue, -1, 4),
			new DfaStateData(int.MinValue, -1, 5),
			new DfaStateData(int.MinValue, -1, 6),
			new DfaStateData(int.MinValue, -1, 7),
			new DfaStateData(1, -1, 8)
		};
		// ���״̬�б�
		int[] next = new[]
		{
			1, 2, 3, 4, 5, 6, 7, 8, 9, 9
		};
		// ״̬����б�
		int[] check = new[]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 0, 9
		};
		// �ʷ�������������
		LexerData<Calc> lexerData = new(contexts,
			terminals,
			new CharClassMap(indexes, classes, categories),
			states,
			next,
			check,
			TrailingType.None,
			false,
			false,
			typeof(TestCalcController));
		return new LexerFactory<Calc, TestCalcController>(lexerData);
	}
}


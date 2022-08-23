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
public partial class TestStrController 
{
	/// <summary>
	/// �ʷ��������Ĺ�����
	/// </summary>
	public static readonly ILexerFactory<Str> Factory = CreateLexerFactory();

	/// <summary>
	/// �����ʷ��������Ĺ�����
	/// </summary>
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	private static ILexerFactory<Str> CreateLexerFactory()
	{
		// ����������
		Dictionary<string, ContextData<Str>> contexts = new()
		{
			 { "Initial", new ContextData<Str>(0, "Initial") }
		};
		// �ս������
		TerminalData<Str>[] terminals = new[]
		{
			// 0: {regular_literal}|{verbatim_literal}
			new TerminalData<Str>(Str.Str)
		};
		// �ַ�����Ϣ
		// 0: [\n\r]
		// 1: ["]
		// 2: [\0-\t\v\f\u000E-!#-?A-[]-\u0084\u0086-?\u202A-\uFFFF]
		// 3: [\\]
		// 4: [\u0085\u2028\u2029]
		// 5: [@]
		// �ַ�������
		int[] indexes = new[]
		{
			8716421, 10493991, 539678719, -117374977
		};
		// �ַ����б�
		int[] classes = new[]
		{
			2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0, 2, 2, 0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
			2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
			2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 5, 2, 2, 2, 2, 2, 2, 2,
			2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 2, 2, 2,
			2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
			2, 2, 2, 2, 2, 2, 2, 2, 4, 2, 2, 2
		};
		// �ַ��� Unicode ���
		Dictionary<UnicodeCategory, int> categories = new()
		{
			 { UnicodeCategory.LineSeparator, 4 },
			 { UnicodeCategory.ParagraphSeparator, 4 },
			 { UnicodeCategory.Control, 2 },
			 { UnicodeCategory.Surrogate, 2 },
			 { UnicodeCategory.PrivateUse, 2 }
		};
		// ״̬ת��
		//    0  1  2  3  4  5 -> Symbols
		// 0     1           2
		// 1     5  1  6     1
		// 2     3            
		// 3  3  4  3  3  3  3
		// 4     3             -> 0
		// 5                   -> 0
		// 6     1  1  1  1  1
		// ״̬�б�
		DfaStateData[] states = new[]
		{
			new DfaStateData(-1, -1),
			new DfaStateData(0, -1),
			new DfaStateData(5, -1),
			new DfaStateData(7, -1),
			new DfaStateData(12, -1, 0),
			new DfaStateData(int.MinValue, -1, 0),
			new DfaStateData(13, -1)
		};
		// ���״̬�б�
		int[] next = new[]
		{
			1, 5, 1, 6, 2, 1, 3, 3, 4, 3, 3, 3, 3, 3, 1, 1, 1, 1, 1
		};
		// ״̬����б�
		int[] check = new[]
		{
			0, 1, 1, 1, 0, 1, 2, 3, 3, 3, 3, 3, 3, 4, 6, 6, 6, 6, 6
		};
		// �ʷ�������������
		LexerData<Str> lexerData = new(contexts,
			terminals,
			new CharClassMap(indexes, classes, categories),
			states,
			next,
			check,
			TrailingType.None,
			false,
			false,
			typeof(TestStrController));
		return new LexerFactory<Str, TestStrController>(lexerData);
	}
}


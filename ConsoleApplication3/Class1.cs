using System;

namespace ConsoleApplication3
{
	/// <summary>
	/// Class1�� ���� ��� �����Դϴ�.
	/// </summary>
	class Class1
	{
		/// <summary>
		/// �ش� ���� ���α׷��� �� �������Դϴ�.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			String a = "%Evi 50 25 32 35 33 45 26 63 6f 6e 74 65 6e 74 4c 65 P%%253E&c ontentLe^I03b0 6e 67 74 68 3d 36 34 26 65 6e 64 46 6c 61 67%";
			string b = @"asdfasfd''dafds'gadfg'3zaswfae'";

			Console.WriteLine(b);

			Console.WriteLine(b.Replace("'", "").ToString());
		}
	}
}

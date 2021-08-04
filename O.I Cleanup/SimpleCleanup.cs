using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SimpleCleanup
{
	class Program
	{
		public static void Main(string[] args)
		{
			if (args.Length < 1)
			{
				Console.WriteLine("Usage: SimpleCleanup.exe <File1> <File2>");
				Console.Read();
				return;
			}
			foreach(var file in args)
			{
				string[] code = File.ReadAllLines(file);
				Console.WriteLine("File: " + file + "\n" + code.Length + " Lines");
				for (int i = 0; i < code.Length; i++)
				{
					while (code[i].Contains("O.I(\""))
					{
						int startIndex = code[i].IndexOf("O.I(\"") + 5;
						int endIndex = code[i].Substring(startIndex).IndexOf("\")") + startIndex;
						string enc = code[i].Substring(startIndex, endIndex - startIndex);
						code[i] = code[i].Replace("O.I(\"" + enc + "\")", GetTxt(enc));
					}
				}
				File.Move(file, file + ".back");
				File.WriteAllLines(file, code);
				Console.WriteLine("Finished\n");
			}
        }

        static string GetTxt(string U_0)
		{
			//Console.WriteLine("Str = " + U_0);
			string strPassword = "amp4Z0wpKzJ5Cg0GDT5sJD0sMw0IDAsaGQ1Afik6NwXr6rrSEQE=";
			string s = "aGQ1Afik6NampDT5sJEQE4Z0wpsMw0IDAD06rrSswXrKzJ5Cg0G=";
			string strHashName = "SHA1";
			int iterations = 2;
			int num = 256;
			string s2 = "@1B2c3D4e5F6g7H8";
			byte[] bytes = Encoding.ASCII.GetBytes(s2);
			byte[] bytes2 = Encoding.ASCII.GetBytes(s);
			byte[] array = Convert.FromBase64String(U_0);
			PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(strPassword, bytes2, strHashName, iterations);
			byte[] bytes3 = passwordDeriveBytes.GetBytes(num / 8);
			ICryptoTransform transform = new RijndaelManaged
			{
				Mode = CipherMode.CBC
			}.CreateDecryptor(bytes3, bytes);
			MemoryStream memoryStream = new MemoryStream(array);
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
			byte[] array2 = new byte[array.Length];
			int count = cryptoStream.Read(array2, 0, array2.Length);
			memoryStream.Close();
			cryptoStream.Close();

			var str = Encoding.UTF8.GetString(array2, 0, count);
			if (str == " ")
				return str;
			
			str = str.Replace("\"", "\\" + "\""); // Replace " with \"
			if (str.Contains("\\") || str.Contains("\n")) // Add @ to fix paths & new lines.
				str = "@\"" + str + "\"";
			else
				str = "\"" + str + "\"";
			//Console.WriteLine("Decrypted: " + str);
			return str;
		}
	}
}

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal class A
{
	public static void Main()
	{
		while (true)
		{
			Console.Write("Str = ");
			string s = Console.ReadLine();
			string strPassword = "amp4Z0wpKzJ5Cg0GDT5sJD0sMw0IDAsaGQ1Afik6NwXr6rrSEQE=";
			string s2 = "aGQ1Afik6NampDT5sJEQE4Z0wpsMw0IDAD06rrSswXrKzJ5Cg0G=";
			string strHashName = "SHA1";
			int iterations = 2;
			int num = 256;
			string s3 = "@1B2c3D4e5F6g7H8";
			byte[] bytes = Encoding.ASCII.GetBytes(s3);
			byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
			byte[] array = Convert.FromBase64String(s);
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
			Console.BackgroundColor = ConsoleColor.Red;
			Console.Write(Encoding.UTF8.GetString(array2, 0, count));
			Console.ResetColor();
                        Console.Write("\n");
		}
	}
}

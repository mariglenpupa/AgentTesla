using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal class O
{
	public static string I(string U_0)
	{
		//Discarded unreachable code: IL_00d6, IL_00e9
		//IL_00e0: Expected O, but got I4
		//IL_00e1: Expected O, but got I4
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
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.Mode = CipherMode.CBC;
		ICryptoTransform transform = rijndaelManaged.CreateDecryptor(bytes3, bytes);
		MemoryStream memoryStream = new MemoryStream(array);
		CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
		byte[] array2 = (byte[])(object)new byte[array.Length];
		int count = cryptoStream.Read(array2, 0, array2.Length);
		memoryStream.Close();
		cryptoStream.Close();
		return Encoding.UTF8.GetString(array2, 0, count);
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace KeyAuth
{
	// Token: 0x0200000E RID: 14
	public static class encryption
	{
		// Token: 0x06000099 RID: 153 RVA: 0x00004914 File Offset: 0x00002B14
		public static string HashHMAC(string enckey, string resp)
		{
			byte[] key = Delegate73.smethod_0(Delegate206.smethod_0(), enckey);
			byte[] buffer = Delegate73.smethod_0(Delegate206.smethod_0(), resp);
			return encryption.byte_arr_to_str(new HMACSHA256(key).ComputeHash(buffer));
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00004948 File Offset: 0x00002B48
		public static string byte_arr_to_str(byte[] ba)
		{
			StringBuilder stringBuilder = Delegate33.smethod_0(ba.Length * 2);
			foreach (byte b in ba)
			{
				Delegate61.smethod_0(stringBuilder, "{0:x2}", b);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000498C File Offset: 0x00002B8C
		public static byte[] str_to_byte_arr(string hex)
		{
			byte[] result;
			try
			{
				int length = hex.Length;
				byte[] array = new byte[length / 2];
				for (int i = 0; i < length; i += 2)
				{
					array[i / 2] = Delegate49.smethod_0(hex.Substring(i, 2), 16);
				}
				result = array;
			}
			catch
			{
				api.error("The session has ended, open program again.");
				Delegate244.smethod_0(0);
				result = null;
			}
			return result;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000049F4 File Offset: 0x00002BF4
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static bool CheckStringsFixedTime(string str1, string str2)
		{
			if (str1.Length != str2.Length)
			{
				return false;
			}
			int num = 0;
			for (int i = 0; i < str1.Length; i++)
			{
				num |= (int)(str1[i] ^ str2[i]);
			}
			return num == 0;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00004A3C File Offset: 0x00002C3C
		public static string iv_key()
		{
			return Delegate41.smethod_0().ToString().Substring(0, 16);
		}
	}
}

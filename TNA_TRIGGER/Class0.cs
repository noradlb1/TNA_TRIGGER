using System;

// Token: 0x02000188 RID: 392
internal static class Class0
{
	// Token: 0x0600059D RID: 1437 RVA: 0x0000D990 File Offset: 0x0000BB90
	internal static void smethod_0(uint[] uint_0)
	{
		int i = 0;
		uint num = 0U;
		while (i < uint_0.Length)
		{
			num = ~uint_0[i] + 1U;
			uint_0[i] = num;
			if (num == 0U)
			{
				i++;
			}
			else
			{
				i++;
				IL_24:
				if (num != 0U)
				{
					while (i < uint_0.Length)
					{
						uint_0[i] = ~uint_0[i];
						i++;
					}
					return;
				}
				uint_0 = Class0.smethod_1(uint_0, uint_0.Length + 1);
				uint_0[uint_0.Length - 1] = 1U;
				return;
			}
		}
		goto IL_24;
	}

	// Token: 0x0600059E RID: 1438 RVA: 0x0000D9F0 File Offset: 0x0000BBF0
	private static uint[] smethod_1(uint[] uint_0, int int_1)
	{
		if (uint_0.Length == int_1)
		{
			return uint_0;
		}
		uint[] array = new uint[int_1];
		int num = Math.Min(uint_0.Length, int_1);
		for (int i = 0; i < num; i++)
		{
			array[i] = uint_0[i];
		}
		return array;
	}

	// Token: 0x0600059F RID: 1439 RVA: 0x0000DA2C File Offset: 0x0000BC2C
	internal static void smethod_2<T>(ref T gparam_0, ref T gparam_1)
	{
		T t = gparam_0;
		gparam_0 = gparam_1;
		gparam_1 = t;
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x00002F3F File Offset: 0x0000113F
	internal static ulong smethod_3(uint uint_0, uint uint_1)
	{
		return (ulong)uint_0 << 32 | (ulong)uint_1;
	}

	// Token: 0x060005A1 RID: 1441 RVA: 0x00002F49 File Offset: 0x00001149
	internal static uint smethod_4(ulong ulong_0)
	{
		return (uint)ulong_0;
	}

	// Token: 0x060005A2 RID: 1442 RVA: 0x00002F4D File Offset: 0x0000114D
	internal static uint smethod_5(ulong ulong_0)
	{
		return (uint)(ulong_0 >> 32);
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x00002F54 File Offset: 0x00001154
	private static uint smethod_6(uint uint_0, uint uint_1)
	{
		return (uint_0 << 7 | uint_0 >> 25) ^ uint_1;
	}

	// Token: 0x060005A4 RID: 1444 RVA: 0x0000DA54 File Offset: 0x0000BC54
	internal static int smethod_7(uint uint_0)
	{
		if (uint_0 == 0U)
		{
			return 32;
		}
		int num = 0;
		if ((uint_0 & 4294901760U) == 0U)
		{
			num += 16;
			uint_0 <<= 16;
		}
		if ((uint_0 & 4278190080U) == 0U)
		{
			num += 8;
			uint_0 <<= 8;
		}
		if ((uint_0 & 4026531840U) == 0U)
		{
			num += 4;
			uint_0 <<= 4;
		}
		if ((uint_0 & 3221225472U) == 0U)
		{
			num += 2;
			uint_0 <<= 2;
		}
		if ((uint_0 & 2147483648U) == 0U)
		{
			num++;
		}
		return num;
	}

	// Token: 0x040000D9 RID: 217
	private const int int_0 = 32;
}

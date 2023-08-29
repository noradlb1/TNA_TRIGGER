using System;
using System.Diagnostics;

// Token: 0x02000186 RID: 390
[Serializable]
internal struct Struct0
{
	// Token: 0x0600056B RID: 1387 RVA: 0x00002CF8 File Offset: 0x00000EF8
	[Conditional("DEBUG")]
	private void method_0()
	{
		if (this.uint_1 != null)
		{
			Struct0.smethod_11(this.uint_1);
		}
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x0600056C RID: 1388 RVA: 0x00002D0E File Offset: 0x00000F0E
	private static Struct0 Struct0_0
	{
		get
		{
			return Struct0.struct0_1;
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x0600056D RID: 1389 RVA: 0x00002D15 File Offset: 0x00000F15
	private bool Boolean_0
	{
		get
		{
			if (this.uint_1 != null)
			{
				return (this.uint_1[0] & 1U) == 0U;
			}
			return (this.int_1 & 1) == 0;
		}
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x0600056E RID: 1390 RVA: 0x00002D38 File Offset: 0x00000F38
	private int Int32_0
	{
		get
		{
			return (this.int_1 >> 31) - (-this.int_1 >> 31);
		}
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x00002D4E File Offset: 0x00000F4E
	public bool vmethod_0(object object_0)
	{
		return object_0 is Struct0 && this.Equals((Struct0)object_0);
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x0000C8F0 File Offset: 0x0000AAF0
	public int vmethod_1()
	{
		if (this.uint_1 == null)
		{
			return this.int_1;
		}
		int result = this.int_1;
		int num = Struct0.smethod_11(this.uint_1);
		while (--num >= 0)
		{
			result = (int)Class0.smethod_6((uint)result, this.uint_1[num]);
		}
		return result;
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x0000C93C File Offset: 0x0000AB3C
	private int method_1(Struct0 struct0_4)
	{
		if ((this.int_1 ^ struct0_4.int_1) < 0)
		{
			if (this.int_1 >= 0)
			{
				return 1;
			}
			return -1;
		}
		else if (this.uint_1 == null)
		{
			if (struct0_4.uint_1 != null)
			{
				return -struct0_4.int_1;
			}
			if (this.int_1 < struct0_4.int_1)
			{
				return -1;
			}
			if (this.int_1 <= struct0_4.int_1)
			{
				return 0;
			}
			return 1;
		}
		else
		{
			int num;
			int num2;
			if (struct0_4.uint_1 == null || (num = Struct0.smethod_11(this.uint_1)) > (num2 = Struct0.smethod_11(struct0_4.uint_1)))
			{
				return this.int_1;
			}
			if (num < num2)
			{
				return -this.int_1;
			}
			int num3 = Struct0.smethod_12(this.uint_1, struct0_4.uint_1, num);
			if (num3 == 0)
			{
				return 0;
			}
			if (this.uint_1[num3 - 1] >= struct0_4.uint_1[num3 - 1])
			{
				return this.int_1;
			}
			return -this.int_1;
		}
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x0000CA14 File Offset: 0x0000AC14
	internal byte[] method_2()
	{
		if (this.uint_1 == null && this.int_1 == 0)
		{
			return new byte[1];
		}
		uint[] array;
		byte b;
		if (this.uint_1 == null)
		{
			array = new uint[]
			{
				(uint)this.int_1
			};
			b = ((this.int_1 < 0) ? byte.MaxValue : 0);
		}
		else if (this.int_1 == -1)
		{
			array = (uint[])this.uint_1.Clone();
			Class0.smethod_0(array);
			b = byte.MaxValue;
		}
		else
		{
			array = this.uint_1;
			b = 0;
		}
		byte[] array2 = new byte[checked(4 * array.Length)];
		int num = 0;
		foreach (uint num2 in array)
		{
			for (int j = 0; j < 4; j++)
			{
				array2[num++] = (byte)(num2 & 255U);
				num2 >>= 8;
			}
		}
		if ((array2[array2.Length - 1] & 128) == (b & 128))
		{
			return array2;
		}
		byte[] array4 = new byte[array2.Length + 1];
		Array.Copy(array2, array4, array2.Length);
		array4[array4.Length - 1] = b;
		return array4;
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x00002D71 File Offset: 0x00000F71
	private Struct0(int int_2)
	{
		if (int_2 == -2147483648)
		{
			this = Struct0.struct0_0;
			return;
		}
		this.int_1 = int_2;
		this.uint_1 = null;
	}

	// Token: 0x06000574 RID: 1396 RVA: 0x0000CB24 File Offset: 0x0000AD24
	internal Struct0(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("value");
		}
		int num = byte_0.Length;
		bool flag = num > 0 && (byte_0[num - 1] & 128) == 128;
		while (num > 0 && byte_0[num - 1] == 0)
		{
			num--;
		}
		if (num == 0)
		{
			this.int_1 = 0;
			this.uint_1 = null;
			return;
		}
		if (num <= 4)
		{
			if (flag)
			{
				this.int_1 = -1;
			}
			else
			{
				this.int_1 = 0;
			}
			for (int i = num - 1; i >= 0; i--)
			{
				this.int_1 <<= 8;
				this.int_1 |= (int)byte_0[i];
			}
			this.uint_1 = null;
			if (this.int_1 < 0 && !flag)
			{
				this.uint_1 = new uint[1];
				this.uint_1[0] = (uint)this.int_1;
				this.int_1 = 1;
			}
			if (this.int_1 == -2147483648)
			{
				this = Struct0.struct0_0;
				return;
			}
		}
		else
		{
			int num2 = num % 4;
			int num3 = num / 4 + ((num2 == 0) ? 0 : 1);
			bool flag2 = true;
			uint[] array = new uint[num3];
			int j = 3;
			int k;
			for (k = 0; k < num3 - ((num2 != 0) ? 1 : 0); k++)
			{
				for (int l = 0; l < 4; l++)
				{
					if (byte_0[j] != 0)
					{
						flag2 = false;
					}
					array[k] <<= 8;
					array[k] |= (uint)byte_0[j];
					j--;
				}
				j += 8;
			}
			if (num2 != 0)
			{
				if (flag)
				{
					array[num3 - 1] = uint.MaxValue;
				}
				for (j = num - 1; j >= num - num2; j--)
				{
					if (byte_0[j] != 0)
					{
						flag2 = false;
					}
					array[k] <<= 8;
					array[k] |= (uint)byte_0[j];
				}
			}
			if (flag2)
			{
				this = Struct0.struct0_2;
				return;
			}
			if (flag)
			{
				Class0.smethod_0(array);
				int num4 = array.Length;
				while (num4 > 0 && array[num4 - 1] == 0U)
				{
					num4--;
				}
				if (num4 == 1 && array[0] > 0U)
				{
					if (array[0] == 1U)
					{
						this = Struct0.struct0_3;
						return;
					}
					if (array[0] == 2147483648U)
					{
						this = Struct0.struct0_0;
						return;
					}
					this.int_1 = (int)(uint.MaxValue * array[0]);
					this.uint_1 = null;
					return;
				}
				else
				{
					if (num4 != array.Length)
					{
						this.int_1 = -1;
						this.uint_1 = new uint[num4];
						Array.Copy(array, this.uint_1, num4);
						return;
					}
					this.int_1 = -1;
					this.uint_1 = array;
					return;
				}
			}
			else
			{
				this.int_1 = 1;
				this.uint_1 = array;
			}
		}
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x00002D95 File Offset: 0x00000F95
	internal Struct0(int int_2, uint[] uint_2)
	{
		this.int_1 = int_2;
		this.uint_1 = uint_2;
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x00002DA5 File Offset: 0x00000FA5
	private static void smethod_0(ref Struct1 struct1_0, ref Struct1 struct1_1, ref Struct1 struct1_2, ref Struct1 struct1_3)
	{
		Class0.smethod_2<Struct1>(ref struct1_0, ref struct1_3);
		struct1_0.method_12(ref struct1_3, ref struct1_1);
		struct1_0.method_13(ref struct1_2);
	}

	// Token: 0x06000577 RID: 1399 RVA: 0x00002DBD File Offset: 0x00000FBD
	private static void smethod_1(ref Struct1 struct1_0, ref Struct1 struct1_1, ref Struct1 struct1_2)
	{
		Class0.smethod_2<Struct1>(ref struct1_0, ref struct1_2);
		struct1_0.method_12(ref struct1_2, ref struct1_2);
		struct1_0.method_13(ref struct1_1);
	}

	// Token: 0x06000578 RID: 1400 RVA: 0x00002DD5 File Offset: 0x00000FD5
	private static void smethod_2(uint uint_2, ref Struct1 struct1_0, ref Struct1 struct1_1, ref Struct1 struct1_2, ref Struct1 struct1_3)
	{
		while (uint_2 != 0U)
		{
			if ((uint_2 & 1U) == 1U)
			{
				Struct0.smethod_0(ref struct1_0, ref struct1_1, ref struct1_2, ref struct1_3);
			}
			if (uint_2 == 1U)
			{
				break;
			}
			Struct0.smethod_1(ref struct1_1, ref struct1_2, ref struct1_3);
			uint_2 >>= 1;
		}
	}

	// Token: 0x06000579 RID: 1401 RVA: 0x0000CDAC File Offset: 0x0000AFAC
	private static void smethod_3(uint uint_2, ref Struct1 struct1_0, ref Struct1 struct1_1, ref Struct1 struct1_2, ref Struct1 struct1_3)
	{
		for (int i = 0; i < 32; i++)
		{
			if ((uint_2 & 1U) == 1U)
			{
				Struct0.smethod_0(ref struct1_0, ref struct1_1, ref struct1_2, ref struct1_3);
			}
			Struct0.smethod_1(ref struct1_1, ref struct1_2, ref struct1_3);
			uint_2 >>= 1;
		}
	}

	// Token: 0x0600057A RID: 1402 RVA: 0x0000CDE4 File Offset: 0x0000AFE4
	internal static Struct0 smethod_4(Struct0 struct0_4, Struct0 struct0_5, Struct0 struct0_6)
	{
		if (struct0_5.Int32_0 < 0)
		{
			throw new ArgumentOutOfRangeException("exponent", "ArgumentOutOfRange must be non negative");
		}
		int num = 1;
		int num2 = 1;
		int num3 = 1;
		bool boolean_ = struct0_5.Boolean_0;
		Struct1 @struct = new Struct1(Struct0.Struct0_0, ref num);
		Struct1 struct2 = new Struct1(struct0_4, ref num2);
		Struct1 struct3 = new Struct1(struct0_6, ref num3);
		Struct1 struct4 = new Struct1(struct2.Int32_0);
		@struct.method_13(ref struct3);
		if (struct0_5.uint_1 == null)
		{
			Struct0.smethod_2((uint)struct0_5.int_1, ref @struct, ref struct2, ref struct3, ref struct4);
		}
		else
		{
			int num4 = Struct0.smethod_11(struct0_5.uint_1);
			for (int i = 0; i < num4 - 1; i++)
			{
				Struct0.smethod_3(struct0_5.uint_1[i], ref @struct, ref struct2, ref struct3, ref struct4);
			}
			Struct0.smethod_2(struct0_5.uint_1[num4 - 1], ref @struct, ref struct2, ref struct3, ref struct4);
		}
		return @struct.method_1((struct0_4.int_1 > 0) ? 1 : (boolean_ ? 1 : -1));
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x00002DFF File Offset: 0x00000FFF
	public static bool smethod_5(Struct0 struct0_4, Struct0 struct0_5)
	{
		return struct0_4.method_1(struct0_5) < 0;
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x00002E0C File Offset: 0x0000100C
	public static bool smethod_6(Struct0 struct0_4, Struct0 struct0_5)
	{
		return struct0_4.method_1(struct0_5) <= 0;
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x00002E1C File Offset: 0x0000101C
	public static bool smethod_7(Struct0 struct0_4, Struct0 struct0_5)
	{
		return struct0_4.method_1(struct0_5) > 0;
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x00002E29 File Offset: 0x00001029
	public static bool smethod_8(Struct0 struct0_4, Struct0 struct0_5)
	{
		return struct0_4.method_1(struct0_5) >= 0;
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x00002E39 File Offset: 0x00001039
	public static bool smethod_9(Struct0 struct0_4, Struct0 struct0_5)
	{
		return struct0_4.Equals(struct0_5);
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x00002E4E File Offset: 0x0000104E
	public static bool smethod_10(Struct0 struct0_4, Struct0 struct0_5)
	{
		return !struct0_4.Equals(struct0_5);
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x0000CED8 File Offset: 0x0000B0D8
	private static int smethod_11(uint[] uint_2)
	{
		int num = uint_2.Length;
		if (uint_2[num - 1] != 0U)
		{
			return num;
		}
		return num - 1;
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x06000582 RID: 1410 RVA: 0x00002E66 File Offset: 0x00001066
	internal int Int32_1
	{
		get
		{
			return this.int_1;
		}
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x06000583 RID: 1411 RVA: 0x00002E6E File Offset: 0x0000106E
	internal uint[] UInt32_0
	{
		get
		{
			return this.uint_1;
		}
	}

	// Token: 0x06000584 RID: 1412 RVA: 0x0000CEF8 File Offset: 0x0000B0F8
	private static int smethod_12(uint[] uint_2, uint[] uint_3, int int_2)
	{
		int num = int_2;
		while (--num >= 0)
		{
			if (uint_2[num] != uint_3[num])
			{
				return num + 1;
			}
		}
		return 0;
	}

	// Token: 0x040000CC RID: 204
	private const uint uint_0 = 2147483648U;

	// Token: 0x040000CD RID: 205
	private const int int_0 = 32;

	// Token: 0x040000CE RID: 206
	private readonly int int_1;

	// Token: 0x040000CF RID: 207
	private readonly uint[] uint_1;

	// Token: 0x040000D0 RID: 208
	private static readonly Struct0 struct0_0 = new Struct0(-1, new uint[]
	{
		2147483648U
	});

	// Token: 0x040000D1 RID: 209
	private static readonly Struct0 struct0_1 = new Struct0(1);

	// Token: 0x040000D2 RID: 210
	private static readonly Struct0 struct0_2 = new Struct0(0);

	// Token: 0x040000D3 RID: 211
	private static readonly Struct0 struct0_3 = new Struct0(-1);
}

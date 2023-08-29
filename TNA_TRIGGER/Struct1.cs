using System;
using System.Diagnostics;

// Token: 0x02000187 RID: 391
internal struct Struct1
{
	// Token: 0x06000586 RID: 1414 RVA: 0x000024C5 File Offset: 0x000006C5
	[Conditional("DEBUG")]
	private void method_0(bool bool_1)
	{
	}

	// Token: 0x06000587 RID: 1415 RVA: 0x00002EB2 File Offset: 0x000010B2
	internal Struct1(int int_2)
	{
		this.int_1 = 0;
		this.uint_0 = 0U;
		if (int_2 > 1)
		{
			this.uint_1 = new uint[int_2];
			this.bool_0 = true;
			return;
		}
		this.uint_1 = null;
		this.bool_0 = false;
	}

	// Token: 0x06000588 RID: 1416 RVA: 0x0000CF20 File Offset: 0x0000B120
	internal Struct1(Struct0 struct0_0, ref int int_2)
	{
		this.bool_0 = false;
		this.uint_1 = struct0_0.UInt32_0;
		int int32_ = struct0_0.Int32_1;
		int num = int32_ >> 31;
		int_2 = (int_2 ^ num) - num;
		if (this.uint_1 == null)
		{
			this.int_1 = 0;
			this.uint_0 = (uint)((int32_ ^ num) - num);
			return;
		}
		this.int_1 = this.uint_1.Length - 1;
		this.uint_0 = this.uint_1[0];
		while (this.int_1 > 0 && this.uint_1[this.int_1] == 0U)
		{
			this.int_1--;
		}
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x0000CFB8 File Offset: 0x0000B1B8
	internal Struct0 method_1(int int_2)
	{
		uint[] uint_;
		this.method_2(int_2, out int_2, out uint_);
		return new Struct0(int_2, uint_);
	}

	// Token: 0x0600058A RID: 1418 RVA: 0x0000CFD8 File Offset: 0x0000B1D8
	private void method_2(int int_2, out int int_3, out uint[] uint_2)
	{
		if (this.int_1 == 0)
		{
			if (this.uint_0 <= 2147483647U)
			{
				int_3 = int_2 * (int)this.uint_0;
				uint_2 = null;
				return;
			}
			if (this.uint_1 == null)
			{
				this.uint_1 = new uint[]
				{
					this.uint_0
				};
			}
			else if (this.bool_0)
			{
				this.uint_1[0] = this.uint_0;
			}
			else if (this.uint_1[0] != this.uint_0)
			{
				this.uint_1 = new uint[]
				{
					this.uint_0
				};
			}
		}
		int_3 = int_2;
		int num = this.uint_1.Length - this.int_1 - 1;
		if (num <= 1)
		{
			if (num == 0 || this.uint_1[this.int_1 + 1] == 0U)
			{
				this.bool_0 = false;
				uint_2 = this.uint_1;
				return;
			}
			if (this.bool_0)
			{
				this.uint_1[this.int_1 + 1] = 0U;
				this.bool_0 = false;
				uint_2 = this.uint_1;
				return;
			}
		}
		uint_2 = this.uint_1;
		Array.Resize<uint>(ref uint_2, this.int_1 + 1);
		if (!this.bool_0)
		{
			this.uint_1 = uint_2;
		}
	}

	// Token: 0x0600058B RID: 1419 RVA: 0x00002EE8 File Offset: 0x000010E8
	private void method_3(uint uint_2)
	{
		this.uint_0 = uint_2;
		this.int_1 = 0;
	}

	// Token: 0x0600058C RID: 1420 RVA: 0x0000D0F0 File Offset: 0x0000B2F0
	private void method_4(ulong ulong_0)
	{
		uint num = Class0.smethod_5(ulong_0);
		if (num == 0U)
		{
			this.uint_0 = Class0.smethod_4(ulong_0);
			this.int_1 = 0;
			return;
		}
		this.method_6(2);
		this.uint_1[0] = (uint)ulong_0;
		this.uint_1[1] = num;
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x0600058D RID: 1421 RVA: 0x00002EF8 File Offset: 0x000010F8
	internal int Int32_0
	{
		get
		{
			return this.int_1 + 1;
		}
	}

	// Token: 0x0600058E RID: 1422 RVA: 0x0000D138 File Offset: 0x0000B338
	private void method_5()
	{
		if (this.int_1 > 0 && this.uint_1[this.int_1] == 0U)
		{
			this.uint_0 = this.uint_1[0];
			int num;
			do
			{
				num = this.int_1 - 1;
				this.int_1 = num;
			}
			while (num > 0 && this.uint_1[this.int_1] == 0U);
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x0600058F RID: 1423 RVA: 0x0000D190 File Offset: 0x0000B390
	private int Int32_1
	{
		get
		{
			int num = 0;
			for (int i = this.int_1; i >= 0; i--)
			{
				if (this.uint_1[i] != 0U)
				{
					num++;
				}
			}
			return num;
		}
	}

	// Token: 0x06000590 RID: 1424 RVA: 0x00002F02 File Offset: 0x00001102
	private void method_6(int int_2)
	{
		if (int_2 <= 1)
		{
			this.int_1 = 0;
			return;
		}
		if (!this.bool_0 || this.uint_1.Length < int_2)
		{
			this.uint_1 = new uint[int_2];
			this.bool_0 = true;
		}
		this.int_1 = int_2 - 1;
	}

	// Token: 0x06000591 RID: 1425 RVA: 0x0000D1C0 File Offset: 0x0000B3C0
	private void method_7(int int_2)
	{
		if (int_2 <= 1)
		{
			this.int_1 = 0;
			this.uint_0 = 0U;
			return;
		}
		if (this.bool_0 && this.uint_1.Length >= int_2)
		{
			Array.Clear(this.uint_1, 0, int_2);
		}
		else
		{
			this.uint_1 = new uint[int_2];
			this.bool_0 = true;
		}
		this.int_1 = int_2 - 1;
	}

	// Token: 0x06000592 RID: 1426 RVA: 0x0000D220 File Offset: 0x0000B420
	private void method_8(int int_2, int int_3)
	{
		if (int_2 <= 1)
		{
			if (this.int_1 > 0)
			{
				this.uint_0 = this.uint_1[0];
			}
			this.int_1 = 0;
			return;
		}
		if (this.bool_0 && this.uint_1.Length >= int_2)
		{
			if (this.int_1 + 1 < int_2)
			{
				Array.Clear(this.uint_1, this.int_1 + 1, int_2 - this.int_1 - 1);
				if (this.int_1 == 0)
				{
					this.uint_1[0] = this.uint_0;
				}
			}
		}
		else
		{
			uint[] array = new uint[int_2 + int_3];
			if (this.int_1 == 0)
			{
				array[0] = this.uint_0;
			}
			else
			{
				Array.Copy(this.uint_1, array, Math.Min(int_2, this.int_1 + 1));
			}
			this.uint_1 = array;
			this.bool_0 = true;
		}
		this.int_1 = int_2 - 1;
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x0000D2F0 File Offset: 0x0000B4F0
	private void method_9(int int_2 = 0)
	{
		if (this.bool_0)
		{
			return;
		}
		uint[] destinationArray = new uint[this.int_1 + 1 + int_2];
		Array.Copy(this.uint_1, destinationArray, this.int_1 + 1);
		this.uint_1 = destinationArray;
		this.bool_0 = true;
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x0000D338 File Offset: 0x0000B538
	private void method_10(ref Struct1 struct1_0, int int_2)
	{
		if (struct1_0.int_1 == 0)
		{
			this.uint_0 = struct1_0.uint_0;
			this.int_1 = 0;
			return;
		}
		if (!this.bool_0 || this.uint_1.Length <= struct1_0.int_1)
		{
			this.uint_1 = new uint[struct1_0.int_1 + 1 + int_2];
			this.bool_0 = true;
		}
		this.int_1 = struct1_0.int_1;
		Array.Copy(struct1_0.uint_1, this.uint_1, this.int_1 + 1);
	}

	// Token: 0x06000595 RID: 1429 RVA: 0x0000D3BC File Offset: 0x0000B5BC
	private void method_11(uint uint_2)
	{
		if (uint_2 == 0U)
		{
			this.method_3(0U);
			return;
		}
		if (uint_2 == 1U)
		{
			return;
		}
		if (this.int_1 == 0)
		{
			this.method_4((ulong)this.uint_0 * (ulong)uint_2);
			return;
		}
		this.method_9(1);
		uint num = 0U;
		for (int i = 0; i <= this.int_1; i++)
		{
			num = Struct1.smethod_3(ref this.uint_1[i], uint_2, num);
		}
		if (num != 0U)
		{
			this.method_8(this.int_1 + 2, 0);
			this.uint_1[this.int_1] = num;
		}
	}

	// Token: 0x06000596 RID: 1430 RVA: 0x0000D440 File Offset: 0x0000B640
	internal void method_12(ref Struct1 struct1_0, ref Struct1 struct1_1)
	{
		if (struct1_0.int_1 == 0)
		{
			if (struct1_1.int_1 == 0)
			{
				this.method_4((ulong)struct1_0.uint_0 * (ulong)struct1_1.uint_0);
				return;
			}
			this.method_10(ref struct1_1, 1);
			this.method_11(struct1_0.uint_0);
			return;
		}
		else
		{
			if (struct1_1.int_1 == 0)
			{
				this.method_10(ref struct1_0, 1);
				this.method_11(struct1_1.uint_0);
				return;
			}
			this.method_7(struct1_0.int_1 + struct1_1.int_1 + 2);
			uint[] array;
			int num;
			uint[] array2;
			int num2;
			if (struct1_0.Int32_1 <= struct1_1.Int32_1)
			{
				array = struct1_0.uint_1;
				num = struct1_0.int_1 + 1;
				array2 = struct1_1.uint_1;
				num2 = struct1_1.int_1 + 1;
			}
			else
			{
				array = struct1_1.uint_1;
				num = struct1_1.int_1 + 1;
				array2 = struct1_0.uint_1;
				num2 = struct1_0.int_1 + 1;
			}
			for (int i = 0; i < num; i++)
			{
				uint num3 = array[i];
				if (num3 != 0U)
				{
					uint num4 = 0U;
					int num5 = i;
					int j = 0;
					while (j < num2)
					{
						num4 = Struct1.smethod_4(ref this.uint_1[num5], num3, array2[j], num4);
						j++;
						num5++;
					}
					while (num4 != 0U)
					{
						num4 = Struct1.smethod_2(ref this.uint_1[num5++], 0U, num4);
					}
				}
			}
			this.method_5();
			return;
		}
	}

	// Token: 0x06000597 RID: 1431 RVA: 0x0000D588 File Offset: 0x0000B788
	private static uint smethod_0(ref Struct1 struct1_0, uint uint_2)
	{
		if (uint_2 == 1U)
		{
			return 0U;
		}
		if (struct1_0.int_1 == 0)
		{
			return struct1_0.uint_0 % uint_2;
		}
		ulong num = 0UL;
		for (int i = struct1_0.int_1; i >= 0; i--)
		{
			num = Class0.smethod_3((uint)num, struct1_0.uint_1[i]);
			num %= (ulong)uint_2;
		}
		return (uint)num;
	}

	// Token: 0x06000598 RID: 1432 RVA: 0x0000D5E0 File Offset: 0x0000B7E0
	internal void method_13(ref Struct1 struct1_0)
	{
		if (struct1_0.int_1 == 0)
		{
			this.method_3(Struct1.smethod_0(ref this, struct1_0.uint_0));
			return;
		}
		if (this.int_1 == 0)
		{
			return;
		}
		Struct1 @struct = default(Struct1);
		Struct1.smethod_1(ref this, ref struct1_0, false, ref @struct);
	}

	// Token: 0x06000599 RID: 1433 RVA: 0x0000D624 File Offset: 0x0000B824
	private static void smethod_1(ref Struct1 struct1_0, ref Struct1 struct1_1, bool bool_1, ref Struct1 struct1_2)
	{
		struct1_2.method_3(0U);
		if (struct1_0.int_1 < struct1_1.int_1)
		{
			return;
		}
		int num = struct1_1.int_1 + 1;
		int num2 = struct1_0.int_1 - struct1_1.int_1;
		int num3 = num2;
		int i = struct1_0.int_1;
		while (i >= num2)
		{
			if (struct1_1.uint_1[i - num2] != struct1_0.uint_1[i])
			{
				if (struct1_1.uint_1[i - num2] < struct1_0.uint_1[i])
				{
					num3++;
				}
				IL_7C:
				if (num3 == 0)
				{
					return;
				}
				if (bool_1)
				{
					struct1_2.method_6(num3);
				}
				uint num4 = struct1_1.uint_1[num - 1];
				uint num5 = struct1_1.uint_1[num - 2];
				int num6 = Class0.smethod_7(num4);
				int num7 = 32 - num6;
				if (num6 > 0)
				{
					num4 = (num4 << num6 | num5 >> num7);
					num5 <<= num6;
					if (num > 2)
					{
						num5 |= struct1_1.uint_1[num - 3] >> num7;
					}
				}
				struct1_0.method_9(0);
				int num8 = num3;
				while (--num8 >= 0)
				{
					uint num9 = (num8 + num <= struct1_0.int_1) ? struct1_0.uint_1[num8 + num] : 0U;
					ulong num10 = Class0.smethod_3(num9, struct1_0.uint_1[num8 + num - 1]);
					uint num11 = struct1_0.uint_1[num8 + num - 2];
					if (num6 > 0)
					{
						num10 = (num10 << num6 | (ulong)(num11 >> num7));
						num11 <<= num6;
						if (num8 + num >= 3)
						{
							num11 |= struct1_0.uint_1[num8 + num - 3] >> num7;
						}
					}
					ulong num12 = num10 / (ulong)num4;
					ulong num13 = (ulong)((uint)(num10 % (ulong)num4));
					if (num12 > 4294967295UL)
					{
						num13 += (ulong)num4 * (num12 - 4294967295UL);
						num12 = 4294967295UL;
					}
					while (num13 <= 4294967295UL && num12 * (ulong)num5 > Class0.smethod_3((uint)num13, num11))
					{
						num12 -= 1UL;
						num13 += (ulong)num4;
					}
					if (num12 > 0UL)
					{
						ulong num14 = 0UL;
						for (int j = 0; j < num; j++)
						{
							num14 += (ulong)struct1_1.uint_1[j] * num12;
							uint num15 = (uint)num14;
							num14 >>= 32;
							if (struct1_0.uint_1[num8 + j] < num15)
							{
								num14 += 1UL;
							}
							struct1_0.uint_1[num8 + j] -= num15;
						}
						if ((ulong)num9 < num14)
						{
							uint uint_ = 0U;
							for (int k = 0; k < num; k++)
							{
								uint_ = Struct1.smethod_2(ref struct1_0.uint_1[num8 + k], struct1_1.uint_1[k], uint_);
							}
							num12 -= 1UL;
						}
						struct1_0.int_1 = num8 + num - 1;
					}
					if (bool_1)
					{
						if (num3 == 1)
						{
							struct1_2.uint_0 = (uint)num12;
						}
						else
						{
							struct1_2.uint_1[num8] = (uint)num12;
						}
					}
				}
				struct1_0.int_1 = num - 1;
				struct1_0.method_5();
				return;
			}
			else
			{
				i--;
			}
		}
		num3++;
		goto IL_7C;
	}

	// Token: 0x0600059A RID: 1434 RVA: 0x0000D92C File Offset: 0x0000BB2C
	private static uint smethod_2(ref uint uint_2, uint uint_3, uint uint_4)
	{
		ulong num = (ulong)uint_2 + (ulong)uint_3 + (ulong)uint_4;
		uint_2 = (uint)num;
		return (uint)(num >> 32);
	}

	// Token: 0x0600059B RID: 1435 RVA: 0x0000D94C File Offset: 0x0000BB4C
	private static uint smethod_3(ref uint uint_2, uint uint_3, uint uint_4)
	{
		ulong num = (ulong)uint_2 * (ulong)uint_3 + (ulong)uint_4;
		uint_2 = (uint)num;
		return (uint)(num >> 32);
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x0000D96C File Offset: 0x0000BB6C
	private static uint smethod_4(ref uint uint_2, uint uint_3, uint uint_4, uint uint_5)
	{
		ulong num = (ulong)uint_3 * (ulong)uint_4 + (ulong)uint_2 + (ulong)uint_5;
		uint_2 = (uint)num;
		return (uint)(num >> 32);
	}

	// Token: 0x040000D4 RID: 212
	private const int int_0 = 32;

	// Token: 0x040000D5 RID: 213
	private int int_1;

	// Token: 0x040000D6 RID: 214
	private uint uint_0;

	// Token: 0x040000D7 RID: 215
	private uint[] uint_1;

	// Token: 0x040000D8 RID: 216
	private bool bool_0;
}

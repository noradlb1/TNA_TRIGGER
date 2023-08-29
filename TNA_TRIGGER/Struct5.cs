using System;

// Token: 0x02000191 RID: 401
internal struct Struct5
{
	// Token: 0x060005C8 RID: 1480 RVA: 0x000030FA File Offset: 0x000012FA
	public Struct5(int int_1)
	{
		this.int_0 = int_1;
		this.struct4_0 = new Struct4[1 << int_1];
	}

	// Token: 0x060005C9 RID: 1481 RVA: 0x0000E5C4 File Offset: 0x0000C7C4
	public void method_0()
	{
		uint num = 1U;
		while ((ulong)num < (ulong)(1L << (this.int_0 & 31)))
		{
			this.struct4_0[(int)num].method_0();
			num += 1U;
		}
	}

	// Token: 0x060005CA RID: 1482 RVA: 0x0000E5FC File Offset: 0x0000C7FC
	public uint method_1(Class4 class4_0)
	{
		uint num = 1U;
		for (int i = this.int_0; i > 0; i--)
		{
			num = (num << 1) + this.struct4_0[(int)num].method_1(class4_0);
		}
		return num - (1U << this.int_0);
	}

	// Token: 0x060005CB RID: 1483 RVA: 0x0000E640 File Offset: 0x0000C840
	public uint method_2(Class4 class4_0)
	{
		uint num = 1U;
		uint num2 = 0U;
		for (int i = 0; i < this.int_0; i++)
		{
			uint num3 = this.struct4_0[(int)num].method_1(class4_0);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	// Token: 0x060005CC RID: 1484 RVA: 0x0000E688 File Offset: 0x0000C888
	public static uint smethod_0(Struct4[] struct4_1, uint uint_0, Class4 class4_0, int int_1)
	{
		uint num = 1U;
		uint num2 = 0U;
		for (int i = 0; i < int_1; i++)
		{
			uint num3 = struct4_1[(int)(uint_0 + num)].method_1(class4_0);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	// Token: 0x04000112 RID: 274
	private readonly Struct4[] struct4_0;

	// Token: 0x04000113 RID: 275
	private readonly int int_0;
}

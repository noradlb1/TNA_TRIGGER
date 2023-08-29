using System;

// Token: 0x0200019E RID: 414
public class GClass9
{
	// Token: 0x060005FF RID: 1535 RVA: 0x00010680 File Offset: 0x0000E880
	public static uint smethod_0(uint uint_0, int int_1)
	{
		uint num = uint_0 << int_1;
		uint num2 = uint_0 >> 32 - int_1;
		return num | num2;
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x000106A0 File Offset: 0x0000E8A0
	public static uint smethod_1(uint uint_0, int int_1)
	{
		uint num = uint_0 >> int_1;
		uint num2 = uint_0 << 32 - int_1;
		return num | num2;
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x000106C0 File Offset: 0x0000E8C0
	public static uint smethod_2(uint uint_0)
	{
		uint num = uint_0 & 16711935U;
		uint num2 = uint_0 & 4278255360U;
		return (num >> 8 | num << 24) + (num2 << 8 | num2 >> 24);
	}

	// Token: 0x0400014A RID: 330
	public const int int_0 = 32;
}

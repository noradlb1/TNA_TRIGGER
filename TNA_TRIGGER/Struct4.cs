using System;

// Token: 0x02000190 RID: 400
internal struct Struct4
{
	// Token: 0x060005C6 RID: 1478 RVA: 0x000030ED File Offset: 0x000012ED
	public void method_0()
	{
		this.uint_1 = 1024U;
	}

	// Token: 0x060005C7 RID: 1479 RVA: 0x0000E4D8 File Offset: 0x0000C6D8
	public uint method_1(Class4 class4_0)
	{
		uint num = (class4_0.uint_2 >> 11) * this.uint_1;
		if (class4_0.uint_3 < num)
		{
			class4_0.uint_2 = num;
			this.uint_1 += 2048U - this.uint_1 >> 5;
			if (class4_0.uint_2 < 16777216U)
			{
				class4_0.uint_3 = (class4_0.uint_3 << 8 | (uint)((byte)class4_0.stream_0.ReadByte()));
				class4_0.uint_2 <<= 8;
			}
			return 0U;
		}
		class4_0.uint_2 -= num;
		class4_0.uint_3 -= num;
		this.uint_1 -= this.uint_1 >> 5;
		if (class4_0.uint_2 < 16777216U)
		{
			class4_0.uint_3 = (class4_0.uint_3 << 8 | (uint)((byte)class4_0.stream_0.ReadByte()));
			class4_0.uint_2 <<= 8;
		}
		return 1U;
	}

	// Token: 0x0400010E RID: 270
	private const int int_0 = 11;

	// Token: 0x0400010F RID: 271
	private const uint uint_0 = 2048U;

	// Token: 0x04000110 RID: 272
	private const int int_1 = 5;

	// Token: 0x04000111 RID: 273
	private uint uint_1;
}

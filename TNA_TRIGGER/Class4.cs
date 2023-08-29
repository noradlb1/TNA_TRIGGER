using System;
using System.IO;

// Token: 0x0200018F RID: 399
internal class Class4
{
	// Token: 0x060005C2 RID: 1474 RVA: 0x0000E418 File Offset: 0x0000C618
	public void method_0(Stream stream_1)
	{
		this.stream_0 = stream_1;
		this.uint_3 = 0U;
		this.uint_2 = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			this.uint_3 = (this.uint_3 << 8 | (uint)((byte)this.stream_0.ReadByte()));
		}
	}

	// Token: 0x060005C3 RID: 1475 RVA: 0x000030D5 File Offset: 0x000012D5
	public void method_1()
	{
		this.stream_0 = null;
	}

	// Token: 0x060005C4 RID: 1476 RVA: 0x0000E464 File Offset: 0x0000C664
	public uint method_2(int int_0)
	{
		uint num = this.uint_2;
		uint num2 = this.uint_3;
		uint num3 = 0U;
		for (int i = int_0; i > 0; i--)
		{
			num >>= 1;
			uint num4 = num2 - num >> 31;
			num2 -= (num & num4 - 1U);
			num3 = (num3 << 1 | 1U - num4);
			if (num < 16777216U)
			{
				num2 = (num2 << 8 | (uint)((byte)this.stream_0.ReadByte()));
				num <<= 8;
			}
		}
		this.uint_2 = num;
		this.uint_3 = num2;
		return num3;
	}

	// Token: 0x04000109 RID: 265
	private uint uint_0 = 1U;

	// Token: 0x0400010A RID: 266
	public const uint uint_1 = 16777216U;

	// Token: 0x0400010B RID: 267
	public uint uint_2;

	// Token: 0x0400010C RID: 268
	public uint uint_3;

	// Token: 0x0400010D RID: 269
	public Stream stream_0;
}

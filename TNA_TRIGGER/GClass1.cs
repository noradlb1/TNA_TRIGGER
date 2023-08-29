using System;
using System.IO;

// Token: 0x02000192 RID: 402
public class GClass1
{
	// Token: 0x060005CD RID: 1485 RVA: 0x00003114 File Offset: 0x00001314
	public void method_0(uint uint_5)
	{
		if (this.uint_1 != uint_5)
		{
			this.byte_0 = new byte[uint_5];
		}
		this.uint_1 = uint_5;
		this.uint_0 = 0U;
		this.uint_2 = 0U;
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x00003140 File Offset: 0x00001340
	public void method_1(Stream stream_1, bool bool_0)
	{
		this.method_2();
		this.stream_0 = stream_1;
		if (!bool_0)
		{
			this.uint_2 = 0U;
			this.uint_0 = 0U;
			this.uint_4 = 0U;
		}
	}

	// Token: 0x060005CF RID: 1487 RVA: 0x00003167 File Offset: 0x00001367
	public void method_2()
	{
		this.method_3();
		this.stream_0 = null;
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x0000E6C8 File Offset: 0x0000C8C8
	public void method_3()
	{
		uint num = this.uint_0 - this.uint_2;
		if (num == 0U)
		{
			return;
		}
		this.stream_0.Write(this.byte_0, (int)this.uint_2, (int)num);
		if (this.uint_0 >= this.uint_1)
		{
			this.uint_0 = 0U;
		}
		this.uint_2 = this.uint_0;
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x0000E720 File Offset: 0x0000C920
	public void method_4(uint uint_5, uint uint_6)
	{
		uint num = this.uint_0 - uint_5 - 1U;
		if (num >= this.uint_1)
		{
			num += this.uint_1;
		}
		while (uint_6 > 0U)
		{
			if (num >= this.uint_1)
			{
				num = 0U;
			}
			byte[] array = this.byte_0;
			uint num2 = this.uint_0;
			this.uint_0 = num2 + 1U;
			array[(int)num2] = this.byte_0[(int)num++];
			if (this.uint_0 >= this.uint_1)
			{
				this.method_3();
			}
			uint_6 -= 1U;
		}
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x0000E798 File Offset: 0x0000C998
	public void method_5(byte byte_1)
	{
		byte[] array = this.byte_0;
		uint num = this.uint_0;
		this.uint_0 = num + 1U;
		array[(int)num] = byte_1;
		if (this.uint_0 >= this.uint_1)
		{
			this.method_3();
		}
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x0000E7D4 File Offset: 0x0000C9D4
	public byte method_6(uint uint_5)
	{
		uint num = this.uint_0 - uint_5 - 1U;
		if (num >= this.uint_1)
		{
			num += this.uint_1;
		}
		return this.byte_0[(int)num];
	}

	// Token: 0x04000114 RID: 276
	private byte[] byte_0;

	// Token: 0x04000115 RID: 277
	private uint uint_0;

	// Token: 0x04000116 RID: 278
	private uint uint_1;

	// Token: 0x04000117 RID: 279
	private uint uint_2;

	// Token: 0x04000118 RID: 280
	private Stream stream_0;

	// Token: 0x04000119 RID: 281
	private uint uint_3 = 1U;

	// Token: 0x0400011A RID: 282
	public uint uint_4;
}

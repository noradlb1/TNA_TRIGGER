using System;

// Token: 0x0200019D RID: 413
public class GClass8
{
	// Token: 0x060005FD RID: 1533 RVA: 0x00003278 File Offset: 0x00001478
	public GClass8()
	{
		this.uint_0 = 1953769406U;
	}

	// Token: 0x060005FE RID: 1534 RVA: 0x00010654 File Offset: 0x0000E854
	public uint method_0(uint uint_1)
	{
		uint num = uint_1 ^ this.uint_0;
		this.uint_0 = (GClass9.smethod_0(this.uint_0, 7) ^ num);
		return num;
	}

	// Token: 0x04000149 RID: 329
	private uint uint_0;
}

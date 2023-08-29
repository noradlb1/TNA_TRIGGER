using System;
using System.Runtime.InteropServices;

// Token: 0x0200019C RID: 412
public class GClass7
{
	// Token: 0x060005FB RID: 1531 RVA: 0x000105A4 File Offset: 0x0000E7A4
	public GClass7()
	{
		if (GClass7.uint_0 == null)
		{
			GClass7.uint_0 = new uint[256];
			for (int i = 0; i < 256; i++)
			{
				uint num = (uint)i;
				for (int j = 0; j < 8; j++)
				{
					if ((num & 1U) == 1U)
					{
						num = (num >> 1 ^ 3988292384U);
					}
					else
					{
						num >>= 1;
					}
				}
				GClass7.uint_0[i] = num;
			}
		}
	}

	// Token: 0x060005FC RID: 1532 RVA: 0x0001060C File Offset: 0x0000E80C
	public uint method_0(IntPtr intptr_0, uint uint_1)
	{
		uint num = 0U;
		int num2 = 0;
		while ((long)num2 < (long)((ulong)uint_1))
		{
			num = (GClass7.uint_0[(int)(((uint)Marshal.ReadByte(new IntPtr(intptr_0.ToInt64() + (long)num2)) ^ num) & 255U)] ^ num >> 8);
			num2++;
		}
		return ~num;
	}

	// Token: 0x04000148 RID: 328
	private static uint[] uint_0;
}

using System;
using System.Drawing;

// Token: 0x020000C2 RID: 194
internal sealed class Delegate162 : MulticastDelegate
{
	// Token: 0x0600031F RID: 799
	internal extern Delegate162(object object_0, IntPtr intptr_0);

	// Token: 0x06000320 RID: 800
	internal unsafe extern byte Invoke(Color* pColor_0);

	// Token: 0x06000321 RID: 801 RVA: 0x0000A9C4 File Offset: 0x00008BC4
	internal unsafe static byte smethod_0(Color* pColor_0)
	{
		return GClass16.object_0[162](pColor_0);
	}
}

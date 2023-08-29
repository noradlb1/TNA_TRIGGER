using System;
using System.Drawing;

// Token: 0x02000047 RID: 71
internal sealed class Delegate39 : MulticastDelegate
{
	// Token: 0x060001AE RID: 430
	internal extern Delegate39(object object_0, IntPtr intptr_0);

	// Token: 0x060001AF RID: 431
	internal unsafe extern byte Invoke(Color* pColor_0);

	// Token: 0x060001B0 RID: 432 RVA: 0x0000970C File Offset: 0x0000790C
	internal unsafe static byte smethod_0(Color* pColor_0)
	{
		return GClass16.object_0[39](pColor_0);
	}
}

using System;
using System.Drawing;

// Token: 0x02000127 RID: 295
internal sealed class Delegate263 : MulticastDelegate
{
	// Token: 0x0600044E RID: 1102
	internal extern Delegate263(object object_0, IntPtr intptr_0);

	// Token: 0x0600044F RID: 1103
	internal unsafe extern byte Invoke(Color* pColor_0);

	// Token: 0x06000450 RID: 1104 RVA: 0x0000B9D0 File Offset: 0x00009BD0
	internal unsafe static byte smethod_0(Color* pColor_0)
	{
		return GClass16.object_0[263](pColor_0);
	}
}

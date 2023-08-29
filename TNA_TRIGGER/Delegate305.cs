using System;
using System.Drawing;

// Token: 0x02000151 RID: 337
internal sealed class Delegate305 : MulticastDelegate
{
	// Token: 0x060004CC RID: 1228
	internal extern Delegate305(object object_0, IntPtr intptr_0);

	// Token: 0x060004CD RID: 1229
	internal unsafe extern int Invoke(Size* pSize_0);

	// Token: 0x060004CE RID: 1230 RVA: 0x0000C040 File Offset: 0x0000A240
	internal unsafe static int smethod_0(Size* pSize_0)
	{
		return GClass16.object_0[305](pSize_0);
	}
}

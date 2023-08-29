using System;
using System.Drawing;

// Token: 0x02000077 RID: 119
internal sealed class Delegate87 : MulticastDelegate
{
	// Token: 0x0600023E RID: 574
	internal extern Delegate87(object object_0, IntPtr intptr_0);

	// Token: 0x0600023F RID: 575
	internal unsafe extern int Invoke(Rectangle* pRectangle_0);

	// Token: 0x06000240 RID: 576 RVA: 0x00009E24 File Offset: 0x00008024
	internal unsafe static int smethod_0(Rectangle* pRectangle_0)
	{
		return GClass16.object_0[87](pRectangle_0);
	}
}

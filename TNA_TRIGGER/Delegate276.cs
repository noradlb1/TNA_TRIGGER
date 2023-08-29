using System;
using System.Drawing;

// Token: 0x02000134 RID: 308
internal sealed class Delegate276 : MulticastDelegate
{
	// Token: 0x06000475 RID: 1141
	internal extern Delegate276(object object_0, IntPtr intptr_0);

	// Token: 0x06000476 RID: 1142
	internal unsafe extern int Invoke(Rectangle* pRectangle_0);

	// Token: 0x06000477 RID: 1143 RVA: 0x0000BBC8 File Offset: 0x00009DC8
	internal unsafe static int smethod_0(Rectangle* pRectangle_0)
	{
		return GClass16.object_0[276](pRectangle_0);
	}
}

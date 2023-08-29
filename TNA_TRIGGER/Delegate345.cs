using System;
using System.Drawing;

// Token: 0x02000179 RID: 377
internal sealed class Delegate345 : MulticastDelegate
{
	// Token: 0x06000544 RID: 1348
	internal extern Delegate345(object object_0, IntPtr intptr_0);

	// Token: 0x06000545 RID: 1349
	internal unsafe extern int Invoke(Rectangle* pRectangle_0);

	// Token: 0x06000546 RID: 1350 RVA: 0x0000C674 File Offset: 0x0000A874
	internal unsafe static int smethod_0(Rectangle* pRectangle_0)
	{
		return GClass16.object_0[345](pRectangle_0);
	}
}

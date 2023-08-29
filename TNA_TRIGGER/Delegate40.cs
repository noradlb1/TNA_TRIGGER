using System;
using System.Drawing;

// Token: 0x02000048 RID: 72
internal sealed class Delegate40 : MulticastDelegate
{
	// Token: 0x060001B1 RID: 433
	internal extern Delegate40(object object_0, IntPtr intptr_0);

	// Token: 0x060001B2 RID: 434
	internal unsafe extern int Invoke(Rectangle* pRectangle_0);

	// Token: 0x060001B3 RID: 435 RVA: 0x0000972C File Offset: 0x0000792C
	internal unsafe static int smethod_0(Rectangle* pRectangle_0)
	{
		return GClass16.object_0[40](pRectangle_0);
	}
}

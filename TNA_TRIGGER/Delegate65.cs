using System;
using System.Drawing;

// Token: 0x02000061 RID: 97
internal sealed class Delegate65 : MulticastDelegate
{
	// Token: 0x060001FC RID: 508
	internal extern Delegate65(object object_0, IntPtr intptr_0);

	// Token: 0x060001FD RID: 509
	internal unsafe extern int Invoke(Point* pPoint_0);

	// Token: 0x060001FE RID: 510 RVA: 0x00009AB4 File Offset: 0x00007CB4
	internal unsafe static int smethod_0(Point* pPoint_0)
	{
		return GClass16.object_0[65](pPoint_0);
	}
}

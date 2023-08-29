using System;
using System.Drawing;

// Token: 0x020000E3 RID: 227
internal sealed class Delegate195 : MulticastDelegate
{
	// Token: 0x06000382 RID: 898
	internal extern Delegate195(object object_0, IntPtr intptr_0);

	// Token: 0x06000383 RID: 899
	internal unsafe extern int Invoke(Point* pPoint_0);

	// Token: 0x06000384 RID: 900 RVA: 0x0000AED0 File Offset: 0x000090D0
	internal unsafe static int smethod_0(Point* pPoint_0)
	{
		return GClass16.object_0[195](pPoint_0);
	}
}

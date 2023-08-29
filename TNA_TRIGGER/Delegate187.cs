using System;
using System.Drawing;

// Token: 0x020000DB RID: 219
internal sealed class Delegate187 : MulticastDelegate
{
	// Token: 0x0600036A RID: 874
	internal extern Delegate187(object object_0, IntPtr intptr_0);

	// Token: 0x0600036B RID: 875
	internal unsafe extern bool Invoke(Point* pPoint_0);

	// Token: 0x0600036C RID: 876 RVA: 0x0000ADA4 File Offset: 0x00008FA4
	internal unsafe static bool smethod_0(Point* pPoint_0)
	{
		return GClass16.object_0[187](pPoint_0);
	}
}

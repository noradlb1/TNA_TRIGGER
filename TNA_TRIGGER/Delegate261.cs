using System;
using System.Drawing;

// Token: 0x02000125 RID: 293
internal sealed class Delegate261 : MulticastDelegate
{
	// Token: 0x06000448 RID: 1096
	internal extern Delegate261(object object_0, IntPtr intptr_0);

	// Token: 0x06000449 RID: 1097
	internal unsafe extern int Invoke(Rectangle* pRectangle_0);

	// Token: 0x0600044A RID: 1098 RVA: 0x0000B984 File Offset: 0x00009B84
	internal unsafe static int smethod_0(Rectangle* pRectangle_0)
	{
		return GClass16.object_0[261](pRectangle_0);
	}
}

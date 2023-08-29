using System;
using System.Drawing;

// Token: 0x0200016A RID: 362
internal sealed class Delegate330 : MulticastDelegate
{
	// Token: 0x06000517 RID: 1303
	internal extern Delegate330(object object_0, IntPtr intptr_0);

	// Token: 0x06000518 RID: 1304
	internal unsafe extern Size Invoke(Rectangle* pRectangle_0);

	// Token: 0x06000519 RID: 1305 RVA: 0x0000C430 File Offset: 0x0000A630
	internal unsafe static Size smethod_0(Rectangle* pRectangle_0)
	{
		return GClass16.object_0[330](pRectangle_0);
	}
}

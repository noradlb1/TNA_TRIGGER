using System;
using System.Drawing;

// Token: 0x0200009B RID: 155
internal sealed class Delegate123 : MulticastDelegate
{
	// Token: 0x060002AA RID: 682
	internal extern Delegate123(object object_0, IntPtr intptr_0);

	// Token: 0x060002AB RID: 683
	internal unsafe extern int Invoke(Rectangle* pRectangle_0);

	// Token: 0x060002AC RID: 684 RVA: 0x0000A318 File Offset: 0x00008518
	internal unsafe static int smethod_0(Rectangle* pRectangle_0)
	{
		return GClass16.object_0[123](pRectangle_0);
	}
}

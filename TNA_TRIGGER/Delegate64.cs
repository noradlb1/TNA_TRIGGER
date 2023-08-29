using System;
using System.Drawing;

// Token: 0x02000060 RID: 96
internal sealed class Delegate64 : MulticastDelegate
{
	// Token: 0x060001F9 RID: 505
	internal extern Delegate64(object object_0, IntPtr intptr_0);

	// Token: 0x060001FA RID: 506
	internal extern void Invoke(object object_0, Color color_0);

	// Token: 0x060001FB RID: 507 RVA: 0x00009A8C File Offset: 0x00007C8C
	internal static void smethod_0(object object_0, Color color_0)
	{
		GClass16.object_0[64](object_0, color_0);
	}
}

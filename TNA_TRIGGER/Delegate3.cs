using System;
using System.Drawing;

// Token: 0x02000023 RID: 35
internal sealed class Delegate3 : MulticastDelegate
{
	// Token: 0x06000142 RID: 322
	internal extern Delegate3(object object_0, IntPtr intptr_0);

	// Token: 0x06000143 RID: 323
	internal extern void Invoke(object object_0, Color color_0);

	// Token: 0x06000144 RID: 324 RVA: 0x000091F4 File Offset: 0x000073F4
	internal static void smethod_0(object object_0, Color color_0)
	{
		GClass16.object_0[3](object_0, color_0);
	}
}

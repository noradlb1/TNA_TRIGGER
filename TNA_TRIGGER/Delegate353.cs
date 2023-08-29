using System;

// Token: 0x02000181 RID: 385
internal sealed class Delegate353 : MulticastDelegate
{
	// Token: 0x0600055C RID: 1372
	internal extern Delegate353(object object_0, IntPtr intptr_0);

	// Token: 0x0600055D RID: 1373
	internal extern void Invoke(object object_0, EventHandler eventHandler_0);

	// Token: 0x0600055E RID: 1374 RVA: 0x0000C7B8 File Offset: 0x0000A9B8
	internal static void smethod_0(object object_0, EventHandler eventHandler_0)
	{
		uint num = 112282545U;
		do
		{
			GClass16.object_0[(int)(num - 112282192U)](object_0, eventHandler_0);
		}
		while (num == 852188322U);
	}
}

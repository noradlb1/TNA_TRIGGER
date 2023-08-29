using System;
using System.Drawing;

// Token: 0x02000157 RID: 343
internal sealed class Delegate311 : MulticastDelegate
{
	// Token: 0x060004DE RID: 1246
	internal extern Delegate311(object object_0, IntPtr intptr_0);

	// Token: 0x060004DF RID: 1247
	internal extern void Invoke(object object_0, Color color_0);

	// Token: 0x060004E0 RID: 1248 RVA: 0x0000C138 File Offset: 0x0000A338
	internal static void smethod_0(object object_0, Color color_0)
	{
		uint num = 1121397559U;
		do
		{
			object[] object_ = GClass16.object_0;
			num = 831020698U + num;
			Delegate311 @delegate = object_[(int)(num ^ 1952418022U)];
			num ^= 398540878U;
			num = 1394829422U * num;
			@delegate(object_0, color_0);
		}
		while (num >> 19 == 0U);
	}
}

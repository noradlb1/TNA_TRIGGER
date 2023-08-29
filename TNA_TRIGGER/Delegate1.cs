using System;
using System.Drawing;

// Token: 0x02000021 RID: 33
internal sealed class Delegate1 : MulticastDelegate
{
	// Token: 0x0600013C RID: 316
	internal extern Delegate1(object object_0, IntPtr intptr_0);

	// Token: 0x0600013D RID: 317
	internal extern void Invoke(object object_0, Color color_0);

	// Token: 0x0600013E RID: 318 RVA: 0x00009190 File Offset: 0x00007390
	internal static void smethod_0(object object_0, Color color_0)
	{
		uint num = 130825910U;
		do
		{
			object[] object_ = GClass16.object_0;
			num = 1821992643U / num;
			object_[(int)(num + 4294967284U)](object_0, color_0);
		}
		while (num % 351822216U == 0U);
	}
}

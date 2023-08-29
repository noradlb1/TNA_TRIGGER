using System;
using System.Drawing;

// Token: 0x02000138 RID: 312
internal sealed class Delegate280 : MulticastDelegate
{
	// Token: 0x06000481 RID: 1153
	internal extern Delegate280(object object_0, IntPtr intptr_0);

	// Token: 0x06000482 RID: 1154
	internal extern void Invoke(object object_0, Color color_0);

	// Token: 0x06000483 RID: 1155 RVA: 0x0000BC64 File Offset: 0x00009E64
	internal static void smethod_0(object object_0, Color color_0)
	{
		uint num = 1620916688U;
		do
		{
			Delegate280 @delegate = GClass16.object_0[(int)(num ^ 1620916424U)];
			num = 1893613440U * num;
			num += 955219578U;
			num <<= 12;
			@delegate(object_0, color_0);
		}
		while (311766778U % num == 0U);
	}
}

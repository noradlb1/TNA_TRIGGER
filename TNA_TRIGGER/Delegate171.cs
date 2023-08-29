using System;
using System.Drawing;

// Token: 0x020000CB RID: 203
internal sealed class Delegate171 : MulticastDelegate
{
	// Token: 0x0600033A RID: 826
	internal extern Delegate171(object object_0, IntPtr intptr_0);

	// Token: 0x0600033B RID: 827
	internal extern void Invoke(object object_0, Color color_0);

	// Token: 0x0600033C RID: 828 RVA: 0x0000AB28 File Offset: 0x00008D28
	internal static void smethod_0(object object_0, Color color_0)
	{
		uint num = 1950762909U;
		do
		{
			Delegate171 @delegate = GClass16.object_0[(int)(num - 1950762738U)];
			num |= 190514430U;
			num -= 70209257U;
			num >>= 2;
			@delegate(object_0, color_0);
		}
		while (num % 612045470U == 0U);
	}
}

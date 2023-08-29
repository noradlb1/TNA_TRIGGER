using System;
using System.Drawing;

// Token: 0x020000B6 RID: 182
internal sealed class Delegate150 : MulticastDelegate
{
	// Token: 0x060002FB RID: 763
	internal extern Delegate150(object object_0, IntPtr intptr_0);

	// Token: 0x060002FC RID: 764
	internal extern void Invoke(object object_0, Color color_0);

	// Token: 0x060002FD RID: 765 RVA: 0x0000A7C4 File Offset: 0x000089C4
	internal static void smethod_0(object object_0, Color color_0)
	{
		uint num = 880753916U;
		do
		{
			object[] object_ = GClass16.object_0;
			num = 1513041523U % num;
			int num2 = (int)(num ^ 632287713U);
			num = (382959362U & num);
			Delegate150 @delegate = object_[num2];
			num = 1290411495U + num;
			@delegate(object_0, color_0);
		}
		while (num <= 142883288U);
	}
}

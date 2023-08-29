using System;

// Token: 0x02000184 RID: 388
internal sealed class Delegate356 : MulticastDelegate
{
	// Token: 0x06000565 RID: 1381
	internal extern Delegate356(object object_0, IntPtr intptr_0);

	// Token: 0x06000566 RID: 1382
	internal extern void Invoke(object object_0, string string_0);

	// Token: 0x06000567 RID: 1383 RVA: 0x0000C870 File Offset: 0x0000AA70
	internal static void smethod_0(object object_0, string string_0)
	{
		uint num = 2063017507U;
		do
		{
			object[] object_ = GClass16.object_0;
			num %= 136799700U;
			int num2 = (int)(num - 11021651U);
			num = 1182354421U * num;
			Delegate356 @delegate = object_[num2];
			num += 1179865617U;
			num ^= 602895355U;
			num = 553389352U / num;
			@delegate(object_0, string_0);
		}
		while (num - 1202285889U == 0U);
	}
}

using System;

// Token: 0x02000183 RID: 387
internal sealed class Delegate355 : MulticastDelegate
{
	// Token: 0x06000562 RID: 1378
	internal extern Delegate355(object object_0, IntPtr intptr_0);

	// Token: 0x06000563 RID: 1379
	internal extern void Invoke(object object_0, int int_0);

	// Token: 0x06000564 RID: 1380 RVA: 0x0000C818 File Offset: 0x0000AA18
	internal static void smethod_0(object object_0, int int_0)
	{
		uint num = 2123703886U;
		do
		{
			object[] object_ = GClass16.object_0;
			num = (1980040901U ^ num);
			int num2 = (int)(num ^ 143663592U);
			num <<= 11;
			Delegate355 @delegate = object_[num2];
			num <<= 0;
			num *= 406665063U;
			@delegate(object_0, int_0);
		}
		while (num == 1896622045U);
	}
}

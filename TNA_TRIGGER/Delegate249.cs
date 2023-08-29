using System;

// Token: 0x02000119 RID: 281
internal sealed class Delegate249 : MulticastDelegate
{
	// Token: 0x06000424 RID: 1060
	internal extern Delegate249(object object_0, IntPtr intptr_0);

	// Token: 0x06000425 RID: 1061
	internal extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06000426 RID: 1062 RVA: 0x0000B794 File Offset: 0x00009994
	internal static void smethod_0(object object_0, bool bool_0)
	{
		uint num = 1535785222U;
		do
		{
			object[] object_ = GClass16.object_0;
			int num2 = (int)(num ^ 1535785471U);
			num = (95713347U ^ num);
			Delegate249 @delegate = object_[num2];
			num *= 781848922U;
			num = (725434849U & num);
			@delegate(object_0, bool_0);
		}
		while (num > 832066106U);
	}
}

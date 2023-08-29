using System;

// Token: 0x02000054 RID: 84
internal sealed class Delegate52 : MulticastDelegate
{
	// Token: 0x060001D5 RID: 469
	internal extern Delegate52(object object_0, IntPtr intptr_0);

	// Token: 0x060001D6 RID: 470
	internal extern void Invoke(object object_0, bool bool_0);

	// Token: 0x060001D7 RID: 471 RVA: 0x000098C0 File Offset: 0x00007AC0
	internal static void smethod_0(object object_0, bool bool_0)
	{
		uint num = 1286502055U;
		do
		{
			object[] object_ = GClass16.object_0;
			num *= 1123037274U;
			int num2 = (int)(num + 165345662U);
			num %= 349595166U;
			Delegate52 @delegate = object_[num2];
			num = 1941657772U >> (int)num;
			@delegate(object_0, bool_0);
		}
		while (274224788U - num == 0U);
	}
}

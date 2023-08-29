using System;

// Token: 0x020000A5 RID: 165
internal sealed class Delegate133 : MulticastDelegate
{
	// Token: 0x060002C8 RID: 712
	internal extern Delegate133(object object_0, IntPtr intptr_0);

	// Token: 0x060002C9 RID: 713
	internal extern void Invoke(object object_0, string string_0);

	// Token: 0x060002CA RID: 714 RVA: 0x0000A4DC File Offset: 0x000086DC
	internal static void smethod_0(object object_0, string string_0)
	{
		uint num = 1076900988U;
		do
		{
			object[] object_ = GClass16.object_0;
			num = 541532804U + num;
			int num2 = (int)(num ^ 1618433925U);
			num = (1027426500U & num);
			Delegate133 @delegate = object_[num2];
			num ^= 1299003943U;
			num -= 1721116943U;
			@delegate(object_0, string_0);
		}
		while (1215718418U + num == 0U);
	}
}

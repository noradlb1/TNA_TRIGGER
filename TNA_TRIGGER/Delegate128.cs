using System;

// Token: 0x020000A0 RID: 160
internal sealed class Delegate128 : MulticastDelegate
{
	// Token: 0x060002B9 RID: 697
	internal extern Delegate128(object object_0, IntPtr intptr_0);

	// Token: 0x060002BA RID: 698
	internal extern void Invoke(object object_0, bool bool_0);

	// Token: 0x060002BB RID: 699 RVA: 0x0000A3F8 File Offset: 0x000085F8
	internal static void smethod_0(object object_0, bool bool_0)
	{
		uint num = 1590040807U;
		do
		{
			object[] object_ = GClass16.object_0;
			int num2 = (int)(num - 1590040679U);
			num = (1859088641U & num);
			Delegate128 @delegate = object_[num2];
			num -= 1991660198U;
			@delegate(object_0, bool_0);
		}
		while (2040142292U / num != 0U);
	}
}

using System;

// Token: 0x02000112 RID: 274
internal sealed class Delegate242 : MulticastDelegate
{
	// Token: 0x0600040F RID: 1039
	internal extern Delegate242(object object_0, IntPtr intptr_0);

	// Token: 0x06000410 RID: 1040
	internal extern void Invoke(object object_0, int int_0);

	// Token: 0x06000411 RID: 1041 RVA: 0x0000B65C File Offset: 0x0000985C
	internal static void smethod_0(object object_0, int int_0)
	{
		uint num = 1132095520U;
		do
		{
			object[] object_ = GClass16.object_0;
			num -= 1487618453U;
			Delegate242 @delegate = object_[(int)(num + 355523175U)];
			num = 1378878849U << (int)num;
			num /= 296430910U;
			@delegate(object_0, int_0);
		}
		while (1646463536U < num);
	}
}

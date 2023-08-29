using System;

// Token: 0x02000162 RID: 354
internal sealed class Delegate322 : MulticastDelegate
{
	// Token: 0x060004FF RID: 1279
	internal extern Delegate322(object object_0, IntPtr intptr_0);

	// Token: 0x06000500 RID: 1280
	internal extern void Invoke();

	// Token: 0x06000501 RID: 1281 RVA: 0x0000C2F4 File Offset: 0x0000A4F4
	internal static void smethod_0()
	{
		uint num = 542458547U;
		do
		{
			object[] object_ = GClass16.object_0;
			int num2 = (int)(num ^ 542458865U);
			num = 1279666630U + num;
			object_[num2]();
		}
		while (num == 1378972966U);
	}
}

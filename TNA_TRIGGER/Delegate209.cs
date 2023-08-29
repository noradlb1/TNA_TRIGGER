using System;

// Token: 0x020000F1 RID: 241
internal sealed class Delegate209 : MulticastDelegate
{
	// Token: 0x060003AC RID: 940
	internal extern Delegate209(object object_0, IntPtr intptr_0);

	// Token: 0x060003AD RID: 941
	internal extern void Invoke(object object_0);

	// Token: 0x060003AE RID: 942 RVA: 0x0000B114 File Offset: 0x00009314
	internal static void smethod_0(object object_0)
	{
		uint num = 1103838325U;
		do
		{
			object[] object_ = GClass16.object_0;
			int num2 = (int)(num ^ 1103838372U);
			num = (1456236638U ^ num);
			object_[num2](object_0);
		}
		while (1903707497U * num == 0U);
	}
}

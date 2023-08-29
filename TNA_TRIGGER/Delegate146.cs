using System;

// Token: 0x020000B2 RID: 178
internal sealed class Delegate146 : MulticastDelegate
{
	// Token: 0x060002EF RID: 751
	internal extern Delegate146(object object_0, IntPtr intptr_0);

	// Token: 0x060002F0 RID: 752
	internal extern void Invoke(object object_0, int int_0);

	// Token: 0x060002F1 RID: 753 RVA: 0x0000A704 File Offset: 0x00008904
	internal static void smethod_0(object object_0, int int_0)
	{
		uint num = 882274671U;
		do
		{
			Delegate146 @delegate = GClass16.object_0[(int)(num - 882274525U)];
			num += 1899724548U;
			num = (480256719U & num);
			@delegate(object_0, int_0);
		}
		while (num >> 19 == 0U);
	}
}

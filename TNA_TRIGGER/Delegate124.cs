using System;

// Token: 0x0200009C RID: 156
internal sealed class Delegate124 : MulticastDelegate
{
	// Token: 0x060002AD RID: 685
	internal extern Delegate124(object object_0, IntPtr intptr_0);

	// Token: 0x060002AE RID: 686
	internal extern void Invoke(object object_0, string string_0);

	// Token: 0x060002AF RID: 687 RVA: 0x0000A33C File Offset: 0x0000853C
	internal static void smethod_0(object object_0, string string_0)
	{
		uint num = 1842501088U;
		do
		{
			object[] object_ = GClass16.object_0;
			num -= 1639334826U;
			Delegate124 @delegate = object_[(int)(num - 203166138U)];
			num += 765082923U;
			@delegate(object_0, string_0);
		}
		while (num - 512113142U == 0U);
	}
}

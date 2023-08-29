using System;

// Token: 0x02000020 RID: 32
internal sealed class Delegate0 : MulticastDelegate
{
	// Token: 0x06000139 RID: 313
	internal extern Delegate0(object object_0, IntPtr intptr_0);

	// Token: 0x0600013A RID: 314
	internal unsafe extern DateTime Invoke(DateTime* pDateTime_0, double double_0);

	// Token: 0x0600013B RID: 315 RVA: 0x0000916C File Offset: 0x0000736C
	internal unsafe static DateTime smethod_0(DateTime* pDateTime_0, double double_0)
	{
		return GClass16.object_0[0](pDateTime_0, double_0);
	}
}

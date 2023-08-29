using System;

// Token: 0x0200007C RID: 124
internal sealed class Delegate92 : MulticastDelegate
{
	// Token: 0x0600024D RID: 589
	internal extern Delegate92(object object_0, IntPtr intptr_0);

	// Token: 0x0600024E RID: 590
	internal unsafe extern double Invoke(TimeSpan* pTimeSpan_0);

	// Token: 0x0600024F RID: 591 RVA: 0x00009ED4 File Offset: 0x000080D4
	internal unsafe static double smethod_0(TimeSpan* pTimeSpan_0)
	{
		return GClass16.object_0[92](pTimeSpan_0);
	}
}

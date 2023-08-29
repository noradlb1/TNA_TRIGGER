using System;

// Token: 0x02000080 RID: 128
internal sealed class Delegate96 : MulticastDelegate
{
	// Token: 0x06000259 RID: 601
	internal extern Delegate96(object object_0, IntPtr intptr_0);

	// Token: 0x0600025A RID: 602
	internal unsafe extern TimeSpan Invoke(DateTime* pDateTime_0, DateTime dateTime_0);

	// Token: 0x0600025B RID: 603 RVA: 0x00009F64 File Offset: 0x00008164
	internal unsafe static TimeSpan smethod_0(DateTime* pDateTime_0, DateTime dateTime_0)
	{
		return GClass16.object_0[96](pDateTime_0, dateTime_0);
	}
}

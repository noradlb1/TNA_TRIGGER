using System;
using System.Net.Security;

// Token: 0x0200011C RID: 284
internal sealed class Delegate252 : MulticastDelegate
{
	// Token: 0x0600042D RID: 1069
	internal extern Delegate252(object object_0, IntPtr intptr_0);

	// Token: 0x0600042E RID: 1070
	internal extern RemoteCertificateValidationCallback Invoke();

	// Token: 0x0600042F RID: 1071 RVA: 0x0000B82C File Offset: 0x00009A2C
	internal static RemoteCertificateValidationCallback smethod_0()
	{
		return GClass16.object_0[252]();
	}
}

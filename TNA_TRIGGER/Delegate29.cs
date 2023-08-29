using System;
using System.Net.Security;

// Token: 0x0200003D RID: 61
internal sealed class Delegate29 : MulticastDelegate
{
	// Token: 0x06000190 RID: 400
	internal extern Delegate29(object object_0, IntPtr intptr_0);

	// Token: 0x06000191 RID: 401
	internal extern void Invoke(RemoteCertificateValidationCallback remoteCertificateValidationCallback_0);

	// Token: 0x06000192 RID: 402 RVA: 0x00009578 File Offset: 0x00007778
	internal static void smethod_0(RemoteCertificateValidationCallback remoteCertificateValidationCallback_0)
	{
		GClass16.object_0[29](remoteCertificateValidationCallback_0);
	}
}

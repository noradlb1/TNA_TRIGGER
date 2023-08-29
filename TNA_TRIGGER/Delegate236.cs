using System;
using System.Diagnostics;

// Token: 0x0200010C RID: 268
internal sealed class Delegate236 : MulticastDelegate
{
	// Token: 0x060003FD RID: 1021
	internal extern Delegate236(object object_0, IntPtr intptr_0);

	// Token: 0x060003FE RID: 1022
	internal extern Process Invoke(ProcessStartInfo processStartInfo_0);

	// Token: 0x060003FF RID: 1023 RVA: 0x0000B560 File Offset: 0x00009760
	internal static Process smethod_0(ProcessStartInfo processStartInfo_0)
	{
		return GClass16.object_0[236](processStartInfo_0);
	}
}

using System;
using System.ComponentModel;

// Token: 0x0200006B RID: 107
internal sealed class Delegate75 : MulticastDelegate
{
	// Token: 0x0600021A RID: 538
	internal extern Delegate75(object object_0, IntPtr intptr_0);

	// Token: 0x0600021B RID: 539
	internal extern void Invoke(object object_0, DoWorkEventHandler doWorkEventHandler_0);

	// Token: 0x0600021C RID: 540 RVA: 0x00009C70 File Offset: 0x00007E70
	internal static void smethod_0(object object_0, DoWorkEventHandler doWorkEventHandler_0)
	{
		GClass16.object_0[75](object_0, doWorkEventHandler_0);
	}
}

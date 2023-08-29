using System;
using System.Runtime.CompilerServices;

// Token: 0x020000C1 RID: 193
internal sealed class Delegate161 : MulticastDelegate
{
	// Token: 0x0600031C RID: 796
	internal extern Delegate161(object object_0, IntPtr intptr_0);

	// Token: 0x0600031D RID: 797
	internal unsafe extern bool Invoke(TaskAwaiter* pTaskAwaiter_0);

	// Token: 0x0600031E RID: 798 RVA: 0x0000A9A0 File Offset: 0x00008BA0
	internal unsafe static bool smethod_0(TaskAwaiter* pTaskAwaiter_0)
	{
		return GClass16.object_0[161](pTaskAwaiter_0);
	}
}

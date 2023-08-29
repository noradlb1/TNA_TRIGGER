using System;
using DiscordRPC.Events;

// Token: 0x02000036 RID: 54
internal sealed class Delegate22 : MulticastDelegate
{
	// Token: 0x0600017B RID: 379
	internal extern Delegate22(object object_0, IntPtr intptr_0);

	// Token: 0x0600017C RID: 380
	internal extern void Invoke(object object_0, OnPresenceUpdateEvent onPresenceUpdateEvent_0);

	// Token: 0x0600017D RID: 381 RVA: 0x00009480 File Offset: 0x00007680
	internal static void smethod_0(object object_0, OnPresenceUpdateEvent onPresenceUpdateEvent_0)
	{
		GClass16.object_0[22](object_0, onPresenceUpdateEvent_0);
	}
}

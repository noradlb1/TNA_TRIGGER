using System;
using DiscordRPC.Events;

// Token: 0x02000153 RID: 339
internal sealed class Delegate307 : MulticastDelegate
{
	// Token: 0x060004D2 RID: 1234
	internal extern Delegate307(object object_0, IntPtr intptr_0);

	// Token: 0x060004D3 RID: 1235
	internal extern void Invoke(object object_0, OnReadyEvent onReadyEvent_0);

	// Token: 0x060004D4 RID: 1236 RVA: 0x0000C088 File Offset: 0x0000A288
	internal static void smethod_0(object object_0, OnReadyEvent onReadyEvent_0)
	{
		uint num = 1466580836U;
		do
		{
			object[] object_ = GClass16.object_0;
			num *= 212011789U;
			object_[(int)(num ^ 231376167U)](object_0, onReadyEvent_0);
		}
		while (num >= 1643790584U);
	}
}

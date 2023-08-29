using System;
using JCS;

// Token: 0x020000A2 RID: 162
internal sealed class Delegate130 : MulticastDelegate
{
	// Token: 0x060002BF RID: 703
	internal extern Delegate130(object object_0, IntPtr intptr_0);

	// Token: 0x060002C0 RID: 704
	internal extern void Invoke(object object_0, ToggleSwitch.CheckedChangedDelegate checkedChangedDelegate_0);

	// Token: 0x060002C1 RID: 705 RVA: 0x0000A460 File Offset: 0x00008660
	internal static void smethod_0(object object_0, ToggleSwitch.CheckedChangedDelegate checkedChangedDelegate_0)
	{
		GClass16.object_0[130](object_0, checkedChangedDelegate_0);
	}
}

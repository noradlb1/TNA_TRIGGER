using System;
using System.Threading;

// Token: 0x02000055 RID: 85
internal sealed class Delegate53 : MulticastDelegate
{
	// Token: 0x060001D8 RID: 472
	internal extern Delegate53(object object_0, IntPtr intptr_0);

	// Token: 0x060001D9 RID: 473
	internal extern object Invoke(ThreadStart threadStart_0);

	// Token: 0x060001DA RID: 474 RVA: 0x00009914 File Offset: 0x00007B14
	internal static object smethod_0(ThreadStart threadStart_0)
	{
		return GClass16.object_0[53](threadStart_0);
	}
}

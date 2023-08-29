using System;
using WindowsInput;

// Token: 0x020000C0 RID: 192
internal sealed class Delegate160 : MulticastDelegate
{
	// Token: 0x06000319 RID: 793
	internal extern Delegate160(object object_0, IntPtr intptr_0);

	// Token: 0x0600031A RID: 794
	internal extern IMouseSimulator Invoke(object object_0, int int_0, int int_1);

	// Token: 0x0600031B RID: 795 RVA: 0x0000A974 File Offset: 0x00008B74
	internal static IMouseSimulator smethod_0(object object_0, int int_0, int int_1)
	{
		return GClass16.object_0[160](object_0, int_0, int_1);
	}
}

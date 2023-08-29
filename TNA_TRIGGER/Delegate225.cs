using System;

// Token: 0x02000101 RID: 257
internal sealed class Delegate225 : MulticastDelegate
{
	// Token: 0x060003DC RID: 988
	internal extern Delegate225(object object_0, IntPtr intptr_0);

	// Token: 0x060003DD RID: 989
	internal extern void Invoke(object sender, EventArgs e);

	// Token: 0x060003DE RID: 990 RVA: 0x0000B384 File Offset: 0x00009584
	internal static void smethod_0(object sender, EventArgs e)
	{
		uint num = 684227561U;
		do
		{
			Delegate225 @delegate = GClass16.object_0[(int)(num ^ 684227336U)];
			num = (786437744U | num);
			num |= 407776337U;
			@delegate(sender, e);
		}
		while (num < 186456434U);
	}
}

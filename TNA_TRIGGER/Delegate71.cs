using System;

// Token: 0x02000067 RID: 103
internal sealed class Delegate71 : MulticastDelegate
{
	// Token: 0x0600020E RID: 526
	internal extern Delegate71(object object_0, IntPtr intptr_0);

	// Token: 0x0600020F RID: 527
	internal extern void Invoke(object object_0);

	// Token: 0x06000210 RID: 528 RVA: 0x00009B8C File Offset: 0x00007D8C
	internal static void smethod_0(object object_0)
	{
		uint num = 247953742U;
		do
		{
			object[] object_ = GClass16.object_0;
			num = 2038915310U - num;
			Delegate71 @delegate = object_[(int)(num + 2504005799U)];
			num >>= 14;
			@delegate(object_0);
		}
		while (327055643U <= num);
	}
}

using System;

// Token: 0x0200010D RID: 269
internal sealed class Delegate237 : MulticastDelegate
{
	// Token: 0x06000400 RID: 1024
	internal extern Delegate237(object object_0, IntPtr intptr_0);

	// Token: 0x06000401 RID: 1025
	internal extern void Invoke(object object_0, string string_0);

	// Token: 0x06000402 RID: 1026 RVA: 0x0000B584 File Offset: 0x00009784
	internal static void smethod_0(object object_0, string string_0)
	{
		uint num = 560283732U;
		do
		{
			object[] object_ = GClass16.object_0;
			int num2 = (int)(num + 3734683801U);
			num %= 595615443U;
			Delegate237 @delegate = object_[num2];
			num = 1078275640U / num;
			@delegate(object_0, string_0);
		}
		while (799112730U <= num);
	}
}

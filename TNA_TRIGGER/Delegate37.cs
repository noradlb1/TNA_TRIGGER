using System;
using JCS;

// Token: 0x02000045 RID: 69
internal sealed class Delegate37 : MulticastDelegate
{
	// Token: 0x060001A8 RID: 424
	internal extern Delegate37(object object_0, IntPtr intptr_0);

	// Token: 0x060001A9 RID: 425
	internal extern void Invoke(object object_0, ToggleSwitch.ToggleSwitchStyle toggleSwitchStyle_0);

	// Token: 0x060001AA RID: 426 RVA: 0x00009694 File Offset: 0x00007894
	internal static void smethod_0(object object_0, ToggleSwitch.ToggleSwitchStyle toggleSwitchStyle_0)
	{
		uint num = 1517579228U;
		do
		{
			object[] object_ = GClass16.object_0;
			num = 1390046735U >> (int)num;
			int num2 = (int)(num + 32U);
			num -= 908085752U;
			Delegate37 @delegate = object_[num2];
			num = 832047409U >> (int)num;
			@delegate(object_0, toggleSwitchStyle_0);
		}
		while (1644837060U <= num);
	}
}

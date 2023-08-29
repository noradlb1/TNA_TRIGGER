using System;
using System.Windows;

// Token: 0x0200010A RID: 266
internal sealed class Delegate234 : MulticastDelegate
{
	// Token: 0x060003F7 RID: 1015
	internal extern Delegate234(object object_0, IntPtr intptr_0);

	// Token: 0x060003F8 RID: 1016
	internal extern MessageBoxResult Invoke(string string_0, string string_1, MessageBoxButton messageBoxButton_0, MessageBoxImage messageBoxImage_0);

	// Token: 0x060003F9 RID: 1017 RVA: 0x0000B508 File Offset: 0x00009708
	internal static MessageBoxResult smethod_0(string string_0, string string_1, MessageBoxButton messageBoxButton_0, MessageBoxImage messageBoxImage_0)
	{
		return GClass16.object_0[234](string_0, string_1, messageBoxButton_0, messageBoxImage_0);
	}
}

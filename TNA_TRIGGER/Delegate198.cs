using System;
using System.Windows.Forms;

// Token: 0x020000E6 RID: 230
internal sealed class Delegate198 : MulticastDelegate
{
	// Token: 0x0600038B RID: 907
	internal extern Delegate198(object object_0, IntPtr intptr_0);

	// Token: 0x0600038C RID: 908
	internal extern void Invoke(object object_0, Padding padding_0);

	// Token: 0x0600038D RID: 909 RVA: 0x0000AF40 File Offset: 0x00009140
	internal static void smethod_0(object object_0, Padding padding_0)
	{
		uint num = 535982588U;
		do
		{
			object[] object_ = GClass16.object_0;
			int num2 = (int)(num + 3758984906U);
			num *= 1365718887U;
			Delegate198 @delegate = object_[num2];
			num >>= 6;
			num >>= 15;
			@delegate(object_0, padding_0);
		}
		while (931875125U - num == 0U);
	}
}

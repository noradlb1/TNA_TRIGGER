using System;
using System.Windows.Forms;

// Token: 0x02000068 RID: 104
internal sealed class Delegate72 : MulticastDelegate
{
	// Token: 0x06000211 RID: 529
	internal extern Delegate72(object object_0, IntPtr intptr_0);

	// Token: 0x06000212 RID: 530
	internal extern void Invoke(object object_0, Cursor cursor_0);

	// Token: 0x06000213 RID: 531 RVA: 0x00009BD0 File Offset: 0x00007DD0
	internal static void smethod_0(object object_0, Cursor cursor_0)
	{
		uint num = 285290292U;
		do
		{
			object[] object_ = GClass16.object_0;
			int num2 = (int)(num - 285290220U);
			num = 61407689U - num;
			Delegate72 @delegate = object_[num2];
			num = 373849894U - num;
			num = 85278447U - num;
			@delegate(object_0, cursor_0);
		}
		while (1525885120U / num != 0U);
	}
}

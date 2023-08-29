using System;
using System.Windows.Forms;

// Token: 0x02000072 RID: 114
internal sealed class Delegate82 : MulticastDelegate
{
	// Token: 0x0600022F RID: 559
	internal extern Delegate82(object object_0, IntPtr intptr_0);

	// Token: 0x06000230 RID: 560
	internal extern void Invoke(object object_0, ImageLayout imageLayout_0);

	// Token: 0x06000231 RID: 561 RVA: 0x00009D60 File Offset: 0x00007F60
	internal static void smethod_0(object object_0, ImageLayout imageLayout_0)
	{
		uint num = 434721863U;
		do
		{
			object[] object_ = GClass16.object_0;
			int num2 = (int)(num + 3860245515U);
			num -= 348521645U;
			object_[num2](object_0, imageLayout_0);
		}
		while (num >= 828210405U);
	}
}

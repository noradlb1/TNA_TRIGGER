using System;
using System.Drawing;
using System.Drawing.Imaging;

// Token: 0x020000BE RID: 190
internal sealed class Delegate158 : MulticastDelegate
{
	// Token: 0x06000313 RID: 787
	internal extern Delegate158(object object_0, IntPtr intptr_0);

	// Token: 0x06000314 RID: 788
	internal extern BitmapData Invoke(object object_0, Rectangle rectangle_0, ImageLockMode imageLockMode_0, PixelFormat pixelFormat_0);

	// Token: 0x06000315 RID: 789 RVA: 0x0000A91C File Offset: 0x00008B1C
	internal static BitmapData smethod_0(object object_0, Rectangle rectangle_0, ImageLockMode imageLockMode_0, PixelFormat pixelFormat_0)
	{
		return GClass16.object_0[158](object_0, rectangle_0, imageLockMode_0, pixelFormat_0);
	}
}

using System;
using System.Globalization;
using System.IO;

// Token: 0x0200017B RID: 379
internal sealed class Delegate347 : MulticastDelegate
{
	// Token: 0x0600054A RID: 1354
	internal extern Delegate347(object object_0, IntPtr intptr_0);

	// Token: 0x0600054B RID: 1355
	internal extern UnmanagedMemoryStream Invoke(object object_0, string string_0, CultureInfo cultureInfo_0);

	// Token: 0x0600054C RID: 1356 RVA: 0x0000C6CC File Offset: 0x0000A8CC
	internal static UnmanagedMemoryStream smethod_0(object object_0, string string_0, CultureInfo cultureInfo_0)
	{
		return GClass16.object_0[347](object_0, string_0, cultureInfo_0);
	}
}

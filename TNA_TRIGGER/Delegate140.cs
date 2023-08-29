using System;
using System.Collections.Specialized;

// Token: 0x020000AC RID: 172
internal sealed class Delegate140 : MulticastDelegate
{
	// Token: 0x060002DD RID: 733
	internal extern Delegate140(object object_0, IntPtr intptr_0);

	// Token: 0x060002DE RID: 734
	internal extern byte[] Invoke(object object_0, string string_0, NameValueCollection nameValueCollection_0);

	// Token: 0x060002DF RID: 735 RVA: 0x0000A61C File Offset: 0x0000881C
	internal static byte[] smethod_0(object object_0, string string_0, NameValueCollection nameValueCollection_0)
	{
		return GClass16.object_0[140](object_0, string_0, nameValueCollection_0);
	}
}

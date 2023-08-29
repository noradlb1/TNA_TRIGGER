using System;
using System.Windows.Forms;

// Token: 0x02000176 RID: 374
internal sealed class Delegate342 : MulticastDelegate
{
	// Token: 0x0600053B RID: 1339
	internal extern Delegate342(object object_0, IntPtr intptr_0);

	// Token: 0x0600053C RID: 1340
	internal extern DialogResult Invoke(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	// Token: 0x0600053D RID: 1341 RVA: 0x0000C5F4 File Offset: 0x0000A7F4
	internal static DialogResult smethod_0(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		return GClass16.object_0[342](string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}
}

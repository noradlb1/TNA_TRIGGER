using System;
using System.Runtime.CompilerServices;

// Token: 0x02000126 RID: 294
internal sealed class Delegate262 : MulticastDelegate
{
	// Token: 0x0600044B RID: 1099
	internal extern Delegate262(object object_0, IntPtr intptr_0);

	// Token: 0x0600044C RID: 1100
	internal unsafe extern void Invoke(AsyncVoidMethodBuilder* pAsyncVoidMethodBuilder_0, Exception exception_0);

	// Token: 0x0600044D RID: 1101 RVA: 0x0000B9A8 File Offset: 0x00009BA8
	internal unsafe static void smethod_0(AsyncVoidMethodBuilder* pAsyncVoidMethodBuilder_0, Exception exception_0)
	{
		GClass16.object_0[262](pAsyncVoidMethodBuilder_0, exception_0);
	}
}

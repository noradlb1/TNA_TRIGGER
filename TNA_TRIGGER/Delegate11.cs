using System;
using System.Threading.Tasks;

// Token: 0x0200002B RID: 43
internal sealed class Delegate11 : MulticastDelegate
{
	// Token: 0x0600015A RID: 346
	internal extern Delegate11(object object_0, IntPtr intptr_0);

	// Token: 0x0600015B RID: 347
	internal extern Task Invoke(int int_0);

	// Token: 0x0600015C RID: 348 RVA: 0x00009304 File Offset: 0x00007504
	internal static Task smethod_0(int int_0)
	{
		return GClass16.object_0[11](int_0);
	}
}

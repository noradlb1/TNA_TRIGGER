using System;
using System.Runtime.CompilerServices;

// Token: 0x0200012D RID: 301
internal sealed class Delegate269 : MulticastDelegate
{
	// Token: 0x06000460 RID: 1120
	internal extern Delegate269(object object_0, IntPtr intptr_0);

	// Token: 0x06000461 RID: 1121
	internal unsafe extern void Invoke(TaskAwaiter* pTaskAwaiter_0);

	// Token: 0x06000462 RID: 1122 RVA: 0x0000BAAC File Offset: 0x00009CAC
	internal unsafe static void smethod_0(TaskAwaiter* pTaskAwaiter_0)
	{
		uint num = 1175877010U;
		do
		{
			Delegate269 @delegate = GClass16.object_0[(int)(num + 3119090555U)];
			num = 1020732053U * num;
			@delegate(pTaskAwaiter_0);
		}
		while (1986413276U > num);
	}
}

using System;
using System.Reflection;

// Token: 0x02000197 RID: 407
public class GClass4
{
	// Token: 0x060005EB RID: 1515 RVA: 0x0000FC78 File Offset: 0x0000DE78
	public GClass4(long long_0)
	{
		object[] array = new object[]
		{
			this,
			long_0
		};
		new GClass18().method_112(array, 40256);
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x0000FCB0 File Offset: 0x0000DEB0
	private void method_0(ref byte[] byte_0, uint uint_0)
	{
		for (int i = 0; i < byte_0.Length; i++)
		{
			byte_0[i] = (byte)((ulong)byte_0[i] ^ (ulong)GClass9.smethod_0(uint_0, i) + (ulong)((long)i));
		}
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x0000FCE4 File Offset: 0x0000DEE4
	private Assembly method_1(object object_1, ResolveEventArgs resolveEventArgs_0)
	{
		object[] array = new object[]
		{
			this,
			object_1,
			resolveEventArgs_0
		};
		return (Assembly)new GClass18().method_112(array, 49343);
	}

	// Token: 0x0400013B RID: 315
	private object object_0;
}

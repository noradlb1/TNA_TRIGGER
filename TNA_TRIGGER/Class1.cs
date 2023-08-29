using System;

// Token: 0x02000189 RID: 393
internal abstract class Class1
{
	// Token: 0x060005A5 RID: 1445 RVA: 0x00002F60 File Offset: 0x00001160
	public static uint smethod_0(uint uint_9)
	{
		uint_9 -= 2U;
		if (uint_9 < 4U)
		{
			return uint_9;
		}
		return 3U;
	}

	// Token: 0x040000DA RID: 218
	public const uint uint_0 = 12U;

	// Token: 0x040000DB RID: 219
	public const int int_0 = 6;

	// Token: 0x040000DC RID: 220
	private const int int_1 = 2;

	// Token: 0x040000DD RID: 221
	public const uint uint_1 = 4U;

	// Token: 0x040000DE RID: 222
	public const uint uint_2 = 2U;

	// Token: 0x040000DF RID: 223
	public const int int_2 = 4;

	// Token: 0x040000E0 RID: 224
	public const uint uint_3 = 4U;

	// Token: 0x040000E1 RID: 225
	public const uint uint_4 = 14U;

	// Token: 0x040000E2 RID: 226
	public const uint uint_5 = 128U;

	// Token: 0x040000E3 RID: 227
	public const int int_3 = 4;

	// Token: 0x040000E4 RID: 228
	public const uint uint_6 = 16U;

	// Token: 0x040000E5 RID: 229
	public const int int_4 = 3;

	// Token: 0x040000E6 RID: 230
	public const int int_5 = 3;

	// Token: 0x040000E7 RID: 231
	public const int int_6 = 8;

	// Token: 0x040000E8 RID: 232
	public const uint uint_7 = 8U;

	// Token: 0x040000E9 RID: 233
	public const uint uint_8 = 8U;

	// Token: 0x0200018A RID: 394
	public struct Struct2
	{
		// Token: 0x060005A7 RID: 1447 RVA: 0x00002F6E File Offset: 0x0000116E
		public void method_0()
		{
			this.uint_0 = 0U;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00002F77 File Offset: 0x00001177
		public void method_1()
		{
			if (this.uint_0 < 4U)
			{
				this.uint_0 = 0U;
				return;
			}
			if (this.uint_0 < 10U)
			{
				this.uint_0 -= 3U;
				return;
			}
			this.uint_0 -= 6U;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00002FB1 File Offset: 0x000011B1
		public void method_2()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 7U : 10U);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00002FC7 File Offset: 0x000011C7
		public void method_3()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 8U : 11U);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00002FDD File Offset: 0x000011DD
		public void method_4()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 9U : 11U);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00002FF4 File Offset: 0x000011F4
		public bool method_5()
		{
			return this.uint_0 < 7U;
		}

		// Token: 0x040000EA RID: 234
		public uint uint_0;
	}
}

using System;
using System.IO;

// Token: 0x0200018B RID: 395
public class GClass0
{
	// Token: 0x060005AD RID: 1453 RVA: 0x0000DAC4 File Offset: 0x0000BCC4
	public GClass0()
	{
		this.uint_1 = uint.MaxValue;
		int num = 0;
		while ((long)num < 4L)
		{
			this.struct5_0[num] = new Struct5(6);
			num++;
		}
	}

	// Token: 0x060005AE RID: 1454 RVA: 0x0000DBBC File Offset: 0x0000BDBC
	private void method_0(uint uint_4)
	{
		if (this.uint_1 != uint_4)
		{
			this.uint_1 = uint_4;
			this.uint_2 = Math.Max(this.uint_1, 1U);
			uint uint_5 = Math.Max(this.uint_2, 4096U);
			this.gclass1_0.method_0(uint_5);
		}
	}

	// Token: 0x060005AF RID: 1455 RVA: 0x00002FFF File Offset: 0x000011FF
	private void method_1(int int_0, int int_1)
	{
		if (int_0 > 8)
		{
			throw new ArgumentException("lp > 8");
		}
		if (int_1 > 8)
		{
			throw new ArgumentException("lc > 8");
		}
		this.class3_0.method_0(int_0, int_1);
	}

	// Token: 0x060005B0 RID: 1456 RVA: 0x0000DC08 File Offset: 0x0000BE08
	private void method_2(int int_0)
	{
		if (int_0 > 4)
		{
			throw new ArgumentException("pb > Base.KNumPosStatesBitsMax");
		}
		uint num = 1U << int_0;
		this.class2_0.method_0(num);
		this.class2_1.method_0(num);
		this.uint_3 = num - 1U;
	}

	// Token: 0x060005B1 RID: 1457 RVA: 0x0000DC4C File Offset: 0x0000BE4C
	private void method_3(Stream stream_0, Stream stream_1)
	{
		this.class4_0.method_0(stream_0);
		this.gclass1_0.method_1(stream_1, false);
		for (uint num = 0U; num < 12U; num += 1U)
		{
			for (uint num2 = 0U; num2 <= this.uint_3; num2 += 1U)
			{
				uint num3 = (num << 4) + num2;
				this.struct4_0[(int)num3].method_0();
				this.struct4_5[(int)num3].method_0();
			}
			this.struct4_1[(int)num].method_0();
			this.struct4_2[(int)num].method_0();
			this.struct4_3[(int)num].method_0();
			this.struct4_4[(int)num].method_0();
		}
		this.class3_0.method_1();
		for (uint num = 0U; num < 4U; num += 1U)
		{
			this.struct5_0[(int)num].method_0();
		}
		for (uint num = 0U; num < 114U; num += 1U)
		{
			this.struct4_6[(int)num].method_0();
		}
		this.class2_0.method_1();
		this.class2_1.method_1();
		this.struct5_1.method_0();
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x0000DD6C File Offset: 0x0000BF6C
	public void method_4(Stream stream_0, Stream stream_1, long long_0)
	{
		this.method_3(stream_0, stream_1);
		Class1.Struct2 @struct = default(Class1.Struct2);
		@struct.method_0();
		uint num = 0U;
		uint num2 = 0U;
		uint num3 = 0U;
		uint num4 = 0U;
		ulong num5 = 0UL;
		if (0L < long_0)
		{
			if (this.struct4_0[(int)((int)@struct.uint_0 << 4)].method_1(this.class4_0) != 0U)
			{
				throw new InvalidDataException("IsMatchDecoders");
			}
			@struct.method_1();
			byte byte_ = this.class3_0.method_3(this.class4_0, 0U, 0);
			this.gclass1_0.method_5(byte_);
			num5 += 1UL;
		}
		while (num5 < (ulong)long_0)
		{
			uint num6 = (uint)num5 & this.uint_3;
			if (this.struct4_0[(int)((@struct.uint_0 << 4) + num6)].method_1(this.class4_0) == 0U)
			{
				byte byte_2 = this.gclass1_0.method_6(0U);
				byte byte_3;
				if (!@struct.method_5())
				{
					byte_3 = this.class3_0.method_4(this.class4_0, (uint)num5, byte_2, this.gclass1_0.method_6(num));
				}
				else
				{
					byte_3 = this.class3_0.method_3(this.class4_0, (uint)num5, byte_2);
				}
				this.gclass1_0.method_5(byte_3);
				@struct.method_1();
				num5 += 1UL;
			}
			else
			{
				uint num8;
				if (this.struct4_1[(int)@struct.uint_0].method_1(this.class4_0) == 1U)
				{
					if (this.struct4_2[(int)@struct.uint_0].method_1(this.class4_0) == 0U)
					{
						if (this.struct4_5[(int)((@struct.uint_0 << 4) + num6)].method_1(this.class4_0) == 0U)
						{
							@struct.method_4();
							this.gclass1_0.method_5(this.gclass1_0.method_6(num));
							num5 += 1UL;
							continue;
						}
					}
					else
					{
						uint num7;
						if (this.struct4_3[(int)@struct.uint_0].method_1(this.class4_0) == 0U)
						{
							num7 = num2;
						}
						else
						{
							if (this.struct4_4[(int)@struct.uint_0].method_1(this.class4_0) == 0U)
							{
								num7 = num3;
							}
							else
							{
								num7 = num4;
								num4 = num3;
							}
							num3 = num2;
						}
						num2 = num;
						num = num7;
					}
					num8 = this.class2_1.method_2(this.class4_0, num6) + 2U;
					@struct.method_3();
				}
				else
				{
					num4 = num3;
					num3 = num2;
					num2 = num;
					num8 = 2U + this.class2_0.method_2(this.class4_0, num6);
					@struct.method_2();
					uint num9 = this.struct5_0[(int)Class1.smethod_0(num8)].method_1(this.class4_0);
					if (num9 >= 4U)
					{
						int num10 = (int)((num9 >> 1) - 1U);
						num = (2U | (num9 & 1U)) << num10;
						if (num9 < 14U)
						{
							num += Struct5.smethod_0(this.struct4_6, num - num9 - 1U, this.class4_0, num10);
						}
						else
						{
							num += this.class4_0.method_2(num10 - 4) << 4;
							num += this.struct5_1.method_2(this.class4_0);
						}
					}
					else
					{
						num = num9;
					}
				}
				if ((ulong)num < (ulong)this.gclass1_0.uint_4 + num5 && num < this.uint_2)
				{
					this.gclass1_0.method_4(num, num8);
					num5 += (ulong)num8;
				}
				else
				{
					if (num != 4294967295U)
					{
						throw new InvalidDataException("rep0");
					}
					IL_359:
					this.gclass1_0.method_3();
					this.gclass1_0.method_2();
					this.class4_0.method_1();
					return;
				}
			}
		}
		goto IL_359;
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x0000E0F4 File Offset: 0x0000C2F4
	public void method_5(byte[] byte_0)
	{
		if (byte_0.Length < 5)
		{
			throw new ArgumentException("properties.Length < 5");
		}
		int int_ = (int)(byte_0[0] % 9);
		byte b = byte_0[0] / 9;
		int int_2 = (int)(b % 5);
		int num = (int)(b / 5);
		if (num > 4)
		{
			throw new ArgumentException("pb > Base.kNumPosStatesBitsMax");
		}
		uint num2 = 0U;
		for (int i = 0; i < 4; i++)
		{
			num2 += (uint)((uint)byte_0[1 + i] << i * 8);
		}
		this.method_0(num2);
		this.method_1(int_2, int_);
		this.method_2(num);
	}

	// Token: 0x040000EB RID: 235
	private uint uint_0 = 1U;

	// Token: 0x040000EC RID: 236
	private readonly GClass1 gclass1_0 = new GClass1();

	// Token: 0x040000ED RID: 237
	private readonly Class4 class4_0 = new Class4();

	// Token: 0x040000EE RID: 238
	private readonly Struct4[] struct4_0 = new Struct4[192];

	// Token: 0x040000EF RID: 239
	private readonly Struct4[] struct4_1 = new Struct4[12];

	// Token: 0x040000F0 RID: 240
	private readonly Struct4[] struct4_2 = new Struct4[12];

	// Token: 0x040000F1 RID: 241
	private readonly Struct4[] struct4_3 = new Struct4[12];

	// Token: 0x040000F2 RID: 242
	private readonly Struct4[] struct4_4 = new Struct4[12];

	// Token: 0x040000F3 RID: 243
	private readonly Struct4[] struct4_5 = new Struct4[192];

	// Token: 0x040000F4 RID: 244
	private readonly Struct5[] struct5_0 = new Struct5[4];

	// Token: 0x040000F5 RID: 245
	private readonly Struct4[] struct4_6 = new Struct4[114];

	// Token: 0x040000F6 RID: 246
	private Struct5 struct5_1 = new Struct5(4);

	// Token: 0x040000F7 RID: 247
	private readonly GClass0.Class2 class2_0 = new GClass0.Class2();

	// Token: 0x040000F8 RID: 248
	private readonly GClass0.Class2 class2_1 = new GClass0.Class2();

	// Token: 0x040000F9 RID: 249
	private readonly GClass0.Class3 class3_0 = new GClass0.Class3();

	// Token: 0x040000FA RID: 250
	private uint uint_1;

	// Token: 0x040000FB RID: 251
	private uint uint_2;

	// Token: 0x040000FC RID: 252
	private uint uint_3;

	// Token: 0x0200018C RID: 396
	private class Class2
	{
		// Token: 0x060005B4 RID: 1460 RVA: 0x0000E170 File Offset: 0x0000C370
		public void method_0(uint uint_1)
		{
			for (uint num = this.uint_0; num < uint_1; num += 1U)
			{
				this.struct5_0[(int)num] = new Struct5(3);
				this.struct5_1[(int)num] = new Struct5(3);
			}
			this.uint_0 = uint_1;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0000E1BC File Offset: 0x0000C3BC
		public void method_1()
		{
			this.struct4_0.method_0();
			for (uint num = 0U; num < this.uint_0; num += 1U)
			{
				this.struct5_0[(int)num].method_0();
				this.struct5_1[(int)num].method_0();
			}
			this.struct4_1.method_0();
			this.struct5_2.method_0();
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0000E220 File Offset: 0x0000C420
		public uint method_2(Class4 class4_0, uint uint_1)
		{
			if (this.struct4_0.method_1(class4_0) == 0U)
			{
				return this.struct5_0[(int)uint_1].method_1(class4_0);
			}
			uint num = 8U;
			if (this.struct4_1.method_1(class4_0) == 0U)
			{
				num += this.struct5_1[(int)uint_1].method_1(class4_0);
			}
			else
			{
				num += 8U;
				num += this.struct5_2.method_1(class4_0);
			}
			return num;
		}

		// Token: 0x040000FD RID: 253
		private Struct4 struct4_0;

		// Token: 0x040000FE RID: 254
		private Struct4 struct4_1;

		// Token: 0x040000FF RID: 255
		private readonly Struct5[] struct5_0 = new Struct5[16];

		// Token: 0x04000100 RID: 256
		private readonly Struct5[] struct5_1 = new Struct5[16];

		// Token: 0x04000101 RID: 257
		private Struct5 struct5_2 = new Struct5(8);

		// Token: 0x04000102 RID: 258
		private uint uint_0;
	}

	// Token: 0x0200018D RID: 397
	private class Class3
	{
		// Token: 0x060005B8 RID: 1464 RVA: 0x0000E28C File Offset: 0x0000C48C
		public void method_0(int int_2, int int_3)
		{
			if (this.struct3_0 != null && this.int_0 == int_3 && this.int_1 == int_2)
			{
				return;
			}
			this.int_1 = int_2;
			this.uint_1 = (1U << int_2) - 1U;
			this.int_0 = int_3;
			uint num = 1U << this.int_0 + this.int_1;
			this.struct3_0 = new GClass0.Class3.Struct3[num];
			for (uint num2 = 0U; num2 < num; num2 += 1U)
			{
				this.struct3_0[(int)num2].method_0();
			}
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0000E30C File Offset: 0x0000C50C
		public void method_1()
		{
			uint num = 1U << this.int_0 + this.int_1;
			for (uint num2 = 0U; num2 < num; num2 += 1U)
			{
				this.struct3_0[(int)num2].method_1();
			}
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0000305A File Offset: 0x0000125A
		private uint method_2(uint uint_2, byte byte_0)
		{
			return ((uint_2 & this.uint_1) << this.int_0) + (uint)(byte_0 >> 8 - this.int_0);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0000307C File Offset: 0x0000127C
		public byte method_3(Class4 class4_0, uint uint_2, byte byte_0)
		{
			return this.struct3_0[(int)this.method_2(uint_2, byte_0)].method_2(class4_0);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00003097 File Offset: 0x00001297
		public byte method_4(Class4 class4_0, uint uint_2, byte byte_0, byte byte_1)
		{
			return this.struct3_0[(int)this.method_2(uint_2, byte_0)].method_3(class4_0, byte_1);
		}

		// Token: 0x04000103 RID: 259
		private uint uint_0 = 1U;

		// Token: 0x04000104 RID: 260
		private GClass0.Class3.Struct3[] struct3_0;

		// Token: 0x04000105 RID: 261
		private int int_0;

		// Token: 0x04000106 RID: 262
		private int int_1;

		// Token: 0x04000107 RID: 263
		private uint uint_1;

		// Token: 0x0200018E RID: 398
		private struct Struct3
		{
			// Token: 0x060005BE RID: 1470 RVA: 0x000030C3 File Offset: 0x000012C3
			public void method_0()
			{
				this.struct4_0 = new Struct4[768];
			}

			// Token: 0x060005BF RID: 1471 RVA: 0x0000E34C File Offset: 0x0000C54C
			public void method_1()
			{
				for (int i = 0; i < 768; i++)
				{
					this.struct4_0[i].method_0();
				}
			}

			// Token: 0x060005C0 RID: 1472 RVA: 0x0000E37C File Offset: 0x0000C57C
			public byte method_2(Class4 class4_0)
			{
				uint num = 1U;
				do
				{
					num = (num << 1 | this.struct4_0[(int)num].method_1(class4_0));
				}
				while (num < 256U);
				return (byte)num;
			}

			// Token: 0x060005C1 RID: 1473 RVA: 0x0000E3AC File Offset: 0x0000C5AC
			public byte method_3(Class4 class4_0, byte byte_0)
			{
				uint num = 1U;
				for (;;)
				{
					uint num2 = (uint)(byte_0 >> 7 & 1);
					byte_0 = (byte)(byte_0 << 1);
					uint num3 = this.struct4_0[(int)((1U + num2 << 8) + num)].method_1(class4_0);
					num = (num << 1 | num3);
					if (num2 != num3)
					{
						break;
					}
					if (num >= 256U)
					{
						goto IL_5C;
					}
				}
				while (num < 256U)
				{
					num = (num << 1 | this.struct4_0[(int)num].method_1(class4_0));
				}
				IL_5C:
				return (byte)num;
			}

			// Token: 0x04000108 RID: 264
			private Struct4[] struct4_0;
		}
	}
}

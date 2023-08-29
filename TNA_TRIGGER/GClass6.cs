using System;
using System.Runtime.InteropServices;

// Token: 0x0200019A RID: 410
public class GClass6
{
	// Token: 0x060005F4 RID: 1524 RVA: 0x0000FE00 File Offset: 0x0000E000
	public GClass6(byte[] byte_0)
	{
		uint num3;
		uint[] array;
		uint num4;
		for (;;)
		{
			uint num = 4U;
			int num2 = 2;
			num3 = 725380826U;
			array = new uint[num2];
			for (;;)
			{
				num3 /= 1294475423U;
				this.uint_0 = new uint[num3 ^ 32U];
				num4 = (num3 ^ 7U);
				num3 = 317538744U * num3;
				if (433079472U < num3)
				{
					break;
				}
				uint[] array2 = array;
				int num5 = (int)(num3 ^ 1U);
				num3 >>= 5;
				uint num6 = num3 - 0U;
				num3 -= 789056941U;
				array2[num5] = num6;
				for (;;)
				{
					num3 = 1524711960U << (int)num3;
					if (num4 == (num3 ^ 4013948927U))
					{
						this.uint_0[(int)(num3 ^ 281018368U)] = num3 + 4270855122U;
						num3 = 1456358097U >> (int)num3;
						num4 = num3 - 1456358096U;
						if (1788627289U + num3 == 0U)
						{
							break;
						}
						while (670589993U % num3 != 0U)
						{
							uint num7 = num4;
							uint num8 = num3 ^ 1456358129U;
							num3 += 252863164U;
							if (num7 >= num8)
							{
								goto IL_19F;
							}
							this.uint_0[(int)num4] = this.uint_0[(int)(num4 - 1U)] + 1379028491U;
							num4 += 1U;
							num3 = 1456358097U;
						}
					}
					else
					{
						array[(int)(num4 / num)] = (array[(int)(num4 / num)] << 8) + (uint)byte_0[(int)num4];
						num4 -= 1U;
						num3 = 3505910355U;
					}
				}
			}
		}
		IL_19F:
		num3 <<= 28;
		uint num9 = num3 + 805306368U;
		num3 = (173739788U & num3);
		uint num10 = num9;
		uint num11 = num9;
		num4 = num9;
		uint num12 = num9;
		num3 = 1070594038U;
		uint num13 = num9;
		for (;;)
		{
			num3 = 1807358168U >> (int)num3;
			uint num14 = num10;
			num3 |= 1304829357U;
			if (num14 >= (num3 ^ 1304829391U))
			{
				break;
			}
			num13 = (this.uint_0[(int)num4] = GClass9.smethod_0(this.uint_0[(int)num4] + num13 + num12, 3));
			num12 = (array[(int)num11] = GClass9.smethod_0(array[(int)num11] + num13 + num12, (int)(num13 + num12)));
			num10 += 1U;
			num4 = (num4 + 1U) % 32U;
			num11 = (num11 + 1U) % 2U;
			num3 = 1070594038U;
		}
	}

	// Token: 0x060005F5 RID: 1525 RVA: 0x000100F8 File Offset: 0x0000E2F8
	private void method_0(ref GClass6.Struct6 struct6_0)
	{
		uint num = struct6_0.uint_0 + this.uint_0[0];
		uint num2 = struct6_0.uint_1 + this.uint_0[1];
		uint num3 = 22671723U;
		uint num4 = 1U;
		for (;;)
		{
			uint num5 = num4;
			uint num6 = num3 ^ 22671716U;
			num3 |= 718225469U;
			if (num5 > num6)
			{
				break;
			}
			num = GClass9.smethod_0(num ^ num2, (int)num2) + this.uint_0[(int)(2U * num4)];
			num2 = GClass9.smethod_0(num2 ^ num, (int)num) + this.uint_0[(int)(2U * num4 + 1U)];
			num4 += 1U;
			num3 = 22671723U;
		}
		num3 = 902052802U << (int)num3;
		uint num7 = num;
		num3 = 217658418U * num3;
		struct6_0.uint_0 = num7;
		uint num8 = num2;
		num3 = 435553852U * num3;
		struct6_0.uint_1 = num8;
	}

	// Token: 0x060005F6 RID: 1526 RVA: 0x00010240 File Offset: 0x0000E440
	private void method_1(ref GClass6.Struct6 struct6_0)
	{
		uint num4;
		do
		{
			uint num = struct6_0.uint_1;
			uint num2 = struct6_0.uint_0;
			uint num3 = 15U;
			num4 = 1318459456U;
			uint num5 = num3;
			for (;;)
			{
				num4 = 912666458U << (int)num4;
				if (num5 <= num4 + 3382300838U)
				{
					break;
				}
				num = (GClass9.smethod_1(num - this.uint_0[(int)(2U * num5 + 1U)], (int)num2) ^ num2);
				num2 = (GClass9.smethod_1(num2 - this.uint_0[(int)(2U * num5)], (int)num) ^ num);
				num5 -= 1U;
				num4 = 1318459456U;
			}
			num4 = 539494879U << (int)num4;
			uint num6 = num;
			num4 = 333013426U * num4;
			uint[] array = this.uint_0;
			num4 = (2081031929U & num4);
			struct6_0.uint_1 = num6 - array[(int)(num4 + 3355443201U)];
			num4 = 1282540396U / num4;
			num4 /= 1584749574U;
			uint num7 = num2;
			num4 *= 220665993U;
			uint[] array2 = this.uint_0;
			num4 = (1035239305U & num4);
			int num8 = (int)(num4 + 0U);
			num4 = 1209093643U << (int)num4;
			uint num9 = num7 - array2[num8];
			num4 = 2036024970U + num4;
			struct6_0.uint_0 = num9;
		}
		while (num4 == 2142834243U);
	}

	// Token: 0x060005F7 RID: 1527 RVA: 0x000103B0 File Offset: 0x0000E5B0
	public byte[] method_2(byte[] byte_0)
	{
		byte[] array = new byte[byte_0.Length];
		uint num = 2026641623U;
		byte[] array2 = array;
		do
		{
			num = (1609058924U & num);
			num = (289623445U & num);
			byte[] byte_ = array2;
			num *= 926578784U;
			this.method_4(byte_0, byte_);
			num /= 1622170273U;
		}
		while (707407963U * num == 0U);
		return array2;
	}

	// Token: 0x060005F8 RID: 1528 RVA: 0x00010408 File Offset: 0x0000E608
	public byte[] method_3(byte[] byte_0)
	{
		byte[] array = new byte[byte_0.Length];
		uint num = 2440385765U;
		do
		{
			num = 181947163U >> (int)num;
			num = 2044613962U - num;
			byte[] byte_ = array;
			num *= 1491091147U;
			this.method_5(byte_0, byte_);
		}
		while (num - 1348547531U == 0U);
		return array;
	}

	// Token: 0x060005F9 RID: 1529 RVA: 0x00010460 File Offset: 0x0000E660
	public void method_4(byte[] byte_0, byte[] byte_1)
	{
		for (;;)
		{
			GClass6.Struct6 @struct = default(GClass6.Struct6);
			uint num = 1963925838U;
			int num2 = 0;
			for (;;)
			{
				num = 1979150067U % num;
				if (num * 685244848U == 0U)
				{
					break;
				}
				int num3 = num2;
				num = (1396794539U & num);
				int num4 = byte_0.Length;
				num = 2105745353U - num;
				if (num3 >= num4)
				{
					return;
				}
				@struct.ulong_0 = BitConverter.ToUInt64(byte_0, num2);
				this.method_0(ref @struct);
				BitConverter.GetBytes(@struct.ulong_0).CopyTo(byte_1, num2);
				num2 += 8;
				num = 1963925838U;
			}
		}
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x00010504 File Offset: 0x0000E704
	public void method_5(byte[] byte_0, byte[] byte_1)
	{
		GClass6.Struct6 @struct = default(GClass6.Struct6);
		uint num4;
		do
		{
			int num = 0;
			for (;;)
			{
				int num2 = num;
				int num3 = byte_0.Length;
				num4 = 3165239U;
				if (num2 >= num3)
				{
					break;
				}
				@struct.ulong_0 = BitConverter.ToUInt64(byte_0, num);
				this.method_1(ref @struct);
				BitConverter.GetBytes(@struct.ulong_0).CopyTo(byte_1, num);
				num += 8;
			}
		}
		while (1806456713U <= num4);
	}

	// Token: 0x0400013E RID: 318
	private const int int_0 = 15;

	// Token: 0x0400013F RID: 319
	private const int int_1 = 8;

	// Token: 0x04000140 RID: 320
	private const int int_2 = 2;

	// Token: 0x04000141 RID: 321
	private const int int_3 = 32;

	// Token: 0x04000142 RID: 322
	private readonly uint[] uint_0;

	// Token: 0x04000143 RID: 323
	private const uint uint_1 = 4207804417U;

	// Token: 0x04000144 RID: 324
	private const uint uint_2 = 4207804418U;

	// Token: 0x0200019B RID: 411
	[StructLayout(LayoutKind.Explicit)]
	private struct Struct6
	{
		// Token: 0x04000145 RID: 325
		[FieldOffset(0)]
		public ulong ulong_0;

		// Token: 0x04000146 RID: 326
		[FieldOffset(0)]
		public uint uint_0;

		// Token: 0x04000147 RID: 327
		[FieldOffset(4)]
		public uint uint_1;
	}
}

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// Token: 0x02000196 RID: 406
public class GClass3
{
	// Token: 0x060005D6 RID: 1494 RVA: 0x00003185 File Offset: 0x00001385
	public static bool smethod_0()
	{
		return (bool)new GClass18().method_112(null, 41304);
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x0000E864 File Offset: 0x0000CA64
	public static bool smethod_1(bool bool_0)
	{
		object[] object_ = new object[]
		{
			bool_0
		};
		return (bool)new GClass18().method_112(object_, 47169);
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x0000E89C File Offset: 0x0000CA9C
	internal static bool smethod_2(byte[] byte_0)
	{
		uint num;
		for (;;)
		{
			IL_00:
			num = 1098778251U;
			int num2 = 0;
			for (;;)
			{
				IL_CDF:
				if ((968252948U ^ num) != 0U)
				{
					int num3 = num2;
					int num4 = byte_0.Length;
					num = (1155083476U | num);
					if (num3 >= num4)
					{
						goto Block_0;
					}
					for (;;)
					{
						int num5 = num2 + 3;
						int num6 = byte_0.Length;
						num = 1939020672U;
						if (num5 < num6)
						{
							num *= 534407699U;
							int num7 = num2;
							num >>= 11;
							byte b = byte_0[num7];
							uint num8 = num ^ 854416U;
							num >>= 14;
							num ^= 1939020724U;
							if (b == num8)
							{
								num >>= 16;
								if (1955082933U <= num)
								{
									continue;
								}
								num >>= 18;
								int num9 = num2;
								num >>= 21;
								byte b2 = byte_0[num9 + 1];
								int num10 = 69;
								num = 1939020672U;
								if (b2 == num10)
								{
									num = 761547679U % num;
									if (num == 1878481961U)
									{
										goto IL_00;
									}
									int num11 = num2;
									uint num12 = num ^ 761547677U;
									num = 1222251371U << (int)num;
									int num13 = num11 + num12;
									num = 1075719226U >> (int)num;
									byte b3 = byte_0[num13];
									num = 1319260368U << (int)num;
									uint num14 = num + 3221225549U;
									num = (1111977477U & num);
									num ^= 865278848U;
									if (b3 == num14)
									{
										num >>= 17;
										if (num << 16 == 0U)
										{
											goto IL_00;
										}
										uint num15 = num2;
										num >>= 18;
										int num16 = num15 + (num + 3U);
										num *= 2141132433U;
										byte b4 = byte_0[num16];
										num = 1863524980U * num;
										uint num17 = num ^ 85U;
										num /= 312889648U;
										num += 1939020672U;
										if (b4 == num17)
										{
											goto Block_65;
										}
									}
								}
							}
						}
						int num18 = num2;
						int num19 = (int)(num ^ 1939020680U);
						num += 1666128578U;
						int num20 = num18 + num19;
						int num21 = byte_0.Length;
						num = 1765357061U << (int)num;
						if (num20 < num21)
						{
							num = 793411385U << (int)num;
							byte b5 = byte_0[num2];
							num = 2012758166U * num;
							uint num22 = num - 3059744691U;
							num = 1458700298U << (int)num;
							num ^= 4061583390U;
							if (b5 == num22)
							{
								num = (1309566528U | num);
								num = 973808657U + num;
								int num23 = num2;
								num <<= 20;
								int num24 = num + 3652190209U;
								num ^= 53875575U;
								byte b6 = byte_0[num23 + num24];
								num = 957965463U - num;
								uint num25 = num ^ 330518857U;
								num *= 1835152742U;
								num += 4251379028U;
								if (b6 == num25)
								{
									num /= 862269908U;
									if ((num ^ 1628471029U) == 0U)
									{
										goto IL_D16;
									}
									num /= 1465786873U;
									byte b7 = byte_0[num2 + (int)(num - 4294967294U)];
									uint num26 = num - 4294967197U;
									num *= 444621482U;
									num += 2766460948U;
									if (b7 == num26)
									{
										num -= 48708858U;
										int num27 = num2;
										num |= 893339379U;
										uint num28 = num ^ 3053445112U;
										num %= 1468485315U;
										int num29 = num27 + num28;
										num &= 943616872U;
										byte b8 = byte_0[num29];
										num *= 703158228U;
										uint num30 = num - 1474664206U;
										num += 1771138925U;
										num ^= 1704189689U;
										if (b8 == num30)
										{
											num -= 445476398U;
											if (num - 318980672U == 0U)
											{
												goto IL_00;
											}
											byte b9 = byte_0[num2 + (int)(num - 2320984546U)];
											uint num31 = num - 2320984439U;
											num = 1824928334U * num;
											num ^= 2379343872U;
											if (b9 == num31)
											{
												num = 1051023902U % num;
												int num32 = num2;
												num <<= 7;
												uint num33 = num - 1387073275U;
												num |= 155676691U;
												int num34 = num32 + num33;
												num *= 1301494833U;
												byte b10 = byte_0[num34];
												uint num35 = num - 1770571312U;
												num &= 1799097894U;
												num += 1004327410U;
												if (b10 == num35)
												{
													if (num == 2047819880U)
													{
														goto IL_00;
													}
													num |= 700807373U;
													int num36 = num2 + (int)(num + 1377437481U);
													num -= 2072321480U;
													byte b11 = byte_0[num36];
													uint num37 = num - 845208230U;
													num >>= 6;
													num += 2753254568U;
													if (b11 == num37)
													{
														num = (1912230009U | num);
														int num38 = num2;
														num = 33323062U % num;
														byte b12 = byte_0[num38 + (int)(num + 4261644241U)];
														uint num39 = num ^ 33323088U;
														num = 1141458128U << (int)num;
														num ^= 2430916628U;
														if (b12 == num39)
														{
															num = 187312208U * num;
															int num40 = num2;
															int num41 = num ^ 2559485512U;
															num &= 1680160035U;
															byte b13 = byte_0[num40 + num41];
															uint num42 = num ^ 271476U;
															num -= 1713316569U;
															num ^= 1023531315U;
															if (b13 == num42)
															{
																goto Block_13;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
						int num43 = num2;
						uint num44 = num ^ 2766460946U;
						num /= 834294154U;
						object obj = num43 + (int)num44;
						int num45 = byte_0.Length;
						num /= 446773260U;
						if (obj < num45)
						{
							num = 549476320U * num;
							num /= 1414346700U;
							int num46 = num2;
							num += 969428179U;
							byte b14 = byte_0[num46];
							uint num47 = num ^ 969428154U;
							num ^= 969428179U;
							if (b14 == num47)
							{
								int num48 = num2;
								num |= 931865326U;
								uint num49 = num + 3363101971U;
								num = 2117490332U % num;
								int num50 = num48 + num49;
								num ^= 1157326225U;
								byte b15 = byte_0[num50];
								num = 384524054U / num;
								uint num51 = num - 4294967186U;
								num += 0U;
								if (b15 == num51)
								{
									num = (1336638U & num);
									int num52 = num2;
									num *= 851014687U;
									int num53 = num ^ 2U;
									num = 1393182472U >> (int)num;
									byte b16 = byte_0[num52 + num53];
									uint num54 = num ^ 1393182566U;
									num ^= 1393182472U;
									if (b16 == num54)
									{
										num |= 1313604713U;
										num *= 1244422461U;
										int num55 = num2;
										uint num56 = num - 2446644738U;
										num = (735260690U ^ num);
										int num57 = num55 + num56;
										num = 376194428U * num;
										byte b17 = byte_0[num57];
										num -= 862090721U;
										uint num58 = num - 355020756U;
										num = (1454048736U ^ num);
										num += 3162360413U;
										if (b17 == num58)
										{
											num &= 1756108914U;
											int num59 = num2;
											num += 1131441061U;
											uint num60 = num - 1131441057U;
											num = 1846438300U - num;
											int num61 = num59 + num60;
											num = (188175047U & num);
											byte b18 = byte_0[num61];
											num = 852383738U * num;
											uint num62 = num + 177831198U;
											num ^= 4117136214U;
											if (b18 == num62)
											{
												num = 1304184794U * num;
												uint num63 = num2;
												num = (77222818U & num);
												int num64 = num63 + (num + 5U);
												num = (1568817582U ^ num);
												byte b19 = byte_0[num64];
												uint num65 = num + 2726149815U;
												num += 2726149714U;
												if (b19 == num65)
												{
													if (843863281 << (int)num == 0)
													{
														continue;
													}
													int num66 = num2;
													int num67 = num + 6U;
													num = 1808737944U + num;
													byte b20 = byte_0[num66 + num67];
													uint num68 = num - 1808737837U;
													num += 2486229352U;
													if (b20 == num68)
													{
														goto Block_22;
													}
												}
											}
										}
									}
								}
							}
						}
						uint num69 = num2;
						num = 1963225432U - num;
						uint num70 = num69 + (num + 2331741873U);
						num = 1650074883U - num;
						int num71 = byte_0.Length;
						num = 1158293048U << (int)num;
						int num72 = num71;
						num = (1114588183U ^ num);
						if (num70 < num72)
						{
							num = 676939343U * num;
							int num73 = num2;
							num %= 964504046U;
							byte b21 = byte_0[num73];
							uint num74 = num + 3811908907U;
							num += 4136870124U;
							if (b21 == num74)
							{
								num = (1163689111U ^ num);
								num <<= 21;
								int num75 = num2;
								num = 1967547828U - num;
								byte b22 = byte_0[num75 + (int)(num ^ 1699112373U)];
								uint num76 = num ^ 1699112413U;
								num += 2920816227U;
								if (b22 == num76)
								{
									num -= 1302673267U;
									int num77 = num2;
									num -= 506206118U;
									byte b23 = byte_0[num77 + (int)(num ^ 2811049212U)];
									uint num78 = num ^ 2811049100U;
									num += 1808879385U;
									if (b23 == num78)
									{
										if (48824379U == num)
										{
											goto IL_00;
										}
										num = 980353393U >> (int)num;
										int num79 = num2;
										uint num80 = num ^ 119U;
										num -= 1688942104U;
										int num81 = num79 + num80;
										num *= 1549216088U;
										byte b24 = byte_0[num81];
										num = 968194756U - num;
										uint num82 = num + 2501693776U;
										num ^= 2042473267U;
										if (b24 == num82)
										{
											num = 1254775687U / num;
											int num83 = num2;
											uint num84 = num ^ 7U;
											num = (2114521072U | num);
											int num85 = num83 + num84;
											num ^= 1185559386U;
											byte b25 = byte_0[num85];
											uint num86 = num ^ 950219996U;
											num ^= 1797588043U;
											num += 3218625333U;
											if (b25 == num86)
											{
												num /= 486881251U;
												int num87 = num2;
												int num88 = num + 5U;
												num -= 1846152321U;
												byte b26 = byte_0[num87 + num88];
												num = 1950967292U << (int)num;
												uint num89 = num + 97U;
												num |= 1730505239U;
												num ^= 1954278912U;
												if (b26 == num89)
												{
													num = 1197480138U % num;
													num = 1713517568U / num;
													int num90 = num2;
													num <<= 10;
													int num91 = num ^ 7174U;
													num = 552034289U + num;
													byte b27 = byte_0[num90 + num91];
													uint num92 = num ^ 552041373U;
													num += 4067887142U;
													if (b27 == num92)
													{
														num = (1792299455U & num);
														if (1817579822U < num)
														{
															continue;
														}
														byte b28 = byte_0[num2 + (int)(num - 39059472U)];
														uint num93 = num ^ 39059541U;
														num += 285901824U;
														if (b28 == num93)
														{
															num %= 1376518358U;
															if (num >> 14 == 0U)
															{
																goto IL_00;
															}
															int num94 = num2;
															num ^= 1728450227U;
															int num95 = num + 2343007588U;
															num *= 320039754U;
															byte b29 = byte_0[num94 + num95];
															num >>= 25;
															uint num96 = num - 4294967197U;
															num += 324961291U;
															if (b29 == num96)
															{
																if (1132541334U == num)
																{
																	goto IL_CDF;
																}
																num <<= 7;
																byte b30 = byte_0[num2 + (int)(num ^ 2940341129U)];
																num <<= 6;
																uint num97 = num - 3498237832U;
																num = (1397836547U | num);
																num += 1066047764U;
																if (b30 == num97)
																{
																	goto Block_37;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
						if (num > 770918221U)
						{
							goto IL_00;
						}
						int num98 = num2;
						uint num99 = num ^ 324961298U;
						num &= 669322198U;
						object obj2 = num98 + (int)num99;
						int num100 = byte_0.Length;
						num &= 747337746U;
						if (obj2 < num100)
						{
							num /= 1688353456U;
							num = (303902821U ^ num);
							int num101 = num2;
							num <<= 5;
							byte b31 = byte_0[num101];
							uint num102 = num + 3160011702U;
							num += 3160011634U;
							if (b31 == num102)
							{
								num &= 1687883995U;
								num -= 1802850062U;
								int num103 = num2;
								int num104 = num ^ 2492117253U;
								num &= 230191904U;
								byte b32 = byte_0[num103 + num104];
								uint num105 = num - 76034227U;
								num = 571158808U % num;
								num ^= 38918666U;
								if (b32 == num105)
								{
									num = 181293192U >> (int)num;
									num = 2010657739U / num;
									int num106 = num2;
									uint num107 = num + 4292057519U;
									num = 1167679929U * num;
									int num108 = num106 + num107;
									num = 512708027U + num;
									byte b33 = byte_0[num108];
									num = (2030910378U & num);
									uint num109 = num ^ 402993877U;
									num += 3891973488U;
									if (b33 == num109)
									{
										num = 1490755884U - num;
										int num110 = num2 + (int)(num ^ 1490755865U);
										num |= 1954503720U;
										byte b34 = byte_0[num110];
										num = (448424822U | num);
										uint num111 = num + 2164293859U;
										num += 2164293780U;
										if (b34 == num111)
										{
											num >>= 24;
											int num112 = num2 + (int)(num ^ 4U);
											num = (1626489089U ^ num);
											byte b35 = byte_0[num112];
											uint num113 = num ^ 1626489203U;
											num *= 537676684U;
											num += 3597478022U;
											if (b35 == num113)
											{
												if (1916167026U * num == 0U)
												{
													continue;
												}
												byte b36 = byte_0[num2 + (int)(num ^ 23U)];
												num += 906836898U;
												uint num114 = num ^ 906836945U;
												num += 3388130398U;
												if (b36 == num114)
												{
													goto Block_46;
												}
											}
										}
									}
								}
							}
						}
						num += 88225528U;
						if (488518550U / num == 0U)
						{
							goto IL_00;
						}
						uint num115 = num2;
						num = 1787584035U + num;
						uint num116 = num115 + (num ^ 1875809573U);
						num = (458097470U & num);
						int num117 = byte_0.Length;
						num = 1957365060U / num;
						if (num116 >= num117)
						{
							break;
						}
						num %= 1402476787U;
						byte b37 = byte_0[num2];
						uint num118 = num + 70U;
						num += 0U;
						if (b37 != num118)
						{
							break;
						}
						num = (1111501070U & num);
						if (num << 4 == 0U)
						{
							goto IL_00;
						}
						int num119 = num2;
						num <<= 20;
						uint num120 = num ^ 10485761U;
						num /= 2085701875U;
						int num121 = num119 + num120;
						num -= 385443746U;
						byte b38 = byte_0[num121];
						num >>= 28;
						uint num122 = num + 83U;
						num = (1572556005U ^ num);
						num ^= 1572556001U;
						if (b38 != num122)
						{
							break;
						}
						if (942427208U < num)
						{
							goto IL_00;
						}
						int num123 = num2 + (int)(num + 4294967288U);
						num = 1310548869U >> (int)num;
						byte b39 = byte_0[num123];
						num = (1037069860U | num);
						uint num124 = num + 3257667830U;
						num = 458061002U % num;
						num ^= 458060992U;
						if (b39 != num124)
						{
							break;
						}
						if (135219487U <= num)
						{
							goto IL_00;
						}
						int num125 = num2 + (int)(num + 4294967289U);
						num += 1665219743U;
						byte b40 = byte_0[num125];
						uint num126 = num + 2629747640U;
						num -= 803696035U;
						num += 3433443588U;
						if (b40 != num126)
						{
							break;
						}
						num = 976488663U / num;
						if ((num ^ 1925078644U) == 0U)
						{
							goto IL_00;
						}
						num += 870398486U;
						int num127 = num2;
						num = 2066839563U / num;
						byte b41 = byte_0[num127 + (int)(num ^ 6U)];
						num = 1018890882U << (int)num;
						uint num128 = num ^ 4075563620U;
						num -= 1135351103U;
						num += 1354754881U;
						if (b41 != num128)
						{
							break;
						}
						num = (1441342347U ^ num);
						if (638671785U < num)
						{
							goto Block_58;
						}
					}
					IL_CBA:
					if (2011704870U != num)
					{
						int num129 = num2;
						num = 1975988123U % num;
						num2 = num129 + (int)(num ^ 2U);
						num ^= 1098778248U;
						continue;
					}
					break;
					Block_58:
					num = 2049520019U >> (int)num;
					int num130 = num2;
					num %= 1197221204U;
					int num131 = num ^ 1024760012U;
					num = 984941381U >> (int)num;
					byte b42 = byte_0[num130 + num131];
					num -= 1915442940U;
					uint num132 = num - 2381447961U;
					num ^= 2381448079U;
					if (b42 != num132)
					{
						goto IL_CBA;
					}
					num = 469111878U % num;
					int num133 = num2;
					num = (1263607598U & num);
					uint num134 = num ^ 14U;
					num = 1995403156U % num;
					int num135 = num133 + num134;
					num = 1549818692U >> (int)num;
					byte b43 = byte_0[num135];
					num = 1893343517U % num;
					uint num136 = num + 4242033572U;
					num += 4242033481U;
					if (b43 != num136)
					{
						goto IL_CBA;
					}
					if (813588723U + num == 0U)
					{
						break;
					}
					num = 1743466612U << (int)num;
					uint num137 = num2;
					num -= 1600916674U;
					int num138 = num137 + (num ^ 1297466169U);
					num = (1089427898U ^ num);
					byte b44 = byte_0[num138];
					uint num139 = num ^ 230333160U;
					num ^= 230333070U;
					if (b44 != num139)
					{
						goto IL_CBA;
					}
					num &= 821826123U;
					num ^= 752097400U;
					uint num140 = num2;
					num <<= 4;
					int num141 = num140 + (num ^ 3443623720U);
					num >>= 13;
					byte b45 = byte_0[num141];
					num = (743978887U ^ num);
					uint num142 = num ^ 744381944U;
					num <<= 19;
					num ^= 3965190154U;
					if (b45 == num142)
					{
						goto Block_71;
					}
					goto IL_CBA;
				}
			}
		}
		Block_0:
		num = 1122378609U >> (int)num;
		return num + 0U != 0U;
		Block_13:
		num = (530648418U & num);
		return num - 77596671U != 0U;
		Block_22:
		return (num ^ 1U) != 0U;
		Block_37:
		num = 989991083U / num;
		return (num ^ 2U) != 0U;
		Block_46:
		return num - 17U != 0U;
		Block_65:
		goto IL_D16;
		Block_71:
		return (num ^ 11U) != 0U;
		IL_D16:
		return (num ^ 1939020673U) != 0U;
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x0000319C File Offset: 0x0000139C
	public static bool smethod_3()
	{
		return (bool)new GClass18().method_112(null, 42982);
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x0000F5F0 File Offset: 0x0000D7F0
	public static bool smethod_4()
	{
		uint num;
		bool result;
		for (;;)
		{
			IL_00:
			bool flag = GClass10.smethod_0();
			num = 749876600U;
			if (flag)
			{
				goto IL_5A8;
			}
			if (348398751U <= num)
			{
				Module module = typeof(GClass3).Module;
				num = 19879853U + num;
				IntPtr hinstance = Marshal.GetHINSTANCE(module);
				num |= 481102947U;
				long num2 = hinstance.ToInt64();
				num |= 550331225U;
				long num3 = num2;
				num += 142180174U;
				long num4 = num3;
				num = 1582633304U * num;
				long num5 = 43934591L;
				num >>= 6;
				uint num6 = (uint)Marshal.ReadInt32(new IntPtr(num4 + num5));
				num |= 748436014U;
				long num7 = 43938987L;
				num |= 706433721U;
				long num8 = num7;
				bool flag2 = num - 782236414U != 0U;
				num ^= 167518887U;
				result = flag2;
				num <<= 26;
				byte[] array = new byte[12];
				GClass7 gclass = new GClass7();
				uint num9 = (uint)Marshal.ReadInt32(new IntPtr(num3 + 43929417L));
				GClass7 gclass2 = gclass;
				IntPtr intptr_ = new IntPtr(num3 + 43938987L);
				uint uint_ = num6;
				num = 3726383949U;
				if (num9 != gclass2.method_0(intptr_, uint_))
				{
					result = (num + 568583347U != 0U);
					num += 0U;
				}
				num >>= 27;
				GClass8 gclass3 = new GClass8();
				num = (1537100733U ^ num);
				GClass8 gclass4 = gclass3;
				int num10 = (int)(num ^ 1537100710U);
				while (num >= 554910982U)
				{
					long num11 = num10;
					num = 972124403U / num;
					long num12 = num11;
					num = (1533304316U ^ num);
					ulong num13 = num6;
					num += 677083260U;
					ulong num14 = num13;
					num %= 1792887005U;
					if (num12 < num14)
					{
						Marshal.Copy(new IntPtr(num3 + num8 + (long)num10), array, 0, array.Length);
						uint num15 = gclass4.method_0(BitConverter.ToUInt32(array, 0));
						uint uint_2 = gclass4.method_0(BitConverter.ToUInt32(array, 4));
						uint num16 = gclass4.method_0(BitConverter.ToUInt32(array, 8));
						uint num17 = gclass.method_0(new IntPtr(num3 + (long)((ulong)num15)), uint_2);
						uint num18 = num16;
						num = 798563290U;
						if (num17 != num18)
						{
							num = (1039415178U | num);
							result = (num - 1073561562U != 0U);
							num ^= 274998272U;
						}
						num ^= 997339602U;
						if (num > 1661422972U)
						{
							break;
						}
						int num19 = num10;
						num = 717239391U << (int)num;
						int num20 = array.Length;
						num &= 238627385U;
						int num21 = num19 + num20;
						num = 639177036U * num;
						num10 = num21;
						num += 582046630U;
					}
					else
					{
						if (1037195948U % num == 0U)
						{
							goto IL_5A8;
						}
						long num22 = num3;
						ulong num23 = (ulong)GClass10.smethod_3();
						num %= 1770282271U;
						long num24 = (long)num23;
						num = 1740315208U + num;
						IntPtr ptr = new IntPtr(num22 + num24);
						num &= 184489280U;
						uint num25 = (uint)Marshal.ReadInt32(ptr);
						num /= 776483556U;
						num6 = num25;
						num -= 138629240U;
						ulong num26 = (ulong)GClass10.smethod_2();
						num += 1679258373U;
						num8 = (long)num26;
						num *= 1512459203U;
						long num27 = num3;
						num = 144573081U >> (int)num;
						long num28 = (ulong)GClass10.smethod_4();
						num -= 1159673104U;
						int num29 = Marshal.ReadInt32(new IntPtr(num27 + num28));
						GClass7 gclass5 = gclass;
						num |= 1720670393U;
						long num30 = num3;
						long num31 = num8;
						num >>= 23;
						long value = num30 + num31;
						num = (286200297U & num);
						IntPtr intptr_2 = new IntPtr(value);
						uint uint_3 = num6;
						num -= 2084910374U;
						uint num32 = gclass5.method_0(intptr_2, uint_3);
						num &= 1874076593U;
						if (num29 != num32)
						{
							bool flag3 = num + 4233101183U != 0U;
							num >>= 15;
							result = flag3;
							num ^= 61868001U;
						}
						if (num > 1567574786U)
						{
							break;
						}
						GClass8 gclass6 = new GClass8();
						num <<= 31;
						GClass8 gclass7 = gclass6;
						num %= 1869311942U;
						int num33 = (int)(num ^ 278171706U);
						for (;;)
						{
							num = 213212634U % num;
							if (num % 948116223U == 0U)
							{
								goto IL_00;
							}
							long num34 = (long)num33;
							num >>= 23;
							ulong num35 = (ulong)num34;
							num = (1163733905U | num);
							if (num35 >= (ulong)num6)
							{
								goto IL_59B;
							}
							Marshal.Copy(new IntPtr(num3 + num8 + (long)num33), array, 0, array.Length);
							uint num36 = gclass7.method_0(BitConverter.ToUInt32(array, 0));
							uint uint_4 = gclass7.method_0(BitConverter.ToUInt32(array, 4));
							uint num37 = gclass7.method_0(BitConverter.ToUInt32(array, 8));
							uint num38 = gclass.method_0(new IntPtr(num3 + (long)((ulong)num36)), uint_4);
							num = 29U;
							if (num38 != num37)
							{
								result = (num + 4294967267U != 0U);
								num ^= 0U;
							}
							int num39 = num33;
							num %= 1755602409U;
							num33 = num39 + array.Length;
							num ^= 278171687U;
						}
					}
				}
			}
		}
		IL_59B:
		num |= 774516423U;
		return result;
		IL_5A8:
		num >>= 16;
		return num - 11442U != 0U;
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x0000FBB8 File Offset: 0x0000DDB8
	public static bool smethod_5(ref string string_0)
	{
		object[] array = new object[]
		{
			string_0
		};
		bool result;
		try
		{
			result = (bool)new GClass18().method_112(array, 51213);
		}
		finally
		{
			string_0 = array[0];
		}
		return result;
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x060005DC RID: 1500 RVA: 0x000031B3 File Offset: 0x000013B3
	// (set) Token: 0x060005DD RID: 1501 RVA: 0x000031BB File Offset: 0x000013BB
	public GClass11 GClass11_0 { get; private set; }

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x060005DE RID: 1502 RVA: 0x000031C4 File Offset: 0x000013C4
	// (set) Token: 0x060005DF RID: 1503 RVA: 0x000031CC File Offset: 0x000013CC
	public GClass17 GClass17_0 { get; private set; }

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x060005E0 RID: 1504 RVA: 0x000031D5 File Offset: 0x000013D5
	// (set) Token: 0x060005E1 RID: 1505 RVA: 0x000031DD File Offset: 0x000013DD
	public GClass12 GClass12_0 { get; private set; }

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x060005E2 RID: 1506 RVA: 0x000031E6 File Offset: 0x000013E6
	// (set) Token: 0x060005E3 RID: 1507 RVA: 0x000031EE File Offset: 0x000013EE
	public GClass4 GClass4_0 { get; private set; }

	// Token: 0x060005E4 RID: 1508 RVA: 0x0000FC04 File Offset: 0x0000DE04
	private static string smethod_6(uint uint_0)
	{
		object[] object_ = new object[]
		{
			uint_0
		};
		return (string)new GClass18().method_112(object_, 40942);
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x000031F7 File Offset: 0x000013F7
	public static void smethod_7(string string_0)
	{
		MessageBox.Show(string_0, Assembly.GetExecutingAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Hand);
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x00003212 File Offset: 0x00001412
	private static void smethod_8()
	{
		new GClass18().method_112(null, 45424);
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x0000FC3C File Offset: 0x0000DE3C
	public bool method_0(long long_0)
	{
		object[] object_ = new object[]
		{
			this,
			long_0
		};
		return (bool)new GClass18().method_112(object_, 48627);
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x00003231 File Offset: 0x00001431
	public static string smethod_9()
	{
		return (string)new GClass18().method_112(null, 46626);
	}

	// Token: 0x04000136 RID: 310
	public static readonly GClass3 gclass3_0 = new GClass3();

	// Token: 0x04000137 RID: 311
	[CompilerGenerated]
	private GClass11 gclass11_0;

	// Token: 0x04000138 RID: 312
	[CompilerGenerated]
	private GClass17 gclass17_0;

	// Token: 0x04000139 RID: 313
	[CompilerGenerated]
	private GClass12 gclass12_0;

	// Token: 0x0400013A RID: 314
	[CompilerGenerated]
	private GClass4 gclass4_0;
}

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x020001A9 RID: 425
public class GClass18
{
	// Token: 0x06000620 RID: 1568 RVA: 0x00010B34 File Offset: 0x0000ED34
	public GClass18()
	{
		uint num = 519125518U;
		for (;;)
		{
			num -= 514750248U;
			Dictionary<uint, GClass18.Delegate359> dictionary = new Dictionary<uint, GClass18.Delegate359>();
			num = 1374229207U >> (int)num;
			this.dictionary_0 = dictionary;
			num = 1918173319U << (int)num;
			if (33844435U % num != 0U)
			{
				RuntimeTypeHandle handle = typeof(GClass18).TypeHandle;
				num <<= 28;
				Type typeFromHandle = Type.GetTypeFromHandle(handle);
				num &= 1717927359U;
				Module module = typeFromHandle.Module;
				num = 798843618U - num;
				this.module_0 = module;
				num = (1236684385U & num);
				Stack<GClass18.Class8> stack = new Stack<GClass18.Class8>();
				num = 477642996U >> (int)num;
				this.stack_0 = stack;
				num = (415988110U ^ num);
				goto IL_18A;
			}
			IL_1BE:
			num /= 810553068U;
			Stack<GClass18.Class37> stack2 = new Stack<GClass18.Class37>();
			num = 236858720U * num;
			this.stack_1 = stack2;
			if (521423272U * num == 0U)
			{
				continue;
			}
			num -= 2110538572U;
			Stack<int> stack3 = new Stack<int>();
			num ^= 89539118U;
			this.stack_2 = stack3;
			if (num - 970805053U == 0U)
			{
				continue;
			}
			this.list_2 = new List<IntPtr>();
			num = 873476694U % num;
			if (1968074836U == num)
			{
				continue;
			}
			num = 1464225552U + num;
			base..ctor();
			if (1631126601U >= num)
			{
				continue;
			}
			num = 101652884U + num;
			num += 1918793100U;
			IntPtr hinstance = Marshal.GetHINSTANCE(this.module_0);
			num /= 1951682156U;
			IntPtr intPtr = hinstance;
			this.long_0 = intPtr.ToInt64();
			num = (600208499U & num);
			num -= 2092634887U;
			Dictionary<uint, GClass18.Delegate359> dictionary2 = this.dictionary_0;
			num = 795036500U + num;
			uint key = num ^ 2997368909U;
			num /= 1849851469U;
			IntPtr intptr_ = ldftn(method_44);
			num ^= 282489484U;
			dictionary2[key] = new GClass18.Delegate359(this, intptr_);
			Dictionary<uint, GClass18.Delegate359> dictionary3 = this.dictionary_0;
			uint key2 = num - 282489484U;
			num = 1558864990U - num;
			IntPtr intptr_2 = ldftn(method_66);
			num = (338906362U & num);
			GClass18.Delegate359 value = new GClass18.Delegate359(this, intptr_2);
			num = 249188512U / num;
			dictionary3[key2] = value;
			num += 1848854436U;
			Dictionary<uint, GClass18.Delegate359> dictionary4 = this.dictionary_0;
			num = 658254814U - num;
			uint key3 = num ^ 3104367669U;
			num ^= 312171468U;
			dictionary4[key3] = new GClass18.Delegate359(this.method_70);
			num = (1984305454U & num);
			num = 538648362U * num;
			Dictionary<uint, GClass18.Delegate359> dictionary5 = this.dictionary_0;
			uint key4 = num + 1127074079U;
			IntPtr intptr_3 = ldftn(method_101);
			num %= 1765420553U;
			dictionary5[key4] = new GClass18.Delegate359(this, intptr_3);
			if (2117410132U >= num)
			{
				Dictionary<uint, GClass18.Delegate359> dictionary6 = this.dictionary_0;
				uint key5 = num ^ 1402472671U;
				num >>= 14;
				num %= 18971688U;
				GClass18.Delegate359 value2 = new GClass18.Delegate359(this.method_43);
				num = 1999258211U * num;
				dictionary6[key5] = value2;
				num |= 101735105U;
				if (912261958U < num)
				{
					break;
				}
				continue;
			}
			IL_18A:
			num = 871506878U << (int)num;
			this.list_0 = new List<GClass18.Class7>();
			num = (327974763U & num);
			List<GClass18.Class37> list = new List<GClass18.Class37>();
			num -= 1471045185U;
			this.list_1 = list;
			goto IL_1BE;
		}
		num <<= 11;
		this.dictionary_0[5U] = new GClass18.Delegate359(this.method_41);
		this.dictionary_0[6U] = new GClass18.Delegate359(this.method_62);
		this.dictionary_0[7U] = new GClass18.Delegate359(this.method_50);
		this.dictionary_0[8U] = new GClass18.Delegate359(this.method_93);
		this.dictionary_0[9U] = new GClass18.Delegate359(this.method_56);
		this.dictionary_0[10U] = new GClass18.Delegate359(this.method_60);
		this.dictionary_0[11U] = new GClass18.Delegate359(this.method_77);
		this.dictionary_0[12U] = new GClass18.Delegate359(this.method_106);
		this.dictionary_0[13U] = new GClass18.Delegate359(this.method_38);
		this.dictionary_0[14U] = new GClass18.Delegate359(this.method_94);
		this.dictionary_0[15U] = new GClass18.Delegate359(this.method_91);
		this.dictionary_0[16U] = new GClass18.Delegate359(this.method_69);
		this.dictionary_0[17U] = new GClass18.Delegate359(this.method_89);
		this.dictionary_0[18U] = new GClass18.Delegate359(this.method_82);
		this.dictionary_0[19U] = new GClass18.Delegate359(this.method_99);
		this.dictionary_0[20U] = new GClass18.Delegate359(this.method_81);
		this.dictionary_0[21U] = new GClass18.Delegate359(this.method_84);
		this.dictionary_0[22U] = new GClass18.Delegate359(this.method_45);
		this.dictionary_0[23U] = new GClass18.Delegate359(this.method_35);
		this.dictionary_0[24U] = new GClass18.Delegate359(this.method_108);
		this.dictionary_0[25U] = new GClass18.Delegate359(this.method_36);
		this.dictionary_0[26U] = new GClass18.Delegate359(this.method_57);
		this.dictionary_0[27U] = new GClass18.Delegate359(this.method_68);
		this.dictionary_0[28U] = new GClass18.Delegate359(this.method_40);
		this.dictionary_0[29U] = new GClass18.Delegate359(this.method_78);
		this.dictionary_0[30U] = new GClass18.Delegate359(this.method_42);
		this.dictionary_0[31U] = new GClass18.Delegate359(this.method_52);
		this.dictionary_0[32U] = new GClass18.Delegate359(this.method_90);
		this.dictionary_0[33U] = new GClass18.Delegate359(this.method_9);
		this.dictionary_0[34U] = new GClass18.Delegate359(this.method_53);
		this.dictionary_0[35U] = new GClass18.Delegate359(this.method_88);
		this.dictionary_0[36U] = new GClass18.Delegate359(this.method_65);
		this.dictionary_0[37U] = new GClass18.Delegate359(this.method_55);
		this.dictionary_0[38U] = new GClass18.Delegate359(this.method_76);
		this.dictionary_0[39U] = new GClass18.Delegate359(this.method_37);
		this.dictionary_0[40U] = new GClass18.Delegate359(this.method_79);
		this.dictionary_0[41U] = new GClass18.Delegate359(this.method_97);
		this.dictionary_0[42U] = new GClass18.Delegate359(this.method_98);
		this.dictionary_0[43U] = new GClass18.Delegate359(this.method_80);
		this.dictionary_0[44U] = new GClass18.Delegate359(this.method_61);
		this.dictionary_0[45U] = new GClass18.Delegate359(this.method_85);
		this.dictionary_0[46U] = new GClass18.Delegate359(this.method_73);
		this.dictionary_0[47U] = new GClass18.Delegate359(this.method_109);
		this.dictionary_0[48U] = new GClass18.Delegate359(this.method_104);
		this.dictionary_0[49U] = new GClass18.Delegate359(this.method_74);
		this.dictionary_0[50U] = new GClass18.Delegate359(this.method_92);
		this.dictionary_0[51U] = new GClass18.Delegate359(this.method_75);
		this.dictionary_0[52U] = new GClass18.Delegate359(this.method_110);
		this.dictionary_0[53U] = new GClass18.Delegate359(this.method_102);
		this.dictionary_0[54U] = new GClass18.Delegate359(this.method_54);
		this.dictionary_0[55U] = new GClass18.Delegate359(this.method_58);
		this.dictionary_0[56U] = new GClass18.Delegate359(this.method_100);
		this.dictionary_0[57U] = new GClass18.Delegate359(this.method_87);
		this.dictionary_0[58U] = new GClass18.Delegate359(this.method_67);
		this.dictionary_0[59U] = new GClass18.Delegate359(this.method_71);
		this.dictionary_0[60U] = new GClass18.Delegate359(this.method_47);
		this.dictionary_0[61U] = new GClass18.Delegate359(this.method_105);
		this.dictionary_0[62U] = new GClass18.Delegate359(this.method_51);
		this.dictionary_0[63U] = new GClass18.Delegate359(this.method_48);
		this.dictionary_0[64U] = new GClass18.Delegate359(this.method_49);
		this.dictionary_0[65U] = new GClass18.Delegate359(this.method_46);
		this.dictionary_0[66U] = new GClass18.Delegate359(this.method_103);
		this.dictionary_0[67U] = new GClass18.Delegate359(this.method_39);
		this.dictionary_0[68U] = new GClass18.Delegate359(this.method_63);
		this.dictionary_0[69U] = new GClass18.Delegate359(this.method_107);
		this.dictionary_0[70U] = new GClass18.Delegate359(this.method_59);
		this.dictionary_0[71U] = new GClass18.Delegate359(this.method_96);
		this.dictionary_0[72U] = new GClass18.Delegate359(this.method_64);
		this.dictionary_0[73U] = new GClass18.Delegate359(this.method_72);
		this.dictionary_0[74U] = new GClass18.Delegate359(this.method_95);
		this.dictionary_0[75U] = new GClass18.Delegate359(this.method_83);
		this.dictionary_0[76U] = new GClass18.Delegate359(this.method_86);
		this.dictionary_0[77U] = new GClass18.Delegate359(this.method_40);
		this.dictionary_0[78U] = new GClass18.Delegate359(this.method_40);
		this.dictionary_0[79U] = new GClass18.Delegate359(this.method_46);
		this.dictionary_0[80U] = new GClass18.Delegate359(this.method_52);
		this.dictionary_0[81U] = new GClass18.Delegate359(this.method_104);
		this.dictionary_0[82U] = new GClass18.Delegate359(this.method_69);
		this.dictionary_0[83U] = new GClass18.Delegate359(this.method_43);
		this.dictionary_0[84U] = new GClass18.Delegate359(this.method_41);
		this.dictionary_0[85U] = new GClass18.Delegate359(this.method_52);
		this.dictionary_0[86U] = new GClass18.Delegate359(this.method_41);
		this.dictionary_0[87U] = new GClass18.Delegate359(this.method_73);
		this.dictionary_0[88U] = new GClass18.Delegate359(this.method_43);
		this.dictionary_0[89U] = new GClass18.Delegate359(this.method_91);
		this.dictionary_0[90U] = new GClass18.Delegate359(this.method_43);
		this.dictionary_0[91U] = new GClass18.Delegate359(this.method_70);
		this.dictionary_0[92U] = new GClass18.Delegate359(this.method_97);
		this.dictionary_0[93U] = new GClass18.Delegate359(this.method_37);
		this.dictionary_0[94U] = new GClass18.Delegate359(this.method_36);
		this.dictionary_0[95U] = new GClass18.Delegate359(this.method_81);
		this.dictionary_0[96U] = new GClass18.Delegate359(this.method_65);
		this.dictionary_0[97U] = new GClass18.Delegate359(this.method_73);
		this.dictionary_0[98U] = new GClass18.Delegate359(this.method_73);
		this.dictionary_0[99U] = new GClass18.Delegate359(this.method_44);
		this.dictionary_0[100U] = new GClass18.Delegate359(this.method_107);
		this.dictionary_0[101U] = new GClass18.Delegate359(this.method_99);
		this.dictionary_0[102U] = new GClass18.Delegate359(this.method_41);
		this.dictionary_0[103U] = new GClass18.Delegate359(this.method_71);
		this.dictionary_0[104U] = new GClass18.Delegate359(this.method_71);
		this.dictionary_0[105U] = new GClass18.Delegate359(this.method_58);
		this.dictionary_0[106U] = new GClass18.Delegate359(this.method_95);
		this.dictionary_0[107U] = new GClass18.Delegate359(this.method_91);
		this.dictionary_0[108U] = new GClass18.Delegate359(this.method_37);
		this.dictionary_0[109U] = new GClass18.Delegate359(this.method_90);
		this.dictionary_0[110U] = new GClass18.Delegate359(this.method_54);
		this.dictionary_0[111U] = new GClass18.Delegate359(this.method_37);
		this.dictionary_0[112U] = new GClass18.Delegate359(this.method_41);
		this.dictionary_0[113U] = new GClass18.Delegate359(this.method_71);
		this.dictionary_0[114U] = new GClass18.Delegate359(this.method_70);
		this.dictionary_0[115U] = new GClass18.Delegate359(this.method_35);
		this.dictionary_0[116U] = new GClass18.Delegate359(this.method_81);
		this.dictionary_0[117U] = new GClass18.Delegate359(this.method_49);
		this.dictionary_0[118U] = new GClass18.Delegate359(this.method_107);
		this.dictionary_0[119U] = new GClass18.Delegate359(this.method_52);
		this.dictionary_0[120U] = new GClass18.Delegate359(this.method_73);
		this.dictionary_0[121U] = new GClass18.Delegate359(this.method_43);
		this.dictionary_0[122U] = new GClass18.Delegate359(this.method_41);
		this.dictionary_0[123U] = new GClass18.Delegate359(this.method_68);
		this.dictionary_0[124U] = new GClass18.Delegate359(this.method_97);
		this.dictionary_0[125U] = new GClass18.Delegate359(this.method_44);
		this.dictionary_0[126U] = new GClass18.Delegate359(this.method_80);
		this.dictionary_0[127U] = new GClass18.Delegate359(this.method_55);
		this.dictionary_0[128U] = new GClass18.Delegate359(this.method_36);
		this.dictionary_0[129U] = new GClass18.Delegate359(this.method_73);
		this.dictionary_0[130U] = new GClass18.Delegate359(this.method_53);
		this.dictionary_0[131U] = new GClass18.Delegate359(this.method_74);
		this.dictionary_0[132U] = new GClass18.Delegate359(this.method_95);
		this.dictionary_0[133U] = new GClass18.Delegate359(this.method_52);
		this.dictionary_0[134U] = new GClass18.Delegate359(this.method_73);
		this.dictionary_0[135U] = new GClass18.Delegate359(this.method_79);
		this.dictionary_0[136U] = new GClass18.Delegate359(this.method_45);
		this.dictionary_0[137U] = new GClass18.Delegate359(this.method_91);
		this.dictionary_0[138U] = new GClass18.Delegate359(this.method_41);
		this.dictionary_0[139U] = new GClass18.Delegate359(this.method_61);
		this.dictionary_0[140U] = new GClass18.Delegate359(this.method_81);
		this.dictionary_0[141U] = new GClass18.Delegate359(this.method_102);
		this.dictionary_0[142U] = new GClass18.Delegate359(this.method_75);
		this.dictionary_0[143U] = new GClass18.Delegate359(this.method_91);
		this.dictionary_0[144U] = new GClass18.Delegate359(this.method_57);
		this.dictionary_0[145U] = new GClass18.Delegate359(this.method_103);
		this.dictionary_0[146U] = new GClass18.Delegate359(this.method_107);
		this.dictionary_0[147U] = new GClass18.Delegate359(this.method_52);
		this.dictionary_0[148U] = new GClass18.Delegate359(this.method_52);
		this.dictionary_0[149U] = new GClass18.Delegate359(this.method_37);
		this.dictionary_0[150U] = new GClass18.Delegate359(this.method_61);
		this.dictionary_0[151U] = new GClass18.Delegate359(this.method_97);
		this.dictionary_0[152U] = new GClass18.Delegate359(this.method_69);
		this.dictionary_0[153U] = new GClass18.Delegate359(this.method_52);
		this.dictionary_0[154U] = new GClass18.Delegate359(this.method_73);
		this.dictionary_0[155U] = new GClass18.Delegate359(this.method_104);
		this.dictionary_0[156U] = new GClass18.Delegate359(this.method_84);
		this.dictionary_0[157U] = new GClass18.Delegate359(this.method_73);
		this.dictionary_0[158U] = new GClass18.Delegate359(this.method_44);
		this.dictionary_0[159U] = new GClass18.Delegate359(this.method_40);
		this.dictionary_0[160U] = new GClass18.Delegate359(this.method_90);
		this.dictionary_0[161U] = new GClass18.Delegate359(this.method_95);
		this.dictionary_0[162U] = new GClass18.Delegate359(this.method_104);
		this.dictionary_0[163U] = new GClass18.Delegate359(this.method_52);
		this.dictionary_0[164U] = new GClass18.Delegate359(this.method_41);
		this.dictionary_0[165U] = new GClass18.Delegate359(this.method_37);
		this.dictionary_0[166U] = new GClass18.Delegate359(this.method_52);
		this.dictionary_0[167U] = new GClass18.Delegate359(this.method_37);
		this.dictionary_0[168U] = new GClass18.Delegate359(this.method_9);
		this.dictionary_0[169U] = new GClass18.Delegate359(this.method_73);
		this.dictionary_0[170U] = new GClass18.Delegate359(this.method_76);
		this.dictionary_0[171U] = new GClass18.Delegate359(this.method_104);
		this.dictionary_0[172U] = new GClass18.Delegate359(this.method_73);
		this.dictionary_0[173U] = new GClass18.Delegate359(this.method_44);
		this.dictionary_0[174U] = new GClass18.Delegate359(this.method_41);
		this.dictionary_0[175U] = new GClass18.Delegate359(this.method_110);
		this.dictionary_0[176U] = new GClass18.Delegate359(this.method_102);
		this.dictionary_0[177U] = new GClass18.Delegate359(this.method_95);
		this.dictionary_0[178U] = new GClass18.Delegate359(this.method_70);
		this.dictionary_0[179U] = new GClass18.Delegate359(this.method_107);
		this.dictionary_0[180U] = new GClass18.Delegate359(this.method_52);
		this.dictionary_0[181U] = new GClass18.Delegate359(this.method_81);
		this.dictionary_0[182U] = new GClass18.Delegate359(this.method_44);
		this.dictionary_0[183U] = new GClass18.Delegate359(this.method_36);
		this.dictionary_0[184U] = new GClass18.Delegate359(this.method_80);
		this.dictionary_0[185U] = new GClass18.Delegate359(this.method_43);
		this.dictionary_0[186U] = new GClass18.Delegate359(this.method_52);
		this.dictionary_0[187U] = new GClass18.Delegate359(this.method_52);
		this.dictionary_0[188U] = new GClass18.Delegate359(this.method_93);
		this.dictionary_0[189U] = new GClass18.Delegate359(this.method_97);
		this.dictionary_0[190U] = new GClass18.Delegate359(this.method_100);
		this.dictionary_0[191U] = new GClass18.Delegate359(this.method_104);
		this.dictionary_0[192U] = new GClass18.Delegate359(this.method_53);
		this.dictionary_0[193U] = new GClass18.Delegate359(this.method_44);
		this.dictionary_0[194U] = new GClass18.Delegate359(this.method_73);
		this.dictionary_0[195U] = new GClass18.Delegate359(this.method_82);
		this.dictionary_0[196U] = new GClass18.Delegate359(this.method_71);
		this.dictionary_0[197U] = new GClass18.Delegate359(this.method_73);
		this.dictionary_0[198U] = new GClass18.Delegate359(this.method_52);
		this.dictionary_0[199U] = new GClass18.Delegate359(this.method_61);
		this.dictionary_0[200U] = new GClass18.Delegate359(this.method_95);
		this.dictionary_0[201U] = new GClass18.Delegate359(this.method_75);
		this.dictionary_0[202U] = new GClass18.Delegate359(this.method_43);
		this.dictionary_0[203U] = new GClass18.Delegate359(this.method_73);
		this.dictionary_0[204U] = new GClass18.Delegate359(this.method_83);
		this.dictionary_0[205U] = new GClass18.Delegate359(this.method_90);
		this.dictionary_0[206U] = new GClass18.Delegate359(this.method_73);
		this.dictionary_0[207U] = new GClass18.Delegate359(this.method_100);
		this.dictionary_0[208U] = new GClass18.Delegate359(this.method_49);
		this.dictionary_0[209U] = new GClass18.Delegate359(this.method_64);
		this.dictionary_0[210U] = new GClass18.Delegate359(this.method_37);
		this.dictionary_0[211U] = new GClass18.Delegate359(this.method_43);
		this.dictionary_0[212U] = new GClass18.Delegate359(this.method_84);
		this.dictionary_0[213U] = new GClass18.Delegate359(this.method_71);
		this.dictionary_0[214U] = new GClass18.Delegate359(this.method_109);
		this.dictionary_0[215U] = new GClass18.Delegate359(this.method_81);
		this.dictionary_0[216U] = new GClass18.Delegate359(this.method_43);
		this.dictionary_0[217U] = new GClass18.Delegate359(this.method_70);
		this.dictionary_0[218U] = new GClass18.Delegate359(this.method_85);
		this.dictionary_0[219U] = new GClass18.Delegate359(this.method_70);
		this.dictionary_0[220U] = new GClass18.Delegate359(this.method_41);
		this.dictionary_0[221U] = new GClass18.Delegate359(this.method_62);
		this.dictionary_0[222U] = new GClass18.Delegate359(this.method_47);
		this.dictionary_0[223U] = new GClass18.Delegate359(this.method_45);
		this.dictionary_0[224U] = new GClass18.Delegate359(this.method_37);
		this.dictionary_0[225U] = new GClass18.Delegate359(this.method_73);
		this.dictionary_0[226U] = new GClass18.Delegate359(this.method_80);
		this.dictionary_0[227U] = new GClass18.Delegate359(this.method_76);
		this.dictionary_0[228U] = new GClass18.Delegate359(this.method_35);
		this.dictionary_0[229U] = new GClass18.Delegate359(this.method_41);
		this.dictionary_0[230U] = new GClass18.Delegate359(this.method_35);
		this.dictionary_0[231U] = new GClass18.Delegate359(this.method_96);
		this.dictionary_0[232U] = new GClass18.Delegate359(this.method_54);
		this.dictionary_0[233U] = new GClass18.Delegate359(this.method_72);
		this.dictionary_0[234U] = new GClass18.Delegate359(this.method_44);
		this.dictionary_0[235U] = new GClass18.Delegate359(this.method_41);
		this.dictionary_0[236U] = new GClass18.Delegate359(this.method_73);
		this.dictionary_0[237U] = new GClass18.Delegate359(this.method_74);
		this.dictionary_0[238U] = new GClass18.Delegate359(this.method_98);
		this.dictionary_0[239U] = new GClass18.Delegate359(this.method_52);
		this.dictionary_0[240U] = new GClass18.Delegate359(this.method_73);
		this.dictionary_0[241U] = new GClass18.Delegate359(this.method_104);
		this.dictionary_0[242U] = new GClass18.Delegate359(this.method_61);
		this.dictionary_0[243U] = new GClass18.Delegate359(this.method_107);
		this.dictionary_0[244U] = new GClass18.Delegate359(this.method_52);
		this.dictionary_0[245U] = new GClass18.Delegate359(this.method_80);
		this.dictionary_0[246U] = new GClass18.Delegate359(this.method_43);
		this.dictionary_0[247U] = new GClass18.Delegate359(this.method_71);
		this.dictionary_0[248U] = new GClass18.Delegate359(this.method_73);
		this.dictionary_0[249U] = new GClass18.Delegate359(this.method_43);
		this.dictionary_0[250U] = new GClass18.Delegate359(this.method_40);
		this.dictionary_0[251U] = new GClass18.Delegate359(this.method_55);
		this.dictionary_0[252U] = new GClass18.Delegate359(this.method_97);
		this.dictionary_0[253U] = new GClass18.Delegate359(this.method_66);
		this.dictionary_0[254U] = new GClass18.Delegate359(this.method_89);
		this.dictionary_0[255U] = new GClass18.Delegate359(this.method_95);
	}

	// Token: 0x06000621 RID: 1569 RVA: 0x00013B10 File Offset: 0x00011D10
	private void method_0(GClass18.Class7 class7_0)
	{
		this.stack_0.Push(class7_0.vmethod_4());
	}

	// Token: 0x06000622 RID: 1570 RVA: 0x00013B30 File Offset: 0x00011D30
	private GClass18.Class7 method_1()
	{
		return this.stack_0.Pop();
	}

	// Token: 0x06000623 RID: 1571 RVA: 0x00013B48 File Offset: 0x00011D48
	private GClass18.Class7 method_2()
	{
		return this.stack_0.Peek();
	}

	// Token: 0x06000624 RID: 1572 RVA: 0x00013B60 File Offset: 0x00011D60
	private byte method_3()
	{
		byte result = Marshal.ReadByte(new IntPtr(this.long_0 + (long)this.int_0));
		this.int_0++;
		return result;
	}

	// Token: 0x06000625 RID: 1573 RVA: 0x00013B94 File Offset: 0x00011D94
	private short method_4()
	{
		short result = Marshal.ReadInt16(new IntPtr(this.long_0 + (long)this.int_0));
		this.int_0 += 2;
		return result;
	}

	// Token: 0x06000626 RID: 1574 RVA: 0x00013BC8 File Offset: 0x00011DC8
	private int method_5()
	{
		int result = Marshal.ReadInt32(new IntPtr(this.long_0 + (long)this.int_0));
		this.int_0 += 4;
		return result;
	}

	// Token: 0x06000627 RID: 1575 RVA: 0x00013BFC File Offset: 0x00011DFC
	private long method_6()
	{
		long result = Marshal.ReadInt64(new IntPtr(this.long_0 + (long)this.int_0));
		this.int_0 += 8;
		return result;
	}

	// Token: 0x06000628 RID: 1576 RVA: 0x00013C30 File Offset: 0x00011E30
	private float method_7()
	{
		return BitConverter.ToSingle(BitConverter.GetBytes(this.method_5()), 0);
	}

	// Token: 0x06000629 RID: 1577 RVA: 0x00013C50 File Offset: 0x00011E50
	private double method_8()
	{
		return BitConverter.ToDouble(BitConverter.GetBytes(this.method_6()), 0);
	}

	// Token: 0x0600062A RID: 1578 RVA: 0x00013C70 File Offset: 0x00011E70
	private void method_9()
	{
		byte byte_;
		uint num;
		int int_;
		int int_2;
		GClass18.Class37 class2;
		bool flag3;
		for (;;)
		{
			IL_00:
			byte_ = this.method_3();
			num = 1U;
			int num17;
			for (;;)
			{
				IL_2A5:
				int num2 = this.method_5();
				num = 1940286268U >> (int)num;
				int num3 = num2;
				int num4 = this.method_5();
				num = (124064783U ^ num);
				int num5 = num4;
				for (;;)
				{
					IL_29C:
					int_ = this.method_5();
					for (;;)
					{
						IL_27C:
						int num6 = this.method_5();
						num = (1570200629U & num);
						int_2 = num6;
						if (1921792706U >= num)
						{
							GClass18.Class37 @class = null;
							num >>= 14;
							class2 = @class;
							int num7 = (int)(num ^ 29272U);
							GClass18.Class37 class3;
							for (;;)
							{
								num = 1915834594U >> (int)num;
								int num8 = num7;
								List<GClass18.Class37> list = this.list_1;
								num = 946368640U % num;
								int count = list.Count;
								num = 1862279181U % num;
								if (num8 >= count)
								{
									goto Block_4;
								}
								class3 = this.list_1[num7];
								int num9 = class3.method_0();
								int num10 = num3;
								num = 2586U;
								if (num9 == num10)
								{
									if (1059596570U == num)
									{
										goto IL_00;
									}
									int num11 = class3.method_1();
									int num12 = num5;
									num |= 247876258U;
									num ^= 247873696U;
									if (num11 == num12)
									{
										goto Block_2;
									}
								}
								num %= 2038566758U;
								if (1544036696U <= num)
								{
									goto IL_00;
								}
								int num13 = num7;
								num = 1617452367U - num;
								int num14 = (int)(num ^ 1617449780U);
								num = 452336947U / num;
								int num15 = num13 + num14;
								num ^= 468848179U;
								num7 = num15;
								num ^= 468876395U;
							}
							IL_143:
							bool flag = class2 != null;
							num -= 648248796U;
							if (flag)
							{
								goto IL_36E;
							}
							num -= 1920171634U;
							bool flag2 = num - 2034119995U != 0U;
							num = 1287865469U << (int)num;
							flag3 = flag2;
							int int_3 = num3;
							num = 551292586U % num;
							class2 = new GClass18.Class37(int_3, num5);
							num &= 1039021339U;
							int num16 = (int)(num + 3744726006U);
							num &= 1878216237U;
							num17 = num16;
							for (;;)
							{
								num = (1518881590U & num);
								if (num / 1878266863U != 0U)
								{
									goto IL_29C;
								}
								int num18 = num17;
								num = 564464264U * num;
								num *= 1475021047U;
								if (num18 >= this.list_1.Count)
								{
									goto IL_316;
								}
								GClass18.Class37 class37_ = this.list_1[num17];
								int num19 = class2.method_2(class37_);
								num = 15854918U;
								if (num19 < 0)
								{
									goto IL_2D1;
								}
								num = (1001286997U & num);
								if (1287416122U + num == 0U)
								{
									goto IL_27C;
								}
								int num20 = num17;
								num = 1358986733U << (int)num;
								int num21 = (int)(num - 268951247U);
								num = 1869358974U % num;
								int num22 = num20 + num21;
								num &= 1145190181U;
								num17 = num22;
								num += 482336260U;
							}
							Block_2:
							GClass18.Class37 class4 = class3;
							num += 307570543U;
							class2 = class4;
							if (num != 368315120U)
							{
								goto IL_143;
							}
							goto IL_00;
							Block_4:
							num += 307573126U;
							goto IL_143;
						}
						goto IL_2A5;
					}
				}
			}
			IL_2D1:
			num <<= 7;
			List<GClass18.Class37> list2 = this.list_1;
			num = 1630101017U - num;
			list2.Insert(num17, class2);
			bool flag4 = (num ^ 3895638808U) != 0U;
			num = 1737099076U * num;
			flag3 = flag4;
			if (905270152U * num == 0U)
			{
				continue;
			}
			IL_320:
			if (num >= 855386443U)
			{
				break;
			}
			continue;
			IL_316:
			num += 1594974628U;
			goto IL_320;
		}
		bool flag5 = flag3;
		num ^= 278974985U;
		if (!flag5)
		{
			num &= 564932437U;
			List<GClass18.Class37> list3 = this.list_1;
			num &= 268263580U;
			GClass18.Class37 item = class2;
			num = 170678227U / num;
			list3.Add(item);
			num += 3954291623U;
		}
		IL_36E:
		num = (516096365U ^ num);
		class2.method_3(byte_, int_, int_2);
	}

	// Token: 0x0600062B RID: 1579 RVA: 0x00014000 File Offset: 0x00012200
	private TypeCode method_10(GClass18.Class7 class7_0, GClass18.Class7 class7_1)
	{
		uint num = 1347692453U;
		TypeCode typeCode;
		TypeCode typeCode2;
		for (;;)
		{
			IL_25E:
			typeCode = class7_0.vmethod_7();
			for (;;)
			{
				IL_19D:
				num = 974749163U - num;
				typeCode2 = class7_1.vmethod_7();
				num = 871520891U / num;
				while (typeCode != TypeCode.Empty)
				{
					if (714803162U * num != 0U)
					{
						goto IL_19D;
					}
					for (;;)
					{
						TypeCode typeCode3 = typeCode;
						num %= 112068029U;
						uint num2 = num ^ 1U;
						num = (1163483019U | num);
						num ^= 1163483019U;
						if (typeCode3 == num2)
						{
							goto IL_396;
						}
						bool flag = typeCode2 != TypeCode.Empty;
						num = 836637129U * num;
						num += 0U;
						if (!flag)
						{
							goto IL_396;
						}
						num /= 1681860373U;
						TypeCode typeCode4 = typeCode2;
						num *= 2055885550U;
						uint num3 = num - uint.MaxValue;
						num %= 1950091782U;
						if (typeCode4 == num3)
						{
							goto Block_3;
						}
						num >>= 9;
						uint num4 = (uint)typeCode;
						num >>= 1;
						if (num4 == (num ^ 10U))
						{
							goto Block_4;
						}
						if (typeCode2 == (TypeCode)(num - 4294967286U))
						{
							break;
						}
						if (num << 10 != 0U)
						{
							goto IL_25E;
						}
						TypeCode typeCode5 = typeCode;
						num >>= 11;
						uint num5 = num ^ 12U;
						num += 2012089027U;
						if (typeCode5 == num5)
						{
							goto Block_7;
						}
						TypeCode typeCode6 = typeCode2;
						uint num6 = num - 2012089015U;
						num += 1892113767U;
						if (typeCode6 == num6)
						{
							goto Block_8;
						}
						if ((num & 31011625U) != 0U)
						{
							uint num7 = (uint)typeCode;
							num &= 1777669516U;
							if (num7 == num - 1756692474U)
							{
								goto IL_386;
							}
							num -= 242221233U;
							if (num != 248396903U)
							{
								goto Block_11;
							}
						}
					}
					if (num - 2050176072U == 0U)
					{
						continue;
					}
					goto IL_281;
					Block_4:
					if (1016233557U == num)
					{
						goto IL_25E;
					}
					uint num8 = (uint)typeCode2;
					num &= 184769953U;
					if (num8 != num - 4294967287U)
					{
						goto Block_14;
					}
					num ^= 1618024731U;
					if (1303194540U - num != 0U)
					{
						return typeCode;
					}
					continue;
					Block_8:
					num = 1034172067U % num;
					if (typeCode == (TypeCode)(num ^ 1034172074U))
					{
						return typeCode;
					}
					num |= 822092970U;
					if (num <= 786107245U)
					{
						goto IL_19D;
					}
					goto IL_2B5;
				}
				goto IL_396;
			}
			Block_7:
			num /= 42687702U;
			if (num + 619980747U == 0U)
			{
				continue;
			}
			TypeCode typeCode7 = typeCode2;
			uint num9 = num ^ 38U;
			num >>= 22;
			if (typeCode7 != num9)
			{
				num *= 1029515765U;
				TypeCode typeCode8 = typeCode2;
				num &= 346781849U;
				uint num10 = num ^ 11U;
				num += 255942301U;
				num ^= 255942301U;
				if (typeCode8 != num10)
				{
					goto Block_20;
				}
			}
			num = (1342465606U ^ num);
			if (1689937483 << (int)num != 0)
			{
				return typeCode;
			}
			continue;
			Block_11:
			if (typeCode2 == (TypeCode)(num ^ 1514471257U))
			{
				goto Block_22;
			}
			num += 447553599U;
			if (typeCode == (TypeCode)(num - 1962024841U))
			{
				goto IL_376;
			}
			num /= 1754626789U;
			if (750328351U >= num)
			{
				goto IL_2EE;
			}
		}
		Block_3:
		num += 0U;
		goto IL_396;
		Block_14:
		return (TypeCode)(num - 0U);
		Block_20:
		return (TypeCode)(num ^ 0U);
		Block_22:
		num ^= 854720351U;
		goto IL_386;
		IL_281:
		TypeCode typeCode9 = typeCode;
		num *= 1982027217U;
		uint num11 = num ^ 9U;
		num = 1441813245U << (int)num;
		if (typeCode9 != num11)
		{
			return (TypeCode)(num - 1441813245U);
		}
		return typeCode2;
		IL_2B5:
		TypeCode typeCode10 = typeCode;
		uint num12 = num + 3260795232U;
		num &= 1820013295U;
		num += 293864440U;
		if (typeCode10 != num12)
		{
			num %= 723583075U;
			return (TypeCode)(num - 310588992U);
		}
		return typeCode;
		IL_2EE:
		TypeCode typeCode11 = typeCode2;
		uint num13 = num + 12U;
		num *= 646347455U;
		if (typeCode11 != num13)
		{
			num = 163513955U >> (int)num;
			TypeCode typeCode12 = typeCode;
			num *= 912921292U;
			uint num14 = num ^ 11U;
			num |= 2027253307U;
			if (typeCode12 != num14)
			{
				num = 780226219U + num;
				TypeCode typeCode13 = typeCode2;
				num += 1385373995U;
				uint num15 = num ^ 4192853530U;
				num |= 139815520U;
				if (typeCode13 != num15)
				{
					return (int)num + (TypeCode)100794776;
				}
				num ^= 2166919242U;
			}
			num /= 1996426022U;
			return (TypeCode)(num ^ 10U);
		}
		num ^= 1383359785U;
		IL_376:
		num /= 1375944801U;
		return (TypeCode)(num ^ 12U);
		IL_386:
		num >>= 27;
		return (TypeCode)(num ^ 3U);
		IL_396:
		return (TypeCode)(num ^ 0U);
	}

	// Token: 0x0600062C RID: 1580 RVA: 0x000143AC File Offset: 0x000125AC
	private unsafe GClass18.Class7 method_11(GClass18.Class7 class7_0, GClass18.Class7 class7_1, bool bool_0, bool bool_1)
	{
		uint num = 1798850749U;
		ulong num14;
		ulong num16;
		long num17;
		GClass18.Class15 class2;
		IntPtr intPtr2;
		int num31;
		int num32;
		int num39;
		GClass18.Class15 class3;
		long num40;
		for (;;)
		{
			IL_6AC:
			num *= 1965636026U;
			TypeCode typeCode = this.method_10(class7_0, class7_1);
			num %= 1068646908U;
			if (num != 1567570828U)
			{
				int value;
				for (;;)
				{
					uint num2 = (uint)typeCode;
					num = 619011165U * num;
					uint num3 = num2 - (num + 3917446347U);
					num = 1305051016U + num;
					switch (num3)
					{
					case 0:
						goto IL_5A4;
					case 1:
					{
						num -= 1226446852U;
						if (bool_1)
						{
							num *= 115824303U;
							num %= 1677149587U;
							uint num4 = class7_0.vmethod_11();
							num = 28009384U - num;
							uint num5 = class7_1.vmethod_11();
							if (691895970U % num == 0U)
							{
								goto IL_6AC;
							}
							num /= 774126104U;
							int num6;
							if (!bool_0)
							{
								num6 = (int)(num4 + num5);
							}
							else
							{
								num ^= 1260982599U;
								if (num == 679678608U)
								{
									continue;
								}
								int num7 = (int)num4;
								num = (975985005U ^ num);
								num6 = checked(num7 + (int)num5);
								num += 2398795734U;
							}
							value = num6;
							if (num % 1182889943U == 0U)
							{
								goto IL_6AC;
							}
						}
						else
						{
							if (436220789U % num == 0U)
							{
								continue;
							}
							num = 1223629073U + num;
							int num8 = class7_0.EC4893C4();
							if (95768113U / num != 0U)
							{
								goto IL_5A4;
							}
							int num9 = class7_1.EC4893C4();
							num %= 1548094863U;
							int num10 = num9;
							int num11;
							if (!bool_0)
							{
								if (2110221599 << (int)num == 0)
								{
									continue;
								}
								num11 = num8 + num10;
							}
							else
							{
								if (893731952U <= num)
								{
									goto IL_6AC;
								}
								int num12 = num8;
								int num13 = num10;
								num = 888167873U % num;
								num11 = checked(num12 + num13);
								num += 33447451U;
							}
							value = num11;
							num += 4163307969U;
						}
						TypeCode typeCode2 = class7_0.vmethod_7();
						TypeCode typeCode3 = typeCode;
						num += 189558799U;
						if (typeCode2 == typeCode3)
						{
							goto IL_41F;
						}
						if (921316809U / num == 0U)
						{
							continue;
						}
						goto IL_407;
					}
					case 2:
						if (num == 381118961U)
						{
							goto IL_6AC;
						}
						num = 1295861054U % num;
						if (bool_1)
						{
							num = 1400797270U >> (int)num;
							if (num << 3 == 0U)
							{
								goto IL_5A4;
							}
							num14 = class7_0.vmethod_12();
							if (122373672U == num)
							{
								goto IL_5A4;
							}
							ulong num15 = class7_1.vmethod_12();
							num = 981168515U - num;
							num16 = num15;
							if (num != 1710427231U)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							num = 1326546076U / num;
							num &= 960564545U;
							num17 = class7_0.DB9EABF5();
							if (1919292414U > num)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					case 3:
					{
						num *= 2052204291U;
						num ^= 717685464U;
						long num24;
						if (bool_1)
						{
							if (391202934U == num)
							{
								goto IL_6AC;
							}
							ulong num18 = class7_0.vmethod_12();
							ulong num19 = class7_1.vmethod_12();
							num = 880150795U << (int)num;
							if (2025813271U >= num)
							{
								continue;
							}
							num |= 1836608005U;
							long num21;
							if (!bool_0)
							{
								if (num % 1806334337U == 0U)
								{
									goto IL_6AC;
								}
								long num20 = (long)num18;
								num += 809515818U;
								num21 = num20 + (long)num19;
							}
							else
							{
								if (num >> 14 == 0U)
								{
									goto IL_6AC;
								}
								long num22 = (long)num18;
								num *= 104484542U;
								long num23 = (long)num19;
								num = (758470061U | num);
								num21 = checked(num22 + num23);
								num += 4001835888U;
							}
							num24 = num21;
							if ((930687745U ^ num) == 0U)
							{
								goto IL_6AC;
							}
						}
						else
						{
							long num25 = class7_0.DB9EABF5();
							num >>= 8;
							long num26 = num25;
							if ((613223749U & num) == 0U)
							{
								goto IL_5A4;
							}
							num = 1820288006U - num;
							long num27 = class7_1.DB9EABF5();
							long num28;
							if (!bool_0)
							{
								num28 = num26 + num27;
							}
							else
							{
								long num29 = num26;
								num |= 1492611360U;
								long num30 = num27;
								num = 168433847U >> (int)num;
								num28 = checked(num29 + num30);
								num += 1810297518U;
							}
							num24 = num28;
							num ^= 1180326905U;
						}
						TypeCode typeCode4 = class7_0.vmethod_7();
						num = 1077704300U >> (int)num;
						TypeCode typeCode5 = typeCode;
						num |= 529531913U;
						GClass18.Class15 @class;
						if (typeCode4 != typeCode5)
						{
							num %= 1902331181U;
							num /= 288648666U;
							@class = (GClass18.Class15)class7_1;
						}
						else
						{
							@class = (GClass18.Class15)class7_0;
							num ^= 529564792U;
						}
						num = 309673617U << (int)num;
						class2 = @class;
						num = 1015623630U % num;
						if (num + 192028673U == 0U)
						{
							goto IL_6AC;
						}
						long value2 = num24;
						num |= 1468409856U;
						IntPtr intPtr = new IntPtr(value2);
						num &= 701108769U;
						intPtr2 = intPtr;
						if (593243634U >= num)
						{
							goto Block_12;
						}
						continue;
					}
					case 4:
						goto IL_4D6;
					case 5:
						goto IL_67F;
					}
					goto Block_30;
				}
				IL_5A4:
				while (40830540U != num)
				{
					if (!bool_1)
					{
						num >>= 22;
						num31 = class7_0.EC4893C4();
						num *= 1531839926U;
						if (num <= 631439992U)
						{
							num32 = class7_1.EC4893C4();
							if (bool_0)
							{
								goto IL_888;
							}
							if ((670568200U ^ num) != 0U)
							{
								goto Block_46;
							}
							break;
						}
					}
					else
					{
						uint num33 = class7_0.vmethod_11();
						num <<= 13;
						uint num34 = class7_1.vmethod_11();
						num = 1404532593U / num;
						if (834147980U == num)
						{
							goto IL_966;
						}
						num *= 373257805U;
						int num37;
						if (!bool_0)
						{
							if (num * 1069884044U == 0U)
							{
								break;
							}
							int num35 = (int)num33;
							num = 2091670544U << (int)num;
							int num36 = (int)num34;
							num = (1212564831U ^ num);
							num37 = num35 + num36;
						}
						else
						{
							num = 1954506977U - num;
							int num38 = (int)num33;
							num = 1034764577U << (int)num;
							num37 = checked(num38 + (int)num34);
							num += 2981381471U;
						}
						num <<= 15;
						num39 = num37;
						if (1461460521U * num != 0U)
						{
							goto Block_50;
						}
						break;
					}
				}
				continue;
				IL_439:
				GClass18.Class15 class4;
				class3 = class4;
				if ((num & 875696325U) == 0U)
				{
					goto IL_5A4;
				}
				intPtr2 = new IntPtr(value);
				if (num < 2145746340U)
				{
					goto Block_32;
				}
				continue;
				IL_41F:
				num >>= 4;
				class4 = (GClass18.Class15)class7_0;
				num ^= 1147455233U;
				goto IL_439;
				IL_407:
				num = 1939301453U << (int)num;
				class4 = (GClass18.Class15)class7_1;
				goto IL_439;
				Block_17:
				if (bool_0)
				{
					goto IL_730;
				}
				num = (1089618366U ^ num);
				if (num > 505833691U)
				{
					goto Block_34;
				}
				continue;
				Block_18:
				num40 = class7_1.DB9EABF5();
				num >>= 28;
				num <<= 24;
				if (!bool_0)
				{
					num ^= 1849961135U;
					if (1986872000 << (int)num != 0)
					{
						goto Block_36;
					}
					continue;
				}
				else
				{
					if ((38405673U ^ num) != 0U)
					{
						goto Block_37;
					}
					continue;
				}
				IL_4D6:
				num = 826042238U - num;
				GClass18.Class7 class5;
				if (!bool_1)
				{
					num = 1859454688U - num;
					class5 = class7_0;
				}
				else
				{
					if (num <= 1282047661U)
					{
						continue;
					}
					class5 = class7_0.vmethod_5();
					num += 3572514160U;
				}
				num = 89545745U >> (int)num;
				float num41 = class5.B4B75C1D();
				num /= 1255304684U;
				if (1655573747U * num != 0U)
				{
					goto IL_966;
				}
				GClass18.Class7 class6;
				if (!bool_1)
				{
					class6 = class7_1;
				}
				else
				{
					class6 = class7_1.vmethod_5();
					num ^= 0U;
				}
				float num42 = class6.B4B75C1D();
				num ^= 70131565U;
				float num43 = num42;
				num += 1801126754U;
				if ((1927887268U ^ num) != 0U)
				{
					goto Block_42;
				}
				goto IL_5A4;
				IL_67F:
				num -= 1095848735U;
				if (bool_1)
				{
					goto IL_8D2;
				}
				num = 1368941107U << (int)num;
				if (1075320420U <= num)
				{
					goto IL_8CF;
				}
			}
		}
		Block_12:
		void* ptr = intPtr2.ToPointer();
		GClass18.Class7 class7 = class2;
		num |= 1008407021U;
		object object_ = Pointer.Box(ptr, class7.vmethod_6());
		num = (135416483U | num);
		GClass18.Class7 class8 = class2;
		num = (380437506U | num);
		Type type_ = class8.vmethod_6();
		num |= 557016390U;
		return new GClass18.Class15(object_, type_);
		Block_30:
		goto IL_966;
		Block_32:
		num = 1105793703U + num;
		void* ptr2 = intPtr2.ToPointer();
		Type type = class3.vmethod_6();
		num = 1157958686U % num;
		object object_2 = Pointer.Box(ptr2, type);
		num %= 1291197268U;
		GClass18.Class7 class9 = class3;
		num = 2086828107U / num;
		return new GClass18.Class15(object_2, class9.vmethod_6());
		Block_34:
		long num44 = (long)num14;
		num = 1787131354U % num;
		long num45 = num44 + (long)num16;
		goto IL_75C;
		Block_36:
		long num46 = num17;
		num = 852963605U >> (int)num;
		long num47 = num46 + num40;
		goto IL_79A;
		Block_37:
		long num48 = num17;
		num >>= 17;
		num47 = checked(num48 + num40);
		num ^= 26030U;
		goto IL_79A;
		Block_42:
		num ^= 1750081258U;
		float float_;
		if (!bool_0)
		{
			float num41;
			float num49 = num41;
			num <<= 7;
			float num43;
			float num50 = num43;
			num |= 615194059U;
			float_ = num49 + num50;
		}
		else
		{
			num = 1622690949U + num;
			float num41;
			float num51 = num41;
			num += 1341356202U;
			float num43;
			float_ = num51 + num43;
			num ^= 1413095071U;
		}
		num <<= 18;
		return new GClass18.Class11(float_);
		Block_46:
		int num52 = num31;
		num = 1403587274U + num;
		int num53 = num32;
		num = 895309826U % num;
		int num54 = num52 + num53;
		goto IL_8B3;
		Block_50:
		goto IL_8BE;
		IL_730:
		num += 199063114U;
		long num55 = (long)num14;
		num = 1473609194U / num;
		long num56 = (long)num16;
		num >>= 16;
		num45 = checked(num55 + num56);
		num ^= 1787131354U;
		IL_75C:
		num /= 984680339U;
		long num57 = num45;
		goto IL_7B0;
		IL_79A:
		num = 107675864U - num;
		num57 = num47;
		num ^= 107649835U;
		IL_7B0:
		num /= 1335054285U;
		long long_ = num57;
		num = (1628459431U | num);
		return new GClass18.Class10(long_);
		IL_888:
		num |= 1588491119U;
		int num58 = num31;
		num = 881802454U + num;
		int num59 = num32;
		num <<= 17;
		num54 = checked(num58 + num59);
		num += 3568523266U;
		IL_8B3:
		num39 = num54;
		num ^= 401790978U;
		IL_8BE:
		int int_ = num39;
		num <<= 1;
		return new GClass18.Class9(int_);
		IL_8CF:
		GClass18.Class7 class10 = class7_0;
		goto IL_8E2;
		IL_8D2:
		class10 = class7_0.vmethod_5();
		num += 2839046617U;
		IL_8E2:
		double num60 = class10.vmethod_13();
		if (1457803520U <= num)
		{
			num = (65287982U | num);
			GClass18.Class7 class11;
			if (!bool_1)
			{
				num = 1948010862U + num;
				class11 = class7_1;
			}
			else
			{
				num = (198728157U & num);
				num ^= 1842358287U;
				class11 = class7_1.vmethod_5();
				num += 3725678489U;
			}
			double num61 = class11.vmethod_13();
			num = 1325091471U + num;
			double double_;
			if (!bool_0)
			{
				if (1488141048U >= num)
				{
					goto IL_966;
				}
				double_ = num60 + num61;
			}
			else
			{
				double_ = num60 + num61;
				num += 0U;
			}
			num = (1401433160U | num);
			return new GClass18.Class12(double_);
		}
		IL_966:
		throw new InvalidOperationException();
	}

	// Token: 0x0600062D RID: 1581 RVA: 0x00014D34 File Offset: 0x00012F34
	private unsafe GClass18.Class7 method_12(GClass18.Class7 class7_0, GClass18.Class7 class7_1, bool bool_0, bool bool_1)
	{
		uint num;
		TypeCode typeCode2;
		long num18;
		long num20;
		float num22;
		double num23;
		GClass18.Class15 class3;
		IntPtr intPtr2;
		ulong num27;
		ulong num28;
		ulong num30;
		ulong num31;
		long num33;
		long num34;
		int int_;
		float num40;
		double num42;
		for (;;)
		{
			IL_00:
			TypeCode typeCode = this.method_10(class7_0, class7_1);
			num = 71092U;
			typeCode2 = typeCode;
			int num10;
			for (;;)
			{
				uint num2 = (uint)typeCode2;
				num /= 357703980U;
				switch (num2 - (num ^ 9U))
				{
				case 0U:
					goto IL_5C6;
				case 1U:
				{
					num = 1835691784U + num;
					if (1194403315U + num == 0U)
					{
						continue;
					}
					num = 2125685634U % num;
					if (bool_1)
					{
						num -= 2104064356U;
						if (2144155215U * num == 0U)
						{
							goto IL_5C6;
						}
						uint num3 = class7_0.vmethod_11();
						num = 1947493498U / num;
						uint num4 = num3;
						num >>= 11;
						if (2059811221U >> (int)num == 0U)
						{
							goto IL_9B2;
						}
						uint num5 = class7_1.vmethod_11();
						num -= 1202353542U;
						uint num6 = num5;
						if (num << 24 == 0U)
						{
							goto IL_00;
						}
						num = 1914925838U * num;
						int num8;
						if (!bool_0)
						{
							num *= 1123310608U;
							if (2138641148U + num == 0U)
							{
								goto IL_5F8;
							}
							int num7 = (int)num4;
							num = 197594326U << (int)num;
							num8 = num7 - (int)num6;
						}
						else
						{
							num &= 2117993037U;
							int num9 = (int)num4;
							num &= 1401242783U;
							num8 = checked(num9 - (int)num6);
							num += 3418819786U;
						}
						num = 656491656U << (int)num;
						num10 = num8;
						if (1615332160U <= num)
						{
							goto IL_9B2;
						}
					}
					else
					{
						int num11 = class7_0.EC4893C4();
						num |= 165237500U;
						int num12 = class7_1.EC4893C4();
						num = 1795836943U % num;
						int num15;
						if (!bool_0)
						{
							if (num == 1307782736U)
							{
								goto IL_00;
							}
							int num13 = num11;
							num >>= 18;
							int num14 = num12;
							num >>= 31;
							num15 = num13 - num14;
						}
						else
						{
							num ^= 2124425956U;
							int num16 = num11;
							num *= 564680699U;
							int num17 = num12;
							num /= 28519650U;
							num15 = checked(num16 - num17);
							num += 4294967240U;
						}
						num -= 1045131822U;
						num10 = num15;
						num += 1615557166U;
					}
					if (num > 1969575022U)
					{
						goto IL_00;
					}
					TypeCode typeCode3 = class7_0.vmethod_7();
					TypeCode typeCode4 = typeCode2;
					num /= 1526079393U;
					if (typeCode3 == typeCode4)
					{
						goto IL_35F;
					}
					num >>= 14;
					if (num * 1616661871U != 0U)
					{
						continue;
					}
					goto IL_34D;
				}
				case 2U:
				{
					if ((2019305909U & num) != 0U)
					{
						goto IL_00;
					}
					if (bool_1)
					{
						goto IL_3C6;
					}
					num >>= 11;
					num18 = class7_0.DB9EABF5();
					if (num / 895762455U != 0U)
					{
						goto IL_00;
					}
					long num19 = class7_1.DB9EABF5();
					num /= 1031427051U;
					num20 = num19;
					if (bool_0)
					{
						goto IL_744;
					}
					num = 1159164155U * num;
					if (num * 1033452437U == 0U)
					{
						goto Block_12;
					}
					continue;
				}
				case 3U:
					goto IL_42E;
				case 4U:
				{
					if (372975567U < num)
					{
						goto IL_9B2;
					}
					GClass18.Class7 @class;
					if (!bool_1)
					{
						num = 2125361372U * num;
						@class = class7_0;
					}
					else
					{
						if (num + 2127459748U == 0U)
						{
							goto IL_5F8;
						}
						@class = class7_0.vmethod_5();
						num += 0U;
					}
					num = 1940655199U + num;
					float num21 = @class.B4B75C1D();
					num -= 919959489U;
					num22 = num21;
					if (1493124200U >= num)
					{
						goto Block_7;
					}
					continue;
				}
				case 5U:
				{
					if (748911181U <= num)
					{
						goto IL_00;
					}
					GClass18.Class7 class2;
					if (!bool_1)
					{
						class2 = class7_0;
					}
					else
					{
						class2 = class7_0.vmethod_5();
						num += 0U;
					}
					num23 = class2.vmethod_13();
					if (bool_1)
					{
						goto IL_677;
					}
					num /= 2146789112U;
					if (1844851083U + num != 0U)
					{
						goto Block_3;
					}
					continue;
				}
				}
				goto Block_25;
			}
			IL_5C6:
			uint num25;
			while ((num & 952661728U) == 0U)
			{
				num >>= 27;
				if (!bool_1)
				{
					goto IL_919;
				}
				if (564678606U >= num)
				{
					num <<= 23;
					uint num24 = class7_0.vmethod_11();
					num ^= 1924661921U;
					num25 = num24;
					num = (787507015U ^ num);
					break;
				}
			}
			goto IL_5F8;
			Block_25:
			if (1592671130U >= num)
			{
				goto Block_26;
			}
			continue;
			IL_36F:
			GClass18.Class15 class4;
			class3 = class4;
			num = (1340216969U & num);
			if (983067984U / num == 0U)
			{
				continue;
			}
			int value = num10;
			num = 1192240285U - num;
			IntPtr intPtr = new IntPtr(value);
			num = 721910615U << (int)num;
			intPtr2 = intPtr;
			num = 449779344U * num;
			if (554836686U < num)
			{
				goto Block_28;
			}
			continue;
			IL_35F:
			class4 = (GClass18.Class15)class7_0;
			num += 1041986557U;
			goto IL_36F;
			IL_34D:
			num = 1041986557U - num;
			class4 = (GClass18.Class15)class7_1;
			goto IL_36F;
			IL_3C6:
			if (8873106U >> (int)num == 0U)
			{
				continue;
			}
			ulong num26 = class7_0.vmethod_12();
			num <<= 8;
			num27 = num26;
			num &= 1122262568U;
			num28 = class7_1.vmethod_12();
			num %= 303046721U;
			if (bool_0)
			{
				goto IL_78E;
			}
			num = 653071559U >> (int)num;
			if (num + 1254826236U != 0U)
			{
				goto Block_31;
			}
			continue;
			IL_42E:
			if (num - 758727747U == 0U)
			{
				continue;
			}
			num <<= 15;
			if (bool_1)
			{
				num %= 1112294389U;
				ulong num29 = class7_0.vmethod_12();
				num = 487926126U + num;
				num30 = num29;
				num31 = class7_1.vmethod_12();
				num = 1775122597U >> (int)num;
				if (937634885U == num)
				{
					continue;
				}
				if (!bool_0)
				{
					num ^= 311372990U;
					if (1279746370U >= num)
					{
						goto Block_36;
					}
					continue;
				}
				else
				{
					if (num <= 1960203616U)
					{
						goto Block_37;
					}
					continue;
				}
			}
			else
			{
				num *= 629502890U;
				if (num * 1898264368U != 0U)
				{
					goto IL_9B2;
				}
				long num32 = class7_0.DB9EABF5();
				num = (1256275441U & num);
				num33 = num32;
				num = 102700586U + num;
				if (1465188382U >> (int)num == 0U)
				{
					continue;
				}
				num = (1936469460U & num);
				num34 = class7_1.DB9EABF5();
				num = 469968449U << (int)num;
				if (!bool_0)
				{
					goto IL_7FE;
				}
				num *= 2086412759U;
				if (num != 128778306U)
				{
					goto Block_41;
				}
				continue;
			}
			IL_5F8:
			num %= 1568550434U;
			uint num35 = class7_1.vmethod_11();
			num = 1473278000U - num;
			int num37;
			if (!bool_0)
			{
				num |= 751001151U;
				int num36 = (int)num25;
				num ^= 1237453500U;
				num37 = num36 - (int)num35;
			}
			else
			{
				num = 733563717U % num;
				if (478834681U >= num)
				{
					continue;
				}
				int num38 = (int)num25;
				int num39 = (int)num35;
				num >>= 15;
				num37 = checked(num38 - num39);
				num += 3054042449U;
			}
			int_ = num37;
			if (1599996121U < num)
			{
				goto Block_49;
			}
			continue;
			Block_7:
			GClass18.Class7 class5;
			if (!bool_1)
			{
				num *= 225455435U;
				class5 = class7_1;
			}
			else
			{
				num = (734662211U & num);
				num = (253196618U | num);
				class5 = class7_1.vmethod_5();
				num ^= 3117034752U;
			}
			num40 = class5.B4B75C1D();
			num = 506884119U / num;
			num += 941115106U;
			if (!bool_0)
			{
				goto IL_995;
			}
			if (1191513023U >> (int)num != 0U)
			{
				goto Block_44;
			}
			goto IL_5C6;
			IL_691:
			num = (863665572U ^ num);
			GClass18.Class7 class6;
			double num41 = class6.vmethod_13();
			num = (70531781U | num);
			num42 = num41;
			num >>= 0;
			if (!bool_0)
			{
				goto IL_9ED;
			}
			num = (1424239558U & num);
			if (1106782876U % num != 0U)
			{
				goto Block_51;
			}
			continue;
			IL_677:
			num = 373915270U + num;
			class6 = class7_1.vmethod_5();
			num ^= 373915270U;
			goto IL_691;
			Block_3:
			class6 = class7_1;
			goto IL_691;
		}
		Block_12:
		long num43 = num18;
		long num44 = num20;
		num = (239740529U ^ num);
		long num45 = num43 - num44;
		goto IL_766;
		Block_26:
		goto IL_9B2;
		Block_28:
		num = 1668753986U / num;
		void* ptr = intPtr2.ToPointer();
		num = 2079082279U * num;
		Type type = class3.vmethod_6();
		num = (2139882652U | num);
		object object_ = Pointer.Box(ptr, type);
		num += 819537842U;
		GClass18.Class7 class7 = class3;
		num = 1635677157U - num;
		Type type_ = class7.vmethod_6();
		num = 1855409247U - num;
		return new GClass18.Class15(object_, type_);
		Block_31:
		long num46 = (long)num27;
		num <<= 27;
		long num47 = num46 - (long)num28;
		goto IL_7A6;
		Block_36:
		long num48 = (long)num30;
		long num49 = (long)num31;
		num = 1187412806U << (int)num;
		long num50 = num48 - num49;
		goto IL_7EA;
		Block_37:
		long num51 = (long)num30;
		num &= 979989634U;
		num50 = checked(num51 - (long)num31);
		num += 2979900800U;
		goto IL_7EA;
		Block_41:
		long num52 = checked(num33 - num34);
		num += 3273597259U;
		goto IL_829;
		Block_44:
		float num53 = num22;
		num -= 488192377U;
		float num54 = num40;
		num = 1809408729U - num;
		float float_ = num53 - num54;
		num += 3879596402U;
		goto IL_99A;
		Block_49:
		goto IL_9A0;
		Block_51:
		double num55 = num23;
		num -= 1386898820U;
		double num56 = num42;
		num *= 1245276039U;
		double double_ = num55 - num56;
		num ^= 3162846245U;
		goto IL_9F2;
		IL_744:
		num += 560296036U;
		long num57 = num18;
		long num58 = num20;
		num <<= 11;
		num45 = checked(num57 - num58);
		num ^= 633931377U;
		IL_766:
		num += 1619346180U;
		long long_ = num45;
		num ^= 1859086708U;
		goto IL_7B2;
		IL_78E:
		long num59 = (long)num27;
		num = 1628921856U + num;
		num47 = checked(num59 - (long)num28);
		num += 3605569536U;
		IL_7A6:
		num = 1079317936U / num;
		long_ = num47;
		IL_7B2:
		return new GClass18.Class10(long_);
		IL_7EA:
		long value2 = num50;
		goto IL_834;
		IL_7FE:
		num = 936338655U >> (int)num;
		if (num == 1992968755U)
		{
			goto IL_9B2;
		}
		long num60 = num33;
		num *= 1886082110U;
		num52 = num60 - num34;
		IL_829:
		value2 = num52;
		num += 3297783454U;
		IL_834:
		TypeCode typeCode5 = class7_0.vmethod_7();
		num *= 1077888534U;
		TypeCode typeCode6 = typeCode2;
		num -= 1483037161U;
		GClass18.Class15 class8;
		if (typeCode5 != typeCode6)
		{
			num += 1878289318U;
			if ((num & 2064342318U) == 0U)
			{
				goto IL_9B2;
			}
			class8 = (GClass18.Class15)class7_1;
		}
		else
		{
			class8 = (GClass18.Class15)class7_0;
			num += 1878289318U;
		}
		num &= 1545679141U;
		GClass18.Class15 class9 = class8;
		intPtr2 = new IntPtr(value2);
		num = (1990539010U & num);
		num |= 1124483986U;
		void* ptr2 = intPtr2.ToPointer();
		num = 291323798U - num;
		Type type2 = class9.vmethod_6();
		num = 757421726U * num;
		object object_2 = Pointer.Box(ptr2, type2);
		num *= 196963879U;
		Type type_2 = class9.vmethod_6();
		num ^= 1976466675U;
		return new GClass18.Class15(object_2, type_2);
		IL_919:
		num = 188638118U * num;
		int num61 = class7_0.EC4893C4();
		if (42472903U * num == 0U)
		{
			int num62 = class7_1.EC4893C4();
			num /= 267735023U;
			int num63 = num62;
			int num64;
			if (!bool_0)
			{
				num *= 1023548267U;
				num64 = num61 - num63;
			}
			else
			{
				num ^= 860120515U;
				if (1564548050U < num)
				{
					goto IL_9B2;
				}
				int num65 = num61;
				int num66 = num63;
				num = 455416638U + num;
				num64 = checked(num65 - num66);
				num += 2979430143U;
			}
			int_ = num64;
			num ^= 3054064835U;
			goto IL_9A0;
		}
		goto IL_9B2;
		IL_995:
		float_ = num22 - num40;
		IL_99A:
		return new GClass18.Class11(float_);
		IL_9A0:
		num %= 1663054427U;
		return new GClass18.Class9(int_);
		IL_9B2:
		num = 1636256690U << (int)num;
		throw new InvalidOperationException();
		IL_9ED:
		double_ = num23 - num42;
		IL_9F2:
		return new GClass18.Class12(double_);
	}

	// Token: 0x0600062E RID: 1582 RVA: 0x00015738 File Offset: 0x00013938
	private GClass18.Class7 method_13(GClass18.Class7 class7_0, GClass18.Class7 class7_1, bool bool_0, bool bool_1)
	{
		uint num = 1174025797U;
		long num8;
		long num10;
		long num12;
		double num16;
		double num18;
		int num19;
		int num21;
		int num27;
		for (;;)
		{
			num *= 1812545929U;
			TypeCode typeCode = this.method_10(class7_0, class7_1);
			int num2 = typeCode - (TypeCode)(num ^ 4279996388U);
			num <<= 28;
			switch (num2)
			{
			case 0:
				break;
			case 1:
			case 3:
				goto IL_15F;
			case 2:
				num += 1115447946U;
				if (bool_1)
				{
					num = (569123636U | num);
					ulong num3 = class7_0.vmethod_12();
					num = 960981609U / num;
					ulong num4 = num3;
					num |= 2129868533U;
					ulong num5 = class7_1.vmethod_12();
					num = (1097557461U ^ num);
					long num7;
					if (!bool_0)
					{
						if (num > 1524521438U)
						{
							continue;
						}
						long num6 = (long)num4;
						num ^= 2054947389U;
						num7 = num6 * (long)num5;
					}
					else
					{
						num7 = (long)(checked(num4 * num5));
						num += 105643517U;
					}
					num = 843459855U % num;
					num8 = num7;
					if (num / 1852709540U == 0U)
					{
						goto Block_25;
					}
					continue;
				}
				else
				{
					if ((num ^ 350846390U) == 0U)
					{
						goto IL_15F;
					}
					long num9 = class7_0.DB9EABF5();
					num ^= 2031367673U;
					num10 = num9;
					long num11 = class7_1.DB9EABF5();
					num = 1778548081U << (int)num;
					num12 = num11;
					num = (907879617U & num);
					if (!bool_0)
					{
						if (num * 1963424553U != 0U)
						{
							goto Block_28;
						}
						goto IL_15F;
					}
					else
					{
						num %= 1381588098U;
						if (68227911U != num)
						{
							goto Block_29;
						}
						continue;
					}
				}
				break;
			case 4:
			{
				num <<= 12;
				if ((184040359U & num) != 0U)
				{
					goto IL_16C;
				}
				num *= 957310396U;
				GClass18.Class7 @class;
				if (!bool_1)
				{
					if (1247158379U >> (int)num == 0U)
					{
						continue;
					}
					@class = class7_0;
				}
				else
				{
					num <<= 18;
					@class = class7_0.vmethod_5();
					num ^= 0U;
				}
				num = 622994083U << (int)num;
				float num13 = @class.B4B75C1D();
				num &= 1285631470U;
				float num14 = num13;
				num -= 1110399827U;
				if (!bool_1)
				{
					goto IL_43E;
				}
				if (num >= 481501324U)
				{
					goto Block_21;
				}
				goto IL_18B;
			}
			case 5:
			{
				if (num << 28 != 0U)
				{
					continue;
				}
				num /= 192874006U;
				GClass18.Class7 class2;
				if (!bool_1)
				{
					if (2059488818U - num == 0U)
					{
						break;
					}
					class2 = class7_0;
				}
				else
				{
					class2 = class7_0.vmethod_5();
					num ^= 0U;
				}
				double num15 = class2.vmethod_13();
				num = (1471378980U & num);
				num16 = num15;
				num ^= 866997292U;
				GClass18.Class7 class3;
				if (!bool_1)
				{
					class3 = class7_1;
				}
				else
				{
					num -= 1098335939U;
					if (1073354624 << (int)num == 0)
					{
						goto IL_15F;
					}
					num = 696987788U + num;
					class3 = class7_1.vmethod_5();
					num += 401348151U;
				}
				num <<= 19;
				double num17 = class3.vmethod_13();
				num ^= 293494005U;
				num18 = num17;
				num = 11894688U - num;
				if (bool_0)
				{
					goto IL_527;
				}
				num = 152200166U * num;
				if (613356909U * num == 0U)
				{
					goto IL_15F;
				}
				goto IL_50C;
			}
			default:
				num ^= 0U;
				goto IL_15F;
			}
			num = 1433935216U % num;
			num = 534261360U / num;
			if (bool_1)
			{
				if (num == 2050953476U)
				{
					continue;
				}
			}
			else
			{
				num19 = class7_0.EC4893C4();
				num &= 1683578857U;
				int num20 = class7_1.EC4893C4();
				num = (1505574445U & num);
				num21 = num20;
				if (43941023U <= num)
				{
					continue;
				}
				if (!bool_0)
				{
					if (num < 1385982505U)
					{
						break;
					}
					goto IL_18B;
				}
				else
				{
					if (1629965368U > num)
					{
						goto Block_9;
					}
					continue;
				}
			}
			IL_16C:
			uint num22 = class7_0.vmethod_11();
			num = 1472987809U - num;
			uint num23 = num22;
			if (1015091705U % num != 0U)
			{
				goto IL_18B;
			}
			continue;
			IL_15F:
			if ((1070038656U ^ num) == 0U)
			{
				goto IL_16C;
			}
			goto IL_55A;
			IL_18B:
			uint num24 = class7_1.vmethod_11();
			num %= 354832378U;
			if (num != 881294987U)
			{
				int num26;
				if (!bool_0)
				{
					num += 1850372557U;
					int num25 = (int)num23;
					num += 755372900U;
					num26 = num25 * (int)num24;
				}
				else
				{
					num ^= 1647141678U;
					if (721975433U == num)
					{
						continue;
					}
					num26 = (int)(checked(num23 * num24));
					num += 1029940819U;
				}
				num27 = num26;
				if (950879610U % num != 0U)
				{
					goto Block_16;
				}
			}
		}
		int num28 = num19;
		num = 969959221U + num;
		int num29 = num21;
		num = 820258330U >> (int)num;
		int num30 = num28 * num29;
		goto IL_4F4;
		Block_9:
		int num31 = num19;
		num += 1231121163U;
		int num32 = num21;
		num ^= 1815555934U;
		num30 = checked(num31 * num32);
		num += 3668557106U;
		goto IL_4F4;
		Block_16:
		goto IL_560;
		Block_21:
		num = 79901751U >> (int)num;
		GClass18.Class7 class4 = class7_1.vmethod_5();
		num += 3253779401U;
		goto IL_43F;
		Block_25:
		goto IL_400;
		Block_28:
		long num33 = num10 * num12;
		goto IL_3F4;
		Block_29:
		num33 = checked(num10 * num12);
		num ^= 0U;
		IL_3F4:
		num8 = num33;
		num ^= 273558799U;
		IL_400:
		num /= 1881891995U;
		long long_ = num8;
		num *= 1852335738U;
		return new GClass18.Class10(long_);
		IL_43E:
		class4 = class7_1;
		IL_43F:
		float num34 = class4.B4B75C1D();
		num = 1109417717U - num;
		float num35 = num34;
		num <<= 12;
		double num38;
		if (!bool_0)
		{
			float num14;
			double num36 = (double)num14;
			double num37 = (double)num35;
			num &= 1217419304U;
			num38 = num36 * num37;
		}
		else
		{
			num <<= 26;
			float num14;
			double num39 = (double)num14;
			double num40 = (double)num35;
			num *= 423782787U;
			num38 = num39 * num40;
			num ^= 1217413120U;
		}
		num -= 688152843U;
		double double_ = num38;
		num = 1555452832U >> (int)num;
		return new GClass18.Class12(double_);
		IL_4F4:
		num = 1158110320U % num;
		num27 = num30;
		num += 2659403372U;
		goto IL_560;
		IL_50C:
		double num41 = num16;
		num |= 955282726U;
		double num42 = num18;
		num ^= 1061423997U;
		double double_2 = num41 * num42;
		goto IL_54A;
		IL_527:
		num = (1145902953U & num);
		double num43 = num16;
		double num44 = num18;
		num = 1277391400U * num;
		double_2 = num43 * num44;
		num += 2405033075U;
		IL_54A:
		num *= 691948017U;
		return new GClass18.Class12(double_2);
		IL_55A:
		throw new InvalidOperationException();
		IL_560:
		int int_ = num27;
		num = 1642738670U >> (int)num;
		return new GClass18.Class9(int_);
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x00015CBC File Offset: 0x00013EBC
	private GClass18.Class7 method_14(GClass18.Class7 class7_0, GClass18.Class7 class7_1, bool bool_0)
	{
		uint num = 723596556U;
		int int_;
		for (;;)
		{
			num &= 1099379918U;
			switch (this.method_10(class7_0, class7_1) - (TypeCode)(num - 16856067U))
			{
			case 0:
				if (171195372U >= num)
				{
					if (!bool_0)
					{
						goto IL_74;
					}
					num <<= 25;
					if (1110130165U > num)
					{
						goto IL_8C;
					}
					continue;
				}
				break;
			case 1:
			case 3:
				break;
			case 2:
				if (859051117U == num)
				{
					goto IL_8C;
				}
				if (!bool_0)
				{
					goto IL_1C7;
				}
				if (num > 752833894U)
				{
					goto IL_74;
				}
				goto IL_19F;
			case 4:
				goto IL_214;
			case 5:
				num = 1928154239U >> (int)num;
				num %= 1836520276U;
				if (!bool_0)
				{
					goto IL_2A7;
				}
				if (65099803U / num != 0U)
				{
					goto Block_2;
				}
				continue;
			default:
				num ^= 0U;
				break;
			}
			num /= 1434066250U;
			if (num != 117268271U)
			{
				goto Block_3;
			}
			continue;
			IL_74:
			num ^= 816389893U;
			if (num <= 1813208771U)
			{
				goto Block_6;
			}
			continue;
			IL_8C:
			int num2 = (int)class7_0.vmethod_11();
			num = (346116045U & num);
			uint num3 = class7_1.vmethod_11();
			num %= 322643006U;
			int num4 = (int)num3;
			num = 1240094740U >> (int)num;
			int_ = num2 / num4;
			if (989926971U != num)
			{
				goto Block_7;
			}
		}
		Block_2:
		GClass18.Class7 @class = class7_0.vmethod_5();
		num ^= 119034112U;
		goto IL_2B2;
		Block_3:
		throw new InvalidOperationException();
		Block_6:
		int num5 = class7_0.EC4893C4();
		num = 765944257U << (int)num;
		int num6 = class7_1.EC4893C4();
		num = 394294060U << (int)num;
		int num7 = num6;
		num ^= 168001118U;
		int num8 = num7;
		num ^= 1902001483U;
		int num9 = num5 / num8;
		num ^= 1323514497U;
		int_ = num9;
		num ^= 1809076908U;
		Block_7:
		goto IL_206;
		IL_19F:
		long num10 = (long)class7_0.vmethod_12();
		num = (703597976U & num);
		ulong num11 = class7_1.vmethod_12();
		long num12 = num10 / (long)num11;
		num = (256799112U & num);
		long num13 = num12;
		goto IL_1EB;
		IL_1C7:
		long num14 = class7_0.DB9EABF5();
		long num15 = class7_1.DB9EABF5();
		long num16 = num14 / num15;
		num = 1090346942U + num;
		num13 = num16;
		num += 3204541502U;
		IL_1EB:
		num ^= 1612448482U;
		long long_ = num13;
		num = (1156871784U ^ num);
		return new GClass18.Class10(long_);
		IL_206:
		return new GClass18.Class9(int_);
		IL_214:
		num <<= 18;
		GClass18.Class7 class2;
		if (!bool_0)
		{
			class2 = class7_0;
		}
		else
		{
			num = (861692584U ^ num);
			class2 = class7_0.vmethod_5();
			num += 3972242776U;
		}
		float num17 = class2.B4B75C1D();
		GClass18.Class7 class3;
		if (!bool_0)
		{
			class3 = class7_1;
		}
		else
		{
			num = 828457746U * num;
			class3 = class7_1.vmethod_5();
			num ^= 3813670912U;
		}
		float num18 = class3.B4B75C1D();
		num += 2126593749U;
		float num19 = num18;
		num -= 2059684915U;
		float num20 = num19;
		num = 1503017702U << (int)num;
		return new GClass18.Class11(num17 / num20);
		IL_2A7:
		num = (119438660U | num);
		@class = class7_0;
		IL_2B2:
		num = 106038764U << (int)num;
		double num21 = @class.vmethod_13();
		num = 128733307U / num;
		num = (447505537U ^ num);
		GClass18.Class7 class4;
		if (!bool_0)
		{
			num = 247338546U - num;
			class4 = class7_1;
		}
		else
		{
			num &= 1124886287U;
			num &= 220213887U;
			class4 = class7_1.vmethod_5();
			num += 4094792112U;
		}
		double num22 = class4.vmethod_13();
		num = 1560364639U >> (int)num;
		double num23 = num22;
		num = 1889629478U >> (int)num;
		double num24 = num23;
		num |= 701113620U;
		double double_ = num21 / num24;
		num /= 64692880U;
		return new GClass18.Class12(double_);
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x0001601C File Offset: 0x0001421C
	private GClass18.Class7 method_15(GClass18.Class7 class7_0, GClass18.Class7 class7_1, bool bool_0)
	{
		TypeCode typeCode = class7_0.vmethod_7();
		uint num = 2968313276U;
		for (;;)
		{
			TypeCode typeCode2 = typeCode;
			uint num2 = num ^ 2968313269U;
			num = (1646811245U | num);
			if (typeCode2 != num2)
			{
				num <<= 26;
				goto IL_2C;
			}
			for (;;)
			{
				IL_66:
				num &= 956115558U;
				if (!bool_0)
				{
					break;
				}
				num = 1712877927U % num;
				if (num <= 507537022U)
				{
					goto IL_9C;
				}
			}
			num /= 1168716043U;
			if (num / 1559101966U == 0U)
			{
				goto IL_164;
			}
			IL_2C:
			TypeCode typeCode3 = typeCode;
			num = 2032880267U - num;
			uint num3 = num - 2234206848U;
			num = 2147316895U >> (int)num;
			if (typeCode3 != num3)
			{
				if (1273312358U != num)
				{
					break;
				}
				goto IL_66;
			}
			else if (num >> 18 != 0U)
			{
				goto Block_4;
			}
		}
		throw new InvalidOperationException();
		Block_4:
		num = 2006081116U % num;
		if (bool_0)
		{
			long num4 = (long)class7_0.vmethod_12();
			num /= 748427267U;
			num = 1228878786U + num;
			ulong num5 = class7_1.vmethod_12();
			num = (1000232576U | num);
			ulong num6 = num5;
			num |= 534601811U;
			return new GClass18.Class10(num4 % (long)num6);
		}
		num <<= 6;
		long num7 = class7_0.DB9EABF5();
		num = (971386869U & num);
		long num8 = class7_1.DB9EABF5();
		num = 1458321729U + num;
		long num9 = num8;
		num &= 1018586546U;
		long num10 = num9;
		num >>= 3;
		long long_ = num7 % num10;
		num = 1431336637U >> (int)num;
		return new GClass18.Class10(long_);
		IL_9C:
		int num11 = (int)class7_0.vmethod_11();
		num = 90650302U - num;
		uint num12 = class7_1.vmethod_11();
		num = 1590692666U / num;
		uint num13 = num12;
		num = (1989812965U & num);
		int num14 = (int)num13;
		num /= 1693472751U;
		return new GClass18.Class9(num11 % num14);
		IL_164:
		num /= 898255089U;
		int num15 = class7_0.EC4893C4();
		num = 592859620U * num;
		num ^= 1654990333U;
		int num16 = class7_1.EC4893C4();
		num = 1567190000U << (int)num;
		int num17 = num16;
		int num18 = num17;
		num *= 398332027U;
		return new GClass18.Class9(num15 % num18);
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x000161D4 File Offset: 0x000143D4
	private GClass18.Class7 method_16(GClass18.Class7 class7_0, GClass18.Class7 class7_1)
	{
		uint num2;
		for (;;)
		{
			TypeCode typeCode = this.method_10(class7_0, class7_1);
			int num = typeCode - TypeCode.Int32;
			num2 = 790497838U;
			switch (num)
			{
			case 0:
				num2 = 1577413586U % num2;
				if (1262321129U >> (int)num2 != 0U)
				{
					goto Block_9;
				}
				continue;
			case 1:
			case 3:
				break;
			case 2:
				goto IL_146;
			case 4:
				if (num2 - 462771447U != 0U)
				{
					int size = IntPtr.Size;
					num2 = 1887243943U - num2;
					uint num3 = num2 - 1096746101U;
					num2 /= 10646345U;
					if (size == num3)
					{
						goto IL_190;
					}
					if (1512012145 << (int)num2 != 0)
					{
						goto Block_8;
					}
					continue;
				}
				break;
			case 5:
				num2 = 452068819U + num2;
				if (735123167U * num2 != 0U)
				{
					int size2 = IntPtr.Size;
					uint num4 = num2 ^ 1242566661U;
					num2 = (1986750905U | num2);
					if (size2 != num4)
					{
						num2 >>= 28;
						if (num2 % 1128749160U != 0U)
						{
							goto Block_3;
						}
						continue;
					}
					else
					{
						if (54345852U <= num2)
						{
							goto Block_4;
						}
						continue;
					}
				}
				break;
			default:
				num2 ^= 0U;
				break;
			}
			num2 ^= 1810719716U;
			if (num2 / 116588889U != 0U)
			{
				goto Block_5;
			}
		}
		Block_3:
		double double_ = 0.0;
		goto IL_1D7;
		Block_4:
		double_ = double.NaN;
		num2 ^= 2122021310U;
		goto IL_1D7;
		Block_5:
		throw new InvalidOperationException();
		Block_8:
		float float_ = 0f;
		goto IL_1A5;
		Block_9:
		num2 = 588516563U + num2;
		int num5 = class7_0.EC4893C4();
		num2 = 239365625U * num2;
		num2 = 896821782U / num2;
		int num6 = class7_1.EC4893C4();
		return new GClass18.Class9(num5 ^ num6);
		IL_146:
		num2 += 1428488260U;
		long num7 = class7_0.DB9EABF5();
		num2 = 333132657U >> (int)num2;
		long num8 = class7_1.DB9EABF5();
		num2 = 979983391U + num2;
		long num9 = num8;
		num2 = 1846756269U - num2;
		long num10 = num9;
		num2 >>= 2;
		return new GClass18.Class10(num7 ^ num10);
		IL_190:
		num2 = 664367959U + num2;
		float_ = float.NaN;
		num2 += 3630599337U;
		IL_1A5:
		num2 >>= 6;
		return new GClass18.Class11(float_);
		IL_1D7:
		num2 = 1373640880U * num2;
		return new GClass18.Class12(double_);
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x000163C8 File Offset: 0x000145C8
	private GClass18.Class7 method_17(GClass18.Class7 class7_0, GClass18.Class7 class7_1)
	{
		uint num = 2083206233U;
		for (;;)
		{
			num %= 820905616U;
			num = (951784022U | num);
			TypeCode typeCode = this.method_10(class7_0, class7_1);
			num = 1956340467U - num;
			TypeCode typeCode2 = typeCode;
			num = (604511871U & num);
			for (;;)
			{
				object obj = typeCode2;
				object obj2 = num ^ 537397885U;
				num = 2061960550U / num;
				object obj3 = obj - obj2;
				num ^= 524305120U;
				switch (obj3)
				{
				case 0:
					goto IL_101;
				case 1:
				case 3:
					goto IL_199;
				case 2:
					goto IL_11E;
				case 4:
				{
					num = 1244274499U << (int)num;
					if (num - 643196587U == 0U)
					{
						continue;
					}
					int size = IntPtr.Size;
					num *= 951929906U;
					uint num2 = num + 808978260U;
					num = 1839289006U + num;
					if (size != num2)
					{
						goto Block_2;
					}
					num = 274756985U >> (int)num;
					if (31409936U < num)
					{
						continue;
					}
					goto IL_162;
				}
				case 5:
					goto IL_9E;
				}
				break;
			}
			if (num != 973931488U)
			{
				goto Block_4;
			}
			continue;
			IL_9E:
			num <<= 12;
			if (IntPtr.Size != (int)(num ^ 70135812U))
			{
				goto Block_5;
			}
			if (num != 406286464U)
			{
				goto Block_6;
			}
		}
		do
		{
			IL_199:
			num = (1444313305U | num);
		}
		while (2108513075U >> (int)num == 0U);
		throw new InvalidOperationException();
		Block_2:
		num %= 365723114U;
		float float_ = 0f;
		goto IL_16F;
		Block_4:
		num ^= 0U;
		goto IL_199;
		Block_5:
		num ^= 1190492717U;
		double double_;
		if (num >= 1024539418U)
		{
			double_ = 0.0;
			goto IL_1C7;
		}
		goto IL_199;
		Block_6:
		double_ = double.NaN;
		num += 1051531821U;
		goto IL_1C7;
		IL_101:
		num = 1259634281U / num;
		int num3 = class7_0.EC4893C4();
		int num4 = class7_1.EC4893C4();
		return new GClass18.Class9(num3 | num4);
		IL_11E:
		num += 1090803421U;
		long num5 = class7_0.DB9EABF5();
		num += 1919966479U;
		long num6 = class7_1.DB9EABF5();
		num &= 1125652689U;
		long num7 = num6;
		num |= 417878558U;
		return new GClass18.Class10(num5 | num7);
		IL_162:
		float_ = float.NaN;
		num ^= 298864522U;
		IL_16F:
		num = (1736385992U | num);
		return new GClass18.Class11(float_);
		IL_1C7:
		return new GClass18.Class12(double_);
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x000165A4 File Offset: 0x000147A4
	private GClass18.Class7 method_18(GClass18.Class7 class7_0, GClass18.Class7 class7_1)
	{
		uint num;
		for (;;)
		{
			TypeCode typeCode = this.method_10(class7_0, class7_1);
			num = 564589401U;
			for (;;)
			{
				switch (typeCode - (TypeCode)(num ^ 564589392U))
				{
				case 0:
					goto IL_BC;
				case 1:
				case 3:
					goto IL_D2;
				case 2:
					goto IL_C9;
				case 4:
					if ((1755862311U ^ num) != 0U)
					{
						if (IntPtr.Size == (int)(num ^ 564589405U))
						{
							goto IL_E7;
						}
						num += 1128168959U;
						if (730861357U * num != 0U)
						{
							goto Block_4;
						}
					}
					break;
				case 5:
				{
					num |= 582515581U;
					int size = IntPtr.Size;
					num = 1961886604U - num;
					uint num2 = num + 2932799477U;
					num = 326765578U * num;
					if (size == num2)
					{
						goto IL_180;
					}
					if (num << 22 != 0U)
					{
						goto Block_1;
					}
					break;
				}
				default:
					if (num * 361003482U != 0U)
					{
						goto IL_B2;
					}
					break;
				}
			}
			IL_BC:
			if (num <= 790128872U)
			{
				goto Block_6;
			}
			continue;
			IL_D2:
			num = 39019786U / num;
			if (1137263282U != num)
			{
				goto Block_7;
			}
			continue;
			IL_B2:
			num += 0U;
			goto IL_D2;
			IL_E7:
			num = 929455156U << (int)num;
			if (2143764031U - num != 0U)
			{
				goto Block_8;
			}
			continue;
			IL_C9:
			if ((num ^ 594935999U) == 0U)
			{
				goto IL_D2;
			}
			goto IL_128;
		}
		Block_1:
		double double_ = 0.0;
		goto IL_199;
		Block_4:
		float float_ = 0f;
		goto IL_16F;
		Block_6:
		num = (1212287278U & num);
		int num3 = class7_0.EC4893C4();
		num &= 1287390511U;
		int num4 = class7_1.EC4893C4();
		return new GClass18.Class9(num3 & num4);
		Block_7:
		throw new InvalidOperationException();
		Block_8:
		float_ = float.NaN;
		num += 4242895192U;
		goto IL_16F;
		IL_128:
		num = 5526523U % num;
		long num5 = class7_0.DB9EABF5();
		num *= 1429144492U;
		long num6 = class7_1.DB9EABF5();
		num >>= 30;
		long num7 = num6;
		return new GClass18.Class10(num5 & num7);
		IL_16F:
		return new GClass18.Class11(float_);
		IL_180:
		num <<= 28;
		double_ = double.NaN;
		num += 208733334U;
		IL_199:
		return new GClass18.Class12(double_);
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x00016750 File Offset: 0x00014950
	private int method_19(GClass18.Class7 class7_0, GClass18.Class7 class7_1, bool bool_0, int int_1)
	{
		uint num = 1913405818U;
		object obj2;
		for (;;)
		{
			IL_4F7:
			int num2 = int_1;
			num %= 902965598U;
			for (;;)
			{
				IL_495:
				TypeCode typeCode = class7_0.vmethod_7();
				if (201334994U * num != 0U)
				{
					TypeCode typeCode2;
					double num8;
					float num11;
					for (;;)
					{
						num >>= 4;
						typeCode2 = class7_1.vmethod_7();
						num = 907612408U << (int)num;
						for (;;)
						{
							TypeCode typeCode3 = typeCode;
							uint num3 = num ^ 3364339713U;
							num = 1882075409U / num;
							if (typeCode3 == num3)
							{
								goto IL_4B5;
							}
							TypeCode typeCode4 = typeCode2;
							num += 49634255U;
							uint num4 = num ^ 49634254U;
							num /= 1744845228U;
							if (typeCode4 == num4)
							{
								goto Block_1;
							}
							num |= 521238203U;
							TypeCode typeCode5 = typeCode;
							uint num5 = num - 521238189U;
							num &= 1905808454U;
							if (typeCode5 != num5)
							{
								uint num6 = (uint)typeCode2;
								num <<= 31;
								if (num6 != (num ^ 14U))
								{
									break;
								}
								num ^= 286282754U;
							}
							if (1844125267U / num == 0U)
							{
								goto IL_495;
							}
							double num7 = class7_0.vmethod_13();
							num = (902195318U & num);
							num8 = num7;
							num = 1741897041U + num;
							if (num >= 1654800330U)
							{
								goto IL_3C0;
							}
						}
						TypeCode typeCode6 = typeCode;
						uint num9 = num ^ 13U;
						num = 1931366860U + num;
						if (typeCode6 != num9)
						{
							num = (1684146468U ^ num);
							TypeCode typeCode7 = typeCode2;
							uint num10 = num ^ 394025189U;
							num *= 1471826640U;
							if (typeCode7 != num10)
							{
								break;
							}
							num ^= 72686924U;
						}
						if (309465948U >= num)
						{
							goto IL_4F7;
						}
						num = 1440763359U - num;
						num11 = class7_0.B4B75C1D();
						if ((610469469U ^ num) != 0U)
						{
							goto IL_386;
						}
					}
					TypeCode typeCode8 = typeCode;
					num = (168520180U & num);
					uint num12 = num ^ 34293899U;
					num = 1084757377U / num;
					if (typeCode8 != num12)
					{
						if (num >= 1612982675U)
						{
							goto IL_4F7;
						}
						TypeCode typeCode9 = typeCode2;
						num = 1830579960U % num;
						uint num13 = num + 4294967293U;
						num = (964525489U & num);
						if (typeCode9 == num13)
						{
							num ^= 31U;
						}
						else
						{
							num = 266544136U << (int)num;
							TypeCode typeCode10 = typeCode;
							uint num14 = num ^ 266544129U;
							num *= 495665563U;
							if (typeCode10 != num14)
							{
								if (450912180U > num)
								{
									goto IL_4F7;
								}
								TypeCode typeCode11 = typeCode2;
								uint num15 = num - 3271874767U;
								num += 1980746628U;
								if (typeCode11 != num15)
								{
									goto IL_3FE;
								}
								num += 2314220668U;
							}
							if (num >= 1418948695U)
							{
								num += 1221068387U;
								int num17;
								if (!bool_0)
								{
									if (num == 811216793U)
									{
										goto IL_4F7;
									}
									int num16 = class7_0.EC4893C4();
									num = (1088560229U & num);
									num17 = num16.CompareTo(class7_1.EC4893C4());
								}
								else
								{
									num %= 817517171U;
									if (1195586983U * num == 0U)
									{
										goto IL_4F7;
									}
									num = 2011571576U >> (int)num;
									uint num18 = class7_0.vmethod_11();
									if (711921535U >> (int)num == 0U)
									{
										continue;
									}
									uint value = class7_1.vmethod_11();
									num <<= 22;
									num17 = num18.CompareTo(value);
									num += 4248837153U;
								}
								num2 = num17;
								num += 945063995U;
								goto IL_3FE;
							}
							continue;
						}
					}
					int num21;
					if (!bool_0)
					{
						long num19 = class7_0.DB9EABF5();
						num /= 7213076U;
						long num20 = num19;
						num = (1461150410U & num);
						if (num >= 2031306937U)
						{
							goto IL_4F7;
						}
						num = 1833991580U * num;
						num += 1043865622U;
						num21 = num20.CompareTo(class7_1.DB9EABF5());
					}
					else
					{
						num /= 1921141270U;
						if (num - 229451100U == 0U)
						{
							continue;
						}
						num = 1381043588U >> (int)num;
						ulong num22 = class7_0.vmethod_12();
						if (601377678U >= num)
						{
							goto IL_508;
						}
						num = 1345016418U - num;
						ulong value2 = class7_1.vmethod_12();
						num = 834146217U + num;
						num21 = num22.CompareTo(value2);
						num += 245746575U;
					}
					num /= 227368067U;
					num2 = num21;
					num ^= 957654104U;
					IL_3FE:
					uint num23 = (uint)num2;
					num ^= 345656943U;
					if (num23 < (num ^ 764340787U))
					{
						num = (1079792771U | num);
						int num24 = (int)(num - 1843330740U);
						num -= 1530473995U;
						num2 = num24;
						if (num * 1978280991U == 0U)
						{
							continue;
						}
					}
					else
					{
						num /= 576086041U;
						int num25 = num2;
						uint num26 = num + uint.MaxValue;
						num %= 1978074045U;
						num ^= 312856745U;
						if (num25 > num26)
						{
							num |= 2034457614U;
							int num27 = (int)(num + 2216174419U);
							num /= 1091071911U;
							num2 = num27;
							num += 312856743U;
						}
					}
					if (2058318432U <= num)
					{
						continue;
					}
					return num2;
					IL_3C0:
					num ^= 2052406198U;
					double value3 = class7_1.vmethod_13();
					num -= 1593469188U;
					int num28 = num8.CompareTo(value3);
					num = 1915308217U >> (int)num;
					num2 = num28;
					if (1129390374U > num)
					{
						goto IL_3FE;
					}
					goto IL_4F7;
					IL_386:
					num |= 1406933023U;
					int num29 = num11.CompareTo(class7_1.B4B75C1D());
					num /= 267596646U;
					num2 = num29;
					if (1551975853U > num)
					{
						num += 957654093U;
						goto IL_3FE;
					}
					goto IL_4F7;
				}
			}
			IL_4B5:
			num <<= 7;
			object obj = class7_0.vmethod_1();
			obj2 = class7_1.vmethod_1();
			object obj3 = obj2;
			num = 0U;
			if (obj == obj3)
			{
				break;
			}
			num = 1291287417U - num;
			if (928804289U >= num)
			{
				continue;
			}
			goto IL_511;
			Block_1:
			num += 0U;
			goto IL_4B5;
		}
		IL_508:
		return (int)(num ^ 0U);
		IL_511:
		bool flag = obj2 != null;
		num = (63846098U ^ num);
		if (flag)
		{
			return (int)(num ^ 2965811796U);
		}
		return (int)(num + 2965811798U);
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x00016C90 File Offset: 0x00014E90
	private GClass18.Class7 method_20(GClass18.Class7 class7_0)
	{
		uint num = 1614167842U;
		for (;;)
		{
			num = (1724939636U ^ num);
			TypeCode typeCode = class7_0.vmethod_7();
			TypeCode typeCode2 = typeCode;
			num <<= 31;
			uint num2 = num + 9U;
			num = 597248361U + num;
			if (typeCode2 == num2)
			{
				goto IL_90;
			}
			num >>= 20;
			if (typeCode != (TypeCode)(num ^ 562U))
			{
				if (num - 1133600969U == 0U)
				{
					continue;
				}
				if (num < 1046360562U)
				{
					break;
				}
			}
			num = (1440440776U & num);
			if (1978034664U + num != 0U)
			{
				goto IL_6D;
			}
		}
		throw new InvalidOperationException();
		IL_6D:
		num = 1403788372U >> (int)num;
		long long_ = ~class7_0.DB9EABF5();
		num ^= 652558866U;
		return new GClass18.Class10(long_);
		IL_90:
		num = 2076593759U % num;
		num |= 1098455163U;
		return new GClass18.Class9(~class7_0.EC4893C4());
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x00016D4C File Offset: 0x00014F4C
	private GClass18.Class7 method_21(GClass18.Class7 class7_0)
	{
		uint num2;
		for (;;)
		{
			TypeCode typeCode = class7_0.vmethod_7();
			int num = typeCode - TypeCode.Int32;
			num2 = 1U;
			switch (num)
			{
			case 0:
				goto IL_47;
			case 1:
			case 3:
				goto IL_81;
			case 2:
				goto IL_6C;
			case 4:
				goto IL_87;
			case 5:
				if ((num2 & 1776576227U) != 0U)
				{
					goto Block_1;
				}
				continue;
			}
			break;
		}
		num2 += 0U;
		goto IL_81;
		Block_1:
		double num3 = class7_0.vmethod_13();
		num2 = 1091976620U % num2;
		return new GClass18.Class12(-num3);
		IL_47:
		num2 /= 535645534U;
		num2 = 1089368632U * num2;
		int num4 = class7_0.EC4893C4();
		num2 = (455156178U ^ num2);
		return new GClass18.Class9(-num4);
		IL_6C:
		num2 = (210722533U ^ num2);
		return new GClass18.Class10(-class7_0.DB9EABF5());
		IL_81:
		throw new InvalidOperationException();
		IL_87:
		num2 <<= 6;
		num2 /= 450167319U;
		float float_ = -class7_0.B4B75C1D();
		num2 = (1936137054U & num2);
		return new GClass18.Class11(float_);
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x00016E1C File Offset: 0x0001501C
	private GClass18.Class7 method_22(GClass18.Class7 class7_0, GClass18.Class7 class7_1, bool bool_0)
	{
		uint num;
		for (;;)
		{
			IL_00:
			TypeCode typeCode = class7_0.vmethod_7();
			num = 2045475332U;
			for (;;)
			{
				uint num2 = (uint)typeCode;
				num = (858875944U ^ num);
				if (num2 == num - 1255805475U)
				{
					break;
				}
				num %= 1368331833U;
				if ((2037329119U ^ num) == 0U)
				{
					goto IL_00;
				}
				uint num3 = (uint)typeCode;
				num /= 219162629U;
				if (num3 != (num ^ 14U))
				{
					goto Block_1;
				}
				num = 1307078074U + num;
				if (78276826U <= num)
				{
					goto IL_94;
				}
			}
			if (num >> 10 == 0U)
			{
				break;
			}
			num += 941391536U;
			if (!bool_0)
			{
				goto IL_1A1;
			}
			num %= 1662276944U;
			if (num >> 24 != 0U)
			{
				goto Block_5;
			}
		}
		Block_1:
		goto IL_18C;
		Block_5:
		uint num4 = class7_0.vmethod_11();
		num = 1180979987U % num;
		int num5 = class7_1.EC4893C4();
		int num6 = num5;
		num = 1155489615U >> (int)num;
		int num7 = num6 & (int)(num ^ 23U);
		num = 2061766588U * num;
		return new GClass18.Class9(num4 >> num7);
		IL_94:
		if (!bool_0)
		{
			num = 2104567916U * num;
			long num8 = class7_0.DB9EABF5();
			int num9 = class7_1.EC4893C4();
			num = 1275478964U << (int)num;
			int num10 = num9;
			num = 953428143U >> (int)num;
			int num11 = num10;
			num = 704209894U >> (int)num;
			int num12 = (int)(num + 4294945869U);
			num = 2133853356U - num;
			int num13 = num11 & num12;
			num = 282476648U * num;
			return new GClass18.Class10(num8 >> num13);
		}
		num &= 186001125U;
		if (num % 356535301U != 0U)
		{
			ulong num14 = class7_0.vmethod_12();
			num = 1271103482U >> (int)num;
			int num15 = class7_1.EC4893C4();
			num *= 1384322188U;
			int num16 = num15;
			num %= 787679396U;
			int num17 = num16 & (int)(num ^ 441131447U);
			num = (582029178U & num);
			return new GClass18.Class10(num14 >> num17);
		}
		goto IL_1A1;
		IL_18C:
		if (225919339 << (int)num != 0)
		{
			throw new InvalidOperationException();
		}
		IL_1A1:
		num ^= 404427826U;
		int num18 = class7_0.EC4893C4();
		int num19 = class7_1.EC4893C4();
		int num20 = num19;
		num = 2091057329U + num;
		int num21 = (int)(num - 395347328U);
		num -= 84764405U;
		int num22 = num20 & num21;
		num = 2076338609U - num;
		return new GClass18.Class9(num18 >> num22);
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x00017008 File Offset: 0x00015208
	private GClass18.Class7 method_23(GClass18.Class7 class7_0, GClass18.Class7 class7_1)
	{
		uint num = 475729136U;
		TypeCode typeCode2;
		for (;;)
		{
			num += 2099454725U;
			TypeCode typeCode = class7_0.vmethod_7();
			num = 773731944U * num;
			typeCode2 = typeCode;
			num >>= 14;
			TypeCode typeCode3 = typeCode2;
			num %= 47190278U;
			uint num2 = num + 4294805421U;
			num ^= 136458353U;
			if (typeCode3 != num2)
			{
				break;
			}
			if (762329272U + num != 0U)
			{
				goto IL_AA;
			}
		}
		if (typeCode2 != (TypeCode)(num ^ 136333350U))
		{
			throw new InvalidOperationException();
		}
		num -= 2112820691U;
		num -= 434403910U;
		long num3 = class7_0.DB9EABF5();
		int num4 = class7_1.EC4893C4();
		num *= 2136673236U;
		int num5 = num4;
		num += 2116889904U;
		int num6 = num5;
		num = (2110652982U | num);
		long long_ = num3 << (num6 & (int)(num ^ 2113829833U));
		num = (909320216U | num);
		return new GClass18.Class10(long_);
		IL_AA:
		int num7 = class7_0.EC4893C4();
		num >>= 28;
		int num8 = class7_1.EC4893C4();
		num -= 1664767675U;
		int num9 = num8;
		num ^= 1524256857U;
		int num10 = num9 & (int)(num ^ 3323984131U);
		num = 885221412U >> (int)num;
		return new GClass18.Class9(num7 << num10);
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x00017104 File Offset: 0x00015304
	private unsafe GClass18.Class7 method_24(object object_0, Type type_1)
	{
		uint num = 1194480953U;
		GClass18.Class7 class2;
		for (;;)
		{
			IL_3D3:
			object obj = object_0;
			num = 1003359674U - num;
			GClass18.Class7 @class = obj as GClass18.Class7;
			num = 2067402887U << (int)num;
			class2 = @class;
			for (;;)
			{
				bool isEnum = type_1.IsEnum;
				num -= 2092854442U;
				if (isEnum)
				{
					goto Block_32;
				}
				num %= 221002416U;
				TypeCode typeCode = Type.GetTypeCode(type_1);
				int num2 = typeCode - (TypeCode)(num - 52929585U);
				num |= 472462404U;
				switch (num2)
				{
				case 0:
					goto IL_3F5;
				case 1:
				{
					if (885678845U / num == 0U)
					{
						continue;
					}
					bool flag = class2 != null;
					num = 1529373629U >> (int)num;
					if (flag)
					{
						goto IL_42C;
					}
					num = 1243376384U * num;
					if (num != 469915588U)
					{
						goto Block_5;
					}
					continue;
				}
				case 2:
					goto IL_461;
				case 3:
				{
					num = 835931387U / num;
					if (num == 1818710324U)
					{
						goto IL_884;
					}
					bool flag2 = class2 != null;
					num &= 894836264U;
					if (flag2)
					{
						goto IL_2FA;
					}
					if ((1847614136U & num) == 0U)
					{
						goto Block_8;
					}
					continue;
				}
				case 4:
					if ((1611087630U ^ num) == 0U)
					{
						continue;
					}
					if (class2 != null)
					{
						goto IL_4CC;
					}
					if (1270416167 << (int)num != 0)
					{
						goto Block_11;
					}
					continue;
				case 5:
				{
					if (num >= 1462336630U)
					{
						goto IL_874;
					}
					bool flag3 = class2 != null;
					num = 909378726U >> (int)num;
					if (flag3)
					{
						goto IL_500;
					}
					if (num - 102699919U != 0U)
					{
						goto Block_14;
					}
					continue;
				}
				case 6:
					goto IL_318;
				case 7:
					goto IL_559;
				case 8:
					goto IL_350;
				case 9:
					if (class2 == null)
					{
						goto IL_5F2;
					}
					num = 994925418U % num;
					if ((1043666364U ^ num) != 0U)
					{
						goto Block_16;
					}
					continue;
				case 10:
					goto IL_60E;
				case 11:
				{
					num = (168322702U | num);
					bool flag4 = class2 != null;
					num %= 176039183U;
					if (!flag4)
					{
						goto IL_663;
					}
					num -= 1625687091U;
					if ((218517772U ^ num) != 0U)
					{
						goto Block_18;
					}
					continue;
				}
				case 12:
				case 13:
				case 14:
					break;
				case 15:
					goto IL_3B1;
				default:
					if ((num ^ 562829280U) == 0U)
					{
						continue;
					}
					num += 0U;
					break;
				}
				num = 1853832168U % num;
				if (num <= 1530218048U)
				{
					num >>= 9;
					RuntimeTypeHandle handle = typeof(IntPtr).TypeHandle;
					num /= 40389450U;
					Type typeFromHandle = Type.GetTypeFromHandle(handle);
					num %= 500968685U;
					if (type_1 == typeFromHandle)
					{
						if ((num ^ 1104880986U) == 0U)
						{
							goto IL_3D3;
						}
						if (class2 != null)
						{
							num = 1457936464U >> (int)num;
							if (758924196 << (int)num != 0)
							{
								goto Block_23;
							}
						}
						else
						{
							num = (1913012455U & num);
							bool flag5 = object_0 != null;
							num = (1917396554U ^ num);
							if (flag5)
							{
								goto IL_6AE;
							}
							num = (1671365605U ^ num);
							if (num <= 1563906308U)
							{
								goto Block_25;
							}
						}
					}
					else
					{
						if ((982541135U & num) != 0U)
						{
							goto IL_3D3;
						}
						num /= 1358632004U;
						RuntimeTypeHandle handle2 = typeof(UIntPtr).TypeHandle;
						num = 267917878U - num;
						Type typeFromHandle2 = Type.GetTypeFromHandle(handle2);
						num += 824793554U;
						if (type_1 == typeFromHandle2)
						{
							goto Block_27;
						}
						num = (800157571U | num);
						num >>= 22;
						bool isValueType = type_1.IsValueType;
						num = 1727732470U << (int)num;
						if (isValueType)
						{
							goto IL_39C;
						}
						num %= 1133652727U;
						num ^= 345710886U;
						bool isArray = type_1.IsArray;
						num >>= 4;
						if (!isArray)
						{
							goto IL_386;
						}
						num += 2044598306U;
						bool flag6 = class2 != null;
						num = 2127510468U + num;
						if (!flag6)
						{
							if (1415797247U / num == 0U)
							{
								goto Block_31;
							}
						}
						else if (num > 1524498527U)
						{
							goto IL_757;
						}
					}
				}
			}
			IL_2FA:
			num = 1766091056U << (int)num;
			if (2059039178U > num)
			{
				goto Block_33;
			}
			continue;
			IL_318:
			if (1540753952 << (int)num == 0)
			{
				goto IL_884;
			}
			bool flag7 = class2 != null;
			num <<= 15;
			if (flag7)
			{
				goto IL_524;
			}
			num /= 1316752673U;
			if (num != 1806002179U)
			{
				goto Block_36;
			}
			continue;
			IL_350:
			bool flag8 = class2 != null;
			num <<= 21;
			if (flag8)
			{
				goto IL_5A8;
			}
			num -= 745610967U;
			if (num > 1303790732U)
			{
				goto Block_38;
			}
			continue;
			Block_27:
			if (class2 != null)
			{
				goto IL_71F;
			}
			if (460538945U <= num)
			{
				goto Block_40;
			}
			continue;
			IL_386:
			num ^= 1021012377U;
			if (784272101U * num != 0U)
			{
				goto Block_41;
			}
			continue;
			IL_39C:
			num /= 1473081495U;
			if (num < 2128424561U)
			{
				goto Block_42;
			}
			continue;
			IL_3B1:
			num %= 1520650038U;
			if (class2 == null)
			{
				goto IL_942;
			}
			num = 1663000878U * num;
			if (num / 112274544U != 0U)
			{
				goto IL_932;
			}
		}
		Block_5:
		char char_ = Convert.ToChar(object_0);
		goto IL_44D;
		Block_8:
		byte byte_ = Convert.ToByte(object_0);
		goto IL_4AE;
		Block_11:
		object value = object_0;
		num = (108883228U ^ num);
		short short_ = Convert.ToInt16(value);
		goto IL_4E2;
		Block_14:
		object value2 = object_0;
		num *= 1764053172U;
		ushort ushort_ = Convert.ToUInt16(value2);
		goto IL_516;
		Block_16:
		GClass18.Class7 class3 = class2;
		num >>= 23;
		ulong ulong_ = class3.vmethod_12();
		num += 344303016U;
		goto IL_608;
		Block_18:
		double double_ = class2.vmethod_13();
		num += 1454528339U;
		goto IL_67A;
		Block_23:
		GClass18.Class7 class4 = class2;
		num = (547622525U & num);
		return new GClass18.Class25(class4.B6AA4A8E());
		Block_25:
		IntPtr intptr_ = IntPtr.Zero;
		goto IL_6BC;
		Block_31:
		object obj2 = object_0;
		num %= 947550346U;
		Array array_ = (Array)obj2;
		goto IL_76A;
		Block_32:
		goto IL_680;
		Block_33:
		byte_ = class2.vmethod_10();
		num ^= 1766091056U;
		goto IL_4AE;
		Block_36:
		int int_ = Convert.ToInt32(object_0);
		goto IL_545;
		Block_38:
		long long_ = Convert.ToInt64(object_0);
		goto IL_5C6;
		Block_40:
		UIntPtr uintptr_;
		if (object_0 == null)
		{
			num <<= 21;
			if (num <= 1845965200U)
			{
				goto IL_874;
			}
			uintptr_ = UIntPtr.Zero;
		}
		else
		{
			num = (1932491997U ^ num);
			object obj3 = object_0;
			num = 1805584179U >> (int)num;
			uintptr_ = (UIntPtr)obj3;
			num += 2164260004U;
		}
		num = (960196495U | num);
		return new GClass18.Class26(uintptr_);
		Block_41:
		if (!type_1.IsPointer)
		{
			num <<= 8;
			object object_;
			if (class2 == null)
			{
				num -= 667891101U;
				object_ = object_0;
			}
			else
			{
				GClass18.Class7 class5 = class2;
				num -= 1085626293U;
				object_ = class5.vmethod_1();
				num += 417735192U;
			}
			num = 198277321U * num;
			return new GClass18.Class14(object_);
		}
		num *= 1773682903U;
		if (class2 != null)
		{
			GClass18.Class7 class6 = class2;
			num &= 211778656U;
			void* ptr = class6.vmethod_15();
			num &= 1931478760U;
			return new GClass18.Class15(Pointer.Box(ptr, type_1), type_1);
		}
		num = 857827826U << (int)num;
		void* ptr2;
		if (object_0 == null)
		{
			num /= 1167198077U;
			ptr2 = (void*)(num + (byte*)0);
		}
		else
		{
			object ptr3 = object_0;
			num = (1100890021U & num);
			ptr2 = Pointer.Unbox(ptr3);
			num += 4276224000U;
		}
		num *= 1657819354U;
		object object_2 = Pointer.Box(ptr2, type_1);
		num >>= 8;
		return new GClass18.Class15(object_2, type_1);
		Block_42:
		bool flag9 = class2 != null;
		num = 1817447639U * num;
		if (!flag9)
		{
			bool flag10 = object_0 != null;
			num -= 1603676045U;
			object object_3;
			if (flag10)
			{
				num |= 702358096U;
				object_3 = object_0;
			}
			else
			{
				object_3 = Activator.CreateInstance(type_1);
				num ^= 557842960U;
			}
			return new GClass18.Class16(object_3);
		}
		num ^= 245976578U;
		if (num >> 13 != 0U)
		{
			GClass18.Class7 class7 = class2;
			num += 1619658893U;
			return new GClass18.Class16(class7.vmethod_1());
		}
		goto IL_874;
		IL_3F5:
		bool bool_;
		if (class2 == null)
		{
			object value3 = object_0;
			num <<= 7;
			bool_ = Convert.ToBoolean(value3);
		}
		else
		{
			GClass18.Class7 class8 = class2;
			num = (2036886451U | num);
			bool_ = class8.vmethod_8();
			num += 409614857U;
		}
		return new GClass18.Class30(bool_);
		IL_42C:
		num <<= 1;
		if (num > 414279876U)
		{
			goto IL_874;
		}
		char_ = class2.F22CF44A();
		num += 366566044U;
		IL_44D:
		num = 990850157U << (int)num;
		return new GClass18.Class31(char_);
		IL_461:
		sbyte sbyte_;
		if (class2 == null)
		{
			num = (1669953694U & num);
			sbyte_ = Convert.ToSByte(object_0);
		}
		else
		{
			GClass18.Class7 class9 = class2;
			num += 601705235U;
			sbyte_ = class9.vmethod_9();
			num ^= 1074122643U;
		}
		num = 141322356U / num;
		return new GClass18.Class33(sbyte_);
		IL_4AE:
		num = 10444519U - num;
		return new GClass18.Class32(byte_);
		IL_4CC:
		GClass18.Class7 class10 = class2;
		num = (398161245U & num);
		short_ = class10.E8F387ED();
		num ^= 242871612U;
		IL_4E2:
		num = (653416344U ^ num);
		return new GClass18.Class28(short_);
		IL_500:
		num /= 1275951489U;
		ushort_ = class2.D3EC5557();
		num ^= 425742748U;
		IL_516:
		return new GClass18.Class29(ushort_);
		IL_524:
		num ^= 50096843U;
		if (num < 584860038U)
		{
			goto IL_874;
		}
		int_ = class2.EC4893C4();
		num += 658085175U;
		IL_545:
		num = 1386226791U >> (int)num;
		return new GClass18.Class9(int_);
		IL_559:
		if (935681424U * num != 0U)
		{
			uint uint_;
			if (class2 == null)
			{
				if (215426124U + num == 0U)
				{
					goto IL_680;
				}
				object value4 = object_0;
				num = 1743326264U - num;
				uint_ = Convert.ToUInt32(value4);
			}
			else
			{
				uint_ = class2.vmethod_11();
				num += 696886096U;
			}
			num <<= 11;
			return new GClass18.Class34(uint_);
		}
		goto IL_680;
		IL_5A8:
		num = (424224047U | num);
		GClass18.Class7 class11 = class2;
		num >>= 8;
		long_ = class11.DB9EABF5();
		num ^= 1653680140U;
		IL_5C6:
		num = 1608525789U >> (int)num;
		return new GClass18.Class10(long_);
		IL_5F2:
		num = (1979672794U ^ num);
		object value5 = object_0;
		num -= 1447769806U;
		ulong_ = Convert.ToUInt64(value5);
		IL_608:
		return new GClass18.Class35(ulong_);
		IL_60E:
		float float_;
		if (class2 == null)
		{
			num = 2130649670U << (int)num;
			object value6 = object_0;
			num |= 2052223128U;
			float_ = Convert.ToSingle(value6);
		}
		else
		{
			num = 1105733056U / num;
			float_ = class2.B4B75C1D();
			num ^= 2121429146U;
		}
		num &= 664305330U;
		return new GClass18.Class11(float_);
		IL_663:
		num /= 1144661476U;
		if ((num ^ 1222837240U) == 0U)
		{
			goto IL_680;
		}
		double_ = Convert.ToDouble(object_0);
		IL_67A:
		return new GClass18.Class12(double_);
		IL_680:
		if (class2 != null)
		{
			num ^= 450173960U;
			goto IL_874;
		}
		goto IL_884;
		IL_6AE:
		intptr_ = (IntPtr)object_0;
		num ^= 1671365605U;
		IL_6BC:
		num = 412363673U >> (int)num;
		return new GClass18.Class25(intptr_);
		IL_71F:
		GClass18.Class7 class12 = class2;
		num = 1326074611U << (int)num;
		UIntPtr uintptr_2 = class12.vmethod_14();
		num = 2069374873U << (int)num;
		return new GClass18.Class26(uintptr_2);
		IL_757:
		array_ = (Array)class2.vmethod_1();
		num ^= 3798868520U;
		IL_76A:
		num >>= 27;
		return new GClass18.Class17(array_);
		IL_874:
		object_0 = class2.vmethod_1();
		num ^= 450173960U;
		IL_884:
		num &= 1791195356U;
		if (object_0 != null)
		{
			bool flag11 = object_0 is Enum;
			num += 0U;
			if (!flag11)
			{
				num >>= 16;
				object value7 = object_0;
				num &= 28580443U;
				object obj4 = Enum.ToObject(type_1, value7);
				num = 1737367874U << (int)num;
				object_0 = obj4;
				num += 2573528512U;
			}
		}
		bool flag12 = object_0 != null;
		num = (1820008702U ^ num);
		Enum enum_;
		if (flag12)
		{
			enum_ = (Enum)object_0;
		}
		else
		{
			num = 1642747323U << (int)num;
			enum_ = (Enum)Activator.CreateInstance(type_1);
			num += 419041466U;
		}
		return new GClass18.Class27(enum_);
		IL_932:
		string string_ = class2.ToString();
		num += 2617359959U;
		goto IL_950;
		IL_942:
		num >>= 16;
		string_ = (string)object_0;
		IL_950:
		return new GClass18.Class13(string_);
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x00017A68 File Offset: 0x00015C68
	private string method_25(int int_1)
	{
		Dictionary<int, object> obj = GClass18.dictionary_1;
		uint num = 2557029571U;
		string result2;
		lock (obj)
		{
			object obj2;
			string text;
			if (1324494581U != num)
			{
				for (;;)
				{
					Dictionary<int, object> dictionary = GClass18.dictionary_1;
					num = (1204580992U & num);
					num *= 795286247U;
					bool flag = dictionary.TryGetValue(int_1, out obj2);
					num <<= 9;
					if (flag)
					{
						break;
					}
					if ((1450141944U & num) != 0U)
					{
						goto IL_5E;
					}
				}
				num = (129714131U | num);
				goto IL_B2;
				IL_5E:
				num = (2038922450U | num);
				Module module = this.module_0;
				num /= 2023370566U;
				num <<= 17;
				text = module.ResolveString(int_1);
				num = 499328473U;
			}
			Dictionary<int, object> dictionary2 = GClass18.dictionary_1;
			object value = text;
			num |= 293610501U;
			dictionary2.Add(int_1, value);
			if (num + 153369695U != 0U)
			{
				string result = text;
				num = 241324201U + num;
				return result;
			}
			IL_B2:
			object obj3 = obj2;
			num += 319061474U;
			string text2 = (string)obj3;
			num = 602302922U >> (int)num;
			result2 = text2;
		}
		return result2;
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x00017B6C File Offset: 0x00015D6C
	private Type method_26(int int_1)
	{
		Dictionary<int, object> obj = GClass18.dictionary_1;
		uint num = 2175105278U;
		Type result;
		lock (obj)
		{
			num += 1740512981U;
			object obj2;
			Type type;
			do
			{
				Dictionary<int, object> dictionary = GClass18.dictionary_1;
				num |= 882266256U;
				num *= 1426029064U;
				num = 1604924343U >> (int)num;
				if (dictionary.TryGetValue(int_1, out obj2))
				{
					goto Block_4;
				}
				num = (1426226882U & num);
				Module module = this.module_0;
				num *= 392758285U;
				num = 696547754U - num;
				type = module.ResolveType(int_1);
				num = 1200114458U >> (int)num;
				Dictionary<int, object> dictionary2 = GClass18.dictionary_1;
				num |= 1458119996U;
				dictionary2.Add(int_1, type);
				num = 871630869U % num;
			}
			while (num == 1690831460U);
			Type type2 = type;
			num -= 187257942U;
			result = type2;
			if (108535978U != num)
			{
				return result;
			}
			Block_4:
			Type type3 = (Type)obj2;
			num *= 1395538299U;
			result = type3;
		}
		return result;
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x00017C6C File Offset: 0x00015E6C
	private MethodBase method_27(int int_1)
	{
		uint num = 829514400U;
		Dictionary<int, object> dictionary;
		do
		{
			dictionary = GClass18.dictionary_1;
		}
		while (num <= 18030049U);
		object obj = dictionary;
		num = (1002856727U & num);
		Monitor.Enter(obj);
		MethodBase result;
		try
		{
			Dictionary<int, object> dictionary2 = GClass18.dictionary_1;
			num = 180370993U % num;
			num = (973168656U ^ num);
			num = (1437927389U | num);
			object obj2;
			bool flag = dictionary2.TryGetValue(int_1, out obj2);
			num = 399783466U - num;
			if (flag && num >= 785651222U)
			{
				result = (MethodBase)obj2;
			}
			else
			{
				num /= 2072135396U;
				Module module = this.module_0;
				num <<= 16;
				MethodBase methodBase = module.ResolveMethod(int_1);
				Dictionary<int, object> dictionary3 = GClass18.dictionary_1;
				num = 1297243362U / num;
				num = 1484284761U - num;
				object value = methodBase;
				num &= 941777621U;
				dictionary3.Add(int_1, value);
				result = methodBase;
			}
		}
		finally
		{
			Monitor.Exit(dictionary);
		}
		return result;
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x00017D3C File Offset: 0x00015F3C
	private FieldInfo method_28(int int_1)
	{
		Dictionary<int, object> obj = GClass18.dictionary_1;
		FieldInfo result;
		lock (obj)
		{
			uint num = 1529564517U;
			object obj2;
			for (;;)
			{
				Dictionary<int, object> dictionary = GClass18.dictionary_1;
				num %= 208085800U;
				if (dictionary.TryGetValue(int_1, out obj2))
				{
					break;
				}
				if (837644948 << (int)num != 0)
				{
					Module module = this.module_0;
					num = 824322526U / num;
					FieldInfo fieldInfo = module.ResolveField(int_1);
					num &= 1719282857U;
					FieldInfo fieldInfo2 = fieldInfo;
					if (1884619334U % num == 0U)
					{
						break;
					}
					GClass18.dictionary_1.Add(int_1, fieldInfo2);
					num >>= 21;
					if (num + 1381781206U == 0U)
					{
						break;
					}
					FieldInfo fieldInfo3 = fieldInfo2;
					num = 585368108U - num;
					result = fieldInfo3;
					if ((1998461300U ^ num) != 0U)
					{
						goto IL_94;
					}
				}
			}
			goto IL_96;
			IL_94:
			return result;
			IL_96:
			object obj3 = obj2;
			num *= 1260067763U;
			FieldInfo fieldInfo4 = (FieldInfo)obj3;
			num = 1141724159U % num;
			result = fieldInfo4;
		}
		return result;
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x00017E18 File Offset: 0x00016018
	private GClass18.Class7 method_29(MethodBase methodBase_0)
	{
		uint num;
		Dictionary<int, GClass18.Class7> dictionary;
		object[] array;
		for (;;)
		{
			ParameterInfo[] parameters = methodBase_0.GetParameters();
			num = 3356830493U;
			for (;;)
			{
				IL_140:
				dictionary = new Dictionary<int, GClass18.Class7>();
				int num2 = parameters.Length;
				num /= 1594628407U;
				array = new object[num2];
				num = 1400929863U / num;
				int num3 = parameters.Length;
				num &= 1258446406U;
				int num4 = num3;
				num *= 2764373U;
				int num5 = (int)(num ^ 4005712555U);
				num <<= 18;
				int num6 = num4 - num5;
				while (1637902941U >= num)
				{
					int num7 = num6;
					uint num8 = num ^ 1252524032U;
					num /= 630009704U;
					if (num7 >= num8)
					{
						GClass18.Class7 @class = this.method_1();
						num = 2483750048U;
						if (@class.vmethod_3())
						{
							num = 1054965750U % num;
							if (num * 865348402U == 0U)
							{
								goto IL_140;
							}
							Dictionary<int, GClass18.Class7> dictionary2 = dictionary;
							int key = num6;
							num = 1488009903U / num;
							dictionary2[key] = @class;
							num ^= 2483750049U;
						}
						num = 1860042929U * num;
						object[] array2 = array;
						num = 1340043706U >> (int)num;
						int num9 = num6;
						num >>= 14;
						num >>= 5;
						object object_ = @class;
						ParameterInfo[] array3 = parameters;
						int num10 = num6;
						num /= 1485200207U;
						GClass18.Class7 class2 = this.method_24(object_, array3[num10].ParameterType);
						num &= 903161454U;
						array2[num9] = class2.vmethod_1();
						if (num > 1867646761U)
						{
							break;
						}
						int num11 = num6;
						int num12 = (int)(num ^ 1U);
						num /= 346045415U;
						num6 = num11 - num12;
						num += 1252524032U;
					}
					else
					{
						if (1596880912U < num)
						{
							goto IL_140;
						}
						goto IL_192;
					}
				}
				break;
			}
		}
		IL_192:
		num <<= 15;
		object object_2 = ((ConstructorInfo)methodBase_0).Invoke(array);
		Dictionary<int, GClass18.Class7>.Enumerator enumerator = dictionary.GetEnumerator();
		num = 2014927410U;
		using (Dictionary<int, GClass18.Class7>.Enumerator enumerator2 = enumerator)
		{
			for (;;)
			{
				num &= 181288258U;
				if (1671522240U <= num)
				{
					break;
				}
				KeyValuePair<int, GClass18.Class7> keyValuePair2;
				if (!enumerator2.MoveNext())
				{
					if (num <= 1412395156U)
					{
						break;
					}
				}
				else
				{
					KeyValuePair<int, GClass18.Class7> keyValuePair = enumerator2.Current;
					num = 1251392U;
					keyValuePair2 = keyValuePair;
				}
				num |= 384199027U;
				GClass18.Class7 value = keyValuePair2.Value;
				object[] array4 = array;
				num -= 2046836575U;
				value.vmethod_2(array4[keyValuePair2.Key]);
				num ^= 3840827430U;
			}
		}
		return this.method_24(object_2, methodBase_0.DeclaringType);
	}

	// Token: 0x0600063F RID: 1599 RVA: 0x000180AC File Offset: 0x000162AC
	private bool method_30(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		uint num = 1165435824U;
		for (;;)
		{
			IL_131:
			Type declaringType = methodBase_0.DeclaringType;
			num = 1391990669U >> (int)num;
			Type type = declaringType;
			num %= 1023374938U;
			while (type != null)
			{
				num %= 992634608U;
				Type type2 = type;
				num &= 1634890546U;
				if (!type2.IsGenericType)
				{
					goto IL_1E2;
				}
				if (2144088768U <= num)
				{
					goto IL_131;
				}
				Type genericTypeDefinition = type.GetGenericTypeDefinition();
				Type typeFromHandle = typeof(Nullable<>);
				num ^= 0U;
				if (genericTypeDefinition != typeFromHandle)
				{
					goto IL_1E2;
				}
				num = 288428412U - num;
				string name = methodBase_0.Name;
				num = (514330365U & num);
				if (string.Equals(name, "get_HasValue", (StringComparison)(num ^ 270536264U)))
				{
					goto IL_1B7;
				}
				if (num >= 1018314667U)
				{
					goto IL_131;
				}
				bool flag = string.Equals(methodBase_0.Name, "get_Value", (int)num + (StringComparison)(-270536264));
				num = (549791622U & num);
				if (!flag)
				{
					num <<= 31;
					string name2 = methodBase_0.Name;
					string value = "GetValueOrDefault";
					num >>= 5;
					bool flag2 = name2.Equals(value, (StringComparison)(num - 4294967292U));
					num ^= 1361662635U;
					if (!flag2)
					{
						goto IL_1DA;
					}
					if (object_0 != null)
					{
						goto IL_18A;
					}
					num *= 1748777645U;
					if (1813519432U * num != 0U)
					{
						goto IL_160;
					}
				}
				else
				{
					num *= 395711944U;
					bool flag3 = object_0 != null;
					num <<= 5;
					if (!flag3)
					{
						goto IL_1A9;
					}
					num = 652179260U + num;
					object obj = object_0;
					num %= 363746938U;
					object_1 = obj;
					if (2003908772U >> (int)num == 0U)
					{
						goto IL_131;
					}
					goto IL_19F;
				}
			}
			break;
		}
		num = (324222854U ^ num);
		return num + 3970732674U != 0U;
		IL_160:
		num |= 594179031U;
		Type declaringType2 = methodBase_0.DeclaringType;
		num >>= 2;
		object_0 = Activator.CreateInstance(Nullable.GetUnderlyingType(declaringType2));
		num += 1160401844U;
		IL_18A:
		num |= 1056050484U;
		object_1 = object_0;
		num += 3509449452U;
		goto IL_1DA;
		IL_19F:
		num += 1358888523U;
		goto IL_1DA;
		IL_1A9:
		num *= 584534620U;
		throw new InvalidOperationException();
		IL_1B7:
		num = (480271085U ^ num);
		object obj2 = object_0;
		num >>= 15;
		object obj3 = obj2 != null;
		num += 1361656235U;
		object_1 = obj3;
		IL_1DA:
		return (num ^ 1361662634U) != 0U;
		IL_1E2:
		return (num ^ 21040U) != 0U;
	}

	// Token: 0x06000640 RID: 1600 RVA: 0x000182A4 File Offset: 0x000164A4
	private GClass18.Class7 method_31(MethodBase methodBase_0, bool bool_0)
	{
		uint num;
		MethodInfo methodInfo2;
		ParameterInfo[] parameters;
		Dictionary<int, GClass18.Class7> dictionary2;
		object[] array;
		GClass18.Class7 @class;
		object obj4;
		object[] array6;
		Dictionary<MethodBase, DynamicMethod> dictionary5;
		do
		{
			IL_00:
			MethodInfo methodInfo = methodBase_0 as MethodInfo;
			num = 2251734912U;
			methodInfo2 = methodInfo;
			for (;;)
			{
				IL_5CD:
				num = 2067094873U - num;
				parameters = methodBase_0.GetParameters();
				num = 249252613U - num;
				object obj3;
				for (;;)
				{
					IL_4CC:
					Dictionary<int, GClass18.Class7> dictionary = new Dictionary<int, GClass18.Class7>();
					num -= 1086591259U;
					dictionary2 = dictionary;
					num = (1571556426U ^ num);
					if ((1999194191U ^ num) == 0U)
					{
						goto IL_00;
					}
					array = new object[parameters.Length];
					num = 1824418504U << (int)num;
					do
					{
						IL_394:
						int num2 = parameters.Length;
						num -= 746091139U;
						int num3 = num2;
						num = 1923614883U + num;
						int num4 = (int)(num ^ 2251265569U);
						num ^= 449645289U;
						int num5 = num3 - num4;
						num %= 1103055181U;
						int num6 = num5;
						for (;;)
						{
							num *= 779319242U;
							if (num > 384117019U)
							{
								if (num6 < (int)(num - 2395529750U))
								{
									break;
								}
								@class = this.method_1();
								bool flag = @class.vmethod_3();
								num = 2504790144U;
								if (flag)
								{
									num = (1141250956U & num);
									if (666986486U <= num)
									{
										goto IL_394;
									}
									Dictionary<int, GClass18.Class7> dictionary3 = dictionary2;
									num = 870450294U << (int)num;
									dictionary3[num6] = @class;
									num ^= 2796426486U;
								}
								num %= 707426975U;
								if (828065356 << (int)num == 0)
								{
									goto IL_394;
								}
								object[] array2 = array;
								num = 916857022U * num;
								int num7 = num6;
								num = 1091916986U / num;
								object object_ = @class;
								num |= 58198441U;
								ParameterInfo[] array3 = parameters;
								num = (427573734U | num);
								GClass18.Class7 class2 = this.method_24(object_, array3[num6].ParameterType);
								num &= 657079993U;
								array2[num7] = class2.vmethod_1();
								num = 937195651U / num;
								if (num + 1064179427U == 0U)
								{
									goto IL_5CD;
								}
								int num8 = num6;
								int num9 = (int)(num + 4294967280U);
								num = (216482117U ^ num);
								int num10 = num8 - num9;
								num %= 941441123U;
								num6 = num10;
								num += 209504475U;
							}
						}
						num = 741305211U >> (int)num;
						num *= 695744350U;
						bool isStatic = methodBase_0.IsStatic;
						num >>= 29;
						GClass18.Class7 class3;
						if (!isStatic)
						{
							num ^= 960396086U;
							class3 = this.method_1();
						}
						else
						{
							class3 = null;
							num ^= 960396086U;
						}
						num <<= 13;
						@class = class3;
						if (1954753251U >= num)
						{
							goto IL_5CD;
						}
						object obj;
						if (@class == null)
						{
							if (num % 1796229481U == 0U)
							{
								goto IL_00;
							}
							obj = null;
						}
						else
						{
							GClass18.Class7 class4 = @class;
							num -= 928534777U;
							obj = class4.vmethod_1();
							num += 928534777U;
						}
						object obj2;
						bool flag2 = (obj2 = obj) != null;
						num %= 1113339702U;
						if (!flag2)
						{
							num = 1672298043U * num;
							num = 1408959101U * num;
							if (339375522U > num)
							{
								goto IL_00;
							}
							obj2 = null;
							num ^= 1186117724U;
						}
						obj3 = obj2;
						if ((num & 617298743U) == 0U)
						{
							goto IL_4CC;
						}
						if (bool_0)
						{
							num = 1749027431U - num;
							bool flag3 = obj3 != null;
							num ^= 1472195159U;
							if (!flag3)
							{
								goto IL_61E;
							}
						}
						obj4 = null;
						num %= 17583720U;
						if ((num & 2019313247U) == 0U)
						{
							goto IL_00;
						}
						num -= 1430797802U;
						if (methodBase_0.IsConstructor)
						{
							if (num / 1935692427U == 0U)
							{
								goto IL_5CD;
							}
							bool isValueType = methodBase_0.DeclaringType.IsValueType;
							num += 60769146U;
							num += 4234198150U;
							if (isValueType)
							{
								goto IL_4F8;
							}
						}
						num = 1717703933U * num;
						object object_2 = obj3;
						num = 1025320518U % num;
						object[] object_3 = array;
						num += 82387673U;
						bool flag4 = this.method_30(methodBase_0, object_2, ref obj4, object_3);
						num ^= 1310483035U;
						if (flag4)
						{
							goto IL_B2E;
						}
						if ((1909476029U ^ num) == 0U)
						{
							goto IL_00;
						}
						num ^= 89735905U;
						if (bool_0)
						{
							goto IL_AC8;
						}
						num %= 833957754U;
						if (num / 996476111U != 0U)
						{
							goto IL_4CC;
						}
						num = (1784623810U ^ num);
						bool isVirtual = methodBase_0.IsVirtual;
						num += 199500348U;
						if (!isVirtual)
						{
							goto IL_AC8;
						}
						num += 1959033839U;
						if (838734572U + num == 0U)
						{
							goto IL_5CD;
						}
						bool isFinal = methodBase_0.IsFinal;
						num += 2335933457U;
						if (isFinal)
						{
							goto IL_AC8;
						}
						num = (1220693517U ^ num);
					}
					while (num > 1901597661U);
					ParameterInfo[] array4 = parameters;
					num = 973410707U - num;
					int num11 = array4.Length;
					num = 569667897U - num;
					int num12 = num11;
					int num13 = (int)(num ^ 72264939U);
					num ^= 1356216302U;
					int num14 = num12 + num13;
					num = 1004352911U + num;
					object[] array5 = new object[num14];
					num ^= 675511815U;
					array6 = array5;
					num *= 151676114U;
					object[] array7 = array6;
					num = 33913584U / num;
					int num15 = (int)(num ^ 0U);
					num = 543188327U * num;
					array7[num15] = obj3;
					num ^= 2050374246U;
					int num16 = (int)(num - 2050374246U);
					for (;;)
					{
						num = 2088269470U << (int)num;
						if (1331382985U <= num)
						{
							break;
						}
						int num17 = num16;
						ParameterInfo[] array8 = parameters;
						num >>= 1;
						int num18 = array8.Length;
						num = (1543514994U & num);
						int num19 = num18;
						num = 927677921U >> (int)num;
						if (num17 >= num19)
						{
							goto IL_5EE;
						}
						array6[num16 + 1] = array[num16];
						num16++;
						num = 2050374246U;
					}
				}
				IL_4F8:
				num -= 1329670572U;
				if (num < 772632636U)
				{
					goto IL_00;
				}
				num = 1975860451U + num;
				object obj5 = Activator.CreateInstance(methodBase_0.DeclaringType, array);
				num = (92300863U ^ num);
				obj3 = obj5;
				if (324426261U < num)
				{
					bool flag5 = @class != null;
					num += 2047677628U;
					if (!flag5)
					{
						goto IL_B2E;
					}
					num *= 169628838U;
					GClass18.Class7 class5 = @class;
					num ^= 1643783398U;
					bool flag6 = class5.vmethod_3();
					num = 569713429U / num;
					num += 1371816360U;
					if (!flag6)
					{
						goto IL_B2E;
					}
					if (num >= 1381847523U)
					{
						goto IL_00;
					}
					GClass18.Class7 class6 = @class;
					object object_4 = obj3;
					num = 1303781574U + num;
					GClass18.Class7 class7 = this.method_24(object_4, methodBase_0.DeclaringType);
					num = 35483727U * num;
					object object_5 = class7.vmethod_1();
					num = 1852729155U % num;
					class6.vmethod_2(object_5);
					if (num >= 1364789822U)
					{
						goto IL_624;
					}
				}
			}
			IL_5EE:
			num &= 1462177554U;
			Dictionary<MethodBase, DynamicMethod> dictionary4 = GClass18.dictionary_2;
			num = 1778142285U % num;
			dictionary5 = dictionary4;
		}
		while (345989648 << (int)num == 0);
		object obj6 = dictionary5;
		num = 174726896U >> (int)num;
		Monitor.Enter(obj6);
		DynamicMethod dynamicMethod;
		try
		{
			do
			{
				IL_64A:
				Dictionary<MethodBase, DynamicMethod> dictionary6 = GClass18.dictionary_2;
				num = (433662759U & num);
				num &= 60587211U;
				num = 1263294528U << (int)num;
				bool flag7 = dictionary6.TryGetValue(methodBase_0, out dynamicMethod);
				num ^= 1631132943U;
				if (!flag7)
				{
					if (192946506 << (int)num == 0)
					{
						continue;
					}
					ILGenerator ilgenerator;
					do
					{
						object[] array9 = array6;
						num %= 1620395418U;
						int num20 = array9.Length;
						num = 764674468U * num;
						int num21 = num20;
						num = 91966137U - num;
						Type[] array10 = new Type[num21];
						num = 1395151776U * num;
						do
						{
							Type[] array11 = array10;
							num = 1805130392U - num;
							int num22 = (int)(num - 985301368U);
							num = 1757952294U % num;
							num <<= 22;
							array11[num22] = methodBase_0.DeclaringType;
							for (;;)
							{
								int num23 = (int)(num ^ 3951034368U);
								for (;;)
								{
									num -= 422719973U;
									int num24 = num23;
									num >>= 29;
									int num25 = parameters.Length;
									num = 1431070874U % num;
									int num26 = num25;
									num <<= 28;
									if (num24 >= num26)
									{
										break;
									}
									array10[num23 + 1] = parameters[num23].ParameterType;
									num23++;
									num = 3951034368U;
								}
								num >>= 16;
								string name = "";
								if (methodInfo2 == null)
								{
									goto IL_795;
								}
								num |= 1275350990U;
								MethodInfo methodInfo3 = methodInfo2;
								num ^= 721376331U;
								Type returnType = methodInfo3.ReturnType;
								Type typeFromHandle = typeof(void);
								num &= 1463821680U;
								if (returnType == typeFromHandle)
								{
									num += 3116367616U;
									goto IL_795;
								}
								Type returnType2 = methodInfo2.ReturnType;
								num += 3116367616U;
								IL_796:
								num %= 275739856U;
								Type[] parameterTypes = array10;
								num -= 1665539270U;
								DynamicMethod dynamicMethod2 = new DynamicMethod(name, returnType2, parameterTypes, typeof(GClass18).Module, num + 1665531079U != 0U);
								num = 1670657601U * num;
								dynamicMethod = dynamicMethod2;
								if (409696969 << (int)num == 0)
								{
									continue;
								}
								break;
								IL_795:
								returnType2 = null;
								goto IL_796;
							}
							ilgenerator = dynamicMethod.GetILGenerator();
							num = 620328539U >> (int)num;
							ILGenerator ilgenerator2 = ilgenerator;
							OpCode opcode;
							if (!@class.vmethod_3())
							{
								opcode = OpCodes.Ldarg;
							}
							else
							{
								opcode = OpCodes.Ldarga;
								num += 0U;
							}
							int arg = (int)(num ^ 9U);
							num |= 895168137U;
							ilgenerator2.Emit(opcode, arg);
							int num27 = (int)(num ^ 895168136U);
							for (;;)
							{
								int num28 = num27;
								Type[] array12 = array10;
								num = 1622700467U + num;
								int num29 = array12.Length;
								num = 1819373168U * num;
								int num30 = num29;
								num *= 1830626838U;
								if (num28 >= num30)
								{
									break;
								}
								ILGenerator ilgenerator3 = ilgenerator;
								Dictionary<int, GClass18.Class7> dictionary7 = dictionary2;
								int key = num27 - 1;
								num = 2889844747U;
								OpCode opcode2;
								if (!dictionary7.ContainsKey(key))
								{
									num *= 351405269U;
									opcode2 = OpCodes.Ldarg;
								}
								else
								{
									num *= 1702516008U;
									opcode2 = OpCodes.Ldarga;
									num ^= 3946100127U;
								}
								num -= 3540655U;
								ilgenerator3.Emit(opcode2, num27);
								if (535041822U + num == 0U)
								{
									goto IL_64A;
								}
								int num31 = num27 + (int)(num ^ 3308017273U);
								num = 1614570291U % num;
								num27 = num31;
								num ^= 1432833466U;
							}
						}
						while (num <= 1752633172U);
						ILGenerator ilgenerator4 = ilgenerator;
						OpCode call = OpCodes.Call;
						MethodInfo meth = methodInfo2;
						num = 1953172520U - num;
						ilgenerator4.Emit(call, meth);
					}
					while (2005272795U == num);
					ILGenerator ilgenerator5 = ilgenerator;
					num = (1319724041U & num);
					ilgenerator5.Emit(OpCodes.Ret);
					GClass18.dictionary_2[methodBase_0] = dynamicMethod;
					num += 645219655U;
				}
			}
			while (1633122391U - num == 0U);
		}
		finally
		{
			Monitor.Exit(dictionary5);
		}
		obj4 = dynamicMethod.Invoke(null, array6);
		Dictionary<int, GClass18.Class7>.Enumerator enumerator = dictionary2.GetEnumerator();
		num = 3310027824U;
		using (Dictionary<int, GClass18.Class7>.Enumerator enumerator2 = enumerator)
		{
			if ((num & 591608653U) == 0U)
			{
				goto IL_A55;
			}
			IL_A22:
			num = (1260520290U & num);
			if (1711151666U >= num && !enumerator2.MoveNext())
			{
				goto IL_B17;
			}
			KeyValuePair<int, GClass18.Class7> keyValuePair = enumerator2.Current;
			num = 1228940320U;
			IL_A55:
			num ^= 1533508760U;
			GClass18.Class7 value = keyValuePair.Value;
			object[] array13 = array6;
			num = 170423679U << (int)num;
			int key2 = keyValuePair.Key;
			int num32 = (int)(num ^ 2130706433U);
			num = 1356859388U % num;
			int num33 = key2 + num32;
			num = 1779126409U % num;
			value.vmethod_2(array13[num33]);
			num ^= 3697298621U;
			goto IL_A22;
		}
		goto IL_AC8;
		IL_61E:
		throw new NullReferenceException();
		IL_624:
		num ^= 1068115691U;
		goto IL_B2E;
		IL_AC8:
		num = 704343030U - num;
		if ((num ^ 213853186U) != 0U)
		{
			num >>= 18;
			object obj3;
			object obj7 = obj3;
			num *= 1896480968U;
			object obj8 = methodBase_0.Invoke(obj7, array);
			num = 1759186483U >> (int)num;
			obj4 = obj8;
			num += 1371816256U;
			goto IL_B2E;
		}
		IL_B17:
		dictionary2.Clear();
		num = 1371816360U;
		IL_B2E:
		num *= 652945312U;
		Dictionary<int, GClass18.Class7>.Enumerator enumerator3 = dictionary2.GetEnumerator();
		num |= 2020354924U;
		using (Dictionary<int, GClass18.Class7>.Enumerator enumerator2 = enumerator3)
		{
			for (;;)
			{
				for (;;)
				{
					num &= 2095523467U;
					if (1348798659U >> (int)num != 0U)
					{
						num = 1846812327U - num;
						bool flag8 = enumerator2.MoveNext();
						num ^= 646464989U;
						if (!flag8)
						{
							goto IL_BC1;
						}
						KeyValuePair<int, GClass18.Class7> keyValuePair2 = enumerator2.Current;
						keyValuePair2.Value.vmethod_2(array[keyValuePair2.Key]);
						num = 2112727916U;
					}
				}
			}
			IL_BC1:;
		}
		if (methodInfo2 != null)
		{
			Type returnType3 = methodInfo2.ReturnType;
			RuntimeTypeHandle handle = typeof(void).TypeHandle;
			num = 2U;
			if (returnType3 != Type.GetTypeFromHandle(handle))
			{
				num = 1416525775U - num;
				num /= 279462901U;
				object object_6 = obj4;
				num = 515444089U / num;
				MethodInfo methodInfo4 = methodInfo2;
				num = 1613054546U >> (int)num;
				return this.method_24(object_6, methodInfo4.ReturnType);
			}
		}
		return null;
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x00018F48 File Offset: 0x00017148
	private GClass18.Class7 method_32(int int_1, bool bool_0)
	{
		uint num = 378275741U;
		Dictionary<int, GClass18.Class7> dictionary;
		int num11;
		for (;;)
		{
			IL_2C8:
			num -= 87779088U;
			int num2 = this.int_0;
			if (num > 34756382U)
			{
				object[] array2;
				for (;;)
				{
					IL_272:
					int num3 = int_1;
					num -= 1810373087U;
					this.int_0 = num3;
					num = 717644757U % num;
					if (num > 1888237336U)
					{
						goto IL_2C8;
					}
					for (;;)
					{
						ushort num4 = (ushort)this.method_4();
						num &= 1258362422U;
						ushort num5 = num4;
						num = 1455309099U % num;
						ushort num6 = num5;
						for (;;)
						{
							dictionary = new Dictionary<int, GClass18.Class7>();
							if (num == 482109245U)
							{
								break;
							}
							object[] array = null;
							num = 1423720385U % num;
							array2 = array;
							num &= 289564195U;
							if (num % 326331172U == 0U)
							{
								goto IL_272;
							}
							ushort num7 = num6;
							num += 733035858U;
							uint num8 = num + 3540935309U;
							num *= 1370705954U;
							if (num7 > num8)
							{
								num *= 1052856514U;
								if (num * 1996316494U == 0U)
								{
									goto IL_2C8;
								}
								object[] array3 = new object[(int)num6];
								num = 1566988052U - num;
								array2 = array3;
								int num9 = (int)((uint)num6 - (num - 3111112711U));
								if (254809538U >= num)
								{
									goto IL_2C8;
								}
								for (;;)
								{
									num = 494420933U - num;
									if ((1536522707U ^ num) == 0U)
									{
										goto IL_2C8;
									}
									if (num9 < (int)(num ^ 1678275517U))
									{
										break;
									}
									GClass18.Class7 @class = this.method_1();
									GClass18.Class7 class2 = @class;
									num = 3352204924U;
									if (class2.vmethod_3())
									{
										num = (1129864731U ^ num);
										if ((2018066595U ^ num) == 0U)
										{
											goto IL_2C8;
										}
										dictionary[num9] = @class;
										num ^= 1129864731U;
									}
									num = (1713706311U | num);
									object[] array4 = array2;
									num = 1801667429U >> (int)num;
									int num10 = num9;
									num |= 238823561U;
									object object_ = @class;
									num = 1829381779U - num;
									num &= 371461931U;
									int int_2 = this.method_5();
									num += 1187320164U;
									array4[num10] = this.method_24(object_, this.method_26(int_2)).vmethod_1();
									num9 -= (int)(num ^ 1556684655U);
									num ^= 3852914534U;
								}
								num += 2410374537U;
							}
							if (num <= 990191759U)
							{
								goto IL_2C8;
							}
							num11 = this.method_5();
							num ^= 1356103029U;
							if (num - 874341517U == 0U)
							{
								goto IL_2C8;
							}
							num *= 1657876359U;
							int num12 = this.int_0;
							num |= 1886877163U;
							int_1 = num12;
							num = 1567777927U / num;
							num = 1075064034U + num;
							this.int_0 = num2;
							num = 652697287U >> (int)num;
							num |= 152324228U;
							if (bool_0)
							{
								if (477655261U == num)
								{
									goto IL_272;
								}
								bool flag = array2 != null;
								num = (387544750U & num);
								if (flag)
								{
									num = (1554058477U ^ num);
									object[] array5 = array2;
									num /= 531845295U;
									bool flag2 = array5[(int)(num + 4294967294U)];
									num %= 1952583498U;
									num += 163438515U;
									if (flag2)
									{
										goto IL_233;
									}
									num ^= 145000721U;
								}
								num = 1532579441U + num;
								if (num != 709321795U)
								{
									goto Block_15;
								}
								continue;
							}
							IL_233:
							num -= 754398560U;
							if ((num ^ 10570745U) != 0U)
							{
								goto IL_293;
							}
						}
					}
				}
				IL_293:
				GClass18 gclass = new GClass18();
				num = 1132789925U >> (int)num;
				object obj = gclass.method_112(array2, int_1);
				num *= 935949032U;
				object obj2 = obj;
				num %= 1521109965U;
				if (num >= 953104988U)
				{
					goto IL_2E8;
				}
			}
		}
		Block_15:
		throw new NullReferenceException();
		IL_2E8:
		Dictionary<int, GClass18.Class7> dictionary2 = dictionary;
		num = 1798197524U / num;
		Dictionary<int, GClass18.Class7>.Enumerator enumerator = dictionary2.GetEnumerator();
		num /= 1497262946U;
		using (Dictionary<int, GClass18.Class7>.Enumerator enumerator2 = enumerator)
		{
			do
			{
				for (;;)
				{
					num -= 718420770U;
					if (1962152201U > num)
					{
						goto IL_367;
					}
					if (!enumerator2.MoveNext())
					{
						break;
					}
					KeyValuePair<int, GClass18.Class7> keyValuePair = enumerator2.Current;
					object[] array2;
					keyValuePair.Value.vmethod_2(array2[keyValuePair.Key]);
					num = 0U;
				}
			}
			while ((689312191U ^ num) == 0U);
			IL_367:
			goto IL_3BC;
		}
		IL_37D:
		num <<= 4;
		num = 1319465248U - num;
		int int_3 = num11;
		num /= 785212712U;
		Type type = this.method_26(int_3);
		num /= 159061809U;
		Type type2 = type;
		num = 1444024724U << (int)num;
		if (num >= 308747087U)
		{
			goto IL_3CE;
		}
		IL_3BC:
		bool flag3 = num11 != 0;
		num = 1800102124U;
		if (flag3)
		{
			goto IL_37D;
		}
		goto IL_3ED;
		IL_3CE:
		Type type3 = type2;
		RuntimeTypeHandle handle = typeof(void).TypeHandle;
		num -= 579153215U;
		Type typeFromHandle = Type.GetTypeFromHandle(handle);
		num ^= 1489470649U;
		if (type3 != typeFromHandle)
		{
			num = 1250849031U >> (int)num;
			num >>= 6;
			object obj2;
			object object_2 = obj2;
			num /= 1882853472U;
			Type type_ = type2;
			num = (947411866U & num);
			return this.method_24(object_2, type_);
		}
		IL_3ED:
		num >>= 30;
		if ((num & 1071645217U) != 0U)
		{
			return null;
		}
		goto IL_3CE;
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x00019394 File Offset: 0x00017594
	private bool method_33(object object_0, Type type_1)
	{
		uint num = 1367296119U;
		if (object_0 == null)
		{
			return (num ^ 1367296118U) != 0U;
		}
		num = 1475420473U + num;
		Type type = object_0.GetType();
		num = (1945111617U & num);
		Type type2 = type;
		num &= 715261153U;
		Type type3 = type2;
		num /= 638613163U;
		num &= 198127976U;
		if (type3 != type_1)
		{
			num += 2019184345U;
			num *= 1999441154U;
			Type c = type2;
			num /= 1740340752U;
			bool flag = type_1.IsAssignableFrom(c);
			num = (1240081101U & num);
			if (!flag)
			{
				num &= 1398161647U;
				return (num ^ 0U) != 0U;
			}
			num ^= 0U;
		}
		return num - uint.MaxValue != 0U;
	}

	// Token: 0x06000643 RID: 1603 RVA: 0x00019430 File Offset: 0x00017630
	private void method_34(Exception exception_1)
	{
		uint num;
		GClass18.Class36 class2;
		for (;;)
		{
			IL_00:
			this.stack_0.Clear();
			num = 2U;
			for (;;)
			{
				IL_49F:
				num <<= 22;
				Stack<int> stack = this.stack_2;
				num *= 463037907U;
				stack.Clear();
				if (164705744 << (int)num != 0)
				{
					for (;;)
					{
						IL_406:
						bool flag = this.class36_0 != null;
						num = 529690113U / num;
						if (!flag)
						{
							num = (1132947484U ^ num);
							if (367294371U >> (int)num != 0U)
							{
								goto IL_3B6;
							}
							goto IL_00;
						}
						IL_3D9:
						while (num << 26 == 0U)
						{
							num = 1526807882U - num;
							if (this.stack_1.Count == 0)
							{
								goto Block_0;
							}
							for (;;)
							{
								IL_343:
								List<GClass18.Class36> list = this.stack_1.Peek().method_4();
								num = 2746655047U;
								int num2;
								if (this.class36_0 != null)
								{
									if (1738362990U + num == 0U)
									{
										goto IL_49F;
									}
									List<GClass18.Class36> list2 = list;
									num = 2142664713U / num;
									num = 84098941U + num;
									num2 = list2.IndexOf(this.class36_0) + (int)(num + 4210868356U);
								}
								else
								{
									num2 = (int)(num ^ 2746655047U);
									num += 1632411190U;
								}
								GClass18.Class36 @class = null;
								num = 113715271U % num;
								this.class36_0 = @class;
								num /= 830759573U;
								int num3 = num2;
								if (909321229U >= num)
								{
									while (1137977001U - num != 0U)
									{
										int num4 = num3;
										num = (305469004U & num);
										List<GClass18.Class36> list3 = list;
										num = (1980322664U & num);
										if (num4 < list3.Count)
										{
											class2 = list[num3];
											byte b = class2.method_0();
											num = 153U;
											if (b != 0)
											{
												num = (1812547676U | num);
												if (num - 274081081U == 0U)
												{
													goto IL_00;
												}
												if ((uint)b == num - 1812547804U)
												{
													goto IL_42D;
												}
											}
											else
											{
												num += 1895918274U;
												Type type = exception_1.GetType();
												num += 607943567U;
												if ((num & 1474252607U) == 0U)
												{
													goto IL_49F;
												}
												num = 663251320U << (int)num;
												GClass18.Class36 class3 = class2;
												num = 105332984U / num;
												int int_ = class3.method_2();
												num <<= 26;
												Type type2 = this.method_26(int_);
												num = (44776237U ^ num);
												if (num + 1282892982U == 0U)
												{
													goto IL_00;
												}
												Type type3 = type;
												num ^= 901150370U;
												if (type3 == type2)
												{
													goto IL_4D9;
												}
												if (num < 7283201U)
												{
													goto IL_406;
												}
												Type type4 = type;
												num = 154480543U / num;
												Type c = type2;
												num <<= 14;
												bool flag2 = type4.IsSubclassOf(c);
												num = (1996305072U | num);
												num += 4111210029U;
												if (flag2)
												{
													goto IL_4D1;
												}
											}
											num = 2069256062U + num;
											int num5 = num3;
											num = 1287596119U << (int)num;
											int num6 = num5 + (int)(num + 1207959553U);
											num = (1763588713U | num);
											num3 = num6;
											num ^= 4179507817U;
										}
										else
										{
											num = 483160339U + num;
											Stack<GClass18.Class37> stack2 = this.stack_1;
											num *= 913392582U;
											stack2.Pop();
											num /= 1336619015U;
											if ((814111003U ^ num) != 0U)
											{
												List<GClass18.Class36> list4 = list;
												num *= 185159614U;
												int count = list4.Count;
												num = 1130639664U / num;
												int num7 = count;
												while ((40178927U ^ num) != 0U)
												{
													int num8 = num7;
													uint num9 = num ^ 3U;
													num = (1485709896U ^ num);
													if (num8 <= num9)
													{
														goto IL_380;
													}
													GClass18.Class36 class4 = list[num7 - 1];
													GClass18.Class36 class5 = class4;
													num = 3676519712U;
													if (class5.method_0() == 2)
													{
														goto IL_294;
													}
													num += 1671592909U;
													byte b2 = class4.method_0();
													num = 1627915978U >> (int)num;
													uint num10 = num ^ 198724U;
													num /= 861620405U;
													if (b2 == num10)
													{
														num ^= 3676519712U;
														goto IL_294;
													}
													IL_2CA:
													num = (1853258024U | num);
													int num11 = num7;
													num <<= 11;
													int num12 = (int)(num ^ 3016310785U);
													num ^= 1118469013U;
													int num13 = num11 - num12;
													num = 582092534U - num;
													num7 = num13;
													num ^= 827247458U;
													continue;
													IL_294:
													num = 1336413626U - num;
													if (num / 70526898U != 0U)
													{
														num /= 1665729348U;
														this.stack_2.Push(class4.method_1());
														num += uint.MaxValue;
														goto IL_2CA;
													}
													goto IL_343;
												}
												goto IL_00;
											}
											goto IL_49F;
										}
									}
									goto IL_3B6;
								}
								goto IL_49F;
							}
							IL_380:
							num >>= 18;
							if (957838227U + num == 0U)
							{
								break;
							}
							num &= 1731604906U;
							bool count2 = this.stack_2.Count != 0;
							num += 4294963166U;
							if (count2)
							{
								goto Block_20;
							}
						}
						goto IL_00;
						IL_3B6:
						num = (820861026U ^ num);
						this.exception_0 = exception_1;
						if ((num ^ 106500039U) != 0U)
						{
							num += 2358628226U;
							goto IL_3D9;
						}
						goto IL_00;
					}
					Block_0:
					num = 540221817U - num;
					if (892287354U < num)
					{
						goto Block_25;
					}
					continue;
					IL_42D:
					num -= 2105360018U;
					GClass18.Class36 class6 = class2;
					num = 74403528U + num;
					this.class36_0 = class6;
					num = (1599475660U | num);
					Stack<GClass18.Class8> stack3 = this.stack_0;
					num += 1541759768U;
					num = 935531054U / num;
					object object_ = this.exception_0;
					num <<= 3;
					stack3.Push(new GClass18.Class14(object_));
					num -= 1957830063U;
					int num14 = class2.method_2();
					num ^= 2144103794U;
					this.int_0 = num14;
					if ((1667312979U & num) != 0U)
					{
						return;
					}
				}
			}
		}
		Block_20:
		num |= 1644708303U;
		num = 324536972U - num;
		this.int_0 = this.stack_2.Pop();
		return;
		Block_25:
		throw exception_1;
		IL_4D1:
		num ^= 1528038738U;
		IL_4D9:
		num &= 1204108353U;
		this.stack_1.Pop();
		num /= 1544836475U;
		Stack<GClass18.Class8> stack4 = this.stack_0;
		num = 1400600469U >> (int)num;
		GClass18.Class8 item = new GClass18.Class14(this.exception_0);
		num = (1127111720U & num);
		stack4.Push(item);
		num = (800991775U | num);
		int num15 = class2.method_1();
		num = (291123577U & num);
		this.int_0 = num15;
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x0001999C File Offset: 0x00017B9C
	private void method_35()
	{
		uint num;
		do
		{
			Type type_ = this.method_26(this.method_1().EC4893C4());
			GClass18.Class7 @class = this.method_1();
			GClass18.Class7 class2 = this.method_24(this.method_1().vmethod_1(), type_);
			num = 128333029U;
			if (@class.vmethod_3())
			{
				GClass18.Class7 class7_ = class2;
				GClass18.Class7 class7_2 = @class;
				num = 756483542U << (int)num;
				class2 = new GClass18.Class20(class7_, class7_2);
				num += 1690663461U;
			}
			num /= 1358783938U;
			num = 856253796U << (int)num;
			this.list_0.Add(class2);
		}
		while (num <= 697376489U);
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x00019A50 File Offset: 0x00017C50
	private void method_36()
	{
		int num = this.method_1().EC4893C4();
		List<GClass18.Class37> list = this.list_1;
		uint num2 = 1212342642U;
		using (List<GClass18.Class37>.Enumerator enumerator = list.GetEnumerator())
		{
			for (;;)
			{
				num2 = 1983341164U >> (int)num2;
				num2 = (34218286U ^ num2);
				bool flag = enumerator.MoveNext();
				num2 |= 2053314115U;
				if (!flag)
				{
					break;
				}
				GClass18.Class37 @class = enumerator.Current;
				int num3 = @class.method_0();
				int num4 = num;
				num2 = 1212342642U;
				if (num3 == num4)
				{
					Stack<GClass18.Class37> stack = this.stack_1;
					num2 = 1697786827U >> (int)num2;
					GClass18.Class37 item = @class;
					num2 &= 966792707U;
					stack.Push(item);
					num2 ^= 1212346738U;
				}
			}
		}
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x00019B40 File Offset: 0x00017D40
	private void method_37()
	{
		this.method_0(new GClass18.Class9(this.method_5()));
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x00019B60 File Offset: 0x00017D60
	private void method_38()
	{
		this.method_0(new GClass18.Class10(this.method_6()));
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x00019B80 File Offset: 0x00017D80
	private void method_39()
	{
		this.method_0(new GClass18.Class11(this.method_7()));
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x00019BA0 File Offset: 0x00017DA0
	private void method_40()
	{
		this.method_0(new GClass18.Class12(this.method_8()));
	}

	// Token: 0x0600064A RID: 1610 RVA: 0x00019BC0 File Offset: 0x00017DC0
	private void method_41()
	{
		uint num = 499986032U;
		do
		{
			this.method_0(new GClass18.Class14(null));
		}
		while (2020485291 << (int)num == 0);
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x00019BF0 File Offset: 0x00017DF0
	private void method_42()
	{
		uint num = 2055933053U;
		do
		{
			num &= 1067397545U;
			int int_ = this.method_1().EC4893C4();
			num = 954871940U * num;
			this.method_0(new GClass18.Class13(this.method_25(int_)));
		}
		while (num >> 3 == 0U);
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x00019C38 File Offset: 0x00017E38
	private void method_43()
	{
		this.method_0(this.method_2().vmethod_0());
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x00019C58 File Offset: 0x00017E58
	private void method_44()
	{
		GClass18.Class7 class7_ = this.method_1();
		GClass18.Class7 class7_2 = this.method_1();
		this.method_0(this.method_11(class7_, class7_2, false, false));
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x00019C84 File Offset: 0x00017E84
	private void method_45()
	{
		GClass18.Class7 class7_ = this.method_1();
		GClass18.Class7 class7_2 = this.method_1();
		this.method_0(this.method_11(class7_, class7_2, true, false));
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x00019CB0 File Offset: 0x00017EB0
	private void method_46()
	{
		uint num = 448947294U;
		GClass18.Class7 class2;
		do
		{
			GClass18.Class7 @class = this.method_1();
			num = 1149845479U / num;
			class2 = @class;
		}
		while ((num ^ 958807041U) == 0U);
		GClass18.Class7 class3 = this.method_1();
		num = (1872657265U & num);
		GClass18.Class7 class4 = class3;
		num = 130355802U << (int)num;
		num = 478892889U >> (int)num;
		num = 391794354U >> (int)num;
		GClass18.Class7 class7_ = class2;
		GClass18.Class7 class7_2 = class4;
		num %= 28646154U;
		bool bool_ = (num ^ 3060892U) != 0U;
		num |= 20797204U;
		bool bool_2 = (num ^ 20969372U) != 0U;
		num ^= 976163365U;
		this.method_0(this.method_11(class7_, class7_2, bool_, bool_2));
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x00019D48 File Offset: 0x00017F48
	private void method_47()
	{
		GClass18.Class7 class7_ = this.method_1();
		GClass18.Class7 class7_2 = this.method_1();
		this.method_0(this.method_12(class7_2, class7_, false, false));
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x00019D74 File Offset: 0x00017F74
	private void method_48()
	{
		GClass18.Class7 class7_ = this.method_1();
		GClass18.Class7 class7_2 = this.method_1();
		this.method_0(this.method_12(class7_2, class7_, true, false));
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x00019DA0 File Offset: 0x00017FA0
	private void method_49()
	{
		GClass18.Class7 class7_ = this.method_1();
		GClass18.Class7 class7_2 = this.method_1();
		this.method_0(this.method_12(class7_2, class7_, true, true));
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x00019DCC File Offset: 0x00017FCC
	private void method_50()
	{
		uint num = 526720371U;
		GClass18.Class7 class2;
		do
		{
			num = 1207049638U - num;
			GClass18.Class7 @class = this.method_1();
			num = 1186223070U >> (int)num;
			class2 = @class;
		}
		while (322376266U < num);
		GClass18.Class7 class3 = this.method_1();
		num >>= 29;
		GClass18.Class7 class4 = class3;
		num = 2090886098U + num;
		GClass18.Class7 class7_ = class4;
		GClass18.Class7 class7_2 = class2;
		bool bool_ = num + 2204081198U != 0U;
		bool bool_2 = (num ^ 2090886098U) != 0U;
		num = (811012523U ^ num);
		GClass18.Class7 class7_3 = this.method_13(class7_, class7_2, bool_, bool_2);
		num += 278402974U;
		this.method_0(class7_3);
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x00019E48 File Offset: 0x00018048
	private void method_51()
	{
		GClass18.Class7 class7_ = this.method_1();
		GClass18.Class7 class7_2 = this.method_1();
		this.method_0(this.method_13(class7_2, class7_, true, false));
	}

	// Token: 0x06000655 RID: 1621 RVA: 0x00019E74 File Offset: 0x00018074
	private void method_52()
	{
		for (;;)
		{
			GClass18.Class7 @class = this.method_1();
			uint num = 540U;
			for (;;)
			{
				num ^= 1155938589U;
				GClass18.Class7 class2 = this.method_1();
				if ((num ^ 124853633U) == 0U)
				{
					break;
				}
				num |= 1152014965U;
				num = 1160006395U * num;
				GClass18.Class7 class7_ = class2;
				num = (1622147393U | num);
				GClass18.Class7 class7_2 = @class;
				num &= 999243013U;
				bool bool_ = (num ^ 713432324U) != 0U;
				num |= 852779910U;
				bool bool_2 = num - 987135878U != 0U;
				num = (350967305U ^ num);
				GClass18.Class7 class7_3 = this.method_13(class7_, class7_2, bool_, bool_2);
				num = 705583192U * num;
				this.method_0(class7_3);
				if (2039164754 << (int)num != 0)
				{
					return;
				}
			}
		}
	}

	// Token: 0x06000656 RID: 1622 RVA: 0x00019F1C File Offset: 0x0001811C
	private void method_53()
	{
		GClass18.Class7 class7_ = this.method_1();
		GClass18.Class7 class7_2 = this.method_1();
		this.method_0(this.method_14(class7_2, class7_, false));
	}

	// Token: 0x06000657 RID: 1623 RVA: 0x00019F48 File Offset: 0x00018148
	private void method_54()
	{
		GClass18.Class7 @class = this.method_1();
		uint num = 0U;
		do
		{
			num -= 1904956937U;
			GClass18.Class7 class2 = this.method_1();
			num = (1718947008U & num);
			GClass18.Class7 class7_ = class2;
			GClass18.Class7 class7_2 = @class;
			bool bool_ = num + 4186699585U != 0U;
			num = 706561354U % num;
			GClass18.Class7 class7_3 = this.method_14(class7_, class7_2, bool_);
			num = 104230683U * num;
			this.method_0(class7_3);
		}
		while (790626807U >= num);
	}

	// Token: 0x06000658 RID: 1624 RVA: 0x00019FA8 File Offset: 0x000181A8
	private void method_55()
	{
		GClass18.Class7 @class = this.method_1();
		uint num = 1807702773U;
		GClass18.Class7 class2 = this.method_1();
		do
		{
			num = 2094793184U - num;
			num = (1387622790U ^ num);
			GClass18.Class7 class7_ = class2;
			GClass18.Class7 class7_2 = @class;
			num += 1358318270U;
			bool bool_ = (num ^ 2493522475U) != 0U;
			num = 1474844969U * num;
			GClass18.Class7 class7_3 = this.method_15(class7_, class7_2, bool_);
			num -= 1630349661U;
			this.method_0(class7_3);
		}
		while (1133395652 << (int)num == 0);
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x0001A01C File Offset: 0x0001821C
	private void method_56()
	{
		uint num = 398660109U;
		GClass18.Class7 class2;
		GClass18.Class7 class3;
		do
		{
			GClass18.Class7 @class = this.method_1();
			num ^= 673863866U;
			class2 = @class;
			num = 393365854U << (int)num;
			if (212010451U + num == 0U)
			{
				break;
			}
			class3 = this.method_1();
			num = 367350104U >> (int)num;
		}
		while ((num ^ 310721811U) == 0U);
		num %= 1411274344U;
		GClass18.Class7 class7_ = class3;
		num += 1213556374U;
		GClass18.Class7 class7_2 = class2;
		bool bool_ = (num ^ 1580906479U) != 0U;
		num %= 1493053973U;
		this.method_0(this.method_15(class7_, class7_2, bool_));
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x0001A0A4 File Offset: 0x000182A4
	private void method_57()
	{
		uint num = 1894390882U;
		GClass18.Class7 class2;
		do
		{
			num -= 1232345292U;
			GClass18.Class7 @class = this.method_1();
			num >>= 19;
			class2 = @class;
		}
		while (832508886U - num == 0U);
		num /= 233313828U;
		GClass18.Class7 class3 = this.method_1();
		num = 1084507762U - num;
		GClass18.Class7 class4 = class3;
		num >>= 18;
		if (num < 885400357U)
		{
			num = (1480656120U ^ num);
			num -= 1786580053U;
			GClass18.Class7 class7_ = class4;
			num = 1645177686U + num;
			GClass18.Class7 class7_2 = class2;
			num = 469320U + num;
			this.method_0(this.method_18(class7_, class7_2));
		}
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x0001A12C File Offset: 0x0001832C
	private void method_58()
	{
		GClass18.Class7 class7_ = this.method_1();
		GClass18.Class7 class7_2 = this.method_1();
		this.method_0(this.method_17(class7_2, class7_));
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x0001A158 File Offset: 0x00018358
	private void method_59()
	{
		uint num = 1285387817U;
		GClass18.Class7 class7_ = this.method_1();
		do
		{
			GClass18.Class7 @class = this.method_1();
			num &= 1559241956U;
			num = 454982064U + num;
			GClass18.Class7 class7_2 = @class;
			num *= 2002731398U;
			this.method_0(this.method_16(class7_2, class7_));
		}
		while (994850994U + num == 0U);
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x0001A1A8 File Offset: 0x000183A8
	private void method_60()
	{
		GClass18.Class7 class7_ = this.method_1();
		this.method_0(this.method_20(class7_));
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x0001A1CC File Offset: 0x000183CC
	private void method_61()
	{
		uint num = 1337017772U;
		GClass18.Class7 class2;
		do
		{
			GClass18.Class7 @class = this.method_1();
			num = 1711890208U << (int)num;
			class2 = @class;
		}
		while ((num ^ 938571711U) == 0U);
		do
		{
			num %= 972123073U;
			GClass18.Class7 class7_ = class2;
			num = 1507417107U * num;
			this.method_0(this.method_21(class7_));
		}
		while (1357251611U - num == 0U);
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x0001A224 File Offset: 0x00018424
	private void method_62()
	{
		uint num = 1926910014U;
		GClass18.Class7 class7_;
		do
		{
			class7_ = this.method_1();
			num = 1091517371U + num;
		}
		while (361069024U >> (int)num == 0U);
		do
		{
			num = 1820737197U % num;
			GClass18.Class7 @class = this.method_1();
			num |= 319061360U;
			GClass18.Class7 class7_2 = @class;
			num %= 1119748757U;
			GClass18.Class7 class7_3 = this.method_22(class7_2, class7_, num - 1019772264U != 0U);
			num = (863463812U & num);
			this.method_0(class7_3);
		}
		while (430600787U - num == 0U);
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x0001A29C File Offset: 0x0001849C
	private void method_63()
	{
		GClass18.Class7 class7_ = this.method_1();
		GClass18.Class7 class7_2 = this.method_1();
		this.method_0(this.method_22(class7_2, class7_, true));
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x0001A2C8 File Offset: 0x000184C8
	private void method_64()
	{
		uint num = 1373728590U;
		GClass18.Class7 class7_;
		GClass18.Class7 class7_2;
		do
		{
			num = (538599710U | num);
			class7_ = this.method_1();
			num += 288322897U;
			num = 2051420281U << (int)num;
			GClass18.Class7 @class = this.method_1();
			num = (1922437518U ^ num);
			class7_2 = @class;
		}
		while (887579901U >= num);
		this.method_0(this.method_23(class7_2, class7_));
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x0001A328 File Offset: 0x00018528
	private void method_65()
	{
		Type type_ = this.method_26(this.method_1().EC4893C4());
		this.method_0(this.method_24(this.method_1(), type_));
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x0001A35C File Offset: 0x0001855C
	private void method_66()
	{
		Type type_ = this.method_26(this.method_1().EC4893C4());
		this.method_0(this.method_24(this.method_1().CB7019CC(type_, false), type_));
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x0001A398 File Offset: 0x00018598
	private void method_67()
	{
		Type type = this.method_26(this.method_1().EC4893C4());
		uint num = 2585817807U;
		Type type2 = type;
		do
		{
			num = 546964787U % num;
			GClass18.Class7 @class = this.method_1();
			Type type3 = type2;
			bool bool_ = num + 3748002510U != 0U;
			num >>= 31;
			GClass18.Class7 class7_ = this.method_24(@class.CB7019CC(type3, bool_), type2);
			num = 731533351U >> (int)num;
			this.method_0(class7_);
		}
		while (num == 185168849U);
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x0001A420 File Offset: 0x00018620
	private void method_68()
	{
		this.method_0(new GClass18.Class9(Marshal.SizeOf(this.method_26(this.method_5()))));
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x0001A44C File Offset: 0x0001864C
	private void method_69()
	{
		Type type_;
		uint num;
		GClass18.Class7 @class;
		for (;;)
		{
			type_ = this.method_26(this.method_1().EC4893C4());
			num = 1U;
			for (;;)
			{
				num = 691940888U % num;
				@class = this.method_1();
				if (num <= 2018859205U)
				{
					if (@class.vmethod_3())
					{
						goto IL_C2;
					}
					num >>= 10;
					if (num >= 1854015864U)
					{
						break;
					}
				}
				GClass18.Class7 class2 = @class;
				num /= 1059332084U;
				object obj = class2.vmethod_1();
				num = 1313297718U << (int)num;
				if (!(obj is Pointer))
				{
					goto IL_BC;
				}
				if (num / 708722714U != 0U)
				{
					goto Block_1;
				}
			}
		}
		Block_1:
		GClass18.Class7 class3 = @class;
		num = (1044740619U ^ num);
		object ptr = class3.vmethod_1();
		num = 1716218881U - num;
		IntPtr intptr_ = new IntPtr(Pointer.Unbox(ptr));
		num *= 1766414361U;
		@class = new GClass18.Class23(intptr_, type_);
		num += 236040412U;
		goto IL_C2;
		IL_BC:
		throw new ArgumentException();
		IL_C2:
		num <<= 21;
		GClass18.Class7 class7_ = this.method_24(@class, type_);
		num = 1407799959U - num;
		this.method_0(class7_);
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x0001A53C File Offset: 0x0001873C
	private void method_70()
	{
		FieldInfo fieldInfo;
		object obj;
		uint num;
		do
		{
			fieldInfo = this.method_28(this.method_1().EC4893C4());
			do
			{
				obj = this.method_1().vmethod_1();
				num = 448140553U;
				if (fieldInfo.IsStatic)
				{
					goto IL_67;
				}
			}
			while (1410018944U >> (int)num == 0U);
			bool flag = obj != null;
			num = 307773766U * num;
			num += 3028093843U;
			if (flag)
			{
				goto IL_67;
			}
		}
		while (978933274U % num == 0U);
		throw new NullReferenceException();
		IL_67:
		num = 2031093328U - num;
		num = 1185379139U - num;
		FieldInfo fieldInfo2 = fieldInfo;
		num = (2115439423U ^ num);
		object obj2 = obj;
		num = (2000295733U & num);
		object value = fieldInfo2.GetValue(obj2);
		Type fieldType = fieldInfo.FieldType;
		num *= 183852705U;
		GClass18.Class7 class7_ = this.method_24(value, fieldType);
		num = 1435849996U + num;
		this.method_0(class7_);
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x0001A5FC File Offset: 0x000187FC
	private void method_71()
	{
		uint num = 992746913U;
		FieldInfo fieldInfo;
		do
		{
			num /= 1116695645U;
			fieldInfo = this.method_28(this.method_1().EC4893C4());
		}
		while (num >= 1688077578U);
		for (;;)
		{
			num |= 238885833U;
			object obj = this.method_1().vmethod_1();
			if (!fieldInfo.IsStatic)
			{
				if (2144092772U == num)
				{
					continue;
				}
				bool flag = obj != null;
				num ^= 0U;
				if (!flag)
				{
					goto Block_5;
				}
			}
			num = 1577782908U / num;
			if (num <= 1657607475U)
			{
				num ^= 172760311U;
				GClass18.Class7 class7_ = new GClass18.Class21(fieldInfo, obj);
				num = 596122344U >> (int)num;
				this.method_0(class7_);
				if (1328680143U != num)
				{
					break;
				}
			}
		}
		return;
		Block_5:
		throw new NullReferenceException();
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x0001A6AC File Offset: 0x000188AC
	private void method_72()
	{
		uint num = 653548272U;
		for (;;)
		{
			num ^= 229340850U;
			GClass18.Class7 @class = this.method_1();
			num = 154080380U + num;
			FieldInfo fieldInfo = this.method_28(@class.EC4893C4());
			if (num * 594491086U != 0U)
			{
				GClass18.Class7 class2 = this.method_1();
				num = 155338707U >> (int)num;
				GClass18.Class7 class3 = class2;
				num -= 833762213U;
				object obj;
				do
				{
					num = (597452762U ^ num);
					obj = this.method_1().vmethod_1();
					num += 1357059649U;
					if (228673170U >= num)
					{
						break;
					}
					if (fieldInfo.IsStatic)
					{
						goto IL_80;
					}
					num *= 1970809166U;
				}
				while (num == 958692566U);
				IL_68:
				bool flag = obj != null;
				num ^= 3049249502U;
				if (flag)
				{
					goto IL_80;
				}
				if (837037423U < num)
				{
					break;
				}
				continue;
				goto IL_68;
				IL_80:
				num <<= 5;
				if (1634074845U <= num)
				{
					FieldInfo fieldInfo2 = fieldInfo;
					object obj2 = obj;
					num &= 1405167573U;
					num -= 723544057U;
					object object_ = class3;
					num = (1602828735U & num);
					FieldInfo fieldInfo3 = fieldInfo;
					num = 1630825222U - num;
					Type fieldType = fieldInfo3.FieldType;
					num -= 41497409U;
					GClass18.Class7 class4 = this.method_24(object_, fieldType);
					num += 1381442551U;
					fieldInfo2.SetValue(obj2, class4.vmethod_1());
					if (num > 2084176368U)
					{
						return;
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x0001A7D0 File Offset: 0x000189D0
	private void method_73()
	{
		FieldInfo fieldInfo = this.method_28(this.method_1().EC4893C4());
		GClass18.Class7 object_ = this.method_1();
		fieldInfo.SetValue(null, this.method_24(object_, fieldInfo.FieldType).vmethod_1());
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x0001A810 File Offset: 0x00018A10
	private unsafe void method_74()
	{
		uint num = 1687105111U;
		Type type2;
		GClass18.Class7 class2;
		GClass18.Class7 class4;
		for (;;)
		{
			num = 137890014U + num;
			GClass18.Class7 @class = this.method_1();
			num += 1861354568U;
			int int_ = @class.EC4893C4();
			num ^= 636580334U;
			Type type = this.method_26(int_);
			num -= 588074739U;
			type2 = type;
			num |= 1678067351U;
			do
			{
				num = 472658786U << (int)num;
				class2 = this.method_1();
				num = 1292841526U * num;
				GClass18.Class7 class3 = this.method_1();
				num = 1672242095U + num;
				class4 = class3;
			}
			while (570058581U == num);
			bool flag = class4.vmethod_3();
			num ^= 188241382U;
			if (flag)
			{
				goto IL_117;
			}
			num = 230181050U >> (int)num;
			if (num <= 374162898U)
			{
				if (class4.vmethod_1() is Pointer)
				{
					num &= 500370699U;
					if (num + 1266513686U != 0U)
					{
						break;
					}
				}
				else
				{
					num ^= 976322550U;
					if (num << 0 != 0U)
					{
						goto IL_111;
					}
				}
			}
		}
		object ptr = class4.vmethod_1();
		num = 1409169228U / num;
		void* value = Pointer.Unbox(ptr);
		num ^= 1462518957U;
		IntPtr intptr_ = new IntPtr(value);
		Type type_ = type2;
		num *= 963853156U;
		class4 = new GClass18.Class23(intptr_, type_);
		num ^= 4197117245U;
		goto IL_117;
		IL_111:
		throw new ArgumentException();
		IL_117:
		GClass18.Class7 class5 = class4;
		object object_ = class2;
		num |= 801799998U;
		Type type_2 = type2;
		num -= 1485844027U;
		class5.vmethod_2(this.method_24(object_, type_2).vmethod_1());
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x0001A958 File Offset: 0x00018B58
	private void method_75()
	{
		this.method_0(this.list_0[(int)((ushort)this.method_4())].vmethod_0());
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x0001A984 File Offset: 0x00018B84
	private void method_76()
	{
		this.method_0(new GClass18.Class19(this.list_0[(int)((ushort)this.method_4())]));
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x0001A9B0 File Offset: 0x00018BB0
	private void method_77()
	{
		GClass18.Class7 @class = this.method_1();
		uint num = 0U;
		GClass18.Class7 class2 = @class;
		do
		{
			List<GClass18.Class7> list = this.list_0;
			num = 332544955U * num;
			GClass18.Class7 class3 = list[(int)((ushort)this.method_4())];
			num = 933764893U * num;
			GClass18.Class7 class4 = class3;
			GClass18.Class7 class5 = class4;
			num <<= 0;
			num >>= 22;
			object object_ = class2;
			Type type_ = class4.vmethod_6();
			num |= 667100140U;
			GClass18.Class7 class6 = this.method_24(object_, type_);
			num %= 1231955009U;
			class5.vmethod_2(class6.vmethod_1());
		}
		while (1944544126U % num == 0U);
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x0001AA30 File Offset: 0x00018C30
	private void method_78()
	{
		this.type_0 = this.method_26(this.method_1().EC4893C4());
	}

	// Token: 0x06000670 RID: 1648 RVA: 0x0001AA54 File Offset: 0x00018C54
	private void method_79()
	{
		MethodBase methodBase_ = this.method_27(this.method_1().EC4893C4());
		GClass18.Class7 @class = this.method_31(methodBase_, false);
		bool flag = @class != null;
		uint num = 4038027008U;
		if (flag)
		{
			num &= 940981505U;
			num /= 20724568U;
			GClass18.Class7 class7_ = @class;
			num = (1567521592U ^ num);
			this.method_0(class7_);
			num ^= 2915114014U;
		}
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x0001AADC File Offset: 0x00018CDC
	private void method_80()
	{
		uint num;
		GClass18.Class7 @class;
		for (;;)
		{
			MethodBase methodBase = this.method_27(this.method_1().EC4893C4());
			num = 1409286144U;
			do
			{
				num %= 1558275475U;
				if (this.type_0 == null)
				{
					goto IL_171;
				}
				num = 335707335U / num;
			}
			while (1050029990U == num);
			ParameterInfo[] parameters = methodBase.GetParameters();
			num += 1218782384U;
			int num2 = parameters.Length;
			num = 1621630697U * num;
			Type[] array = new Type[num2];
			int num3 = (int)(num - 2350580784U);
			num = 593309077U << (int)num;
			int num4 = num3;
			num <<= 30;
			ParameterInfo[] array2 = parameters;
			num %= 691437144U;
			int num5 = (int)(num - 0U);
			if (num >= 968634115U)
			{
				continue;
			}
			for (;;)
			{
				num >>= 3;
				int num6 = num5;
				num /= 1951555306U;
				int num7 = array2.Length;
				num ^= 2143488224U;
				if (num6 >= num7)
				{
					break;
				}
				ParameterInfo parameterInfo = array2[num5];
				array[num4++] = parameterInfo.ParameterType;
				num5++;
				num = 0U;
			}
			num = (1798314194U & num);
			Type type = this.type_0;
			num = 1696597580U % num;
			string name = methodBase.Name;
			BindingFlags bindingAttr = (int)num + (BindingFlags)(-1696584984);
			num *= 299445059U;
			Binder binder = null;
			num = (183634589U ^ num);
			MethodInfo method = type.GetMethod(name, bindingAttr, binder, array, null);
			num = 1445531099U + num;
			MethodInfo methodInfo = method;
			if (methodInfo != null)
			{
				num <<= 9;
				methodBase = methodInfo;
				num ^= 683006292U;
			}
			num &= 1453154600U;
			this.type_0 = null;
			num ^= 1377132800U;
			IL_171:
			if (num != 1709210856U)
			{
				num /= 617315989U;
				MethodBase methodBase_ = methodBase;
				bool bool_ = num + uint.MaxValue != 0U;
				num *= 211817295U;
				@class = this.method_31(methodBase_, bool_);
				num = 1054159273U - num;
				if (@class == null)
				{
					return;
				}
				num = 1549564243U / num;
				if (num << 21 != 0U)
				{
					break;
				}
			}
		}
		num += 116682670U;
		GClass18.Class7 class7_ = @class;
		num |= 1063460195U;
		this.method_0(class7_);
		num ^= 442660088U;
	}

	// Token: 0x06000672 RID: 1650 RVA: 0x0001ACC8 File Offset: 0x00018EC8
	private void method_81()
	{
		uint num = 656761624U;
		GClass18.Class7 @class;
		for (;;)
		{
			num += 1171000556U;
			MethodBase methodBase = this.method_1().vmethod_1() as MethodBase;
			if (1305741706U < num)
			{
				for (;;)
				{
					bool flag = methodBase != null;
					num &= 2131248786U;
					if (!flag)
					{
						break;
					}
					num = (1968275314U ^ num);
					if (num != 1728851557U)
					{
						@class = this.method_31(methodBase, num - 424755058U != 0U);
						if (1905278074U >> (int)num != 0U)
						{
							goto IL_73;
						}
					}
				}
				if (num % 1312715715U != 0U)
				{
					break;
				}
			}
		}
		throw new ArgumentException();
		IL_73:
		bool flag2 = @class != null;
		num ^= 1230536614U;
		if (flag2)
		{
			num += 690174538U;
			this.method_0(@class);
			num += 3604792758U;
		}
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x0001AD6C File Offset: 0x00018F6C
	private void method_82()
	{
		uint num = 1479691061U;
		GClass18.Class7 @class;
		for (;;)
		{
			int int_ = this.method_1().EC4893C4();
			bool bool_ = (num ^ 1479691061U) != 0U;
			num /= 1825650504U;
			@class = this.method_32(int_, bool_);
			num = 285768154U + num;
			if (num - 1154831617U != 0U)
			{
				bool flag = @class != null;
				num += 1465386560U;
				if (!flag)
				{
					return;
				}
				num = 1225669425U * num;
				if (1183720568U <= num)
				{
					break;
				}
			}
		}
		num >>= 10;
		this.method_0(@class);
		num += 1748477306U;
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x0001ADE8 File Offset: 0x00018FE8
	private void method_83()
	{
		GClass18.Class7 @class = this.method_32(this.method_1().EC4893C4(), true);
		uint num = 1333828U;
		GClass18.Class7 class2 = @class;
		if (class2 != null)
		{
			num = 1690315359U + num;
			num >>= 28;
			GClass18.Class7 class7_ = class2;
			num = 538928111U - num;
			this.method_0(class7_);
			num ^= 537606573U;
		}
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x0001AE40 File Offset: 0x00019040
	private void method_84()
	{
		uint num;
		do
		{
			MethodBase methodBase_ = this.method_27(this.method_1().EC4893C4());
			GClass18.Class7 @class = this.method_29(methodBase_);
			bool flag = @class != null;
			num = 1074929824U;
			if (flag)
			{
				if (num <= 353042654U)
				{
					continue;
				}
				num &= 131138289U;
				this.method_0(@class);
				num += 1073881088U;
			}
		}
		while (572926647U > num);
	}

	// Token: 0x06000676 RID: 1654 RVA: 0x0001AEB4 File Offset: 0x000190B4
	private void method_85()
	{
		uint num;
		GClass18.Class7 class2;
		for (;;)
		{
			IL_00:
			Type type = this.method_26(this.method_1().EC4893C4());
			num = 1391136693U;
			Type type2 = type;
			for (;;)
			{
				GClass18.Class7 @class = this.method_1();
				num &= 688786314U;
				class2 = @class;
				if (num > 1313689978U)
				{
					goto IL_00;
				}
				if (!type2.IsGenericType)
				{
					break;
				}
				Type genericTypeDefinition = type2.GetGenericTypeDefinition();
				num <<= 20;
				Type typeFromHandle = typeof(Nullable<>);
				num &= 1956580783U;
				num += 3490319232U;
				if (genericTypeDefinition != typeFromHandle)
				{
					break;
				}
				num = 1825790992U >> (int)num;
				GClass18.Class7 class3 = class2;
				num |= 1382109967U;
				class3.vmethod_2(null);
				if (num >= 1617326789U)
				{
					return;
				}
			}
			Type type3 = type2;
			num = 1983458765U >> (int)num;
			bool isValueType = type3.IsValueType;
			num >>= 1;
			if (isValueType)
			{
				num *= 378102594U;
				if (num != 267858936U)
				{
					Type type4 = type2;
					num *= 119497192U;
					FieldInfo[] fields = type4.GetFields((BindingFlags)(num ^ 1642510484U));
					int num2 = (int)(num + 2652456736U);
					num += 1055347819U;
					int num3 = num2;
					for (;;)
					{
						int num4 = num3;
						FieldInfo[] array = fields;
						num = (1373921598U & num);
						int num5 = array.Length;
						num *= 699931912U;
						if (num4 >= num5)
						{
							return;
						}
						FieldInfo fieldInfo = fields[num3];
						FieldInfo fieldInfo2 = fieldInfo;
						object obj = class2.vmethod_1();
						num = 2147483648U;
						object value;
						if (!fieldInfo.FieldType.IsValueType)
						{
							num = 108487971U * num;
							value = null;
						}
						else
						{
							value = Activator.CreateInstance(fieldInfo.FieldType);
							num += 0U;
						}
						fieldInfo2.SetValue(obj, value);
						num ^= 2123792284U;
						if (num < 2042450058U)
						{
							break;
						}
						num3 += (int)(num ^ 4271275933U);
						num ^= 1582854871U;
					}
				}
			}
			else
			{
				num *= 279541262U;
				if (num * 780226071U != 0U)
				{
					goto Block_8;
				}
			}
		}
		return;
		Block_8:
		GClass18.Class7 class4 = class2;
		num = 2053113770U << (int)num;
		class4.vmethod_2(null);
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x0001B078 File Offset: 0x00019278
	private void method_86()
	{
		uint num = 1287613549U;
		for (;;)
		{
			int num2 = this.method_1().EC4893C4();
			num %= 1056134578U;
			if ((1691626349U ^ num) != 0U)
			{
				for (;;)
				{
					GClass18.Class7 @class = this.method_1();
					GClass18.Class7 class2 = this.method_1();
					num = 1135180655U - num;
					GClass18.Class7 class3 = class2;
					num %= 818942852U;
					if (1795949934U % num == 0U)
					{
						break;
					}
					GClass18.Class7 class7_ = class3;
					num <<= 31;
					GClass18.Class7 class7_2 = @class;
					bool bool_ = num - 0U != 0U;
					int int_ = num2;
					num /= 1316126333U;
					int int_2 = this.method_19(class7_, class7_2, bool_, int_);
					num *= 380773415U;
					GClass18.Class7 class7_3 = new GClass18.Class9(int_2);
					num = 1425745894U + num;
					this.method_0(class7_3);
					if (num < 1469474396U)
					{
						return;
					}
				}
			}
		}
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x0001B118 File Offset: 0x00019318
	private void method_87()
	{
		int int_ = this.method_1().EC4893C4();
		GClass18.Class7 class7_ = this.method_1();
		GClass18.Class7 class7_2 = this.method_1();
		this.method_0(new GClass18.Class9(this.method_19(class7_2, class7_, true, int_)));
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x0001B154 File Offset: 0x00019354
	private void method_88()
	{
		int int_ = this.method_1().EC4893C4();
		uint num = 2147483648U;
		Type type = this.method_26(int_);
		do
		{
			num = 1062882700U >> (int)num;
			Type elementType = type;
			num += 1119553048U;
			GClass18.Class7 @class = this.method_1();
			num = 225011820U % num;
			GClass18.Class7 class7_ = new GClass18.Class17(Array.CreateInstance(elementType, @class.EC4893C4()));
			num ^= 385026854U;
			this.method_0(class7_);
		}
		while (1614825508U * num == 0U);
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x0001B1D0 File Offset: 0x000193D0
	private void method_89()
	{
		Type type_ = this.method_26(this.method_1().EC4893C4());
		uint num = 11914U;
		GClass18.Class7 @class;
		GClass18.Class7 class3;
		Array array2;
		do
		{
			num %= 530874310U;
			@class = this.method_1();
			num = (167781660U ^ num);
			if (1760965865U * num != 0U)
			{
				num |= 1571641901U;
				GClass18.Class7 class2 = this.method_1();
				num += 558434012U;
				class3 = class2;
				if (1217661400U == num)
				{
					break;
				}
			}
			Array array = this.method_1().vmethod_1() as Array;
			num = 2087019485U + num;
			array2 = array;
			num <<= 6;
		}
		while (536826448U - num == 0U);
		if (array2 == null)
		{
			num /= 205786844U;
			throw new ArgumentException();
		}
		Array array3 = array2;
		num = (320161904U | num);
		num *= 67700807U;
		object object_ = @class;
		num >>= 11;
		object object_2 = this.method_24(object_, type_);
		num |= 1447111497U;
		Type elementType = array2.GetType().GetElementType();
		num >>= 26;
		array3.SetValue(this.method_24(object_2, elementType).vmethod_1(), class3.EC4893C4());
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x0001B308 File Offset: 0x00019508
	private void method_90()
	{
		Type type_ = this.method_26(this.method_1().EC4893C4());
		GClass18.Class7 @class = this.method_1();
		Array array = this.method_1().vmethod_1() as Array;
		uint num = 584338088U;
		Array array2 = array;
		do
		{
			bool flag = array2 != null;
			num &= 1008080546U;
			if (!flag && 1672883402U / num != 0U)
			{
				goto Block_2;
			}
		}
		while (237979376U == num);
		Array array3 = array2;
		num ^= 976308285U;
		object value = array3.GetValue(@class.EC4893C4());
		num += 1762619234U;
		GClass18.Class7 class7_ = this.method_24(value, type_);
		num <<= 25;
		this.method_0(class7_);
		return;
		Block_2:
		throw new ArgumentException();
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x0001B3B4 File Offset: 0x000195B4
	private void method_91()
	{
		uint num = 1822843532U;
		Array array;
		for (;;)
		{
			array = (this.method_1().vmethod_1() as Array);
			num = 562724768U << (int)num;
			if (582774400U + num == 0U)
			{
				break;
			}
			if (array == null)
			{
				num /= 126031917U;
				if (num != 1972598542U)
				{
					break;
				}
			}
			else
			{
				num = 1017140686U * num;
				if ((num ^ 1573726592U) != 0U)
				{
					goto IL_5C;
				}
			}
		}
		throw new ArgumentException();
		IL_5C:
		Array array2 = array;
		num /= 1109031007U;
		this.method_0(new GClass18.Class9(array2.Length));
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x0001B438 File Offset: 0x00019638
	private void method_92()
	{
		for (;;)
		{
			GClass18.Class7 @class = this.method_1();
			uint num = 1048792257U;
			GClass18.Class7 class2 = @class;
			Array array;
			for (;;)
			{
				num = 2039374772U - num;
				GClass18.Class7 class3 = this.method_1();
				num = 1924925089U - num;
				object obj = class3.vmethod_1();
				num %= 1441860621U;
				array = (obj as Array);
				num += 239087049U;
				if (array == null)
				{
					num ^= 986923060U;
					if (num != 1138707427U)
					{
						goto Block_1;
					}
				}
				else if (1883398025U != num)
				{
					break;
				}
			}
			num <<= 6;
			Array array_ = array;
			num = (937367310U ^ num);
			GClass18.Class7 class4 = class2;
			num = 655117575U - num;
			GClass18.Class7 class7_ = new GClass18.Class22(array_, class4.EC4893C4());
			num = 612328858U + num;
			this.method_0(class7_);
			if ((118689911U ^ num) != 0U)
			{
				return;
			}
		}
		Block_1:
		throw new ArgumentException();
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x0001B4EC File Offset: 0x000196EC
	private void method_93()
	{
		this.method_0(new GClass18.Class24(this.method_27(this.method_1().EC4893C4())));
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x0001B518 File Offset: 0x00019718
	private void method_94()
	{
		uint num = 1023165998U;
		for (;;)
		{
			IL_25B:
			num /= 362302545U;
			GClass18.Class7 @class = this.method_1();
			num = 961683981U - num;
			MethodBase methodBase = this.method_27(@class.EC4893C4());
			num = 913864584U / num;
			MethodBase methodBase2 = methodBase;
			num = (1774149243U | num);
			if (1036680013U < num)
			{
				goto IL_145;
			}
			goto IL_1EC;
			int num3;
			ParameterInfo[] array2;
			Type[] array3;
			int num5;
			for (;;)
			{
				IL_178:
				num = (844901608U ^ num);
				int num2 = num3;
				num <<= 25;
				ParameterInfo[] array = array2;
				num += 2027568903U;
				int num4 = array.Length;
				num = 704528914U / num;
				if (num2 >= num4)
				{
					break;
				}
				ParameterInfo parameterInfo = array2[num3];
				array3[num5++] = parameterInfo.ParameterType;
				num3++;
				num = 1989901743U;
			}
			Type type;
			Type declaringType;
			while (num <= 1952740388U)
			{
				bool flag = type != null;
				num = (126317732U ^ num);
				num += 4168649566U;
				if (flag)
				{
					Type type2 = type;
					num = (1220807965U | num);
					if (type2 == declaringType)
					{
						num += 3074159331U;
					}
					else
					{
						MethodInfo method = type.GetMethod(methodBase2.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array3, null);
						bool flag2 = method != null;
						num = 1744534511U;
						if (flag2)
						{
							num = 1732005463U << (int)num;
							MethodInfo methodInfo = method;
							num = 1334062178U << (int)num;
							MethodInfo baseDefinition = methodInfo.GetBaseDefinition();
							MethodBase methodBase3 = methodBase2;
							num += 410472333U;
							if (baseDefinition == methodBase3)
							{
								if (num / 1100431631U == 0U)
								{
									goto IL_1C2;
								}
								MethodBase methodBase4 = method;
								num = 475558478U / num;
								methodBase2 = methodBase4;
								if (num - 2100302040U == 0U)
								{
									goto IL_1C2;
								}
								goto IL_230;
							}
						}
						num -= 1332313149U;
						if (num <= 608258011U)
						{
							Type baseType = type.BaseType;
							num = (243491060U ^ num);
							type = baseType;
							num ^= 370319168U;
							continue;
						}
						goto IL_1EC;
					}
				}
				IL_230:
				num &= 1553088432U;
				GClass18.Class7 class7_ = new GClass18.Class24(methodBase2);
				num = 669976023U << (int)num;
				this.method_0(class7_);
				if (num / 209650415U == 0U)
				{
					goto IL_25B;
				}
				return;
			}
			goto IL_145;
			IL_1C2:
			num = 1419407397U - num;
			int num6 = (int)(num + 2875559899U);
			num = (1989766574U | num);
			num3 = num6;
			if (1927970759U >> (int)num != 0U)
			{
				goto IL_178;
			}
			continue;
			IL_1EC:
			MemberInfo memberInfo = methodBase2;
			num = 1242831674U - num;
			declaringType = memberInfo.DeclaringType;
			ParameterInfo[] parameters = methodBase2.GetParameters();
			num = (124419643U | num);
			int num7 = parameters.Length;
			num = 952195960U / num;
			array3 = new Type[num7];
			num5 = (int)(num ^ 0U);
			array2 = parameters;
			goto IL_1C2;
			IL_145:
			GClass18.Class7 class2 = this.method_1();
			num /= 1241796468U;
			object obj = class2.vmethod_1();
			num = 662053399U + num;
			Type type3 = obj.GetType();
			num >>= 15;
			type = type3;
			if (1077437778U * num == 0U)
			{
				goto IL_178;
			}
			goto IL_1EC;
		}
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x0001B7C4 File Offset: 0x000199C4
	private void method_95()
	{
		uint num = 1324099981U;
		do
		{
			this.int_0 = this.method_1().EC4893C4();
		}
		while (num / 2045404704U != 0U);
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x0001B7F4 File Offset: 0x000199F4
	private void method_96()
	{
		this.method_1();
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x0001B808 File Offset: 0x00019A08
	private void method_97()
	{
		uint num = 1590633499U;
		for (;;)
		{
			num = 1819700785U >> (int)num;
			Stack<int> stack = this.stack_2;
			num &= 1511014456U;
			num -= 2029542939U;
			stack.Push(this.method_1().EC4893C4());
			for (;;)
			{
				IL_15A:
				num <<= 17;
				int num2 = this.method_1().EC4893C4();
				num = 35291057U * num;
				int num3 = num2;
				for (;;)
				{
					num = 1574056586U + num;
					if (this.stack_1.Count == 0)
					{
						goto IL_181;
					}
					num = 1444022255U % num;
					int num4 = num3;
					num += 1027046871U;
					num = 488454465U + num;
					Stack<GClass18.Class37> stack2 = this.stack_1;
					num /= 256994306U;
					GClass18.Class37 @class = stack2.Peek();
					num -= 2122736774U;
					int num5 = @class.method_1();
					num = 1628528204U + num;
					if (num4 <= num5)
					{
						goto IL_179;
					}
					List<GClass18.Class36> list = this.stack_1.Pop().method_4();
					List<GClass18.Class36> list2 = list;
					num = 1591507413U;
					int num6 = list2.Count;
					for (;;)
					{
						int num7 = num6;
						uint num8 = num ^ 1591507413U;
						num = (521754505U & num);
						if (num7 <= num8)
						{
							break;
						}
						GClass18.Class36 class2 = list[num6 - 1];
						GClass18.Class36 class3 = class2;
						num = 4098162688U;
						if (class3.method_0() == 2)
						{
							num = 695813411U % num;
							Stack<int> stack3 = this.stack_2;
							num = 620120504U - num;
							int item = class2.method_1();
							num ^= 70540619U;
							stack3.Push(item);
							num ^= 185358814U;
						}
						num = 2096836051U >> (int)num;
						if (num < 1343253911U)
						{
							goto IL_15A;
						}
						int num9 = num6;
						num = (286147722U & num);
						int num10 = (int)(num - 269091969U);
						num ^= 1678794448U;
						num6 = num9 - num10;
						num ^= 717628295U;
					}
					num ^= 295850369U;
				}
			}
			IL_181:
			num *= 577197768U;
			num -= 2013150775U;
			this.exception_0 = null;
			if ((940265141U ^ num) == 0U)
			{
				continue;
			}
			break;
			IL_179:
			num += 2332113081U;
			goto IL_181;
		}
		num += 1114262623U;
		Stack<GClass18.Class8> stack4 = this.stack_0;
		num >>= 27;
		stack4.Clear();
		num %= 464138696U;
		num = (9520727U & num);
		Stack<int> stack5 = this.stack_2;
		num = (786253046U & num);
		int num11 = stack5.Pop();
		num = (60442191U ^ num);
		this.int_0 = num11;
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x0001BA38 File Offset: 0x00019C38
	private void method_98()
	{
		uint num = 973955397U;
		do
		{
			bool flag = this.exception_0 != null;
			num = 1815168989U >> (int)num;
			if (flag)
			{
				goto IL_42;
			}
		}
		while (1941981596U < num);
		int num2 = this.stack_2.Pop();
		num *= 609634151U;
		this.int_0 = num2;
		return;
		IL_42:
		num = 1377462205U + num;
		Exception exception_ = this.exception_0;
		num |= 457525753U;
		this.method_34(exception_);
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x0001BAA4 File Offset: 0x00019CA4
	private void method_99()
	{
		uint num = 1970619722U;
		do
		{
			GClass18.Class7 @class = this.method_1();
			num = (1348010465U ^ num);
			if (@class.EC4893C4() != 0)
			{
				num = (1172834310U & num);
				if (1038560517U % num == 0U)
				{
					continue;
				}
			}
			else
			{
				num >>= 8;
				if (num <= 1804085441U)
				{
					goto IL_E2;
				}
			}
			do
			{
				this.stack_1.Pop();
				num += 1750223792U;
				num = 1299647146U * num;
				num = (1687167974U ^ num);
				Stack<GClass18.Class8> stack = this.stack_0;
				num <<= 23;
				stack.Push(new GClass18.Class14(this.exception_0));
				num -= 1290012935U;
			}
			while ((342629710U ^ num) == 0U);
			num = 593830323U / num;
			GClass18.Class36 class2 = this.class36_0;
			num ^= 676282118U;
			this.int_0 = class2.method_1();
			num &= 1398366879U;
		}
		while (1881869105U < num);
		num = (799281313U ^ num);
		this.class36_0 = null;
		return;
		IL_E2:
		num = 1518687568U - num;
		num %= 1179738351U;
		this.method_34(this.exception_0);
	}

	// Token: 0x06000685 RID: 1669 RVA: 0x0001BBB0 File Offset: 0x00019DB0
	private void method_100()
	{
		Type type_ = this.method_26(this.method_1().EC4893C4());
		this.method_0(new GClass18.Class14(this.method_24(this.method_1(), type_).vmethod_1()));
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x0001BBEC File Offset: 0x00019DEC
	private void method_101()
	{
		Type type_ = this.method_26(this.method_1().EC4893C4());
		this.method_0(this.method_24(this.method_1().vmethod_1(), type_));
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x0001BC24 File Offset: 0x00019E24
	private void method_102()
	{
		uint num;
		GClass18.Class7 class2;
		object obj;
		for (;;)
		{
			IL_00:
			Type type = this.method_26(this.method_1().EC4893C4());
			num = 0U;
			for (;;)
			{
				num = 173412783U + num;
				GClass18.Class7 @class = this.method_1();
				num ^= 403275688U;
				class2 = @class;
				for (;;)
				{
					obj = class2.vmethod_1();
					num += 1352809354U;
					for (;;)
					{
						bool flag = obj != null;
						num %= 1277107296U;
						if (!flag)
						{
							goto Block_3;
						}
						if (num == 1645694607U)
						{
							goto IL_00;
						}
						Type type2 = type;
						num = (349598895U | num);
						bool isValueType = type2.IsValueType;
						num >>= 5;
						if (!isValueType)
						{
							TypeCode typeCode = Type.GetTypeCode(type);
							num <<= 6;
							object obj2 = typeCode;
							num ^= 923431247U;
							object obj3 = num + 3843585524U;
							num = (384318192U | num);
							object obj4 = obj2 - obj3;
							num = 944914176U * num;
							switch (obj4)
							{
							case 0:
								goto IL_113;
							case 1:
								goto IL_183;
							case 2:
								goto IL_193;
							case 3:
								num = 1301762933U + num;
								if (1887855889U >> (int)num == 0U)
								{
									continue;
								}
								goto IL_2F7;
							case 4:
								goto IL_1AC;
							case 5:
								goto IL_1FA;
							case 6:
								goto IL_31A;
							case 7:
								goto IL_153;
							case 8:
								goto IL_DF;
							case 9:
								goto IL_22F;
							case 10:
								goto IL_39E;
							case 11:
								goto IL_3CF;
							}
							goto Block_2;
						}
						goto IL_23F;
					}
					IL_DF:
					num = 529801317U % num;
					if (1707295967U != num)
					{
						goto Block_4;
					}
				}
				Block_2:
				if (1811488165U != num)
				{
					goto Block_5;
				}
				continue;
				IL_113:
				num <<= 2;
				num += 476651204U;
				bool bool_ = (bool)obj;
				num ^= 1946828228U;
				GClass18.Class7 class7_ = new GClass18.Class30(bool_);
				num ^= 1495034625U;
				this.method_0(class7_);
				if ((num & 2074890099U) != 0U)
				{
					return;
				}
				continue;
				IL_153:
				num &= 52905768U;
				if ((num & 653477614U) != 0U)
				{
					goto IL_33D;
				}
			}
			IL_183:
			if (1795312975U <= num)
			{
				goto Block_7;
			}
			continue;
			IL_193:
			num += 1705910417U;
			if (1035081370U / num != 0U)
			{
				goto Block_8;
			}
			continue;
			IL_1AC:
			num /= 188507447U;
			object obj5 = obj;
			num = 1740458080U << (int)num;
			short short_ = (short)obj5;
			num = 677078980U << (int)num;
			GClass18.Class7 class7_2 = new GClass18.Class28(short_);
			num += 690713221U;
			this.method_0(class7_2);
			if (num >= 1313744770U)
			{
				return;
			}
			continue;
			IL_1FA:
			if (1814511180U > num)
			{
				continue;
			}
			object obj6 = obj;
			num = (549914715U & num);
			this.method_0(new GClass18.Class29((ushort)obj6));
			if (508258267U < num)
			{
				return;
			}
			continue;
			IL_22F:
			if (1649439345U != num)
			{
				goto Block_12;
			}
			continue;
			IL_23F:
			if (num != 1534609439U)
			{
				Type type3 = type;
				num = 605564058U / num;
				object obj7 = obj;
				num |= 311325871U;
				Type type4 = obj7.GetType();
				num = 1692741256U * num;
				if (type3 != type4)
				{
					if (num > 1196587291U)
					{
						goto Block_15;
					}
				}
				else
				{
					num = 1626691314U >> (int)num;
					if (num << 18 != 0U)
					{
						goto Block_16;
					}
				}
			}
		}
		Block_3:
		goto IL_2F1;
		Block_4:
		num |= 1828790305U;
		object obj8 = obj;
		num = (995122623U | num);
		long long_ = (long)obj8;
		num %= 474379367U;
		this.method_0(new GClass18.Class10(long_));
		return;
		Block_5:
		throw new InvalidCastException();
		Block_7:
		num |= 461242551U;
		GClass18.Class7 class7_3 = new GClass18.Class31((char)obj);
		num |= 209668316U;
		this.method_0(class7_3);
		return;
		Block_8:
		sbyte sbyte_ = (sbyte)obj;
		num ^= 82188361U;
		GClass18.Class7 class7_4 = new GClass18.Class33(sbyte_);
		num = (581376808U ^ num);
		this.method_0(class7_4);
		if ((num ^ 848723818U) != 0U)
		{
			return;
		}
		goto IL_2F1;
		Block_12:
		num |= 1119368328U;
		this.method_0(new GClass18.Class35((ulong)obj));
		return;
		Block_15:
		throw new InvalidCastException();
		Block_16:
		num = 26301505U << (int)num;
		this.method_0(class2);
		return;
		IL_2F1:
		throw new NullReferenceException();
		IL_2F7:
		byte byte_ = (byte)obj;
		num = 958556973U >> (int)num;
		this.method_0(new GClass18.Class32(byte_));
		return;
		IL_31A:
		num = 1187124231U + num;
		GClass18.Class7 class7_5 = new GClass18.Class9((int)obj);
		num &= 519705823U;
		this.method_0(class7_5);
		return;
		IL_33D:
		GClass18.Class7 class7_6 = new GClass18.Class34((uint)obj);
		num = (417621782U ^ num);
		this.method_0(class7_6);
		return;
		IL_39E:
		num += 1980042375U;
		num = 1928406997U >> (int)num;
		float float_ = (float)obj;
		num %= 1351878389U;
		this.method_0(new GClass18.Class11(float_));
		return;
		IL_3CF:
		num ^= 1319462823U;
		num = (1953105210U | num);
		this.method_0(new GClass18.Class12((double)obj));
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x0001C040 File Offset: 0x0001A240
	private void method_103()
	{
		this.method_0(new GClass18.Class9(Marshal.ReadInt32(new IntPtr(this.long_0 + (long)((ulong)this.method_1().vmethod_11())))));
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x0001C078 File Offset: 0x0001A278
	private void method_104()
	{
		uint num = 1767981535U;
		int num3;
		int num4;
		for (;;)
		{
			num = 589765377U * num;
			GClass18.Class7 @class = this.method_1();
			num <<= 2;
			int num2 = @class.EC4893C4();
			num %= 403452789U;
			num3 = num2;
			num <<= 26;
			for (;;)
			{
				num4 = num3 >> (int)(num ^ 1342177304U);
				if ((num ^ 547885539U) == 0U)
				{
					break;
				}
				if (num4 <= (int)(num + 2952790026U))
				{
					switch (num4 - (int)(num ^ 1342177281U))
					{
					case 0:
					case 1:
						goto IL_28B;
					case 2:
					case 4:
						goto IL_27D;
					case 3:
						num = 1010517037U * num;
						if (num + 1346514452U != 0U)
						{
							goto Block_3;
						}
						continue;
					case 5:
						goto IL_A7;
					}
					goto Block_2;
				}
				num -= 1085373788U;
				if ((num & 832513359U) == 0U)
				{
					goto IL_27D;
				}
				int num5 = num4;
				uint num6 = num ^ 256803519U;
				num ^= 1598980772U;
				if (num5 == num6)
				{
					goto IL_28B;
				}
				if (num % 508050941U == 0U)
				{
					break;
				}
				int num7 = num4;
				num *= 955403049U;
				uint num8 = num ^ 3489660971U;
				num += 2147483648U;
				if (num7 != num8)
				{
					goto Block_7;
				}
				IL_A7:
				num = (250896308U | num);
				if (1513381140U / num == 0U)
				{
					goto IL_230;
				}
			}
		}
		Block_2:
		num = 1411857197U + num;
		if (num4 != (int)(num ^ 2754034471U))
		{
			num += 2883110099U;
			goto IL_27D;
		}
		num &= 313354975U;
		ModuleHandle moduleHandle2;
		try
		{
			do
			{
				num %= 104554265U;
				num = (1275551142U | num);
				Module module = this.module_0;
				num &= 1156282816U;
				ModuleHandle moduleHandle = module.ModuleHandle;
				num = 1172974811U - num;
				moduleHandle2 = moduleHandle;
				RuntimeFieldHandle runtimeFieldHandle = moduleHandle2.ResolveFieldHandle(num3);
				num ^= 584392756U;
				this.method_0(new GClass18.Class16(runtimeFieldHandle));
			}
			while (num % 302071092U == 0U);
		}
		catch (object obj)
		{
			this.method_0(new GClass18.Class16(this.module_0.ModuleHandle.ResolveMethodHandle(num3)));
		}
		return;
		Block_3:
		num = (808275803U & num);
		num *= 1589781335U;
		ModuleHandle moduleHandle3 = this.module_0.ModuleHandle;
		num -= 356719862U;
		moduleHandle2 = moduleHandle3;
		num *= 734027476U;
		num = 1508642761U % num;
		GClass18.Class7 class7_ = new GClass18.Class16(moduleHandle2.ResolveFieldHandle(num3));
		num = (183568576U & num);
		this.method_0(class7_);
		return;
		Block_7:
		num ^= 0U;
		goto IL_27D;
		IL_230:
		num -= 2015914039U;
		Module module2 = this.module_0;
		num = (688065930U & num);
		moduleHandle2 = module2.ModuleHandle;
		num = 1479424938U - num;
		object object_ = moduleHandle2.ResolveMethodHandle(num3);
		num += 1339575068U;
		GClass18.Class7 class7_2 = new GClass18.Class16(object_);
		num = 1436632898U / num;
		this.method_0(class7_2);
		return;
		IL_27D:
		num *= 346490329U;
		throw new InvalidOperationException();
		IL_28B:
		num = 1257649206U - num;
		moduleHandle2 = this.module_0.ModuleHandle;
		num = 1065304049U - num;
		num = (1776031625U | num);
		int typeToken = num3;
		num *= 1783197414U;
		this.method_0(new GClass18.Class16(moduleHandle2.ResolveTypeHandle(typeToken)));
	}

	// Token: 0x0600068A RID: 1674 RVA: 0x0001C364 File Offset: 0x0001A564
	private void method_105()
	{
		Exception ex = this.method_1().vmethod_1() as Exception;
		if (ex == null)
		{
			throw new ArgumentException();
		}
		throw ex;
	}

	// Token: 0x0600068B RID: 1675 RVA: 0x0001C38C File Offset: 0x0001A58C
	private void method_106()
	{
		uint num;
		for (;;)
		{
			bool flag = this.exception_0 != null;
			num = 3050904533U;
			if (flag)
			{
				num = (1152070471U ^ num);
				if (num != 234246139U)
				{
					break;
				}
			}
			else
			{
				num = (173552801U ^ num);
				if (510151552U - num != 0U)
				{
					goto Block_2;
				}
			}
		}
		num = 470157755U << (int)num;
		throw this.exception_0;
		Block_2:
		throw new InvalidOperationException();
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x0001C3EC File Offset: 0x0001A5EC
	private void method_107()
	{
		GClass18.Class7 @class;
		uint num;
		do
		{
			Type type_ = this.method_26(this.method_1().EC4893C4());
			@class = this.method_1();
			bool flag = this.method_33(@class.vmethod_1(), type_);
			num = 2466626860U;
			if (flag)
			{
				goto IL_75;
			}
			num = 1173493648U << (int)num;
		}
		while (num / 568396499U != 0U);
		throw new InvalidCastException();
		IL_75:
		GClass18.Class7 class7_ = @class;
		num = 839794070U / num;
		this.method_0(class7_);
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x0001C480 File Offset: 0x0001A680
	private void method_108()
	{
		for (;;)
		{
			Type type_ = this.method_26(this.method_1().EC4893C4());
			uint num = 1052208005U;
			for (;;)
			{
				GClass18.Class7 @class = this.method_1();
				num -= 450051261U;
				GClass18.Class7 class2 = @class;
				num = 513359563U >> (int)num;
				num = 1660894140U << (int)num;
				if (!this.method_33(class2.vmethod_1(), type_))
				{
					num = (1106999423U ^ num);
					if (num <= 157834809U)
					{
						break;
					}
					object object_ = null;
					num ^= 1230334656U;
					GClass18.Class7 class3 = new GClass18.Class14(object_);
					num -= 684399755U;
					class2 = class3;
					num ^= 3756193332U;
				}
				num = 1321762696U * num;
				GClass18.Class7 class7_ = class2;
				num = 56520283U * num;
				this.method_0(class7_);
				if ((516695144U ^ num) != 0U)
				{
					return;
				}
			}
		}
	}

	// Token: 0x0600068E RID: 1678 RVA: 0x0001C544 File Offset: 0x0001A744
	private void method_109()
	{
		GClass18.Class7 @class;
		uint num;
		do
		{
			@class = this.method_1();
			object obj = @class.vmethod_1();
			num = 1358309380U;
			if (!(obj is IConvertible))
			{
				GClass18.Class7 class2 = new GClass18.Class12(double.NaN);
				num = 1606441799U % num;
				@class = class2;
				num += 1731016867U;
			}
			else
			{
				double num2 = @class.vmethod_13();
				num |= 556231040U;
				double num3 = num2;
				if (num <= 611925760U)
				{
					continue;
				}
				if (double.IsNaN(num3))
				{
					goto IL_82;
				}
				if (num <= 968571510U)
				{
					continue;
				}
				double d = num3;
				num = (1677738850U | num);
				if (double.IsInfinity(d))
				{
					goto Block_5;
				}
			}
		}
		while (num < 44592722U);
		this.method_0(@class);
		return;
		Block_5:
		num += 4227857822U;
		IL_82:
		num <<= 10;
		throw new OverflowException();
	}

	// Token: 0x0600068F RID: 1679 RVA: 0x0001C5E8 File Offset: 0x0001A7E8
	private unsafe void method_110()
	{
		uint num = 73541092U;
		IntPtr item;
		for (;;)
		{
			GClass18.Class7 @class = this.method_1();
			num ^= 792614308U;
			item = Marshal.AllocHGlobal(@class.B6AA4A8E());
			num = 1178953770U / num;
			if ((num ^ 1311984685U) != 0U)
			{
				num = 679489837U * num;
				List<IntPtr> list = this.list_2;
				num += 1906513998U;
				list.Add(item);
				if (1898653417U + num != 0U)
				{
					break;
				}
			}
		}
		do
		{
			num ^= 1464340048U;
			void* ptr = item.ToPointer();
			Type typeFromHandle = typeof(void*);
			num = (1709252636U ^ num);
			GClass18.Class7 class7_ = new GClass18.Class14(Pointer.Box(ptr, typeFromHandle));
			num = (1675046880U ^ num);
			this.method_0(class7_);
		}
		while (950746098U >= num);
	}

	// Token: 0x06000690 RID: 1680 RVA: 0x0001C690 File Offset: 0x0001A890
	private void method_111()
	{
		List<IntPtr>.Enumerator enumerator = this.list_2.GetEnumerator();
		uint num = 0U;
		using (List<IntPtr>.Enumerator enumerator2 = enumerator)
		{
			if (1515656736U < num)
			{
				goto IL_39;
			}
			do
			{
				IL_28:
				num = (669534550U | num);
				if (enumerator2.MoveNext())
				{
					goto IL_39;
				}
			}
			while (851465246U <= num);
			return;
			IL_39:
			Marshal.FreeHGlobal(enumerator2.Current);
			num = 0U;
			goto IL_28;
		}
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x0001C718 File Offset: 0x0001A918
	public object method_112(object[] object_0, int int_1)
	{
		uint num = 461201126U;
		do
		{
			num = (1180381427U & num);
			this.int_0 = int_1;
		}
		while (num >= 403787556U);
		num -= 2082087712U;
		this.method_0(new GClass18.Class17(object_0));
		object result;
		try
		{
			for (;;)
			{
				num = 1885609083U;
				try
				{
					num = 1977503839U - num;
					if (1690831093U >= num)
					{
						do
						{
							num = 1527866240U + num;
							this.dictionary_0[(uint)this.method_3()]();
							num ^= 513373745U;
							if (this.int_0 != 0)
							{
								goto IL_84;
							}
						}
						while (num + 1101495823U == 0U);
						break;
					}
					IL_84:
					continue;
				}
				catch (Exception exception_)
				{
					this.method_34(exception_);
					continue;
				}
				break;
			}
			result = this.method_1().vmethod_1();
		}
		finally
		{
			this.method_111();
		}
		return result;
	}

	// Token: 0x06000692 RID: 1682 RVA: 0x0001C7FC File Offset: 0x0001A9FC
	// Note: this type is marked as 'beforefieldinit'.
	static GClass18()
	{
		Dictionary<int, object> dictionary = new Dictionary<int, object>();
		uint num = 1U;
		GClass18.dictionary_1 = dictionary;
		do
		{
			GClass18.dictionary_2 = new Dictionary<MethodBase, DynamicMethod>();
		}
		while (num / 1745904051U != 0U);
	}

	// Token: 0x04000168 RID: 360
	private readonly Dictionary<uint, GClass18.Delegate359> dictionary_0;

	// Token: 0x04000169 RID: 361
	private readonly Module module_0;

	// Token: 0x0400016A RID: 362
	private readonly long long_0;

	// Token: 0x0400016B RID: 363
	private int int_0;

	// Token: 0x0400016C RID: 364
	private Type type_0;

	// Token: 0x0400016D RID: 365
	private Stack<GClass18.Class8> stack_0;

	// Token: 0x0400016E RID: 366
	private static readonly Dictionary<int, object> dictionary_1;

	// Token: 0x0400016F RID: 367
	private static readonly Dictionary<MethodBase, DynamicMethod> dictionary_2;

	// Token: 0x04000170 RID: 368
	private List<GClass18.Class7> list_0;

	// Token: 0x04000171 RID: 369
	private List<GClass18.Class37> list_1;

	// Token: 0x04000172 RID: 370
	private Stack<GClass18.Class37> stack_1;

	// Token: 0x04000173 RID: 371
	private Stack<int> stack_2;

	// Token: 0x04000174 RID: 372
	private Exception exception_0;

	// Token: 0x04000175 RID: 373
	private GClass18.Class36 class36_0;

	// Token: 0x04000176 RID: 374
	private List<IntPtr> list_2;

	// Token: 0x020001AA RID: 426
	private static class Class6
	{
	}

	// Token: 0x020001AB RID: 427
	private abstract class Class7
	{
		// Token: 0x06000693 RID: 1683
		public abstract GClass18.Class7 vmethod_0();

		// Token: 0x06000694 RID: 1684
		public abstract object vmethod_1();

		// Token: 0x06000695 RID: 1685
		public abstract void vmethod_2(object object_0);

		// Token: 0x06000696 RID: 1686 RVA: 0x0001C830 File Offset: 0x0001AA30
		public virtual bool vmethod_3()
		{
			return false;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0001C840 File Offset: 0x0001AA40
		public virtual GClass18.Class8 vmethod_4()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0001C854 File Offset: 0x0001AA54
		public virtual GClass18.Class7 vmethod_5()
		{
			return this;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0001C840 File Offset: 0x0001AA40
		public virtual Type vmethod_6()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0001C840 File Offset: 0x0001AA40
		public virtual TypeCode vmethod_7()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0001C864 File Offset: 0x0001AA64
		public virtual bool vmethod_8()
		{
			return Convert.ToBoolean(this.vmethod_1());
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0001C87C File Offset: 0x0001AA7C
		public virtual sbyte vmethod_9()
		{
			return Convert.ToSByte(this.vmethod_1());
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0001C894 File Offset: 0x0001AA94
		public virtual short E8F387ED()
		{
			return Convert.ToInt16(this.vmethod_1());
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0001C8AC File Offset: 0x0001AAAC
		public virtual int EC4893C4()
		{
			return Convert.ToInt32(this.vmethod_1());
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0001C8C4 File Offset: 0x0001AAC4
		public virtual long DB9EABF5()
		{
			return Convert.ToInt64(this.vmethod_1());
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0001C8DC File Offset: 0x0001AADC
		public virtual char F22CF44A()
		{
			return Convert.ToChar(this.vmethod_1());
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0001C8F4 File Offset: 0x0001AAF4
		public virtual byte vmethod_10()
		{
			return Convert.ToByte(this.vmethod_1());
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0001C90C File Offset: 0x0001AB0C
		public virtual ushort D3EC5557()
		{
			return Convert.ToUInt16(this.vmethod_1());
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0001C924 File Offset: 0x0001AB24
		public virtual uint vmethod_11()
		{
			return Convert.ToUInt32(this.vmethod_1());
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0001C93C File Offset: 0x0001AB3C
		public virtual ulong vmethod_12()
		{
			return Convert.ToUInt64(this.vmethod_1());
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0001C954 File Offset: 0x0001AB54
		public virtual float B4B75C1D()
		{
			return Convert.ToSingle(this.vmethod_1());
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0001C96C File Offset: 0x0001AB6C
		public virtual double vmethod_13()
		{
			return Convert.ToDouble(this.vmethod_1());
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0001C984 File Offset: 0x0001AB84
		public override string ToString()
		{
			uint num = 597050555U;
			object obj2;
			do
			{
				num -= 2054898457U;
				object obj = this.vmethod_1();
				num <<= 6;
				obj2 = obj;
				num = (1862292357U ^ num);
			}
			while (1081685427U < num);
			bool flag = obj2 != null;
			num >>= 19;
			if (!flag)
			{
				return null;
			}
			object value = obj2;
			num = 1055331090U >> (int)num;
			return Convert.ToString(value);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0001C840 File Offset: 0x0001AA40
		public virtual IntPtr B6AA4A8E()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0001C840 File Offset: 0x0001AA40
		public virtual UIntPtr vmethod_14()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0001C840 File Offset: 0x0001AA40
		public unsafe virtual void* vmethod_15()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0001C840 File Offset: 0x0001AA40
		public virtual object CB7019CC(Type type_0, bool bool_0)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0001C9E0 File Offset: 0x0001ABE0
		protected Class7()
		{
			uint num = 1363427562U;
			do
			{
				num += 5976771U;
				base..ctor();
			}
			while ((1410745557U ^ num) == 0U);
		}
	}

	// Token: 0x020001AC RID: 428
	private abstract class Class8 : GClass18.Class7
	{
		// Token: 0x060006AD RID: 1709 RVA: 0x0001C854 File Offset: 0x0001AA54
		public override GClass18.Class8 vmethod_4()
		{
			return this;
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x0001C830 File Offset: 0x0001AA30
		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}
	}

	// Token: 0x020001AD RID: 429
	private sealed class Class9 : GClass18.Class8
	{
		// Token: 0x060006B0 RID: 1712 RVA: 0x0001CA20 File Offset: 0x0001AC20
		public Class9(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0001CA3C File Offset: 0x0001AC3C
		public override Type vmethod_6()
		{
			return typeof(int);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0001CA54 File Offset: 0x0001AC54
		public override TypeCode vmethod_7()
		{
			return TypeCode.Int32;
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0001CA64 File Offset: 0x0001AC64
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class9(this.int_0);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x0001CA7C File Offset: 0x0001AC7C
		public override object vmethod_1()
		{
			return this.int_0;
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0001CA94 File Offset: 0x0001AC94
		public override void vmethod_2(object object_0)
		{
			this.int_0 = Convert.ToInt32(object_0);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0001CAB0 File Offset: 0x0001ACB0
		public override bool vmethod_8()
		{
			return this.int_0 != 0;
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0001CAC8 File Offset: 0x0001ACC8
		public override sbyte vmethod_9()
		{
			return (sbyte)this.int_0;
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0001CADC File Offset: 0x0001ACDC
		public override short E8F387ED()
		{
			return (short)this.int_0;
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x0001CAF0 File Offset: 0x0001ACF0
		public override int EC4893C4()
		{
			return this.int_0;
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0001CB04 File Offset: 0x0001AD04
		public override long DB9EABF5()
		{
			return (long)this.int_0;
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0001CB18 File Offset: 0x0001AD18
		public override char F22CF44A()
		{
			return (char)this.int_0;
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0001CB2C File Offset: 0x0001AD2C
		public override byte vmethod_10()
		{
			return (byte)this.int_0;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0001CB18 File Offset: 0x0001AD18
		public override ushort D3EC5557()
		{
			return (ushort)this.int_0;
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0001CAF0 File Offset: 0x0001ACF0
		public override uint vmethod_11()
		{
			return (uint)this.int_0;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0001CB40 File Offset: 0x0001AD40
		public override ulong vmethod_12()
		{
			return (ulong)this.int_0;
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x0001CB54 File Offset: 0x0001AD54
		public override float B4B75C1D()
		{
			return (float)this.int_0;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x0001CB68 File Offset: 0x0001AD68
		public override double vmethod_13()
		{
			return (double)this.int_0;
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0001CB7C File Offset: 0x0001AD7C
		public override IntPtr B6AA4A8E()
		{
			return new IntPtr(this.int_0);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0001CB94 File Offset: 0x0001AD94
		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((uint)this.int_0);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0001CBAC File Offset: 0x0001ADAC
		public override GClass18.Class7 vmethod_5()
		{
			return new GClass18.Class34((uint)this.int_0);
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0001CBC4 File Offset: 0x0001ADC4
		public override object CB7019CC(Type type_0, bool bool_0)
		{
			uint num = 2042911310U;
			for (;;)
			{
				RuntimeTypeHandle handle = typeof(IntPtr).TypeHandle;
				num /= 1753314177U;
				if (type_0 == Type.GetTypeFromHandle(handle))
				{
					if (num >= 1290741103U)
					{
						goto IL_544;
					}
				}
				else
				{
					num = 1962099168U * num;
					if (num < 1040913260U)
					{
						goto IL_539;
					}
					RuntimeTypeHandle handle2 = typeof(UIntPtr).TypeHandle;
					num <<= 18;
					Type typeFromHandle = Type.GetTypeFromHandle(handle2);
					num = (329410328U | num);
					if (type_0 == typeFromHandle)
					{
						num -= 1351630144U;
						if ((num & 258934637U) != 0U)
						{
							if (!bool_0)
							{
								if (num >= 969806716U)
								{
									break;
								}
								continue;
							}
							else
							{
								num += 1950039134U;
								if (1127947049U / num != 0U)
								{
									goto Block_6;
								}
								continue;
							}
						}
					}
					else
					{
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num ^= 1202352963U;
						TypeCode typeCode2 = typeCode;
						num -= 813311504U;
						TypeCode typeCode3 = typeCode2;
						num = 929698818U - num;
						uint num2 = num - 400303538U;
						num ^= 268204303U;
						switch (typeCode3 - num2)
						{
						case 0:
							if (1277460308U - num == 0U)
							{
								goto IL_554;
							}
							num >>= 26;
							if (!bool_0)
							{
								goto IL_2F4;
							}
							num *= 2091015000U;
							if (22707456U < num)
							{
								goto Block_11;
							}
							continue;
						case 1:
							num = (714158916U | num);
							num ^= 451958035U;
							if (bool_0)
							{
								goto IL_328;
							}
							if (num % 880099621U != 0U)
							{
								goto Block_13;
							}
							break;
						case 2:
							if ((num ^ 1065826545U) != 0U)
							{
								goto Block_14;
							}
							break;
						case 3:
							if (num < 10708314U)
							{
								continue;
							}
							if (!bool_0)
							{
								goto IL_3BE;
							}
							if (num < 1964725766U)
							{
								goto Block_17;
							}
							continue;
						case 4:
							num = 1232014472U / num;
							if (!bool_0)
							{
								num %= 985818389U;
								if (num + 1963999858U != 0U)
								{
									goto Block_19;
								}
								goto IL_257;
							}
							else if (1229072475U >= num)
							{
								goto Block_20;
							}
							break;
						case 5:
							num &= 1731813023U;
							num = (1875728053U | num);
							if (bool_0)
							{
								goto IL_412;
							}
							if (num - 1562402238U != 0U)
							{
								goto Block_22;
							}
							break;
						case 6:
							num += 337642840U;
							num = 736722924U << (int)num;
							if (!bool_0)
							{
								num = 2039572788U % num;
								if ((1555696336U & num) != 0U)
								{
									goto Block_24;
								}
								continue;
							}
							else
							{
								if (num - 63969774U != 0U)
								{
									goto Block_25;
								}
								goto IL_257;
							}
							break;
						case 7:
							goto IL_454;
						case 8:
							goto IL_484;
						case 9:
							num *= 1579697145U;
							if (!bool_0)
							{
								goto IL_516;
							}
							num = 734163891U >> (int)num;
							if (num - 1362568775U != 0U)
							{
								goto IL_4F4;
							}
							break;
						default:
							if (num / 312244296U != 0U)
							{
								goto Block_8;
							}
							continue;
						}
					}
				}
				int size = IntPtr.Size;
				uint num3 = num - 4294967293U;
				num += 224405330U;
				if (size == num3)
				{
					if (num <= 387451675U)
					{
						goto Block_28;
					}
					continue;
				}
				IL_257:
				num = 848848713U * num;
				if (779844302U >= num)
				{
					goto Block_29;
				}
			}
			uint num4 = (uint)this.int_0;
			num = (1135885574U ^ num);
			uint value = num4;
			goto IL_2BA;
			Block_6:
			num += 129318341U;
			value = (uint)this.int_0;
			num += 1101230307U;
			goto IL_2BA;
			Block_8:
			num += 0U;
			goto IL_484;
			Block_11:
			uint num5 = (uint)this.int_0;
			num += 1470593843U;
			sbyte b = checked((sbyte)num5);
			num += 3182806484U;
			goto IL_309;
			Block_13:
			num += 2019887707U;
			byte b2 = (byte)this.int_0;
			num = 740246821U + num;
			byte b3 = b2;
			goto IL_348;
			Block_14:
			short num7;
			if (!bool_0)
			{
				short num6 = (short)this.int_0;
				num += 1666989368U;
				num7 = num6;
			}
			else
			{
				num = 738478172U >> (int)num;
				uint num8 = (uint)this.int_0;
				num = 962163141U >> (int)num;
				short num9 = (short)num8;
				num += 684081556U;
				num7 = num9;
				num += 1387446981U;
			}
			return num7;
			Block_17:
			uint num10 = (uint)this.int_0;
			num = 170618243U - num;
			ushort num11 = (ushort)num10;
			num |= 1650198962U;
			ushort num12 = num11;
			num ^= 2241887719U;
			goto IL_3CD;
			Block_19:
			int num13 = this.int_0;
			goto IL_403;
			Block_20:
			num ^= 980032850U;
			uint num15;
			checked
			{
				int num14 = (int)((uint)this.int_0);
				num <<= 20;
				num13 = num14;
				num ^= 3574595587U;
				goto IL_403;
				Block_22:
				num15 = (uint)this.int_0;
				goto IL_420;
				Block_24:;
			}
			long num16 = (long)this.int_0;
			goto IL_446;
			Block_25:
			ulong num17 = (ulong)this.int_0;
			num = 1434546044U * num;
			num16 = (long)num17;
			num ^= 868313396U;
			goto IL_446;
			Block_28:
			goto IL_539;
			Block_29:
			num *= 1405237390U;
			long value2;
			if (!bool_0)
			{
				num &= 1756261381U;
				long num18 = (long)this.int_0;
				num %= 1561987634U;
				value2 = num18;
			}
			else
			{
				if ((728260802U ^ num) == 0U)
				{
					goto IL_544;
				}
				value2 = (long)((ulong)this.int_0);
				num += 3924721446U;
			}
			num = 1918924603U % num;
			IntPtr intPtr = new IntPtr(value2);
			num = 1488930996U % num;
			return intPtr;
			IL_2BA:
			num = 443055671U * num;
			return new UIntPtr(value);
			IL_2F4:
			sbyte b4 = (sbyte)this.int_0;
			num = 1255753170U >> (int)num;
			b = b4;
			IL_309:
			return b;
			IL_328:
			num <<= 5;
			checked
			{
				byte b5 = (byte)((uint)this.int_0);
				num /= 924523405U;
				b3 = b5;
				num ^= 3301276271U;
				IL_348:
				return b3;
				IL_3BE:
				num = (1876900004U ^ num);
				num12 = (ushort)this.int_0;
				IL_3CD:;
			}
			num = 1847733713U - num;
			return num12;
			IL_403:
			return num13;
			IL_412:
			num15 = (uint)this.int_0;
			num ^= 0U;
			IL_420:
			return num15;
			IL_446:
			num += 237186026U;
			return num16;
			IL_454:
			uint num19;
			if (!bool_0)
			{
				num = (2113481038U & num);
				num19 = checked((uint)this.int_0);
			}
			else
			{
				num19 = (uint)this.int_0;
				num ^= 21680U;
			}
			num = 531249356U + num;
			return num19;
			IL_484:
			num /= 1369844390U;
			if (1215762418U != num)
			{
				throw new ArgumentException();
			}
			goto IL_544;
			IL_4F4:
			num *= 2039497548U;
			double num20 = this.int_0;
			num = 1651470278U - num;
			double num21 = num20;
			num ^= 1244930562U;
			goto IL_52B;
			IL_516:
			num = 2108054205U << (int)num;
			num21 = (double)this.int_0;
			IL_52B:
			num &= 762661856U;
			return num21;
			IL_539:
			num *= 483746427U;
			if (bool_0)
			{
				goto IL_554;
			}
			IL_544:
			num = 453585412U - num;
			int value3 = this.int_0;
			goto IL_56C;
			IL_554:
			int num22 = (int)(checked((uint)this.int_0));
			num |= 627523190U;
			value3 = num22;
			num ^= 1071038932U;
			IL_56C:
			num = (2124614601U | num);
			IntPtr intPtr2 = new IntPtr(value3);
			num &= 1821981904U;
			return intPtr2;
		}

		// Token: 0x04000177 RID: 375
		private int int_0;
	}

	// Token: 0x020001AE RID: 430
	private sealed class Class10 : GClass18.Class8
	{
		// Token: 0x060006C6 RID: 1734 RVA: 0x0001D158 File Offset: 0x0001B358
		public Class10(long long_1)
		{
			this.long_0 = long_1;
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0001D174 File Offset: 0x0001B374
		public override Type vmethod_6()
		{
			return typeof(long);
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0001D18C File Offset: 0x0001B38C
		public override TypeCode vmethod_7()
		{
			return TypeCode.Int64;
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0001D19C File Offset: 0x0001B39C
		public override GClass18.Class7 vmethod_5()
		{
			return new GClass18.Class35((ulong)this.long_0);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0001D1B4 File Offset: 0x0001B3B4
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class10(this.long_0);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0001D1CC File Offset: 0x0001B3CC
		public override object vmethod_1()
		{
			return this.long_0;
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0001D1E4 File Offset: 0x0001B3E4
		public override void vmethod_2(object object_0)
		{
			this.long_0 = Convert.ToInt64(object_0);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0001D200 File Offset: 0x0001B400
		public override bool vmethod_8()
		{
			return this.long_0 != 0L;
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0001D220 File Offset: 0x0001B420
		public override char F22CF44A()
		{
			return (char)this.long_0;
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x0001D234 File Offset: 0x0001B434
		public override byte vmethod_10()
		{
			return (byte)this.long_0;
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0001D248 File Offset: 0x0001B448
		public override sbyte vmethod_9()
		{
			return (sbyte)this.long_0;
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x0001D25C File Offset: 0x0001B45C
		public override short E8F387ED()
		{
			return (short)this.long_0;
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x0001D270 File Offset: 0x0001B470
		public override int EC4893C4()
		{
			return (int)this.long_0;
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0001D284 File Offset: 0x0001B484
		public override long DB9EABF5()
		{
			return this.long_0;
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0001D220 File Offset: 0x0001B420
		public override ushort D3EC5557()
		{
			return (ushort)this.long_0;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0001D298 File Offset: 0x0001B498
		public override uint vmethod_11()
		{
			return (uint)this.long_0;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0001D284 File Offset: 0x0001B484
		public override ulong vmethod_12()
		{
			return (ulong)this.long_0;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0001D2AC File Offset: 0x0001B4AC
		public override float B4B75C1D()
		{
			return (float)this.long_0;
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0001D2C0 File Offset: 0x0001B4C0
		public override double vmethod_13()
		{
			return (double)this.long_0;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0001D2D4 File Offset: 0x0001B4D4
		public override IntPtr B6AA4A8E()
		{
			uint num = 754285532U;
			for (;;)
			{
				int size = IntPtr.Size;
				num <<= 20;
				uint num2 = num ^ 3183476740U;
				num = 951085100U + num;
				if (size != num2)
				{
					break;
				}
				num /= 2125269711U;
				if (1042360211U / num != 0U)
				{
					goto IL_47;
				}
			}
			num = 1009347093U / num;
			long value = this.long_0;
			goto IL_5F;
			IL_47:
			int num3 = (int)this.long_0;
			num = 1985113147U / num;
			value = (long)num3;
			num += 2309854149U;
			IL_5F:
			num = (904923604U & num);
			return new IntPtr(value);
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0001D350 File Offset: 0x0001B550
		public override UIntPtr vmethod_14()
		{
			uint num = 1331366474U;
			do
			{
				int size = UIntPtr.Size;
				num = 35946042U * num;
				uint num2 = num ^ 3491283136U;
				num %= 1344538138U;
				if (size == num2)
				{
					goto IL_41;
				}
			}
			while (num << 3 == 0U);
			num = 1226852070U * num;
			ulong value = (ulong)this.long_0;
			goto IL_61;
			IL_41:
			uint num3 = (uint)this.long_0;
			num ^= 1270306371U;
			ulong num4 = (ulong)num3;
			num = (450103588U ^ num);
			value = num4;
			num ^= 3595727511U;
			IL_61:
			return new UIntPtr(value);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0001D3C4 File Offset: 0x0001B5C4
		public override object CB7019CC(Type type_0, bool bool_0)
		{
			uint num = 40729318U;
			for (;;)
			{
				IL_20F:
				num >>= 12;
				if (type_0 != typeof(IntPtr))
				{
					for (;;)
					{
						Type typeFromHandle = typeof(UIntPtr);
						num = 1203508868U + num;
						if (type_0 == typeFromHandle)
						{
							goto Block_5;
						}
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num = 675350660U * num;
						if (955060536U <= num)
						{
							uint num2 = (uint)typeCode;
							num = (1052532142U & num);
							uint num3 = num2 - (num - 705976487U);
							num = 1759642149U / num;
							switch (num3)
							{
							case 0:
								if (263258768U == num)
								{
									goto IL_1F8;
								}
								if (bool_0)
								{
									goto IL_B1;
								}
								if ((169550751U ^ num) == 0U)
								{
									continue;
								}
								goto IL_26E;
							case 1:
								goto IL_D0;
							case 2:
								goto IL_E7;
							case 3:
								goto IL_12E;
							case 4:
								goto IL_14C;
							case 5:
								goto IL_163;
							case 6:
								goto IL_3E2;
							case 7:
								goto IL_194;
							case 8:
								goto IL_1B2;
							case 9:
								goto IL_1C7;
							}
							goto Block_2;
						}
						goto IL_20F;
					}
					IL_D0:
					if (!bool_0)
					{
						goto IL_2D7;
					}
					if (num * 423325873U != 0U)
					{
						goto Block_8;
					}
					continue;
					IL_E7:
					num = 1948652322U << (int)num;
					if ((321420226U ^ num) == 0U)
					{
						goto IL_1F8;
					}
					if (!bool_0)
					{
						num &= 1981225945U;
						if ((num & 237130939U) != 0U)
						{
							goto Block_11;
						}
						goto IL_1F8;
					}
					else
					{
						if ((503843896U ^ num) != 0U)
						{
							goto Block_12;
						}
						continue;
					}
					IL_163:
					if ((864774883U ^ num) == 0U)
					{
						continue;
					}
					if (!bool_0)
					{
						goto IL_3C5;
					}
					num >>= 24;
					if (244645924U >> (int)num != 0U)
					{
						goto Block_19;
					}
					continue;
					IL_194:
					if (!bool_0)
					{
						if (num <= 763237244U)
						{
							goto Block_21;
						}
						continue;
					}
					else
					{
						if (1542337606U / num != 0U)
						{
							goto Block_22;
						}
						continue;
					}
					IL_1B2:
					num *= 606807637U;
					if (num != 1023680937U)
					{
						goto Block_23;
					}
					continue;
					Block_2:
					num += 0U;
					goto IL_1B2;
					IL_1C7:
					if (!bool_0)
					{
						num = (1991713365U ^ num);
						if (1976116264U <= num)
						{
							goto Block_25;
						}
						goto IL_203;
					}
					else
					{
						if ((num ^ 1433816061U) != 0U)
						{
							goto Block_26;
						}
						goto IL_1F8;
					}
					IL_14C:
					if (bool_0)
					{
						goto IL_37D;
					}
					if (num >> 25 == 0U)
					{
						goto Block_16;
					}
					goto IL_1F8;
					IL_12E:
					if (!bool_0)
					{
						goto IL_343;
					}
					num = 834405546U - num;
					if (832922356U <= num)
					{
						goto Block_14;
					}
					goto IL_1F8;
					IL_B1:
					num += 527518752U;
					if (1871863986 << (int)num != 0)
					{
						goto Block_6;
					}
					goto IL_203;
				}
				for (;;)
				{
					IL_1F8:
					num &= 494666895U;
					if (bool_0)
					{
						break;
					}
					if (num <= 2018201894U)
					{
						goto IL_4B5;
					}
				}
				IL_203:
				if (num * 2135642768U != 0U)
				{
					goto IL_493;
				}
			}
			Block_5:
			num = (716124847U | num);
			ulong value;
			if (!bool_0)
			{
				num <<= 19;
				ulong num4 = (ulong)this.long_0;
				num %= 1114584023U;
				value = num4;
			}
			else
			{
				value = (ulong)this.long_0;
				num += 3370853500U;
			}
			num = 751046602U - num;
			return new UIntPtr(value);
			Block_6:
			ulong num5 = (ulong)this.long_0;
			num += 1977098982U;
			sbyte b = checked((sbyte)num5);
			num += 1790349560U;
			goto IL_29F;
			Block_8:
			num ^= 1791436872U;
			ulong num6 = (ulong)this.long_0;
			num <<= 13;
			byte b2 = (byte)num6;
			num ^= 887837367U;
			byte b3 = b2;
			num ^= 2257970189U;
			goto IL_2F4;
			Block_11:
			short num7 = (short)this.long_0;
			num %= 1727147676U;
			short num8 = num7;
			goto IL_323;
			Block_12:
			ushort num9;
			int num11;
			uint num13;
			ulong num14;
			checked
			{
				num8 = (short)((ulong)this.long_0);
				num ^= 2156413952U;
				goto IL_323;
				Block_14:
				num &= 1831875828U;
				num9 = (ushort)((uint)this.long_0);
				num ^= 3082867250U;
				goto IL_35E;
				Block_16:
				num %= 1820723763U;
				int num10 = (int)this.long_0;
				num /= 1360603321U;
				num11 = num10;
				goto IL_3A5;
				Block_19:
				uint num12 = (uint)((ulong)this.long_0);
				num ^= 179063510U;
				num13 = num12;
				num ^= 179063511U;
				goto IL_3DC;
				Block_21:
				num = 1848185619U % num;
				num14 = (ulong)this.long_0;
			}
			num = 2054962815U + num;
			ulong num15 = num14;
			goto IL_458;
			Block_22:
			num /= 50945315U;
			num15 = (ulong)this.long_0;
			num ^= 2054962816U;
			goto IL_458;
			Block_23:
			throw new ArgumentException();
			Block_25:
			double num16 = (double)this.long_0;
			num += 195778545U;
			double num17 = num16;
			goto IL_485;
			Block_26:
			num17 = this.long_0;
			num += 2187491910U;
			goto IL_485;
			IL_26E:
			num = 866024934U % num;
			sbyte b4 = (sbyte)this.long_0;
			num /= 1138844742U;
			b = b4;
			IL_29F:
			num = 1206202936U + num;
			return b;
			IL_2D7:
			num = 27097380U << (int)num;
			num |= 1429410474U;
			b3 = checked((byte)this.long_0);
			IL_2F4:
			num = 1413890583U + num;
			return b3;
			IL_323:
			return num8;
			IL_343:
			if (num * 558195799U == 0U)
			{
				goto IL_4B5;
			}
			num *= 1266182985U;
			num9 = checked((ushort)this.long_0);
			IL_35E:
			return num9;
			IL_37D:
			num = (728915684U ^ num);
			ulong num18 = (ulong)this.long_0;
			num /= 808979546U;
			int num19 = (int)num18;
			num = (780742919U ^ num);
			num11 = num19;
			num ^= 780742919U;
			IL_3A5:
			return num11;
			IL_3C5:
			num = (1018520491U | num);
			uint num20 = (uint)this.long_0;
			num /= 986917022U;
			num13 = num20;
			IL_3DC:
			return num13;
			IL_3E2:
			num = 871245643U >> (int)num;
			long num21;
			if (!bool_0)
			{
				num = 369122170U * num;
				num21 = this.long_0;
			}
			else
			{
				long num22 = (long)(checked((ulong)this.long_0));
				num >>= 17;
				num21 = num22;
				num += 2782743959U;
			}
			num = 1724994050U * num;
			return num21;
			IL_458:
			return num15;
			IL_485:
			num /= 1853708253U;
			return num17;
			IL_493:
			ulong num23 = (ulong)this.long_0;
			num *= 1914533447U;
			long num24 = (long)num23;
			num <<= 29;
			long value2 = num24;
			num += 3759617925U;
			goto IL_4C3;
			IL_4B5:
			num = 1763466177U / num;
			value2 = this.long_0;
			IL_4C3:
			num <<= 4;
			return new IntPtr(value2);
		}

		// Token: 0x04000178 RID: 376
		private long long_0;
	}

	// Token: 0x020001AF RID: 431
	private sealed class Class11 : GClass18.Class8
	{
		// Token: 0x060006DC RID: 1756 RVA: 0x0001D8A8 File Offset: 0x0001BAA8
		public Class11(float float_1)
		{
			this.float_0 = float_1;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0001D8C4 File Offset: 0x0001BAC4
		public override Type vmethod_6()
		{
			return typeof(float);
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x0001D8DC File Offset: 0x0001BADC
		public override TypeCode vmethod_7()
		{
			return TypeCode.Single;
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0001D8EC File Offset: 0x0001BAEC
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class11(this.float_0);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0001D904 File Offset: 0x0001BB04
		public override object vmethod_1()
		{
			return this.float_0;
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0001D91C File Offset: 0x0001BB1C
		public override void vmethod_2(object object_0)
		{
			this.float_0 = Convert.ToSingle(object_0);
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x0001D938 File Offset: 0x0001BB38
		public override bool vmethod_8()
		{
			return Convert.ToBoolean(this.float_0);
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0001D950 File Offset: 0x0001BB50
		public override sbyte vmethod_9()
		{
			return (sbyte)this.float_0;
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x0001D964 File Offset: 0x0001BB64
		public override short E8F387ED()
		{
			return (short)this.float_0;
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0001D978 File Offset: 0x0001BB78
		public override int EC4893C4()
		{
			return (int)this.float_0;
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0001D98C File Offset: 0x0001BB8C
		public override long DB9EABF5()
		{
			return (long)this.float_0;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0001D9A0 File Offset: 0x0001BBA0
		public override char F22CF44A()
		{
			return (char)this.float_0;
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0001D9B4 File Offset: 0x0001BBB4
		public override byte vmethod_10()
		{
			return (byte)this.float_0;
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x0001D9A0 File Offset: 0x0001BBA0
		public override ushort D3EC5557()
		{
			return (ushort)this.float_0;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x0001D9C8 File Offset: 0x0001BBC8
		public override uint vmethod_11()
		{
			return (uint)this.float_0;
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0001D9DC File Offset: 0x0001BBDC
		public override ulong vmethod_12()
		{
			return (ulong)this.float_0;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x0001D9F0 File Offset: 0x0001BBF0
		public override float B4B75C1D()
		{
			return this.float_0;
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0001DA04 File Offset: 0x0001BC04
		public override double vmethod_13()
		{
			return (double)this.float_0;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0001DA18 File Offset: 0x0001BC18
		public override IntPtr B6AA4A8E()
		{
			int size = IntPtr.Size;
			int num = 4;
			uint num2 = 1281536970U;
			long value;
			if (size != num)
			{
				num2 ^= 228860453U;
				value = (long)this.float_0;
			}
			else
			{
				num2 = (56247002U | num2);
				num2 &= 567495121U;
				long num3 = (long)((int)this.float_0);
				num2 &= 721972952U;
				value = num3;
				num2 += 1086738719U;
			}
			num2 <<= 5;
			return new IntPtr(value);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0001DA80 File Offset: 0x0001BC80
		public override UIntPtr vmethod_14()
		{
			uint num = 686387046U;
			do
			{
				uint size = (uint)IntPtr.Size;
				num &= 1001413222U;
				if (size == (num ^ 681593442U))
				{
					goto IL_32;
				}
			}
			while (num % 1692887855U == 0U);
			ulong value = (ulong)this.float_0;
			goto IL_50;
			IL_32:
			uint num2 = (uint)this.float_0;
			num = 1979212795U >> (int)num;
			value = (ulong)num2;
			num += 650668247U;
			IL_50:
			num <<= 28;
			return new UIntPtr(value);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0001DAEC File Offset: 0x0001BCEC
		public override object CB7019CC(Type type_0, bool bool_0)
		{
			uint num;
			for (;;)
			{
				RuntimeTypeHandle handle = typeof(IntPtr).TypeHandle;
				num = 1975672832U;
				if (type_0 == Type.GetTypeFromHandle(handle))
				{
					num = 560339732U * num;
					if (num + 718356627U != 0U)
					{
						goto Block_11;
					}
				}
				for (;;)
				{
					num /= 14246375U;
					Type typeFromHandle = typeof(UIntPtr);
					num = 871308261U * num;
					if (type_0 == typeFromHandle)
					{
						goto Block_5;
					}
					num = (2084927953U ^ num);
					if (54597301U + num != 0U)
					{
						num *= 1924221870U;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num = 1059399069U >> (int)num;
						uint num2 = (uint)typeCode;
						num >>= 4;
						uint num3 = num2 - (num ^ 64657U);
						num = 1689679771U >> (int)num;
						switch (num3)
						{
						case 0:
							goto IL_DC;
						case 1:
							goto IL_1C3;
						case 2:
							num *= 1236561078U;
							if (!bool_0)
							{
								goto IL_EF;
							}
							if (num != 1569934769U)
							{
								goto Block_4;
							}
							continue;
						case 3:
							goto IL_20D;
						case 4:
							goto IL_230;
						case 5:
							goto IL_10D;
						case 6:
							goto IL_11E;
						case 7:
							goto IL_268;
						}
						goto Block_2;
					}
					goto IL_285;
				}
				IL_DC:
				if (!bool_0)
				{
					goto IL_190;
				}
				if (924844476U >= num)
				{
					goto Block_7;
				}
				continue;
				IL_EF:
				num = 363819602U >> (int)num;
				if (num <= 565403530U)
				{
					goto Block_8;
				}
				continue;
				IL_10D:
				if (1095633702U % num != 0U)
				{
					goto Block_9;
				}
				continue;
				IL_11E:
				if (1417427521U / num != 0U)
				{
					goto Block_10;
				}
				continue;
				Block_2:
				num += 0U;
				goto IL_11E;
			}
			Block_4:
			short num4 = (short)(checked((uint)this.float_0));
			num = 1343630689U * num;
			short num5 = num4;
			num += 3562634071U;
			goto IL_1F9;
			Block_5:
			if (num / 1969051896U != 0U)
			{
				ulong value = checked((ulong)this.float_0);
				num |= 577792632U;
				return new UIntPtr(value);
			}
			goto IL_285;
			Block_7:
			num |= 520379394U;
			uint num6 = (uint)this.float_0;
			num = 1966215061U + num;
			sbyte b = checked((sbyte)num6);
			num += 1808372256U;
			goto IL_1B5;
			Block_8:
			num = (1185612781U & num);
			int num9;
			checked
			{
				num5 = (short)this.float_0;
				goto IL_1F9;
				Block_9:
				uint num7 = (uint)this.float_0;
				num ^= 799747824U;
				return num7;
				Block_10:
				throw new ArgumentException();
				Block_11:
				goto IL_285;
				IL_190:
				num = unchecked(1938448886U - num);
				num = 605899989U << (int)num;
				sbyte b2 = (sbyte)this.float_0;
				num = 1621370987U / num;
				b = b2;
				IL_1B5:
				num = (1829376611U ^ num);
				return b;
				IL_1C3:
				return (byte)this.float_0;
				IL_1F9:
				num = 1652167850U >> (int)num;
				return num5;
				IL_20D:
				num = 2081455555U % num;
				ushort num8 = (ushort)this.float_0;
				num = 1129858043U << (int)num;
				return num8;
				IL_230:
				num /= 907899850U;
				num9 = (int)this.float_0;
			}
			num *= 128665508U;
			return num9;
			IL_268:
			num <<= 15;
			ulong num10 = checked((ulong)this.float_0);
			num = (540683030U ^ num);
			return num10;
			IL_285:
			num <<= 30;
			long num11 = (long)this.float_0;
			num = (404563387U & num);
			return new IntPtr(num11);
		}

		// Token: 0x04000179 RID: 377
		private float float_0;
	}

	// Token: 0x020001B0 RID: 432
	private sealed class Class12 : GClass18.Class8
	{
		// Token: 0x060006F1 RID: 1777 RVA: 0x0001DDA4 File Offset: 0x0001BFA4
		public Class12(double double_1)
		{
			uint num = 1583165223U;
			do
			{
				base..ctor();
			}
			while (667041043U == num);
			num = 1367954203U % num;
			this.double_0 = double_1;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0001DDD4 File Offset: 0x0001BFD4
		public override Type vmethod_6()
		{
			return typeof(double);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x0001DDEC File Offset: 0x0001BFEC
		public override TypeCode vmethod_7()
		{
			return TypeCode.Double;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0001DDFC File Offset: 0x0001BFFC
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class12(this.double_0);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0001DE14 File Offset: 0x0001C014
		public override object vmethod_1()
		{
			return this.double_0;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0001DE2C File Offset: 0x0001C02C
		public override void vmethod_2(object object_0)
		{
			this.double_0 = (double)object_0;
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0001DE48 File Offset: 0x0001C048
		public override bool vmethod_8()
		{
			return Convert.ToBoolean(this.double_0);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0001DE60 File Offset: 0x0001C060
		public override sbyte vmethod_9()
		{
			return (sbyte)this.double_0;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0001DE74 File Offset: 0x0001C074
		public override short E8F387ED()
		{
			return (short)this.double_0;
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0001DE88 File Offset: 0x0001C088
		public override int EC4893C4()
		{
			return (int)this.double_0;
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0001DE9C File Offset: 0x0001C09C
		public override long DB9EABF5()
		{
			return (long)this.double_0;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0001DEB0 File Offset: 0x0001C0B0
		public override char F22CF44A()
		{
			return (char)this.double_0;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0001DEC4 File Offset: 0x0001C0C4
		public override byte vmethod_10()
		{
			return (byte)this.double_0;
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0001DEB0 File Offset: 0x0001C0B0
		public override ushort D3EC5557()
		{
			return (ushort)this.double_0;
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x0001DED8 File Offset: 0x0001C0D8
		public override uint vmethod_11()
		{
			return (uint)this.double_0;
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x0001DEEC File Offset: 0x0001C0EC
		public override ulong vmethod_12()
		{
			return (ulong)this.double_0;
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x0001DF00 File Offset: 0x0001C100
		public override float B4B75C1D()
		{
			return (float)this.double_0;
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0001DF14 File Offset: 0x0001C114
		public override double vmethod_13()
		{
			return this.double_0;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x0001DF28 File Offset: 0x0001C128
		public override IntPtr B6AA4A8E()
		{
			int size = IntPtr.Size;
			int num = 4;
			uint num2 = 37774338U;
			long value;
			if (size != num)
			{
				num2 -= 2008158242U;
				value = (long)this.double_0;
			}
			else
			{
				num2 = (734072269U & num2);
				long num3 = (long)((int)this.double_0);
				num2 >>= 9;
				value = num3;
				num2 ^= 2324657122U;
			}
			num2 *= 312042799U;
			return new IntPtr(value);
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x0001DF88 File Offset: 0x0001C188
		public override UIntPtr vmethod_14()
		{
			uint num;
			for (;;)
			{
				int size = IntPtr.Size;
				num = 805705980U;
				if (size != 4)
				{
					break;
				}
				if ((num & 1728393914U) != 0U)
				{
					goto Block_1;
				}
			}
			num %= 31000886U;
			ulong num2 = (ulong)this.double_0;
			num -= 823288455U;
			ulong value = num2;
			goto IL_44;
			Block_1:
			value = (ulong)((uint)this.double_0);
			num += 2696656691U;
			IL_44:
			return new UIntPtr(value);
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x0001DFE0 File Offset: 0x0001C1E0
		public override object CB7019CC(Type type_0, bool bool_0)
		{
			uint num;
			for (;;)
			{
				IL_00:
				Type typeFromHandle = typeof(IntPtr);
				num = 331821116U;
				if (type_0 == typeFromHandle)
				{
					break;
				}
				while (1079127184U / num == 0U || type_0 != typeof(UIntPtr))
				{
					for (;;)
					{
						num *= 143420019U;
						if (1297950953U >> (int)num != 0U)
						{
							num = (646061562U ^ num);
							TypeCode typeCode = Type.GetTypeCode(type_0);
							num = 1873051061U + num;
							object obj = typeCode;
							num = (1885025027U | num);
							object obj2 = num + 2223030338U;
							num <<= 13;
							object obj3 = obj - obj2;
							num = 1993688489U % num;
							switch (obj3)
							{
							case 0:
								goto IL_113;
							case 1:
								goto IL_D8;
							case 2:
								if (num - 745603504U == 0U)
								{
									continue;
								}
								goto IL_186;
							case 3:
								goto IL_1FB;
							case 4:
								goto IL_210;
							case 5:
								goto IL_22B;
							case 6:
								goto IL_258;
							case 7:
								goto IL_26D;
							case 8:
								goto IL_2AC;
							case 9:
								goto IL_2B2;
							}
							break;
						}
						goto IL_00;
					}
					if (1418345367U * num != 0U)
					{
						goto Block_3;
					}
					continue;
					IL_D8:
					if ((415442171U ^ num) != 0U)
					{
						goto Block_6;
					}
					goto IL_00;
				}
				goto Block_4;
			}
			num = (418858222U | num);
			goto IL_1D1;
			Block_3:
			num ^= 0U;
			goto IL_2AC;
			Block_4:
			if (548809981U > num)
			{
				goto IL_292;
			}
			goto IL_1D1;
			Block_6:
			num <<= 15;
			return checked((byte)this.double_0);
			IL_113:
			if (1842090029U >> (int)num != 0U)
			{
				sbyte b2;
				if (!bool_0)
				{
					if ((num ^ 222197678U) == 0U)
					{
						goto IL_292;
					}
					sbyte b = (sbyte)this.double_0;
					num <<= 23;
					b2 = b;
				}
				else
				{
					uint num2 = (uint)this.double_0;
					num = (958662105U | num);
					b2 = checked((sbyte)num2);
					num += 1418377735U;
				}
				num ^= 2103059300U;
				return b2;
			}
			goto IL_1D1;
			IL_186:
			short num3;
			if (!bool_0)
			{
				num += 447029690U;
				num = 1906051776U - num;
				num3 = checked((short)this.double_0);
			}
			else
			{
				if (1616784826U * num == 0U)
				{
					goto IL_1D1;
				}
				uint num4 = (uint)this.double_0;
				num >>= 19;
				short num5 = (short)num4;
				num /= 1444766613U;
				num3 = num5;
				num ^= 3760300893U;
			}
			return num3;
			IL_1D1:
			num ^= 1015818155U;
			long num6 = (long)this.double_0;
			num |= 890785637U;
			IntPtr intPtr = new IntPtr(num6);
			num = (1841114166U & num);
			return intPtr;
			IL_1FB:
			ushort num7 = checked((ushort)this.double_0);
			num = 1996973616U + num;
			return num7;
			IL_210:
			int num8 = checked((int)this.double_0);
			num = 417821309U >> (int)num;
			return num8;
			IL_22B:
			if (num > 647845665U)
			{
				num ^= 1540320446U;
				uint num9 = (uint)this.double_0;
				num += 647323798U;
				uint num10 = num9;
				num += 2082422678U;
				return num10;
			}
			goto IL_2AC;
			IL_258:
			num = 1136022350U / num;
			checked
			{
				return (long)this.double_0;
				IL_26D:
				if (num > 1512589586U)
				{
					num = unchecked(2092255951U + num);
					ulong num11 = (ulong)this.double_0;
					num >>= 30;
					return num11;
				}
				IL_292:
				ulong value = (ulong)this.double_0;
				num = (1787315268U | num);
				return new UIntPtr(value);
				IL_2AC:
				throw new ArgumentException();
				IL_2B2:
				num = (1895786025U ^ num);
				num ^= 623784582U;
				return this.double_0;
			}
		}

		// Token: 0x0400017A RID: 378
		private double double_0;
	}

	// Token: 0x020001B1 RID: 433
	private sealed class Class13 : GClass18.Class8
	{
		// Token: 0x06000706 RID: 1798 RVA: 0x0001E2BC File Offset: 0x0001C4BC
		public Class13(string string_1)
		{
			uint num = 453274665U;
			do
			{
				base..ctor();
				num = (1191212597U & num);
			}
			while (num > 1331975707U);
			num = 1012865509U << (int)num;
			this.string_0 = string_1;
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x0001E2FC File Offset: 0x0001C4FC
		public override Type vmethod_6()
		{
			return typeof(string);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0001E314 File Offset: 0x0001C514
		public override TypeCode vmethod_7()
		{
			return TypeCode.Object;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x0001E324 File Offset: 0x0001C524
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class13(this.string_0);
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x0001E33C File Offset: 0x0001C53C
		public override object vmethod_1()
		{
			return this.string_0;
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0001E350 File Offset: 0x0001C550
		public override void vmethod_2(object object_0)
		{
			uint num = 614694877U;
			string text;
			if (object_0 == null)
			{
				num = 1958770163U / num;
				text = null;
			}
			else
			{
				num = (1666125696U & num);
				text = Convert.ToString(object_0);
				num ^= 537071491U;
			}
			this.string_0 = text;
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0001E390 File Offset: 0x0001C590
		public override bool vmethod_8()
		{
			return this.string_0 != null;
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0001E33C File Offset: 0x0001C53C
		public override string ToString()
		{
			return this.string_0;
		}

		// Token: 0x0400017B RID: 379
		private string string_0;
	}

	// Token: 0x020001B2 RID: 434
	private sealed class Class28 : GClass18.Class7
	{
		// Token: 0x0600070E RID: 1806 RVA: 0x0001E3A8 File Offset: 0x0001C5A8
		public Class28(short short_1)
		{
			this.short_0 = short_1;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0001E3C4 File Offset: 0x0001C5C4
		public override Type vmethod_6()
		{
			return typeof(short);
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0001E3DC File Offset: 0x0001C5DC
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class28(this.short_0);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x0001E3F4 File Offset: 0x0001C5F4
		public override object vmethod_1()
		{
			return this.short_0;
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x0001E40C File Offset: 0x0001C60C
		public override void vmethod_2(object object_0)
		{
			this.short_0 = Convert.ToInt16(object_0);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x0001E428 File Offset: 0x0001C628
		public override GClass18.Class8 vmethod_4()
		{
			return new GClass18.Class9(this.EC4893C4());
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0001E440 File Offset: 0x0001C640
		public override sbyte vmethod_9()
		{
			return (sbyte)this.short_0;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0001E454 File Offset: 0x0001C654
		public override byte vmethod_10()
		{
			return (byte)this.short_0;
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0001E468 File Offset: 0x0001C668
		public override short E8F387ED()
		{
			return this.short_0;
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0001E47C File Offset: 0x0001C67C
		public override ushort D3EC5557()
		{
			return (ushort)this.short_0;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x0001E468 File Offset: 0x0001C668
		public override int EC4893C4()
		{
			return (int)this.short_0;
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0001E468 File Offset: 0x0001C668
		public override uint vmethod_11()
		{
			return (uint)this.short_0;
		}

		// Token: 0x0400017C RID: 380
		private short short_0;
	}

	// Token: 0x020001B3 RID: 435
	private sealed class Class29 : GClass18.Class7
	{
		// Token: 0x0600071A RID: 1818 RVA: 0x0001E490 File Offset: 0x0001C690
		public Class29(ushort ushort_1)
		{
			uint num = 187957477U;
			do
			{
				base..ctor();
				num = 1496001093U * num;
				num -= 184631479U;
				num = 1512601950U + num;
				this.ushort_0 = ushort_1;
			}
			while ((1945269911U & num) == 0U);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x0001E4D4 File Offset: 0x0001C6D4
		public override Type vmethod_6()
		{
			return typeof(ushort);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0001E4EC File Offset: 0x0001C6EC
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class29(this.ushort_0);
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0001E504 File Offset: 0x0001C704
		public override object vmethod_1()
		{
			return this.ushort_0;
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0001E51C File Offset: 0x0001C71C
		public override void vmethod_2(object object_0)
		{
			this.ushort_0 = Convert.ToUInt16(object_0);
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0001E428 File Offset: 0x0001C628
		public override GClass18.Class8 vmethod_4()
		{
			return new GClass18.Class9(this.EC4893C4());
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0001E538 File Offset: 0x0001C738
		public override sbyte vmethod_9()
		{
			return (sbyte)this.ushort_0;
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0001E54C File Offset: 0x0001C74C
		public override byte vmethod_10()
		{
			return (byte)this.ushort_0;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0001E560 File Offset: 0x0001C760
		public override short E8F387ED()
		{
			return (short)this.ushort_0;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x0001E574 File Offset: 0x0001C774
		public override ushort D3EC5557()
		{
			return this.ushort_0;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0001E574 File Offset: 0x0001C774
		public override int EC4893C4()
		{
			return (int)this.ushort_0;
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0001E574 File Offset: 0x0001C774
		public override uint vmethod_11()
		{
			return (uint)this.ushort_0;
		}

		// Token: 0x0400017D RID: 381
		private ushort ushort_0;
	}

	// Token: 0x020001B4 RID: 436
	private sealed class Class30 : GClass18.Class7
	{
		// Token: 0x06000726 RID: 1830 RVA: 0x0001E588 File Offset: 0x0001C788
		public Class30(bool bool_1)
		{
			this.bool_0 = bool_1;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0001E5A4 File Offset: 0x0001C7A4
		public override Type vmethod_6()
		{
			return typeof(bool);
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x0001E5BC File Offset: 0x0001C7BC
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class30(this.bool_0);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0001E5D4 File Offset: 0x0001C7D4
		public override object vmethod_1()
		{
			return this.bool_0;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0001E5EC File Offset: 0x0001C7EC
		public override void vmethod_2(object object_0)
		{
			uint num = 1873949914U;
			do
			{
				num ^= 81673121U;
				num &= 1580300316U;
				this.bool_0 = Convert.ToBoolean(object_0);
			}
			while (num > 1431791215U);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x0001E428 File Offset: 0x0001C628
		public override GClass18.Class8 vmethod_4()
		{
			return new GClass18.Class9(this.EC4893C4());
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0001E624 File Offset: 0x0001C824
		public override int EC4893C4()
		{
			bool flag = this.bool_0;
			uint num = 521479219U;
			if (!flag)
			{
				num = (664743454U & num);
				return (int)(num - 118826002U);
			}
			return (int)(num ^ 521479218U);
		}

		// Token: 0x0400017E RID: 382
		private bool bool_0;
	}

	// Token: 0x020001B5 RID: 437
	private sealed class Class31 : GClass18.Class7
	{
		// Token: 0x0600072D RID: 1837 RVA: 0x0001E658 File Offset: 0x0001C858
		public Class31(char char_1)
		{
			uint num = 787490116U;
			do
			{
				num = 535909205U % num;
				base..ctor();
			}
			while (2106086573U == num);
			this.char_0 = char_1;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0001E688 File Offset: 0x0001C888
		public override Type vmethod_6()
		{
			return typeof(char);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0001E6A0 File Offset: 0x0001C8A0
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class31(this.char_0);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0001E6B8 File Offset: 0x0001C8B8
		public override object vmethod_1()
		{
			return this.char_0;
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0001E6D0 File Offset: 0x0001C8D0
		public override void vmethod_2(object object_0)
		{
			this.char_0 = Convert.ToChar(object_0);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0001E428 File Offset: 0x0001C628
		public override GClass18.Class8 vmethod_4()
		{
			return new GClass18.Class9(this.EC4893C4());
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x0001E6EC File Offset: 0x0001C8EC
		public override sbyte vmethod_9()
		{
			return (sbyte)this.char_0;
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0001E700 File Offset: 0x0001C900
		public override byte vmethod_10()
		{
			return (byte)this.char_0;
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0001E714 File Offset: 0x0001C914
		public override short E8F387ED()
		{
			return (short)this.char_0;
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0001E728 File Offset: 0x0001C928
		public override ushort D3EC5557()
		{
			return (ushort)this.char_0;
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0001E728 File Offset: 0x0001C928
		public override int EC4893C4()
		{
			return (int)this.char_0;
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0001E728 File Offset: 0x0001C928
		public override uint vmethod_11()
		{
			return (uint)this.char_0;
		}

		// Token: 0x0400017F RID: 383
		private char char_0;
	}

	// Token: 0x020001B6 RID: 438
	private sealed class Class32 : GClass18.Class7
	{
		// Token: 0x06000739 RID: 1849 RVA: 0x0001E73C File Offset: 0x0001C93C
		public Class32(byte byte_1)
		{
			uint num = 483665860U;
			do
			{
				base..ctor();
				num -= 1452874578U;
				this.byte_0 = byte_1;
			}
			while (num == 1736054098U);
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x0001E76C File Offset: 0x0001C96C
		public override Type vmethod_6()
		{
			return typeof(byte);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x0001E784 File Offset: 0x0001C984
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class32(this.byte_0);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0001E79C File Offset: 0x0001C99C
		public override object vmethod_1()
		{
			return this.byte_0;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0001E7B4 File Offset: 0x0001C9B4
		public override void vmethod_2(object object_0)
		{
			this.byte_0 = Convert.ToByte(object_0);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0001E428 File Offset: 0x0001C628
		public override GClass18.Class8 vmethod_4()
		{
			return new GClass18.Class9(this.EC4893C4());
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0001E7D0 File Offset: 0x0001C9D0
		public override sbyte vmethod_9()
		{
			return (sbyte)this.byte_0;
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0001E7E4 File Offset: 0x0001C9E4
		public override byte vmethod_10()
		{
			return this.byte_0;
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0001E7E4 File Offset: 0x0001C9E4
		public override short E8F387ED()
		{
			return (short)this.byte_0;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x0001E7E4 File Offset: 0x0001C9E4
		public override ushort D3EC5557()
		{
			return (ushort)this.byte_0;
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x0001E7E4 File Offset: 0x0001C9E4
		public override int EC4893C4()
		{
			return (int)this.byte_0;
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0001E7E4 File Offset: 0x0001C9E4
		public override uint vmethod_11()
		{
			return (uint)this.byte_0;
		}

		// Token: 0x04000180 RID: 384
		private byte byte_0;
	}

	// Token: 0x020001B7 RID: 439
	private sealed class Class33 : GClass18.Class7
	{
		// Token: 0x06000745 RID: 1861 RVA: 0x0001E7F8 File Offset: 0x0001C9F8
		public Class33(sbyte sbyte_1)
		{
			this.sbyte_0 = sbyte_1;
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x0001E814 File Offset: 0x0001CA14
		public override Type vmethod_6()
		{
			return typeof(sbyte);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x0001E82C File Offset: 0x0001CA2C
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class33(this.sbyte_0);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x0001E844 File Offset: 0x0001CA44
		public override object vmethod_1()
		{
			return this.sbyte_0;
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x0001E85C File Offset: 0x0001CA5C
		public override void vmethod_2(object object_0)
		{
			uint num = 481953964U;
			do
			{
				num = (574816445U ^ num);
				this.sbyte_0 = Convert.ToSByte(object_0);
			}
			while (num <= 474561668U);
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0001E428 File Offset: 0x0001C628
		public override GClass18.Class8 vmethod_4()
		{
			return new GClass18.Class9(this.EC4893C4());
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0001E88C File Offset: 0x0001CA8C
		public override sbyte vmethod_9()
		{
			return this.sbyte_0;
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0001E8A0 File Offset: 0x0001CAA0
		public override byte vmethod_10()
		{
			return (byte)this.sbyte_0;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0001E88C File Offset: 0x0001CA8C
		public override short E8F387ED()
		{
			return (short)this.sbyte_0;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0001E8B4 File Offset: 0x0001CAB4
		public override ushort D3EC5557()
		{
			return (ushort)this.sbyte_0;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0001E88C File Offset: 0x0001CA8C
		public override int EC4893C4()
		{
			return (int)this.sbyte_0;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0001E88C File Offset: 0x0001CA8C
		public override uint vmethod_11()
		{
			return (uint)this.sbyte_0;
		}

		// Token: 0x04000181 RID: 385
		private sbyte sbyte_0;
	}

	// Token: 0x020001B8 RID: 440
	private sealed class Class34 : GClass18.Class7
	{
		// Token: 0x06000751 RID: 1873 RVA: 0x0001E8C8 File Offset: 0x0001CAC8
		public Class34(uint uint_1)
		{
			uint num = 527908824U;
			do
			{
				num = 43913787U >> (int)num;
				base..ctor();
				num -= 2099249706U;
				num = 1053714923U % num;
				this.uint_0 = uint_1;
			}
			while (1894464031U <= num);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0001E910 File Offset: 0x0001CB10
		public override Type vmethod_6()
		{
			return typeof(uint);
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0001E928 File Offset: 0x0001CB28
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class34(this.uint_0);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0001E940 File Offset: 0x0001CB40
		public override object vmethod_1()
		{
			return this.uint_0;
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0001E958 File Offset: 0x0001CB58
		public override void vmethod_2(object object_0)
		{
			uint num = 465909021U;
			do
			{
				num = (1133003135U ^ num);
				num = 1182597295U % num;
				this.uint_0 = Convert.ToUInt32(object_0);
			}
			while (num >> 11 == 0U);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0001E428 File Offset: 0x0001C628
		public override GClass18.Class8 vmethod_4()
		{
			return new GClass18.Class9(this.EC4893C4());
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0001E990 File Offset: 0x0001CB90
		public override sbyte vmethod_9()
		{
			return (sbyte)this.uint_0;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0001E9A4 File Offset: 0x0001CBA4
		public override byte vmethod_10()
		{
			return (byte)this.uint_0;
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0001E9B8 File Offset: 0x0001CBB8
		public override short E8F387ED()
		{
			return (short)this.uint_0;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0001E9CC File Offset: 0x0001CBCC
		public override ushort D3EC5557()
		{
			return (ushort)this.uint_0;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0001E9E0 File Offset: 0x0001CBE0
		public override int EC4893C4()
		{
			return (int)this.uint_0;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x0001E9E0 File Offset: 0x0001CBE0
		public override uint vmethod_11()
		{
			return this.uint_0;
		}

		// Token: 0x04000182 RID: 386
		private uint uint_0;
	}

	// Token: 0x020001B9 RID: 441
	private sealed class Class35 : GClass18.Class7
	{
		// Token: 0x0600075D RID: 1885 RVA: 0x0001E9F4 File Offset: 0x0001CBF4
		public Class35(ulong ulong_1)
		{
			uint num = 858858091U;
			for (;;)
			{
				base..ctor();
				num &= 1962376402U;
				if (254435253U < num)
				{
					num = 1811427873U >> (int)num;
					this.ulong_0 = ulong_1;
					if (num != 76763443U)
					{
						break;
					}
				}
			}
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0001EA40 File Offset: 0x0001CC40
		public override Type vmethod_6()
		{
			return typeof(ulong);
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x0001EA58 File Offset: 0x0001CC58
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class35(this.ulong_0);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0001EA70 File Offset: 0x0001CC70
		public override object vmethod_1()
		{
			return this.ulong_0;
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0001EA88 File Offset: 0x0001CC88
		public override void vmethod_2(object object_0)
		{
			uint num = 1741689119U;
			do
			{
				num = 1137602050U >> (int)num;
				this.ulong_0 = Convert.ToUInt64(object_0);
			}
			while ((num ^ 1252973U) == 0U);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x0001EAC0 File Offset: 0x0001CCC0
		public override GClass18.Class8 vmethod_4()
		{
			return new GClass18.Class10(this.DB9EABF5());
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0001EAD8 File Offset: 0x0001CCD8
		public override sbyte vmethod_9()
		{
			return (sbyte)this.ulong_0;
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x0001EAEC File Offset: 0x0001CCEC
		public override byte vmethod_10()
		{
			return (byte)this.ulong_0;
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0001EB00 File Offset: 0x0001CD00
		public override short E8F387ED()
		{
			return (short)this.ulong_0;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0001EB14 File Offset: 0x0001CD14
		public override ushort D3EC5557()
		{
			return (ushort)this.ulong_0;
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x0001EB28 File Offset: 0x0001CD28
		public override int EC4893C4()
		{
			return (int)this.ulong_0;
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0001EB3C File Offset: 0x0001CD3C
		public override uint vmethod_11()
		{
			return (uint)this.ulong_0;
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0001EB50 File Offset: 0x0001CD50
		public override long DB9EABF5()
		{
			return (long)this.ulong_0;
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0001EB50 File Offset: 0x0001CD50
		public override ulong vmethod_12()
		{
			return this.ulong_0;
		}

		// Token: 0x04000183 RID: 387
		private ulong ulong_0;
	}

	// Token: 0x020001BA RID: 442
	private sealed class Class14 : GClass18.Class8
	{
		// Token: 0x0600076B RID: 1899 RVA: 0x0001EB64 File Offset: 0x0001CD64
		public Class14(object object_1)
		{
			this.object_0 = object_1;
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0001EB80 File Offset: 0x0001CD80
		public override Type vmethod_6()
		{
			return typeof(object);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0001E314 File Offset: 0x0001C514
		public override TypeCode vmethod_7()
		{
			return TypeCode.Object;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0001EB98 File Offset: 0x0001CD98
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class14(this.object_0);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0001EBB0 File Offset: 0x0001CDB0
		public override object vmethod_1()
		{
			return this.object_0;
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x0001EBC4 File Offset: 0x0001CDC4
		public override void vmethod_2(object object_1)
		{
			uint num = 1647083041U;
			do
			{
				this.object_0 = object_1;
			}
			while ((894571576U ^ num) == 0U);
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0001EBE8 File Offset: 0x0001CDE8
		public override bool vmethod_8()
		{
			return this.object_0 != null;
		}

		// Token: 0x04000184 RID: 388
		private object object_0;
	}

	// Token: 0x020001BB RID: 443
	private sealed class Class15 : GClass18.Class8
	{
		// Token: 0x06000772 RID: 1906 RVA: 0x0001EC00 File Offset: 0x0001CE00
		public Class15(object object_1, Type type_1)
		{
			uint num = 1946052478U;
			do
			{
				num = 817329791U - num;
				this.object_0 = object_1;
				num = 10116708U * num;
			}
			while ((num ^ 2114397538U) == 0U);
			num = 1187871924U >> (int)num;
			this.type_0 = type_1;
			num = (57737726U ^ num);
			num /= 920330317U;
			this.class7_0 = GClass18.Class15.smethod_0(object_1);
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0001EC70 File Offset: 0x0001CE70
		private unsafe static GClass18.Class7 smethod_0(object object_1)
		{
			uint num = 594743125U;
			IntPtr intPtr;
			if (object_1 == null)
			{
				intPtr = IntPtr.Zero;
				num += 3700226240U;
				goto IL_3E;
			}
			num += 1574855243U;
			IL_2B:
			void* value = Pointer.Unbox(object_1);
			num >>= 20;
			intPtr = new IntPtr(value);
			IL_3E:
			num += 1273790267U;
			IntPtr intPtr2 = intPtr;
			num = 986736353U << (int)num;
			if (IntPtr.Size != (int)(num + 2568945668U))
			{
				num *= 301952825U;
				long long_ = intPtr2.ToInt64();
				num = 119543128U << (int)num;
				return new GClass18.Class10(long_);
			}
			if (num * 1676085920U == 0U)
			{
				goto IL_2B;
			}
			num = 92822754U + num;
			int int_ = intPtr2.ToInt32();
			num &= 2075217542U;
			return new GClass18.Class9(int_);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0001ED24 File Offset: 0x0001CF24
		public override Type vmethod_6()
		{
			return this.type_0;
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0001ED38 File Offset: 0x0001CF38
		public override TypeCode vmethod_7()
		{
			uint num = 780036900U;
			if (IntPtr.Size != 4)
			{
				return (TypeCode)(num ^ 780036904U);
			}
			return (TypeCode)(num ^ 780036910U);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0001ED64 File Offset: 0x0001CF64
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class15(this.object_0, this.type_0);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x0001ED84 File Offset: 0x0001CF84
		public override object vmethod_1()
		{
			return this.object_0;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0001ED98 File Offset: 0x0001CF98
		public override void vmethod_2(object object_1)
		{
			this.object_0 = object_1;
			uint num = 5U;
			do
			{
				num >>= 29;
				GClass18.Class7 @class = GClass18.Class15.smethod_0(object_1);
				num = (1266179503U ^ num);
				this.class7_0 = @class;
			}
			while (num < 198847691U);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0001EDD8 File Offset: 0x0001CFD8
		public override bool vmethod_8()
		{
			return this.object_0 != null;
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x0001EDF0 File Offset: 0x0001CFF0
		public override sbyte vmethod_9()
		{
			return this.class7_0.vmethod_9();
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0001EE08 File Offset: 0x0001D008
		public override short E8F387ED()
		{
			return this.class7_0.E8F387ED();
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x0001EE20 File Offset: 0x0001D020
		public override int EC4893C4()
		{
			return this.class7_0.EC4893C4();
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0001EE38 File Offset: 0x0001D038
		public override long DB9EABF5()
		{
			return this.class7_0.DB9EABF5();
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0001EE50 File Offset: 0x0001D050
		public override byte vmethod_10()
		{
			return this.class7_0.vmethod_10();
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0001EE68 File Offset: 0x0001D068
		public override ushort D3EC5557()
		{
			return this.class7_0.D3EC5557();
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0001EE80 File Offset: 0x0001D080
		public override uint vmethod_11()
		{
			return this.class7_0.vmethod_11();
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x0001EE98 File Offset: 0x0001D098
		public override ulong vmethod_12()
		{
			return this.class7_0.vmethod_12();
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x0001EEB0 File Offset: 0x0001D0B0
		public override float B4B75C1D()
		{
			return this.class7_0.B4B75C1D();
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0001EEC8 File Offset: 0x0001D0C8
		public override double vmethod_13()
		{
			return this.class7_0.vmethod_13();
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x0001EEE0 File Offset: 0x0001D0E0
		public override IntPtr B6AA4A8E()
		{
			return this.class7_0.B6AA4A8E();
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x0001EEF8 File Offset: 0x0001D0F8
		public override UIntPtr vmethod_14()
		{
			return this.class7_0.vmethod_14();
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x0001EF10 File Offset: 0x0001D110
		public unsafe override void* vmethod_15()
		{
			return Pointer.Unbox(this.object_0);
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x0001EF28 File Offset: 0x0001D128
		public override object CB7019CC(Type type_1, bool bool_0)
		{
			return this.class7_0.CB7019CC(type_1, bool_0);
		}

		// Token: 0x04000185 RID: 389
		private object object_0;

		// Token: 0x04000186 RID: 390
		private Type type_0;

		// Token: 0x04000187 RID: 391
		private GClass18.Class7 class7_0;
	}

	// Token: 0x020001BC RID: 444
	private sealed class Class16 : GClass18.Class8
	{
		// Token: 0x06000788 RID: 1928 RVA: 0x0001EF44 File Offset: 0x0001D144
		public Class16(object object_1)
		{
			uint num = 1452109456U;
			do
			{
				num = (1360147926U ^ num);
				base..ctor();
				num = 781217128U << (int)num;
				if (num < 1303800976U)
				{
					goto IL_7C;
				}
				if (object_1 == null)
				{
					goto IL_6B;
				}
			}
			while ((92155251U ^ num) == 0U);
			num = 554632598U * num;
			bool flag = object_1 is ValueType;
			num ^= 1389618688U;
			if (!flag)
			{
				num = (1691431997U & num);
				if (1235694371U >> (int)num != 0U)
				{
					goto IL_7C;
				}
				return;
			}
			IL_6B:
			num = (1127376398U & num);
			this.object_0 = object_1;
			return;
			IL_7C:
			throw new ArgumentException();
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0001EFD4 File Offset: 0x0001D1D4
		public override Type vmethod_6()
		{
			return typeof(ValueType);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x0001EFEC File Offset: 0x0001D1EC
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class16(this.object_0);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x0001F004 File Offset: 0x0001D204
		public override object vmethod_1()
		{
			return this.object_0;
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0001F018 File Offset: 0x0001D218
		public override void vmethod_2(object object_1)
		{
			uint num = 1671303578U;
			if (object_1 == null)
			{
				goto IL_19;
			}
			IL_09:
			bool flag = object_1 is ValueType;
			num += 0U;
			if (!flag)
			{
				num -= 1083574514U;
				throw new ArgumentException();
			}
			IL_19:
			num = 1655925305U / num;
			this.object_0 = object_1;
			if (num + 932851783U != 0U)
			{
				return;
			}
			goto IL_09;
		}

		// Token: 0x04000188 RID: 392
		private object object_0;
	}

	// Token: 0x020001BD RID: 445
	private sealed class Class17 : GClass18.Class8
	{
		// Token: 0x0600078D RID: 1933 RVA: 0x0001F068 File Offset: 0x0001D268
		public Class17(Array array_1)
		{
			this.array_0 = array_1;
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0001F084 File Offset: 0x0001D284
		public override Type vmethod_6()
		{
			return typeof(Array);
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0001F09C File Offset: 0x0001D29C
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class17(this.array_0);
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0001F0B4 File Offset: 0x0001D2B4
		public override object vmethod_1()
		{
			return this.array_0;
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0001F0C8 File Offset: 0x0001D2C8
		public override void vmethod_2(object object_0)
		{
			uint num = 919093528U;
			do
			{
				this.array_0 = (Array)object_0;
			}
			while (num - 1253125962U == 0U);
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0001F0F0 File Offset: 0x0001D2F0
		public override bool vmethod_8()
		{
			return this.array_0 != null;
		}

		// Token: 0x04000189 RID: 393
		private Array array_0;
	}

	// Token: 0x020001BE RID: 446
	private abstract class Class18 : GClass18.Class8
	{
		// Token: 0x06000793 RID: 1939 RVA: 0x0001E314 File Offset: 0x0001C514
		public override bool vmethod_3()
		{
			return true;
		}
	}

	// Token: 0x020001BF RID: 447
	private sealed class Class19 : GClass18.Class18
	{
		// Token: 0x06000795 RID: 1941 RVA: 0x0001F11C File Offset: 0x0001D31C
		public Class19(GClass18.Class7 class7_1)
		{
			uint num = 36208640U;
			do
			{
				num = (1618360340U & num);
				num /= 553015851U;
				this.class7_0 = class7_1;
			}
			while (22418372U * num != 0U);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0001F15C File Offset: 0x0001D35C
		public override Type vmethod_6()
		{
			return this.class7_0.vmethod_6();
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0001F174 File Offset: 0x0001D374
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class19(this.class7_0);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0001F18C File Offset: 0x0001D38C
		public override object vmethod_1()
		{
			return this.class7_0.vmethod_1();
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0001F1A4 File Offset: 0x0001D3A4
		public override void vmethod_2(object object_0)
		{
			this.class7_0.vmethod_2(object_0);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0001F1C0 File Offset: 0x0001D3C0
		public override bool vmethod_8()
		{
			return this.class7_0 != null;
		}

		// Token: 0x0400018A RID: 394
		private GClass18.Class7 class7_0;
	}

	// Token: 0x020001C0 RID: 448
	private sealed class Class20 : GClass18.Class18
	{
		// Token: 0x0600079B RID: 1947 RVA: 0x0001F1D8 File Offset: 0x0001D3D8
		public Class20(GClass18.Class7 class7_2, GClass18.Class7 class7_3)
		{
			this.class7_0 = class7_2;
			this.class7_1 = class7_3;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0001F1FC File Offset: 0x0001D3FC
		public override Type vmethod_6()
		{
			return this.class7_0.vmethod_6();
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0001F214 File Offset: 0x0001D414
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class20(this.class7_0, this.class7_1);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0001F234 File Offset: 0x0001D434
		public override object vmethod_1()
		{
			return this.class7_0.vmethod_1();
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0001F24C File Offset: 0x0001D44C
		public override void vmethod_2(object object_0)
		{
			this.class7_0.vmethod_2(object_0);
			uint num = 0U;
			do
			{
				GClass18.Class7 @class = this.class7_1;
				GClass18.Class7 class2 = this.class7_0;
				num *= 507341287U;
				@class.vmethod_2(class2.vmethod_1());
			}
			while (num >= 92887324U);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0001F294 File Offset: 0x0001D494
		public override bool vmethod_8()
		{
			return this.class7_0 != null;
		}

		// Token: 0x0400018B RID: 395
		private GClass18.Class7 class7_0;

		// Token: 0x0400018C RID: 396
		private GClass18.Class7 class7_1;
	}

	// Token: 0x020001C1 RID: 449
	private sealed class Class21 : GClass18.Class18
	{
		// Token: 0x060007A1 RID: 1953 RVA: 0x0001F2AC File Offset: 0x0001D4AC
		public Class21(FieldInfo fieldInfo_1, object object_1)
		{
			uint num = 483741155U;
			do
			{
				num = 999904334U * num;
				this.fieldInfo_0 = fieldInfo_1;
				num ^= 262079037U;
				if (num % 1358647563U == 0U)
				{
					break;
				}
				num -= 1651650868U;
				num += 1682132526U;
				this.object_0 = object_1;
			}
			while (461989051U * num == 0U);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0001F308 File Offset: 0x0001D508
		public override Type vmethod_6()
		{
			return this.fieldInfo_0.FieldType;
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0001F320 File Offset: 0x0001D520
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class21(this.fieldInfo_0, this.object_0);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0001F340 File Offset: 0x0001D540
		public override object vmethod_1()
		{
			return this.fieldInfo_0.GetValue(this.object_0);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0001F360 File Offset: 0x0001D560
		public override void vmethod_2(object object_1)
		{
			uint num = 995314219U;
			do
			{
				num = 1022702610U + num;
				FieldInfo fieldInfo = this.fieldInfo_0;
				num = (1575759362U ^ num);
				num = 1220310762U - num;
				fieldInfo.SetValue(this.object_0, object_1);
			}
			while (1497057194U % num == 0U);
		}

		// Token: 0x0400018D RID: 397
		private FieldInfo fieldInfo_0;

		// Token: 0x0400018E RID: 398
		private object object_0;
	}

	// Token: 0x020001C2 RID: 450
	private sealed class Class22 : GClass18.Class18
	{
		// Token: 0x060007A6 RID: 1958 RVA: 0x0001F3A8 File Offset: 0x0001D5A8
		public Class22(Array array_1, int int_1)
		{
			this.array_0 = array_1;
			this.int_0 = int_1;
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0001F3CC File Offset: 0x0001D5CC
		public override Type vmethod_6()
		{
			return this.array_0.GetType().GetElementType();
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0001F3EC File Offset: 0x0001D5EC
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class22(this.array_0, this.int_0);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0001F40C File Offset: 0x0001D60C
		public override object vmethod_1()
		{
			return this.array_0.GetValue(this.int_0);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0001F42C File Offset: 0x0001D62C
		public override void vmethod_2(object object_0)
		{
			this.array_0.SetValue(object_0, this.int_0);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0001F44C File Offset: 0x0001D64C
		public override UIntPtr vmethod_14()
		{
			DynamicMethod dynamicMethod = new DynamicMethod("", typeof(UIntPtr), new Type[]
			{
				this.array_0.GetType(),
				typeof(int)
			}, typeof(GClass18).Module, true);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			ilgenerator.Emit(OpCodes.Ldarg, 0);
			ilgenerator.Emit(OpCodes.Ldarg, 1);
			ilgenerator.Emit(OpCodes.Ldelema, this.array_0.GetType().GetElementType());
			ilgenerator.Emit(OpCodes.Conv_U);
			ilgenerator.Emit(OpCodes.Ret);
			return (UIntPtr)dynamicMethod.Invoke(null, new object[]
			{
				this.array_0,
				this.int_0
			});
		}

		// Token: 0x0400018F RID: 399
		private Array array_0;

		// Token: 0x04000190 RID: 400
		private int int_0;
	}

	// Token: 0x020001C3 RID: 451
	private sealed class Class24 : GClass18.Class8
	{
		// Token: 0x060007AC RID: 1964 RVA: 0x0001F514 File Offset: 0x0001D714
		public Class24(MethodBase methodBase_1)
		{
			uint num = 2017012525U;
			do
			{
				base..ctor();
				num = 1806982285U >> (int)num;
				if ((num ^ 410022183U) == 0U)
				{
					break;
				}
				num *= 3615658U;
				this.methodBase_0 = methodBase_1;
			}
			while (1530143585U == num);
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0001F560 File Offset: 0x0001D760
		public override Type vmethod_6()
		{
			return typeof(MethodBase);
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0001F578 File Offset: 0x0001D778
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class24(this.methodBase_0);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0001F590 File Offset: 0x0001D790
		public override object vmethod_1()
		{
			return this.methodBase_0;
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0001F5A4 File Offset: 0x0001D7A4
		public override void vmethod_2(object object_0)
		{
			uint num = 1505040140U;
			do
			{
				num = (1528915742U | num);
				num = 1390026161U % num;
				this.methodBase_0 = (MethodBase)object_0;
			}
			while (num << 4 == 0U);
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0001F5DC File Offset: 0x0001D7DC
		public override bool vmethod_8()
		{
			return this.methodBase_0 != null;
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x0001F5F4 File Offset: 0x0001D7F4
		public override IntPtr B6AA4A8E()
		{
			uint num = 663235660U;
			RuntimeMethodHandle runtimeMethodHandle;
			do
			{
				MethodBase methodBase = this.methodBase_0;
				num = 1023887435U + num;
				RuntimeMethodHandle methodHandle = methodBase.MethodHandle;
				num = 1619205410U >> (int)num;
				runtimeMethodHandle = methodHandle;
				num *= 664428604U;
			}
			while (1285227309U == num);
			num += 1055217593U;
			return runtimeMethodHandle.GetFunctionPointer();
		}

		// Token: 0x04000191 RID: 401
		private MethodBase methodBase_0;
	}

	// Token: 0x020001C4 RID: 452
	private sealed class Class25 : GClass18.Class8
	{
		// Token: 0x060007B3 RID: 1971 RVA: 0x0001F648 File Offset: 0x0001D848
		public Class25(IntPtr intptr_1)
		{
			uint num = 601104418U;
			do
			{
				base..ctor();
				num -= 1566181446U;
				num >>= 11;
				this.intptr_0 = intptr_1;
			}
			while (num >= 1211118834U);
			num = 1190078470U << (int)num;
			IntPtr intptr_2 = this.intptr_0;
			num |= 1503092898U;
			this.class7_0 = GClass18.Class25.smethod_0(intptr_2);
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0001F6A8 File Offset: 0x0001D8A8
		private static GClass18.Class7 smethod_0(IntPtr intptr_1)
		{
			uint num = 1133981088U;
			do
			{
				uint size = (uint)IntPtr.Size;
				num = 1713832588U << (int)num;
				if (size != num - 1713832584U)
				{
					goto IL_4D;
				}
				num = 1870163429U - num;
			}
			while (num == 613097946U);
			int int_ = intptr_1.ToInt32();
			num = (1690790061U ^ num);
			return new GClass18.Class9(int_);
			IL_4D:
			num >>= 14;
			long long_ = intptr_1.ToInt64();
			num = 1553663128U + num;
			return new GClass18.Class10(long_);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0001F720 File Offset: 0x0001D920
		public override Type vmethod_6()
		{
			return typeof(IntPtr);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0001F738 File Offset: 0x0001D938
		public override TypeCode vmethod_7()
		{
			return this.class7_0.vmethod_7();
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0001F750 File Offset: 0x0001D950
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class25(this.intptr_0);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0001F768 File Offset: 0x0001D968
		public override object vmethod_1()
		{
			return this.intptr_0;
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x0001F780 File Offset: 0x0001D980
		public override void vmethod_2(object object_0)
		{
			this.intptr_0 = (IntPtr)object_0;
			this.class7_0 = GClass18.Class25.smethod_0(this.intptr_0);
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x0001F7AC File Offset: 0x0001D9AC
		public override bool vmethod_8()
		{
			return this.intptr_0 != IntPtr.Zero;
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0001F7CC File Offset: 0x0001D9CC
		public override sbyte vmethod_9()
		{
			return this.class7_0.vmethod_9();
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0001F7E4 File Offset: 0x0001D9E4
		public override short E8F387ED()
		{
			return this.class7_0.E8F387ED();
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x0001F7FC File Offset: 0x0001D9FC
		public override int EC4893C4()
		{
			return this.class7_0.EC4893C4();
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x0001F814 File Offset: 0x0001DA14
		public override long DB9EABF5()
		{
			return this.class7_0.DB9EABF5();
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x0001F82C File Offset: 0x0001DA2C
		public override byte vmethod_10()
		{
			return this.class7_0.vmethod_10();
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x0001F844 File Offset: 0x0001DA44
		public override ushort D3EC5557()
		{
			return this.class7_0.D3EC5557();
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0001F85C File Offset: 0x0001DA5C
		public override uint vmethod_11()
		{
			return this.class7_0.vmethod_11();
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x0001F874 File Offset: 0x0001DA74
		public override ulong vmethod_12()
		{
			return this.class7_0.vmethod_12();
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0001F88C File Offset: 0x0001DA8C
		public override float B4B75C1D()
		{
			return this.class7_0.B4B75C1D();
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x0001F8A4 File Offset: 0x0001DAA4
		public override double vmethod_13()
		{
			return this.class7_0.vmethod_13();
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0001F8BC File Offset: 0x0001DABC
		public override IntPtr B6AA4A8E()
		{
			return this.intptr_0;
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x0001F8D0 File Offset: 0x0001DAD0
		public override UIntPtr vmethod_14()
		{
			return this.class7_0.vmethod_14();
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x0001F8E8 File Offset: 0x0001DAE8
		public unsafe override void* vmethod_15()
		{
			return this.intptr_0.ToPointer();
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x0001F900 File Offset: 0x0001DB00
		public override object CB7019CC(Type type_0, bool bool_0)
		{
			return this.class7_0.CB7019CC(type_0, bool_0);
		}

		// Token: 0x04000192 RID: 402
		private IntPtr intptr_0;

		// Token: 0x04000193 RID: 403
		private GClass18.Class7 class7_0;
	}

	// Token: 0x020001C5 RID: 453
	private sealed class Class26 : GClass18.Class8
	{
		// Token: 0x060007C9 RID: 1993 RVA: 0x0001F91C File Offset: 0x0001DB1C
		public Class26(UIntPtr uintptr_1)
		{
			this.uintptr_0 = uintptr_1;
			this.class7_0 = GClass18.Class26.smethod_0(this.uintptr_0);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x0001F948 File Offset: 0x0001DB48
		private static GClass18.Class7 smethod_0(UIntPtr uintptr_1)
		{
			uint num = 1913788886U;
			for (;;)
			{
				uint size = (uint)IntPtr.Size;
				num = (343503015U ^ num);
				if (size == num + 2576651923U)
				{
					break;
				}
				if (38763652U < num)
				{
					goto IL_3B;
				}
			}
			int int_ = (int)uintptr_1.ToUInt32();
			num = 1452417012U % num;
			return new GClass18.Class9(int_);
			IL_3B:
			long long_ = (long)uintptr_1.ToUInt64();
			num ^= 718042933U;
			return new GClass18.Class10(long_);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0001F9A4 File Offset: 0x0001DBA4
		public override Type vmethod_6()
		{
			return typeof(UIntPtr);
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x0001F9BC File Offset: 0x0001DBBC
		public override TypeCode vmethod_7()
		{
			return this.class7_0.vmethod_7();
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0001F9D4 File Offset: 0x0001DBD4
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class26(this.uintptr_0);
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x0001F9EC File Offset: 0x0001DBEC
		public override object vmethod_1()
		{
			return this.uintptr_0;
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0001FA04 File Offset: 0x0001DC04
		public override void vmethod_2(object object_0)
		{
			this.uintptr_0 = (UIntPtr)object_0;
			uint num = 768692797U;
			do
			{
				num = 1733038091U - num;
				num = 1728842915U + num;
				this.class7_0 = GClass18.Class26.smethod_0(this.uintptr_0);
			}
			while ((num ^ 537854084U) == 0U);
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0001FA5C File Offset: 0x0001DC5C
		public override bool vmethod_8()
		{
			return this.uintptr_0 != UIntPtr.Zero;
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x0001FA7C File Offset: 0x0001DC7C
		public override sbyte vmethod_9()
		{
			return this.class7_0.vmethod_9();
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x0001FA94 File Offset: 0x0001DC94
		public override short E8F387ED()
		{
			return this.class7_0.E8F387ED();
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x0001FAAC File Offset: 0x0001DCAC
		public override int EC4893C4()
		{
			return this.class7_0.EC4893C4();
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x0001FAC4 File Offset: 0x0001DCC4
		public override long DB9EABF5()
		{
			return this.class7_0.DB9EABF5();
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x0001FADC File Offset: 0x0001DCDC
		public override byte vmethod_10()
		{
			return this.class7_0.vmethod_10();
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x0001FAF4 File Offset: 0x0001DCF4
		public override ushort D3EC5557()
		{
			return this.class7_0.D3EC5557();
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x0001FB0C File Offset: 0x0001DD0C
		public override uint vmethod_11()
		{
			return this.class7_0.vmethod_11();
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x0001FB24 File Offset: 0x0001DD24
		public override ulong vmethod_12()
		{
			return this.class7_0.vmethod_12();
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x0001FB3C File Offset: 0x0001DD3C
		public override float B4B75C1D()
		{
			return this.class7_0.B4B75C1D();
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x0001FB54 File Offset: 0x0001DD54
		public override double vmethod_13()
		{
			return this.class7_0.vmethod_13();
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x0001FB6C File Offset: 0x0001DD6C
		public override IntPtr B6AA4A8E()
		{
			return this.class7_0.B6AA4A8E();
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x0001FB84 File Offset: 0x0001DD84
		public override UIntPtr vmethod_14()
		{
			return this.uintptr_0;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x0001FB98 File Offset: 0x0001DD98
		public unsafe override void* vmethod_15()
		{
			return this.uintptr_0.ToPointer();
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
		public override object CB7019CC(Type type_0, bool bool_0)
		{
			return this.class7_0.CB7019CC(type_0, bool_0);
		}

		// Token: 0x04000194 RID: 404
		private UIntPtr uintptr_0;

		// Token: 0x04000195 RID: 405
		private GClass18.Class7 class7_0;
	}

	// Token: 0x020001C6 RID: 454
	private sealed class Class27 : GClass18.Class8
	{
		// Token: 0x060007DF RID: 2015 RVA: 0x0001FBCC File Offset: 0x0001DDCC
		public Class27(Enum enum_1)
		{
			for (;;)
			{
				IL_00:
				base..ctor();
				uint num = 110513253U;
				for (;;)
				{
					num = 1254910833U * num;
					if (enum_1 == null)
					{
						break;
					}
					num = 566718210U << (int)num;
					if (num <= 1199376298U)
					{
						goto IL_00;
					}
					num = 624370382U - num;
					this.enum_0 = enum_1;
					num >>= 21;
					num |= 89326702U;
					GClass18.Class7 @class = GClass18.Class27.smethod_0(this.enum_0);
					num = 61698362U << (int)num;
					this.class7_0 = @class;
					if (659897575U != num)
					{
						return;
					}
				}
				if (198199714U - num != 0U)
				{
					goto Block_3;
				}
			}
			return;
			Block_3:
			throw new ArgumentException();
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0001FC60 File Offset: 0x0001DE60
		private static GClass18.Class7 smethod_0(Enum enum_1)
		{
			uint num2;
			for (;;)
			{
				TypeCode typeCode = enum_1.GetTypeCode();
				int num = typeCode - TypeCode.SByte;
				num2 = 2641538890U;
				switch (num)
				{
				case 0:
				case 2:
				case 4:
					goto IL_52;
				case 1:
				case 3:
				case 5:
					goto IL_76;
				case 6:
					goto IL_92;
				case 7:
					goto IL_B6;
				default:
					if (num2 > 1206730084U)
					{
						goto IL_43;
					}
					break;
				}
			}
			IL_43:
			while ((991036760U ^ num2) == 0U)
			{
			}
			throw new InvalidOperationException();
			IL_52:
			num2 |= 2064455191U;
			num2 %= 958691159U;
			int int_ = Convert.ToInt32(enum_1);
			num2 &= 1184068880U;
			return new GClass18.Class9(int_);
			IL_76:
			num2 += 1212813859U;
			int int_2 = (int)Convert.ToUInt32(enum_1);
			num2 = 1435530065U % num2;
			return new GClass18.Class9(int_2);
			IL_92:
			num2 = 249891866U - num2;
			num2 = 246635012U * num2;
			long long_ = Convert.ToInt64(enum_1);
			num2 *= 511514541U;
			return new GClass18.Class10(long_);
			IL_B6:
			num2 &= 1733455764U;
			long long_2 = (long)Convert.ToUInt64(enum_1);
			num2 &= 1423512893U;
			return new GClass18.Class10(long_2);
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0001FD40 File Offset: 0x0001DF40
		public override GClass18.Class7 vmethod_5()
		{
			return this.class7_0.vmethod_5();
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0001FD58 File Offset: 0x0001DF58
		public override Type vmethod_6()
		{
			return this.enum_0.GetType();
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0001FD70 File Offset: 0x0001DF70
		public override TypeCode vmethod_7()
		{
			return this.class7_0.vmethod_7();
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0001FD88 File Offset: 0x0001DF88
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class27(this.enum_0);
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0001FDA0 File Offset: 0x0001DFA0
		public override object vmethod_1()
		{
			return this.enum_0;
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0001FDB4 File Offset: 0x0001DFB4
		public override void vmethod_2(object object_0)
		{
			if (object_0 == null)
			{
				throw new ArgumentException();
			}
			this.enum_0 = (Enum)object_0;
			this.class7_0 = GClass18.Class27.smethod_0(this.enum_0);
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0001FDE8 File Offset: 0x0001DFE8
		public override byte vmethod_10()
		{
			return this.class7_0.vmethod_10();
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0001FE00 File Offset: 0x0001E000
		public override sbyte vmethod_9()
		{
			return this.class7_0.vmethod_9();
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0001FE18 File Offset: 0x0001E018
		public override short E8F387ED()
		{
			return this.class7_0.E8F387ED();
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0001FE30 File Offset: 0x0001E030
		public override ushort D3EC5557()
		{
			return this.class7_0.D3EC5557();
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0001FE48 File Offset: 0x0001E048
		public override int EC4893C4()
		{
			return this.class7_0.EC4893C4();
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0001FE60 File Offset: 0x0001E060
		public override uint vmethod_11()
		{
			return this.class7_0.vmethod_11();
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0001FE78 File Offset: 0x0001E078
		public override long DB9EABF5()
		{
			return this.class7_0.DB9EABF5();
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0001FE90 File Offset: 0x0001E090
		public override ulong vmethod_12()
		{
			return this.class7_0.vmethod_12();
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x0001FEA8 File Offset: 0x0001E0A8
		public override float B4B75C1D()
		{
			return this.class7_0.B4B75C1D();
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0001FEC0 File Offset: 0x0001E0C0
		public override double vmethod_13()
		{
			return this.class7_0.vmethod_13();
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x0001FED8 File Offset: 0x0001E0D8
		public override IntPtr B6AA4A8E()
		{
			uint num2;
			do
			{
				int size = IntPtr.Size;
				int num = 4;
				num2 = 1443256130U;
				if (size == num)
				{
					goto IL_20;
				}
				num2 %= 123012346U;
			}
			while (num2 >= 1852711357U);
			goto IL_42;
			IL_20:
			long value;
			if ((1156334779U ^ num2) != 0U)
			{
				long num3 = (long)this.EC4893C4();
				num2 >>= 29;
				value = num3;
				num2 += 1058145574U;
				goto IL_50;
			}
			IL_42:
			num2 ^= 978134444U;
			value = this.DB9EABF5();
			IL_50:
			num2 = 10178077U - num2;
			return new IntPtr(value);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0001FF44 File Offset: 0x0001E144
		public override UIntPtr vmethod_14()
		{
			int size = IntPtr.Size;
			int num = 4;
			uint num2 = 89575176U;
			ulong value;
			if (size != num)
			{
				num2 += 994275778U;
				value = this.vmethod_12();
			}
			else
			{
				num2 += 1771795684U;
				value = (ulong)this.vmethod_11();
				num2 ^= 778568486U;
			}
			return new UIntPtr(value);
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0001FF98 File Offset: 0x0001E198
		public override object CB7019CC(Type type_0, bool bool_0)
		{
			return this.class7_0.CB7019CC(type_0, bool_0);
		}

		// Token: 0x04000196 RID: 406
		private Enum enum_0;

		// Token: 0x04000197 RID: 407
		private GClass18.Class7 class7_0;
	}

	// Token: 0x020001C7 RID: 455
	private sealed class Class23 : GClass18.Class18
	{
		// Token: 0x060007F4 RID: 2036 RVA: 0x0001FFB4 File Offset: 0x0001E1B4
		public Class23(IntPtr intptr_1, Type type_1)
		{
			uint num = 188494282U;
			base..ctor();
			do
			{
				this.intptr_0 = intptr_1;
			}
			while ((num ^ 1128952114U) == 0U);
			this.type_0 = type_1;
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x0001FFE4 File Offset: 0x0001E1E4
		public override Type vmethod_6()
		{
			return typeof(Pointer);
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x0001C830 File Offset: 0x0001AA30
		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x0001FFFC File Offset: 0x0001E1FC
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class23(this.intptr_0, this.type_0);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x0002001C File Offset: 0x0001E21C
		public override object vmethod_1()
		{
			Type type = this.type_0;
			uint num = 1848665968U;
			if (!type.IsValueType)
			{
				num = (1308694636U & num);
				if (1620016951U >= num)
				{
					throw new InvalidOperationException();
				}
			}
			return Marshal.PtrToStructure(this.intptr_0, this.type_0);
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x0002006C File Offset: 0x0001E26C
		public override void vmethod_2(object object_0)
		{
			uint num = 1729182493U;
			for (;;)
			{
				if (object_0 == null)
				{
					num = (1896819247U | num);
					if (num >= 826359774U)
					{
						goto IL_3F7;
					}
				}
				else
				{
					for (;;)
					{
						if (num + 1696290420U != 0U)
						{
							num = (800272050U & num);
							Type type = this.type_0;
							num -= 1298100099U;
							if (type.IsValueType)
							{
								goto Block_4;
							}
						}
						num -= 1585274050U;
						if (299660948U >> (int)num != 0U)
						{
							num /= 2103452838U;
							TypeCode typeCode = Type.GetTypeCode(object_0.GetType());
							num <<= 13;
							TypeCode typeCode2 = typeCode;
							uint num2 = (uint)typeCode2;
							num %= 1075646200U;
							uint num3 = num2 - (num ^ 4U);
							num |= 1096971873U;
							switch (num3)
							{
							case 0:
								goto IL_D9;
							case 1:
								goto IL_F1;
							case 2:
								num = 1427388970U / num;
								if ((num & 783089963U) != 0U)
								{
									goto Block_3;
								}
								continue;
							case 3:
								goto IL_24F;
							case 4:
								goto IL_289;
							case 5:
								goto IL_102;
							case 6:
								goto IL_2EC;
							case 7:
								goto IL_11A;
							case 8:
								goto IL_37A;
							case 9:
								goto IL_3AC;
							case 10:
								goto IL_128;
							}
							goto Block_2;
						}
					}
					IL_D9:
					num = (747666307U ^ num);
					if (num >= 409672681U)
					{
						goto Block_6;
					}
					continue;
					IL_F1:
					if (num << 11 != 0U)
					{
						goto Block_7;
					}
					continue;
					IL_102:
					num += 443948410U;
					if (num >= 355291098U)
					{
						goto Block_8;
					}
					continue;
					IL_11A:
					if ((772696930U ^ num) != 0U)
					{
						goto Block_9;
					}
					continue;
					IL_128:
					if ((351156244U & num) == 0U)
					{
						goto IL_3F7;
					}
					num ^= 1405120934U;
					IntPtr ptr = this.intptr_0;
					double value = Convert.ToDouble(object_0);
					num = (2043550823U & num);
					byte[] bytes = BitConverter.GetBytes(value);
					int startIndex = (int)(num ^ 276956231U);
					num <<= 25;
					long val = BitConverter.ToInt64(bytes, startIndex);
					num += 723929870U;
					Marshal.WriteInt64(ptr, val);
					if ((1182022524U ^ num) != 0U)
					{
						return;
					}
				}
			}
			Block_2:
			if (num >> 31 == 0U)
			{
				throw new ArgumentException();
			}
			goto IL_3F7;
			Block_3:
			num ^= 51389746U;
			IntPtr ptr2 = this.intptr_0;
			num /= 797452561U;
			byte val2 = Convert.ToByte(object_0);
			num |= 464929254U;
			Marshal.WriteByte(ptr2, val2);
			return;
			Block_4:
			num *= 624577488U;
			if ((858925385U ^ num) != 0U)
			{
				goto IL_325;
			}
			goto IL_3F7;
			Block_6:
			num <<= 3;
			IntPtr ptr3 = this.intptr_0;
			char val3 = Convert.ToChar(object_0);
			num /= 745480997U;
			Marshal.WriteInt16(ptr3, val3);
			return;
			Block_7:
			num = 396652251U << (int)num;
			IntPtr ptr4 = this.intptr_0;
			num = (1751385938U | num);
			byte b = (byte)Convert.ToSByte(object_0);
			num += 311821026U;
			byte val4 = b;
			num -= 895616501U;
			Marshal.WriteByte(ptr4, val4);
			return;
			Block_8:
			Marshal.WriteInt32(this.intptr_0, Convert.ToInt32(object_0));
			return;
			Block_9:
			num >>= 26;
			IntPtr ptr5 = this.intptr_0;
			num <<= 28;
			Marshal.WriteInt64(ptr5, Convert.ToInt64(object_0));
			return;
			IL_24F:
			num |= 1508471036U;
			num = 509098720U % num;
			IntPtr ptr6 = this.intptr_0;
			num <<= 31;
			num = 514423510U + num;
			short val5 = Convert.ToInt16(object_0);
			num = (2060804982U & num);
			Marshal.WriteInt16(ptr6, val5);
			return;
			IL_289:
			num = 637738760U - num;
			num = 1916691783U + num;
			IntPtr ptr7 = this.intptr_0;
			num = (633608502U & num);
			num = 1827235424U * num;
			short num4 = (short)Convert.ToUInt16(object_0);
			num |= 7414513U;
			short val6 = num4;
			num = 1108900412U << (int)num;
			Marshal.WriteInt16(ptr7, val6);
			if (369764168U <= num)
			{
				return;
			}
			goto IL_325;
			IL_2EC:
			num *= 1874070346U;
			if (1063147114 << (int)num != 0)
			{
				IntPtr ptr8 = this.intptr_0;
				num /= 348850517U;
				int val7 = (int)Convert.ToUInt32(object_0);
				num >>= 20;
				Marshal.WriteInt32(ptr8, val7);
				return;
			}
			IL_325:
			num = 1122507488U >> (int)num;
			num ^= 681013893U;
			IntPtr ptr9 = this.intptr_0;
			bool fDeleteOld = (num ^ 680996973U) != 0U;
			num += 1178883025U;
			Marshal.StructureToPtr(object_0, ptr9, fDeleteOld);
			return;
			IL_37A:
			num = (591416267U & num);
			IntPtr ptr10 = this.intptr_0;
			num = 1947673632U >> (int)num;
			Marshal.WriteInt64(ptr10, (long)Convert.ToUInt64(object_0));
			if ((494546589U ^ num) != 0U)
			{
				return;
			}
			return;
			IL_3AC:
			num /= 1277509477U;
			num &= 491811512U;
			IntPtr ptr11 = this.intptr_0;
			num = (673202759U & num);
			float value2 = Convert.ToSingle(object_0);
			num %= 411260029U;
			byte[] bytes2 = BitConverter.GetBytes(value2);
			int startIndex2 = (int)(num - 0U);
			num >>= 31;
			Marshal.WriteInt32(ptr11, BitConverter.ToInt32(bytes2, startIndex2));
			return;
			IL_3F7:
			throw new ArgumentException();
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00020478 File Offset: 0x0001E678
		public override sbyte vmethod_9()
		{
			return (sbyte)Marshal.ReadByte(this.intptr_0);
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00020494 File Offset: 0x0001E694
		public override short E8F387ED()
		{
			return Marshal.ReadInt16(this.intptr_0);
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x000204AC File Offset: 0x0001E6AC
		public override int EC4893C4()
		{
			return Marshal.ReadInt32(this.intptr_0);
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x000204C4 File Offset: 0x0001E6C4
		public override long DB9EABF5()
		{
			return Marshal.ReadInt64(this.intptr_0);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x000204DC File Offset: 0x0001E6DC
		public override char F22CF44A()
		{
			return (char)Marshal.ReadInt16(this.intptr_0);
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x000204F8 File Offset: 0x0001E6F8
		public override byte vmethod_10()
		{
			return Marshal.ReadByte(this.intptr_0);
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x000204DC File Offset: 0x0001E6DC
		public override ushort D3EC5557()
		{
			return (ushort)Marshal.ReadInt16(this.intptr_0);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x000204AC File Offset: 0x0001E6AC
		public override uint vmethod_11()
		{
			return (uint)Marshal.ReadInt32(this.intptr_0);
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x000204C4 File Offset: 0x0001E6C4
		public override ulong vmethod_12()
		{
			return (ulong)Marshal.ReadInt64(this.intptr_0);
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00020510 File Offset: 0x0001E710
		public override float B4B75C1D()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(this.intptr_0)), 0);
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00020534 File Offset: 0x0001E734
		public override double vmethod_13()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(this.intptr_0)), 0);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00020558 File Offset: 0x0001E758
		public override IntPtr B6AA4A8E()
		{
			uint num = 403781775U;
			for (;;)
			{
				int size = IntPtr.Size;
				num = 2022064269U / num;
				uint num2 = num - 1U;
				num = 821123135U >> (int)num;
				if (size != num2)
				{
					if (num / 590234834U == 0U)
					{
						goto IL_4A;
					}
				}
				else
				{
					num = (2046168415U ^ num);
					if (num - 1909672603U != 0U)
					{
						break;
					}
				}
			}
			num /= 155598096U;
			IntPtr ptr = this.intptr_0;
			num = 180300306U << (int)num;
			long num3 = (long)Marshal.ReadInt32(ptr);
			num = 418713089U << (int)num;
			long value = num3;
			num ^= 384556702U;
			goto IL_97;
			IL_4A:
			IntPtr ptr2 = this.intptr_0;
			num = 1829114719U * num;
			value = Marshal.ReadInt64(ptr2);
			IL_97:
			num = 1631022065U << (int)num;
			return new IntPtr(value);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00020610 File Offset: 0x0001E810
		public override UIntPtr vmethod_14()
		{
			int size = IntPtr.Size;
			int num = 4;
			uint num2 = 588647201U;
			ulong value;
			if (size != num && (310129128U & num2) != 0U)
			{
				num2 = 1880052874U * num2;
				value = (ulong)Marshal.ReadInt64(this.intptr_0);
			}
			else
			{
				value = (ulong)Marshal.ReadInt32(this.intptr_0);
				num2 ^= 526506219U;
			}
			num2 = 2061523821U / num2;
			return new UIntPtr(value);
		}

		// Token: 0x04000198 RID: 408
		private IntPtr intptr_0;

		// Token: 0x04000199 RID: 409
		private Type type_0;
	}

	// Token: 0x020001C8 RID: 456
	private sealed class Class36
	{
		// Token: 0x06000807 RID: 2055 RVA: 0x0002066C File Offset: 0x0001E86C
		public Class36(byte byte_1, int int_2, int int_3)
		{
			this.byte_0 = byte_1;
			this.int_0 = int_2;
			this.int_1 = int_3;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00020694 File Offset: 0x0001E894
		public byte method_0()
		{
			return this.byte_0;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x000206A8 File Offset: 0x0001E8A8
		public int method_1()
		{
			return this.int_0;
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x000206BC File Offset: 0x0001E8BC
		public int method_2()
		{
			return this.int_1;
		}

		// Token: 0x0400019A RID: 410
		private byte byte_0;

		// Token: 0x0400019B RID: 411
		private int int_0;

		// Token: 0x0400019C RID: 412
		private int int_1;
	}

	// Token: 0x020001C9 RID: 457
	private sealed class Class37
	{
		// Token: 0x0600080B RID: 2059 RVA: 0x000206D0 File Offset: 0x0001E8D0
		public Class37(int int_2, int int_3)
		{
			uint num = 67169U;
			do
			{
				base..ctor();
				num = (417618972U ^ num);
				if (num % 990193495U != 0U)
				{
					num = 1260595604U * num;
					num = (412891720U ^ num);
					this.int_0 = int_2;
				}
				this.int_1 = int_3;
			}
			while (num == 255133176U);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x0002073C File Offset: 0x0001E93C
		public int method_0()
		{
			return this.int_0;
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00020750 File Offset: 0x0001E950
		public int method_1()
		{
			return this.int_1;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00020764 File Offset: 0x0001E964
		public int method_2(GClass18.Class37 class37_0)
		{
			uint num = 436414637U;
			while (class37_0 != null)
			{
				int value = class37_0.method_0();
				num = 1278546706U << (int)num;
				int num2 = this.int_0.CompareTo(value);
				bool flag = num2 != 0;
				num %= 870331373U;
				if (!flag)
				{
					num /= 1752650015U;
					int num3 = class37_0.method_1();
					num = 1114387311U - num;
					num += 126092277U;
					int num4 = num3.CompareTo(this.int_1);
					num = (1724264351U | num);
					num2 = num4;
					num += 2529911866U;
				}
				if (677667945U + num != 0U)
				{
					return num2;
				}
			}
			return (int)(num - 436414636U);
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x000207F8 File Offset: 0x0001E9F8
		public void method_3(byte byte_0, int int_2, int int_3)
		{
			this.list_0.Add(new GClass18.Class36(byte_0, int_2, int_3));
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00020818 File Offset: 0x0001EA18
		public List<GClass18.Class36> method_4()
		{
			return this.list_0;
		}

		// Token: 0x0400019D RID: 413
		private int int_0;

		// Token: 0x0400019E RID: 414
		private int int_1;

		// Token: 0x0400019F RID: 415
		private List<GClass18.Class36> list_0 = new List<GClass18.Class36>();
	}

	// Token: 0x020001CA RID: 458
	// (Invoke) Token: 0x06000812 RID: 2066
	internal delegate void Delegate359();
}

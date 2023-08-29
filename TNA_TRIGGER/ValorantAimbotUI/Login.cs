using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Events;
using DiscordRPC.Logging;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using KeyAuth;

namespace ValorantAimbotUI
{
	// Token: 0x02000018 RID: 24
	public partial class Login : Form
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x000028A4 File Offset: 0x00000AA4
		public Login()
		{
			Delegate116.smethod_0(this);
			this.InitializeComponent();
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00008254 File Offset: 0x00006454
		private void Initialize1()
		{
			this.client = Delegate213.smethod_0("1140575323205931088");
			Delegate285.smethod_0(this.client, new ConsoleLogger
			{
				Level = LogLevel.Warning
			});
			object object_ = this.client;
			OnReadyEvent onReadyEvent_;
			if ((onReadyEvent_ = Login.<>c.<>9__3_0) == null)
			{
				onReadyEvent_ = (Login.<>c.<>9__3_0 = Delegate58.smethod_0(Login.<>c.<>9, ldftn(<Initialize1>b__3_0)));
			}
			Delegate307.smethod_0(object_, onReadyEvent_);
			object object_2 = this.client;
			OnPresenceUpdateEvent onPresenceUpdateEvent_;
			if ((onPresenceUpdateEvent_ = Login.<>c.<>9__3_1) == null)
			{
				onPresenceUpdateEvent_ = (Login.<>c.<>9__3_1 = Delegate91.smethod_0(Login.<>c.<>9, ldftn(<Initialize1>b__3_1)));
			}
			Delegate22.smethod_0(object_2, onPresenceUpdateEvent_);
			Delegate165.smethod_0(this.client);
			Login.KeyAuthApp.init();
			Login.KeyAuthApp.fetchStats();
			object object_3 = this.client;
			RichPresence richPresence = Delegate339.smethod_0();
			Delegate186.smethod_0(richPresence, Delegate301.smethod_0("BEST IN THE WEST || USERS : ", Login.KeyAuthApp.app_data.numUsers));
			Delegate356.smethod_0(richPresence, "PLAYING [TNA_TRIGGER]");
			Delegate203.smethod_0(richPresence, Delegate81.smethod_0());
			object object_4 = richPresence;
			DiscordRPC.Button[] array = new DiscordRPC.Button[2];
			int num = 0;
			object obj = Delegate55.smethod_0();
			Delegate237.smethod_0(obj, "Discord Server");
			Delegate265.smethod_0(obj, "https://discord.gg/b4W9xYMz3T");
			array[num] = obj;
			int num2 = 1;
			object obj2 = Delegate55.smethod_0();
			Delegate237.smethod_0(obj2, "Youtub Link");
			Delegate265.smethod_0(obj2, "https://www.youtube.com/channel/UC5gYCBtgtxxiOL6uRo-Nuxg");
			array[num2] = obj2;
			Delegate218.smethod_0(object_4, array);
			object object_5 = richPresence;
			object obj3 = Delegate313.smethod_0();
			Delegate316.smethod_0(obj3, "https://2.bp.blogspot.com/-r2_FhVj_9B0/Vx8p2cey-nI/AAAAAAAAAJg/LGG28BehKioEwRannldlaVF28fli7adbgCLcB/s1600/Advanced%2BEditing%2BOf%2BFree%2BGaming%2BLogo.gif");
			Delegate109.smethod_0(obj3, "https://c.tenor.com/WQ67K3ynhV0AAAAd/verified.gif");
			Delegate16.smethod_0(object_5, obj3);
			Delegate270.smethod_0(object_3, richPresence);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000028B2 File Offset: 0x00000AB2
		private void Login_Load(object sender, EventArgs e)
		{
			Delegate235.smethod_0(this.ANTICRACK, true);
			Delegate77.smethod_0(this.ANTICRACK);
			Delegate235.smethod_0(this.AppClose, true);
			Delegate77.smethod_0(this.AppClose);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000272E File Offset: 0x0000092E
		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
			Delegate244.smethod_0(0);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000083AC File Offset: 0x000065AC
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.init();
			Login.KeyAuthApp.license(Delegate170.smethod_0(this.guna2TextBox1));
			if (Login.KeyAuthApp.response.success)
			{
				this.Initialize1();
				if (!Delegate110.smethod_0("C:\\TNA_TRIGGER.txt"))
				{
					try
					{
						StreamWriter streamWriter = new StreamWriter("C:\\TNA_TRIGGER.txt");
						streamWriter.WriteLine(Delegate170.smethod_0(this.guna2TextBox1));
						streamWriter.Close();
					}
					catch
					{
					}
				}
				Delegate342.smethod_0("Login Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Delegate204.smethod_0(new Main());
				Delegate209.smethod_0(this);
				return;
			}
			if (!Login.KeyAuthApp.response.success)
			{
				Delegate342.smethod_0("Login Failed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Delegate244.smethod_0(0);
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00008480 File Offset: 0x00006680
		private void guna2TextBox1_Load(object sender, EventArgs e)
		{
			if (Delegate110.smethod_0("C:\\TNA_TRIGGER.txt"))
			{
				try
				{
					StreamReader streamReader = Delegate168.smethod_0("C:\\TNA_TRIGGER.txt");
					Delegate124.smethod_0(this.guna2TextBox1, streamReader.ReadLine());
					streamReader.Close();
				}
				catch
				{
				}
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000024C5 File Offset: 0x000006C5
		private void guna2TextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000024C5 File Offset: 0x000006C5
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000028E2 File Offset: 0x00000AE2
		private void ANTICRACK_Tick(object sender, EventArgs e)
		{
			object obj = Delegate6.smethod_0();
			Delegate202.smethod_0(obj, true);
			Delegate32.smethod_0(obj, true);
			this.CheckCrack = obj;
			Delegate75.smethod_0(this.CheckCrack, Delegate176.smethod_0(this, ldftn(CheckCrack_DoWork1)));
			Delegate79.smethod_0(this.CheckCrack);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000055EC File Offset: 0x000037EC
		private void CheckCrack_DoWork1(object sender, DoWorkEventArgs e)
		{
			foreach (Process object_ in Delegate245.smethod_0("ida64"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_);
				Delegate167.smethod_0("ShutDown", "/s");
				string text = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text).Write(text);
				if (Delegate110.smethod_0(text))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_2 in Delegate245.smethod_0("dotPeek64"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_2);
				Delegate167.smethod_0("ShutDown", "/s");
				string text2 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text2).Write(text2);
				if (Delegate110.smethod_0(text2))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_3 in Delegate245.smethod_0("ida"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_3);
				Delegate167.smethod_0("ShutDown", "/s");
				string text3 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text3).Write(text3);
				if (Delegate110.smethod_0(text3))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_4 in Delegate245.smethod_0("reclass.net"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_4);
				Delegate167.smethod_0("ShutDown", "/s");
				string text4 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text4).Write(text4);
				if (Delegate110.smethod_0(text4))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_5 in Delegate245.smethod_0("reclass"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_5);
				Delegate167.smethod_0("ShutDown", "/s");
				string text5 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text5).Write(text5);
				if (Delegate110.smethod_0(text5))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_6 in Delegate245.smethod_0("heyrays"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_6);
				Delegate167.smethod_0("ShutDown", "/s");
				string text6 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text6).Write(text6);
				if (Delegate110.smethod_0(text6))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_7 in Delegate245.smethod_0("QMEmulatorService"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_7);
				Delegate167.smethod_0("ShutDown", "/s");
				string text7 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text7).Write(text7);
				if (Delegate110.smethod_0(text7))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_8 in Delegate245.smethod_0("lighthouse"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_8);
				Delegate167.smethod_0("ShutDown", "/s");
				string text8 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text8).Write(text8);
				if (Delegate110.smethod_0(text8))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_9 in Delegate245.smethod_0("cheatengine-x86_64"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_9);
				Delegate167.smethod_0("ShutDown", "/s");
				string text9 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text9).Write(text9);
				if (Delegate110.smethod_0(text9))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_10 in Delegate245.smethod_0("classinformer"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_10);
				Delegate167.smethod_0("ShutDown", "/s");
				string text10 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text10).Write(text10);
				if (Delegate110.smethod_0(text10))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_11 in Delegate245.smethod_0("ida-x86emu"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_11);
				Delegate167.smethod_0("ShutDown", "/s");
				string text11 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text11).Write(text11);
				if (Delegate110.smethod_0(text11))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_12 in Delegate245.smethod_0("cffexplorer"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_12);
				Delegate167.smethod_0("ShutDown", "/s");
				string text12 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text12).Write(text12);
				if (Delegate110.smethod_0(text12))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_13 in Delegate245.smethod_0("winhex"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_13);
				Delegate167.smethod_0("ShutDown", "/s");
				string text13 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text13).Write(text13);
				if (Delegate110.smethod_0(text13))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_14 in Delegate245.smethod_0("hiew"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_14);
				Delegate167.smethod_0("ShutDown", "/s");
				string text14 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text14).Write(text14);
				if (Delegate110.smethod_0(text14))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_15 in Delegate245.smethod_0("fiddler"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_15);
				Delegate167.smethod_0("ShutDown", "/s");
				string text15 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text15).Write(text15);
				if (Delegate110.smethod_0(text15))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_16 in Delegate245.smethod_0("httpdebugger"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_16);
				Delegate167.smethod_0("ShutDown", "/s");
				string text16 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text16).Write(text16);
				if (Delegate110.smethod_0(text16))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_17 in Delegate245.smethod_0("httpdebuggerpro"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_17);
				Delegate167.smethod_0("ShutDown", "/s");
				string text17 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text17).Write(text17);
				if (Delegate110.smethod_0(text17))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_18 in Delegate245.smethod_0("scylla"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_18);
				Delegate167.smethod_0("ShutDown", "/s");
				string text18 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text18).Write(text18);
				if (Delegate110.smethod_0(text18))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_19 in Delegate245.smethod_0("Cheat Engine"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_19);
				Delegate167.smethod_0("ShutDown", "/s");
				string text19 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text19).Write(text19);
				if (Delegate110.smethod_0(text19))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_20 in Delegate245.smethod_0("x64dbg"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_20);
				Delegate167.smethod_0("ShutDown", "/s");
				string text20 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text20).Write(text20);
				if (Delegate110.smethod_0(text20))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_21 in Delegate245.smethod_0("x32dbg"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_21);
				Delegate167.smethod_0("ShutDown", "/s");
				string text21 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text21).Write(text21);
				if (Delegate110.smethod_0(text21))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_22 in Delegate245.smethod_0("Cheat Engine 7.4"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_22);
				Delegate167.smethod_0("ShutDown", "/s");
				string text22 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text22).Write(text22);
				if (Delegate110.smethod_0(text22))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_23 in Delegate245.smethod_0("HxD"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_23);
				Delegate167.smethod_0("ShutDown", "/s");
				string text23 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text23).Write(text23);
				if (Delegate110.smethod_0(text23))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_24 in Delegate245.smethod_0("HxD32"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_24);
				Delegate167.smethod_0("ShutDown", "/s");
				string text24 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text24).Write(text24);
				if (Delegate110.smethod_0(text24))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_25 in Delegate245.smethod_0("dnSpy"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_25);
				Delegate167.smethod_0("ShutDown", "/s");
				string text25 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text25).Write(text25);
				if (Delegate110.smethod_0(text25))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_26 in Delegate245.smethod_0("dnSpy64"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_26);
				Delegate167.smethod_0("ShutDown", "/s");
				string text26 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text26).Write(text26);
				if (Delegate110.smethod_0(text26))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_27 in Delegate245.smethod_0("ExtremeDumper"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_27);
				Delegate167.smethod_0("ShutDown", "/s");
				string text27 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text27).Write(text27);
				if (Delegate110.smethod_0(text27))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_28 in Delegate245.smethod_0("ExtremeDumper-x86"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_28);
				Delegate167.smethod_0("ShutDown", "/s");
				string text28 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text28).Write(text28);
				if (Delegate110.smethod_0(text28))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_29 in Delegate245.smethod_0("die"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_29);
				Delegate167.smethod_0("ShutDown", "/s");
				string text29 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text29).Write(text29);
				if (Delegate110.smethod_0(text29))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_30 in Delegate245.smethod_0("de4dot"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_30);
				Delegate167.smethod_0("ShutDown", "/s");
				string text30 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text30).Write(text30);
				if (Delegate110.smethod_0(text30))
				{
					Delegate244.smethod_0(0);
				}
			}
			foreach (Process object_31 in Delegate245.smethod_0("de4dot-x64"))
			{
				Delegate56.smethod_0();
				Delegate255.smethod_0(object_31);
				Delegate167.smethod_0("ShutDown", "/s");
				string text31 = "C:\\Windows\\System32\\AntiCarck.lic";
				new StreamWriter(text31).Write(text31);
				if (Delegate110.smethod_0(text31))
				{
					Delegate244.smethod_0(0);
				}
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000291F File Offset: 0x00000B1F
		private void AppClose_Tick(object sender, EventArgs e)
		{
			object obj = Delegate6.smethod_0();
			Delegate202.smethod_0(obj, true);
			Delegate32.smethod_0(obj, true);
			this.Closingmm = obj;
			Delegate75.smethod_0(this.Closingmm, Delegate176.smethod_0(this, ldftn(Closingmm_DoWork1)));
			Delegate79.smethod_0(this.Closingmm);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000027EB File Offset: 0x000009EB
		private void Closingmm_DoWork1(object sender, DoWorkEventArgs e)
		{
			if (Delegate110.smethod_0("C:\\Windows\\System32\\AntiCarck.lic"))
			{
				Delegate244.smethod_0(0);
			}
		}

		// Token: 0x040000A1 RID: 161
		public static api KeyAuthApp = new api("TNA_PRIVET_ENGINE", "ABHljFgnm9", "cf750368b03ea96a1c03ff72cb12dfa4005df1652ae7b617b8660f345c091988", "1.0");

		// Token: 0x040000A2 RID: 162
		public DiscordRpcClient client;
	}
}

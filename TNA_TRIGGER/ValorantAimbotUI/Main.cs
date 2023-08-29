using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Aimbot;
using FreeVer;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using JCS;
using ValorantAimbotUI.Properties;
using WindowsInput;

namespace ValorantAimbotUI
{
	// Token: 0x02000011 RID: 17
	public partial class Main : Form
	{
		// Token: 0x060000A4 RID: 164
		[DllImport("user32.dll")]
		private static extern short GetAsyncKeyState(Keys vkey);

		// Token: 0x060000A5 RID: 165 RVA: 0x00004C04 File Offset: 0x00002E04
		public Main()
		{
			Delegate116.smethod_0(this);
			this.frr = new Free(this);
			this.frr.CheckTrail();
			this.InitializeComponent();
			Delegate279.smethod_0(this, Delegate14.smethod_0());
			Delegate124.smethod_0(this, "TNA_TRIGGER");
			Delegate291.smethod_0(this, false);
			this.isTriggerbot = this.GetKey<bool>("isTriggerbot");
			this.isAimbot = this.GetKey<bool>("isAimbot");
			this.speed = this.GetKey<decimal>("speed");
			this.fovX = this.GetKey<int>("fovX");
			this.fovY = this.GetKey<int>("fovY");
			this.color = (Main.ColorType)this.GetKey<int>("color");
			this.mainAimKey = (Main.AimKey)this.GetKey<int>("mainAimKey");
			this.isAimKey = this.GetKey<bool>("isAimKey");
			this.isHold = this.GetKey<bool>("isHold");
			this.monitor = this.GetKey<int>("monitor");
			this.isTriggerbot = this.GetKey<bool>("isTriggerbot");
			this.offsetY = this.GetKey<int>("offsetY");
			this.msShootTime = this.GetKey<int>("msShootTime");
			Main.ColorType colorType = this.color;
			if (colorType != Main.ColorType.Red)
			{
				if (colorType == Main.ColorType.Purple)
				{
					this.PurpleRadio.Checked = true;
				}
			}
			else
			{
				this.RedRadio.Checked = true;
			}
			this.UpdateUI();
			this.IsHoldToggle.Checked = this.isHold;
			this.AimbotBtt.Checked = this.isAimbot;
			this.AimKeyToggle.Checked = this.isAimKey;
			Delegate105.smethod_0(this.Speed, this.speed);
			Delegate105.smethod_0(this.FovXNum, Delegate78.smethod_0(this.fovX));
			Delegate105.smethod_0(this.FovYNum, Delegate78.smethod_0(this.fovY));
			this.TriggerbotBtt.Checked = this.isTriggerbot;
			Delegate105.smethod_0(this.offsetNum, Delegate78.smethod_0(this.offsetY));
			Delegate105.smethod_0(this.FireRateNum, Delegate78.smethod_0(this.msShootTime));
			foreach (string string_ in Delegate250.smethod_0(Delegate340.smethod_0(typeof(Main.AimKey).TypeHandle)))
			{
				Delegate93.smethod_0(this.contextMenuStrip1.Items, string_);
			}
			this.contextMenuStrip1.ItemClicked += Delegate134.smethod_0(this, ldftn(<.ctor>b__5_0));
			Delegate284.smethod_0(this, false);
			base.AutoScaleMode = AutoScaleMode.Font;
			Delegate156.smethod_0(this, Delegate346.smethod_0("Trebuchet MS", 10f, FontStyle.Regular, GraphicsUnit.Point, 204));
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00004EF8 File Offset: 0x000030F8
		private unsafe void MainLogic()
		{
			for (;;)
			{
				if (this.IsHotKeyPressed(this.aimbotHotKey))
				{
					Point point = this.FindColorPosition(this.ConvertIntToColor(16711680), 797, 343, 1183, 625);
					if (!Delegate187.smethod_0(&point))
					{
						Delegate160.smethod_0(Delegate115.smethod_0(this.inputSimulator), Delegate195.smethod_0(&point) - 512, Delegate65.smethod_0(&point) - 384);
						Delegate289.smethod_0(100);
					}
				}
				Delegate289.smethod_0(5);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00004F80 File Offset: 0x00003180
		private Color ConvertIntToColor(int intColor)
		{
			int int_ = intColor >> 16 & 255;
			int int_2 = intColor >> 8 & 255;
			int int_3 = intColor & 255;
			return Delegate232.smethod_0(int_, int_2, int_3);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00004FB0 File Offset: 0x000031B0
		private Point FindColorPosition(Color targetColor, int startX, int startY, int endX, int endY)
		{
			Point empty;
			using (Bitmap bitmap = Delegate125.smethod_0(endX - startX, endY - startY))
			{
				using (Graphics graphics = Delegate35.smethod_0(bitmap))
				{
					Delegate69.smethod_0(graphics, Delegate136.smethod_0(startX, startY), Point.Empty, Delegate121.smethod_0(bitmap));
					for (int i = 0; i < Delegate201.smethod_0(bitmap); i++)
					{
						for (int j = 0; j < Delegate180.smethod_0(bitmap); j++)
						{
							Color color = Delegate107.smethod_0(bitmap, i, j);
							if (this.AreColorsSimilar(targetColor, color, 5))
							{
								return Delegate136.smethod_0(i + startX, j + startY);
							}
						}
					}
					empty = Point.Empty;
				}
			}
			return empty;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000506C File Offset: 0x0000326C
		private unsafe bool AreColorsSimilar(Color color1, Color color2, int maxColorDifference)
		{
			int num = Delegate172.smethod_0((int)(Delegate39.smethod_0(&color1) - Delegate39.smethod_0(&color2)));
			int num2 = Delegate172.smethod_0((int)(Delegate162.smethod_0(&color1) - Delegate162.smethod_0(&color2)));
			int num3 = Delegate172.smethod_0((int)(Delegate263.smethod_0(&color1) - Delegate263.smethod_0(&color2)));
			return num <= maxColorDifference && num2 <= maxColorDifference && num3 <= maxColorDifference;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002496 File Offset: 0x00000696
		private bool IsHotKeyPressed(Keys vkey)
		{
			return Main.GetAsyncKeyState(vkey) < 0;
		}

		// Token: 0x060000AB RID: 171
		[DllImport("gdi32.dll")]
		private static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

		// Token: 0x060000AC RID: 172 RVA: 0x000050C8 File Offset: 0x000032C8
		private float GetScalingFactor()
		{
			IntPtr hdc = Delegate211.smethod_0(Delegate310.smethod_0(IntPtr.Zero));
			int deviceCaps = Main.GetDeviceCaps(hdc, 10);
			return (float)Main.GetDeviceCaps(hdc, 117) / (float)deviceCaps;
		}

		// Token: 0x060000AD RID: 173
		[DllImport("user32.dll")]
		private static extern short GetAsyncKeyState(int vKey);

		// Token: 0x060000AE RID: 174
		[DllImport("USER32.dll")]
		private static extern short GetKeyState(int nVirtKey);

		// Token: 0x060000AF RID: 175 RVA: 0x000050F8 File Offset: 0x000032F8
		private new void Update()
		{
			Main.<Update>d__15 <Update>d__;
			<Update>d__.<>t__builder = Delegate84.smethod_0();
			<Update>d__.<>4__this = this;
			<Update>d__.<>1__state = -1;
			<Update>d__.<>t__builder.Start<Main.<Update>d__15>(ref <Update>d__);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000024A1 File Offset: 0x000006A1
		private int GetColor(Main.ColorType color)
		{
			if (color == Main.ColorType.Red)
			{
				return 11801877;
			}
			if (color != Main.ColorType.Purple)
			{
				return 0;
			}
			return 11480751;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00005130 File Offset: 0x00003330
		private unsafe void UpdateDisplayInformation()
		{
			this.zoom = this.GetScalingFactor();
			Screen object_ = this.CurrentScreen();
			bool flag = Delegate17.smethod_0(object_);
			Rectangle rectangle = Delegate177.smethod_0(object_);
			this.xSize = (int)((float)Delegate345.smethod_0(&rectangle) * (flag ? this.zoom : 1f));
			rectangle = Delegate177.smethod_0(object_);
			this.ySize = (int)((float)Delegate40.smethod_0(&rectangle) * (flag ? this.zoom : 1f));
		}

		// Token: 0x060000B2 RID: 178
		[DllImport("user32.dll")]
		private static extern void mouse_event(int dwFlags, int dx, int dy, uint dwData, UIntPtr dwExtraInfo);

		// Token: 0x060000B3 RID: 179 RVA: 0x000051A8 File Offset: 0x000033A8
		public new unsafe void Move(int xDelta, int yDelta, bool pressDown = false)
		{
			if (pressDown)
			{
				DateTime dateTime = Delegate102.smethod_0();
				TimeSpan timeSpan = Delegate96.smethod_0(&dateTime, this.lastShot);
				if (Delegate92.smethod_0(&timeSpan) < (double)this.msShootTime)
				{
					pressDown = false;
				}
				else
				{
					this.lastShot = Delegate102.smethod_0();
				}
			}
			Main.mouse_event(pressDown ? 6 : 1, xDelta, yDelta, 0U, UIntPtr.Zero);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000024B7 File Offset: 0x000006B7
		public Screen CurrentScreen()
		{
			return Delegate239.smethod_0()[this.monitor];
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00005200 File Offset: 0x00003400
		public unsafe Point[] PixelSearch(Rectangle rect, Color Pixel_Color, int Shade_Variation)
		{
			ArrayList object_ = Delegate89.smethod_0();
			Bitmap bitmap = Delegate227.smethod_0(Delegate345.smethod_0(&rect), Delegate40.smethod_0(&rect), PixelFormat.Format24bppRgb);
			if (this.monitor >= Delegate239.smethod_0().Length)
			{
				this.monitor = 0;
				this.UpdateUI();
			}
			Rectangle rectangle = Delegate177.smethod_0(Delegate239.smethod_0()[this.monitor]);
			int num = Delegate276.smethod_0(&rectangle);
			rectangle = Delegate177.smethod_0(Delegate239.smethod_0()[this.monitor]);
			int num2 = Delegate87.smethod_0(&rectangle);
			using (Graphics graphics = Delegate35.smethod_0(bitmap))
			{
				Delegate169.smethod_0(graphics, Delegate123.smethod_0(&rect) + num, Delegate261.smethod_0(&rect) + num2, 0, 0, Delegate330.smethod_0(&rect), CopyPixelOperation.SourceCopy);
			}
			BitmapData object_2 = Delegate158.smethod_0(bitmap, Delegate304.smethod_0(0, 0, Delegate201.smethod_0(bitmap), Delegate180.smethod_0(bitmap)), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			int[] array = new int[]
			{
				(int)Delegate263.smethod_0(&Pixel_Color),
				(int)Delegate162.smethod_0(&Pixel_Color),
				(int)Delegate39.smethod_0(&Pixel_Color)
			};
			for (int i = 0; i < Delegate319.smethod_0(object_2); i++)
			{
				byte* ptr = (byte*)Delegate229.smethod_0(Delegate315.smethod_0(object_2)) + i * Delegate190.smethod_0(object_2);
				for (int j = 0; j < Delegate309.smethod_0(object_2); j++)
				{
					if (((int)ptr[j * 3] >= array[0] - Shade_Variation & (int)ptr[j * 3] <= array[0] + Shade_Variation) && ((int)ptr[j * 3 + 1] >= array[1] - Shade_Variation & (int)ptr[j * 3 + 1] <= array[1] + Shade_Variation) && ((int)ptr[j * 3 + 2] >= array[2] - Shade_Variation & (int)ptr[j * 3 + 2] <= array[2] + Shade_Variation))
					{
						Delegate80.smethod_0(object_, Delegate136.smethod_0(j + Delegate123.smethod_0(&rect), i + Delegate261.smethod_0(&rect)));
					}
				}
			}
			Delegate292.smethod_0(bitmap);
			return (Point[])Delegate30.smethod_0(object_, Delegate340.smethod_0(typeof(Point).TypeHandle));
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000024C5 File Offset: 0x000006C5
		private void Red_changed(object sender, EventArgs e)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000024C5 File Offset: 0x000006C5
		private void Purple_changed(object sender, EventArgs e)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000024C7 File Offset: 0x000006C7
		private void Speed_changed(object sender, EventArgs e)
		{
			this.speed = Delegate8.smethod_0(this.Speed);
			this.SetKey("speed", this.speed);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000024EB File Offset: 0x000006EB
		private void FovX_changed(object sender, EventArgs e)
		{
			this.fovX = Delegate324.smethod_0(Delegate8.smethod_0(this.FovXNum));
			this.SetKey("fovX", this.fovX);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002514 File Offset: 0x00000714
		private void FovY_changed(object sender, EventArgs e)
		{
			this.fovY = Delegate324.smethod_0(Delegate8.smethod_0(this.FovYNum));
			this.SetKey("fovY", this.fovY);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000024C5 File Offset: 0x000006C5
		private void IsAimbot_changed(object sender, EventArgs e)
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000024C5 File Offset: 0x000006C5
		private void IsTriggerbot_changed(object sender, EventArgs e)
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00005428 File Offset: 0x00003628
		private void Main_load(object sender, EventArgs e)
		{
			Delegate235.smethod_0(this.ANTICRACK, true);
			Delegate77.smethod_0(this.ANTICRACK);
			Delegate235.smethod_0(this.AppClose, true);
			Delegate77.smethod_0(this.AppClose);
			this.mainThread = Delegate53.smethod_0(Delegate219.smethod_0(this, ldftn(<Main_load>b__29_0)));
			Delegate216.smethod_0(this.mainThread);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000253D File Offset: 0x0000073D
		private void SetKey(string key, bool o)
		{
			Delegate296.smethod_0(Settings.Default, key, o);
			Delegate297.smethod_0(Settings.Default);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000255A File Offset: 0x0000075A
		private void SetKey(string key, int o)
		{
			Delegate296.smethod_0(Settings.Default, key, o);
			Delegate297.smethod_0(Settings.Default);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002577 File Offset: 0x00000777
		private void SetKey(string key, decimal o)
		{
			Delegate296.smethod_0(Settings.Default, key, o);
			Delegate297.smethod_0(Settings.Default);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002594 File Offset: 0x00000794
		private T GetKey<T>(string key)
		{
			return (T)((object)Delegate10.smethod_0(Settings.Default, key));
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000025A6 File Offset: 0x000007A6
		protected override void OnHandleDestroyed(EventArgs e)
		{
			Delegate336.smethod_0(this.mainThread);
			Delegate297.smethod_0(Settings.Default);
			Delegate225.smethod_0(this, e);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000025C4 File Offset: 0x000007C4
		private void Start_click(object sender, EventArgs e)
		{
			this.isRunning = !this.isRunning;
			this.UpdateUI();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00005488 File Offset: 0x00003688
		private void UpdateUI()
		{
			Delegate124.smethod_0(this.StartBtt, this.isRunning ? "Stop" : "Start");
			this.UpdateDisplayInformation();
			Delegate124.smethod_0(this.ChangeMonitorBtt, Delegate155.smethod_0(new string[]
			{
				"Monitor [",
				this.monitor.ToString(),
				"] ",
				this.xSize.ToString(),
				"x",
				this.ySize.ToString()
			}));
			Delegate124.smethod_0(this.AimkeyBtt, Delegate74.smethod_0(Delegate340.smethod_0(typeof(Main.AimKey).TypeHandle), this.mainAimKey));
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000025DB File Offset: 0x000007DB
		private void MonitorChanged(object sender, EventArgs e)
		{
			this.monitor++;
			if (this.monitor >= Delegate239.smethod_0().Length)
			{
				this.monitor = 0;
			}
			this.SetKey("monitor", this.monitor);
			this.UpdateUI();
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002618 File Offset: 0x00000818
		private void IsAimKeyChanged(object sender, EventArgs e)
		{
			this.isAimKey = this.AimKeyToggle.Checked;
			this.SetKey("isAimKey", this.isAimKey);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000024C5 File Offset: 0x000006C5
		private void IsHold_changed(object sender, EventArgs e)
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00005538 File Offset: 0x00003738
		private unsafe void AimKeyDrop(object sender, EventArgs e)
		{
			Point point = Delegate253.smethod_0(this.AimkeyBtt, Delegate136.smethod_0(Delegate153.smethod_0(this.AimkeyBtt), Delegate182.smethod_0(this.AimkeyBtt)));
			int num = Delegate65.smethod_0(&point);
			Size size = Delegate231.smethod_0(this.contextMenuStrip1);
			int num2 = num + Delegate305.smethod_0(&size);
			Rectangle rectangle = Delegate139.smethod_0(Delegate286.smethod_0());
			if (num2 > Delegate40.smethod_0(&rectangle))
			{
				ToolStripDropDown toolStripDropDown = this.contextMenuStrip1;
				Control aimkeyBtt = this.AimkeyBtt;
				int int_ = 0;
				size = Delegate231.smethod_0(this.contextMenuStrip1);
				toolStripDropDown.Show(aimkeyBtt, Delegate136.smethod_0(int_, -Delegate305.smethod_0(&size)));
				return;
			}
			this.contextMenuStrip1.Show(this.AimkeyBtt, Delegate136.smethod_0(0, Delegate88.smethod_0(this.AimkeyBtt)));
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000024C5 File Offset: 0x000006C5
		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000263C File Offset: 0x0000083C
		private void OffsetY_changed(object sender, EventArgs e)
		{
			this.offsetY = Delegate324.smethod_0(Delegate8.smethod_0(this.offsetNum));
			this.SetKey("offsetY", this.offsetY);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000024C5 File Offset: 0x000006C5
		private void label5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002665 File Offset: 0x00000865
		private void FireRate_changed(object sender, EventArgs e)
		{
			this.msShootTime = Delegate324.smethod_0(Delegate8.smethod_0(this.FireRateNum));
			this.SetKey("msShootTime", this.msShootTime);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000268E File Offset: 0x0000088E
		private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			this.isAimbot = this.AimbotBtt.Checked;
			this.SetKey("isAimbot", this.isAimbot);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000026B2 File Offset: 0x000008B2
		private void guna2CheckBox1_CheckedChanged_1(object sender, EventArgs e)
		{
			this.isTriggerbot = this.TriggerbotBtt.Checked;
			this.SetKey("isTriggerbot", this.isTriggerbot);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000026D6 File Offset: 0x000008D6
		private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
		{
			this.color = Main.ColorType.Red;
			this.SetKey("color", (int)this.color);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000026F0 File Offset: 0x000008F0
		private void guna2RadioButton1_CheckedChanged_1(object sender, EventArgs e)
		{
			this.color = Main.ColorType.Purple;
			this.SetKey("color", (int)this.color);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000024C5 File Offset: 0x000006C5
		private void AimKeyToggle_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000270A File Offset: 0x0000090A
		private void guna2CheckBox1_CheckedChanged_2(object sender, EventArgs e)
		{
			this.isHold = this.IsHoldToggle.Checked;
			this.SetKey("isHold", this.isHold);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000272E File Offset: 0x0000092E
		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
			Delegate244.smethod_0(0);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000024C5 File Offset: 0x000006C5
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002736 File Offset: 0x00000936
		private void toggleSwitch1_CheckedChanged(object sender, EventArgs e)
		{
			if (Delegate31.smethod_0(this.toggleSwitch1))
			{
				new SoundPlayer(Resources.david_kushner_daylight__slowed_reverb___64_kbps_).Play();
				return;
			}
			if (!Delegate31.smethod_0(this.toggleSwitch1))
			{
				new SoundPlayer(Resources.david_kushner_daylight__slowed_reverb___64_kbps_).Stop();
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000024C5 File Offset: 0x000006C5
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000024C5 File Offset: 0x000006C5
		private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000024C5 File Offset: 0x000006C5
		private void backgroundWorker2_DoWork_1(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000024C5 File Offset: 0x000006C5
		private void CheckCrack_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002771 File Offset: 0x00000971
		private void ANTICRACK_Tick(object sender, EventArgs e)
		{
			object obj = Delegate6.smethod_0();
			Delegate202.smethod_0(obj, true);
			Delegate32.smethod_0(obj, true);
			this.CheckCrack = obj;
			Delegate75.smethod_0(this.CheckCrack, Delegate176.smethod_0(this, ldftn(CheckCrack_DoWork1)));
			Delegate79.smethod_0(this.CheckCrack);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000055EC File Offset: 0x000037EC
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

		// Token: 0x060000DC RID: 220 RVA: 0x000024C5 File Offset: 0x000006C5
		private void AimKeyToggle_CheckedChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000024C5 File Offset: 0x000006C5
		private void guna2CheckBox1_CheckedChanged_3(object sender, EventArgs e)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000027AE File Offset: 0x000009AE
		private void AppClose_Tick(object sender, EventArgs e)
		{
			object obj = Delegate6.smethod_0();
			Delegate202.smethod_0(obj, true);
			Delegate32.smethod_0(obj, true);
			this.Closingmm = obj;
			Delegate75.smethod_0(this.Closingmm, Delegate176.smethod_0(this, ldftn(Closingmm_DoWork1)));
			Delegate79.smethod_0(this.Closingmm);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000027EB File Offset: 0x000009EB
		private void Closingmm_DoWork1(object sender, DoWorkEventArgs e)
		{
			if (Delegate110.smethod_0("C:\\Windows\\System32\\AntiCarck.lic"))
			{
				Delegate244.smethod_0(0);
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000024C5 File Offset: 0x000006C5
		private void Closingmm_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000060F8 File Offset: 0x000042F8
		private void guna2CheckBox1_CheckedChanged_4(object sender, EventArgs e)
		{
			if (this.guna2CheckBox1.Checked)
			{
				ThreadStart threadStart_;
				if ((threadStart_ = Main.<>c.<>9__92_0) == null)
				{
					threadStart_ = (Main.<>c.<>9__92_0 = Delegate219.smethod_0(Main.<>c.<>9, ldftn(<guna2CheckBox1_CheckedChanged_4>b__92_0)));
				}
				this.aimbotThread = Delegate53.smethod_0(threadStart_);
				Delegate216.smethod_0(this.aimbotThread);
			}
		}

		// Token: 0x04000047 RID: 71
		private Free frr;

		// Token: 0x04000048 RID: 72
		private aimbot aim;

		// Token: 0x04000049 RID: 73
		private InputSimulator inputSimulator = Delegate38.smethod_0();

		// Token: 0x0400004A RID: 74
		private Keys aimbotHotKey = Keys.XButton2;

		// Token: 0x0400004B RID: 75
		private int xSize;

		// Token: 0x0400004C RID: 76
		private int ySize;

		// Token: 0x0400004D RID: 77
		private int msShootTime = 225;

		// Token: 0x0400004E RID: 78
		private DateTime lastShot = Delegate102.smethod_0();

		// Token: 0x0400004F RID: 79
		private int offsetY = 10;

		// Token: 0x04000050 RID: 80
		private bool isTriggerbot;

		// Token: 0x04000051 RID: 81
		private bool isAimbot;

		// Token: 0x04000052 RID: 82
		private decimal speed = 1m;

		// Token: 0x04000053 RID: 83
		private int fovX = 100;

		// Token: 0x04000054 RID: 84
		private int fovY = 100;

		// Token: 0x04000055 RID: 85
		private bool isAimKey;

		// Token: 0x04000056 RID: 86
		private bool isHold = true;

		// Token: 0x04000057 RID: 87
		private int monitor;

		// Token: 0x04000058 RID: 88
		private int colorVariation = 25;

		// Token: 0x04000059 RID: 89
		private Main.AimKey mainAimKey = Main.AimKey.Alt;

		// Token: 0x0400005A RID: 90
		private Main.ColorType color = Main.ColorType.Purple;

		// Token: 0x0400005B RID: 91
		private float zoom = 1f;

		// Token: 0x0400005C RID: 92
		private const int MOUSEEVENTF_LEFTDOWN = 2;

		// Token: 0x0400005D RID: 93
		private const int MOUSEEVENTF_LEFTUP = 4;

		// Token: 0x0400005E RID: 94
		private const int MOUSEEVENTF_RIGHTDOWN = 8;

		// Token: 0x0400005F RID: 95
		private const int MOUSEEVENTF_RIGHTUP = 16;

		// Token: 0x04000060 RID: 96
		private Thread mainThread;

		// Token: 0x04000061 RID: 97
		private Thread aimbotThread;

		// Token: 0x04000062 RID: 98
		private bool isRunning;

		// Token: 0x02000012 RID: 18
		private enum AimKey
		{
			// Token: 0x04000088 RID: 136
			LeftMouse = 1,
			// Token: 0x04000089 RID: 137
			RightMouse,
			// Token: 0x0400008A RID: 138
			X1Mouse = 5,
			// Token: 0x0400008B RID: 139
			X2Button,
			// Token: 0x0400008C RID: 140
			Shift = 160,
			// Token: 0x0400008D RID: 141
			Ctrl = 162,
			// Token: 0x0400008E RID: 142
			Alt = 164,
			// Token: 0x0400008F RID: 143
			Capslock = 20,
			// Token: 0x04000090 RID: 144
			Numpad0 = 96,
			// Token: 0x04000091 RID: 145
			Numlock = 144
		}

		// Token: 0x02000013 RID: 19
		public enum DeviceCap
		{
			// Token: 0x04000093 RID: 147
			VERTRES = 10,
			// Token: 0x04000094 RID: 148
			DESKTOPVERTRES = 117
		}

		// Token: 0x02000014 RID: 20
		private enum ColorType
		{
			// Token: 0x04000096 RID: 150
			Red,
			// Token: 0x04000097 RID: 151
			Purple
		}
	}
}

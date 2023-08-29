namespace ValorantAimbotUI
{
	// Token: 0x02000011 RID: 17
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x060000E2 RID: 226 RVA: 0x000027FF File Offset: 0x000009FF
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			global::Delegate66.smethod_0(this, disposing);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00006148 File Offset: 0x00004348
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager object_ = global::Delegate348.smethod_0(global::Delegate340.smethod_0(typeof(global::ValorantAimbotUI.Main).TypeHandle));
			this.Speed = global::Delegate299.smethod_0();
			this.label1 = global::Delegate45.smethod_0();
			this.FovXNum = global::Delegate299.smethod_0();
			this.label2 = global::Delegate45.smethod_0();
			this.FovYNum = global::Delegate299.smethod_0();
			this.label3 = global::Delegate45.smethod_0();
			this.ChangeMonitorBtt = global::Delegate179.smethod_0();
			this.AimkeyBtt = global::Delegate179.smethod_0();
			this.StartBtt = global::Delegate179.smethod_0();
			this.contextMenuStrip1 = global::Delegate273.smethod_0(this.components);
			this.offsetNum = global::Delegate299.smethod_0();
			this.label4 = global::Delegate45.smethod_0();
			this.label5 = global::Delegate45.smethod_0();
			this.FireRateNum = global::Delegate299.smethod_0();
			this.guna2Elipse1 = global::Delegate241.smethod_0(this.components);
			this.guna2DragControl1 = global::Delegate83.smethod_0(this.components);
			this.pictureBox1 = global::Delegate60.smethod_0();
			this.AimbotBtt = global::Delegate120.smethod_0();
			this.TriggerbotBtt = global::Delegate120.smethod_0();
			this.RedRadio = global::Delegate314.smethod_0();
			this.PurpleRadio = global::Delegate314.smethod_0();
			this.AimKeyToggle = global::Delegate120.smethod_0();
			this.IsHoldToggle = global::Delegate120.smethod_0();
			this.guna2ControlBox1 = global::Delegate54.smethod_0();
			this.guna2ControlBox2 = global::Delegate54.smethod_0();
			this.pictureBox2 = global::Delegate60.smethod_0();
			this.toggleSwitch1 = global::Delegate192.smethod_0();
			this.guna2Elipse2 = global::Delegate241.smethod_0(this.components);
			this.backgroundWorker1 = global::Delegate6.smethod_0();
			this.backgroundWorker2 = global::Delegate6.smethod_0();
			this.CheckCrack = global::Delegate6.smethod_0();
			this.ANTICRACK = global::Delegate111.smethod_0(this.components);
			this.AppClose = global::Delegate111.smethod_0(this.components);
			this.Closingmm = global::Delegate6.smethod_0();
			this.guna2CheckBox1 = global::Delegate120.smethod_0();
			((global::System.ComponentModel.ISupportInitialize)this.Speed).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FovXNum).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FovYNum).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.offsetNum).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FireRateNum).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			global::Delegate274.smethod_0(this);
			global::Delegate344.smethod_0(this.Speed, 2);
			global::Delegate36.smethod_0(this.Speed, global::Delegate59.smethod_0(new int[]
			{
				1,
				0,
				0,
				65536
			}));
			global::Delegate257.smethod_0(this.Speed, global::Delegate136.smethod_0(53, 245));
			global::Delegate198.smethod_0(this.Speed, global::Delegate318.smethod_0(2));
			global::Delegate221.smethod_0(this.Speed, "Speed");
			global::Delegate352.smethod_0(this.Speed, global::Delegate86.smethod_0(90, 20));
			global::Delegate76.smethod_0(this.Speed, 3);
			global::Delegate353.smethod_0(this.Speed, global::Delegate20.smethod_0(this, ldftn(Speed_changed)));
			global::Delegate284.smethod_0(this.label1, true);
			global::Delegate279.smethod_0(this.label1, global::Delegate293.smethod_0());
			global::Delegate156.smethod_0(this.label1, global::Delegate199.smethod_0("Oswald", 11.25f, global::System.Drawing.FontStyle.Bold));
			global::Delegate220.smethod_0(this.label1, global::Delegate303.smethod_0());
			global::Delegate257.smethod_0(this.label1, global::Delegate136.smethod_0(145, 240));
			global::Delegate198.smethod_0(this.label1, global::Delegate90.smethod_0(2, 0, 2, 0));
			global::Delegate221.smethod_0(this.label1, "label1");
			global::Delegate352.smethod_0(this.label1, global::Delegate86.smethod_0(62, 26));
			global::Delegate76.smethod_0(this.label1, 4);
			global::Delegate124.smethod_0(this.label1, "Speed : ");
			global::Delegate257.smethod_0(this.FovXNum, global::Delegate136.smethod_0(53, 280));
			global::Delegate198.smethod_0(this.FovXNum, global::Delegate318.smethod_0(2));
			object fovXNum = this.FovXNum;
			int[] array = new int[4];
			array[0] = 10000;
			global::Delegate104.smethod_0(fovXNum, global::Delegate59.smethod_0(array));
			global::Delegate221.smethod_0(this.FovXNum, "FovXNum");
			global::Delegate352.smethod_0(this.FovXNum, global::Delegate86.smethod_0(90, 20));
			global::Delegate76.smethod_0(this.FovXNum, 5);
			global::Delegate353.smethod_0(this.FovXNum, global::Delegate20.smethod_0(this, ldftn(FovX_changed)));
			global::Delegate284.smethod_0(this.label2, true);
			global::Delegate279.smethod_0(this.label2, global::Delegate293.smethod_0());
			global::Delegate156.smethod_0(this.label2, global::Delegate199.smethod_0("Oswald", 11.25f, global::System.Drawing.FontStyle.Bold));
			global::Delegate220.smethod_0(this.label2, global::Delegate303.smethod_0());
			global::Delegate257.smethod_0(this.label2, global::Delegate136.smethod_0(147, 277));
			global::Delegate198.smethod_0(this.label2, global::Delegate90.smethod_0(2, 0, 2, 0));
			global::Delegate221.smethod_0(this.label2, "label2");
			global::Delegate352.smethod_0(this.label2, global::Delegate86.smethod_0(56, 26));
			global::Delegate76.smethod_0(this.label2, 6);
			global::Delegate124.smethod_0(this.label2, "Fov X : ");
			global::Delegate257.smethod_0(this.FovYNum, global::Delegate136.smethod_0(53, 315));
			global::Delegate198.smethod_0(this.FovYNum, global::Delegate318.smethod_0(2));
			object fovYNum = this.FovYNum;
			int[] array2 = new int[4];
			array2[0] = 10000;
			global::Delegate104.smethod_0(fovYNum, global::Delegate59.smethod_0(array2));
			global::Delegate221.smethod_0(this.FovYNum, "FovYNum");
			global::Delegate352.smethod_0(this.FovYNum, global::Delegate86.smethod_0(90, 20));
			global::Delegate76.smethod_0(this.FovYNum, 7);
			global::Delegate353.smethod_0(this.FovYNum, global::Delegate20.smethod_0(this, ldftn(FovY_changed)));
			global::Delegate284.smethod_0(this.label3, true);
			global::Delegate279.smethod_0(this.label3, global::Delegate293.smethod_0());
			global::Delegate156.smethod_0(this.label3, global::Delegate199.smethod_0("Oswald", 11.25f, global::System.Drawing.FontStyle.Bold));
			global::Delegate220.smethod_0(this.label3, global::Delegate303.smethod_0());
			global::Delegate257.smethod_0(this.label3, global::Delegate136.smethod_0(147, 312));
			global::Delegate198.smethod_0(this.label3, global::Delegate90.smethod_0(2, 0, 2, 0));
			global::Delegate221.smethod_0(this.label3, "label3");
			global::Delegate352.smethod_0(this.label3, global::Delegate86.smethod_0(55, 26));
			global::Delegate76.smethod_0(this.label3, 8);
			global::Delegate124.smethod_0(this.label3, "Fov Y : ");
			global::Delegate279.smethod_0(this.ChangeMonitorBtt, global::Delegate232.smethod_0(255, 128, 128));
			this.ChangeMonitorBtt.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			global::Delegate220.smethod_0(this.ChangeMonitorBtt, global::Delegate98.smethod_0());
			global::Delegate257.smethod_0(this.ChangeMonitorBtt, global::Delegate136.smethod_0(37, 411));
			global::Delegate198.smethod_0(this.ChangeMonitorBtt, global::Delegate318.smethod_0(2));
			global::Delegate221.smethod_0(this.ChangeMonitorBtt, "ChangeMonitorBtt");
			global::Delegate352.smethod_0(this.ChangeMonitorBtt, global::Delegate86.smethod_0(139, 22));
			global::Delegate76.smethod_0(this.ChangeMonitorBtt, 11);
			global::Delegate124.smethod_0(this.ChangeMonitorBtt, "Change Monitor");
			this.ChangeMonitorBtt.UseVisualStyleBackColor = false;
			global::Delegate154.smethod_0(this.ChangeMonitorBtt, global::Delegate20.smethod_0(this, ldftn(MonitorChanged)));
			global::Delegate279.smethod_0(this.AimkeyBtt, global::Delegate232.smethod_0(255, 128, 128));
			this.AimkeyBtt.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			global::Delegate220.smethod_0(this.AimkeyBtt, global::Delegate98.smethod_0());
			global::Delegate257.smethod_0(this.AimkeyBtt, global::Delegate136.smethod_0(180, 411));
			global::Delegate198.smethod_0(this.AimkeyBtt, global::Delegate318.smethod_0(2));
			global::Delegate221.smethod_0(this.AimkeyBtt, "AimkeyBtt");
			global::Delegate352.smethod_0(this.AimkeyBtt, global::Delegate86.smethod_0(81, 22));
			global::Delegate76.smethod_0(this.AimkeyBtt, 14);
			global::Delegate124.smethod_0(this.AimkeyBtt, "button1");
			this.AimkeyBtt.UseVisualStyleBackColor = false;
			global::Delegate154.smethod_0(this.AimkeyBtt, global::Delegate20.smethod_0(this, ldftn(AimKeyDrop)));
			global::Delegate279.smethod_0(this.StartBtt, global::Delegate232.smethod_0(255, 128, 128));
			this.StartBtt.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			global::Delegate220.smethod_0(this.StartBtt, global::Delegate98.smethod_0());
			global::Delegate257.smethod_0(this.StartBtt, global::Delegate136.smethod_0(37, 437));
			global::Delegate198.smethod_0(this.StartBtt, global::Delegate318.smethod_0(2));
			global::Delegate221.smethod_0(this.StartBtt, "StartBtt");
			global::Delegate352.smethod_0(this.StartBtt, global::Delegate86.smethod_0(224, 24));
			global::Delegate76.smethod_0(this.StartBtt, 15);
			global::Delegate124.smethod_0(this.StartBtt, "button1");
			this.StartBtt.UseVisualStyleBackColor = false;
			global::Delegate154.smethod_0(this.StartBtt, global::Delegate20.smethod_0(this, ldftn(Start_click)));
			this.contextMenuStrip1.ImageScalingSize = global::Delegate86.smethod_0(20, 20);
			global::Delegate221.smethod_0(this.contextMenuStrip1, "contextMenuStrip1");
			global::Delegate352.smethod_0(this.contextMenuStrip1, global::Delegate86.smethod_0(61, 4));
			this.contextMenuStrip1.Opening += global::Delegate67.smethod_0(this, ldftn(contextMenuStrip1_Opening));
			global::Delegate257.smethod_0(this.offsetNum, global::Delegate136.smethod_0(54, 347));
			global::Delegate198.smethod_0(this.offsetNum, global::Delegate318.smethod_0(2));
			global::Delegate221.smethod_0(this.offsetNum, "offsetNum");
			global::Delegate352.smethod_0(this.offsetNum, global::Delegate86.smethod_0(90, 20));
			global::Delegate76.smethod_0(this.offsetNum, 16);
			global::Delegate353.smethod_0(this.offsetNum, global::Delegate20.smethod_0(this, ldftn(OffsetY_changed)));
			global::Delegate284.smethod_0(this.label4, true);
			global::Delegate279.smethod_0(this.label4, global::Delegate293.smethod_0());
			global::Delegate156.smethod_0(this.label4, global::Delegate199.smethod_0("Oswald", 11.25f, global::System.Drawing.FontStyle.Bold));
			global::Delegate220.smethod_0(this.label4, global::Delegate303.smethod_0());
			global::Delegate257.smethod_0(this.label4, global::Delegate136.smethod_0(147, 345));
			global::Delegate198.smethod_0(this.label4, global::Delegate90.smethod_0(2, 0, 2, 0));
			global::Delegate221.smethod_0(this.label4, "label4");
			global::Delegate352.smethod_0(this.label4, global::Delegate86.smethod_0(60, 26));
			global::Delegate76.smethod_0(this.label4, 17);
			global::Delegate124.smethod_0(this.label4, "Offset : ");
			global::Delegate284.smethod_0(this.label5, true);
			global::Delegate279.smethod_0(this.label5, global::Delegate293.smethod_0());
			global::Delegate156.smethod_0(this.label5, global::Delegate199.smethod_0("Oswald", 11.25f, global::System.Drawing.FontStyle.Bold));
			global::Delegate220.smethod_0(this.label5, global::Delegate303.smethod_0());
			global::Delegate257.smethod_0(this.label5, global::Delegate136.smethod_0(146, 375));
			global::Delegate198.smethod_0(this.label5, global::Delegate90.smethod_0(2, 0, 2, 0));
			global::Delegate221.smethod_0(this.label5, "label5");
			global::Delegate352.smethod_0(this.label5, global::Delegate86.smethod_0(68, 26));
			global::Delegate76.smethod_0(this.label5, 19);
			global::Delegate124.smethod_0(this.label5, "Fire Rate");
			global::Delegate154.smethod_0(this.label5, global::Delegate20.smethod_0(this, ldftn(label5_Click)));
			global::Delegate257.smethod_0(this.FireRateNum, global::Delegate136.smethod_0(53, 379));
			global::Delegate198.smethod_0(this.FireRateNum, global::Delegate318.smethod_0(2));
			object fireRateNum = this.FireRateNum;
			int[] array3 = new int[4];
			array3[0] = 10000;
			global::Delegate104.smethod_0(fireRateNum, global::Delegate59.smethod_0(array3));
			global::Delegate221.smethod_0(this.FireRateNum, "FireRateNum");
			global::Delegate352.smethod_0(this.FireRateNum, global::Delegate86.smethod_0(90, 20));
			global::Delegate76.smethod_0(this.FireRateNum, 18);
			global::Delegate353.smethod_0(this.FireRateNum, global::Delegate20.smethod_0(this, ldftn(FireRate_changed)));
			global::Delegate242.smethod_0(this.guna2Elipse1, 20);
			global::Delegate50.smethod_0(this.guna2Elipse1, this);
			global::Delegate2.smethod_0(this.guna2DragControl1, 1.0);
			global::Delegate159.smethod_0(this.guna2DragControl1, 1.0);
			global::Delegate256.smethod_0(this.guna2DragControl1, this.pictureBox1);
			global::Delegate46.smethod_0(this.guna2DragControl1, true);
			global::Delegate164.smethod_0(this.pictureBox1, (global::System.Drawing.Image)global::Delegate181.smethod_0(object_, "pictureBox1.Image"));
			global::Delegate257.smethod_0(this.pictureBox1, global::Delegate136.smethod_0(-1, 0));
			global::Delegate221.smethod_0(this.pictureBox1, "pictureBox1");
			global::Delegate352.smethod_0(this.pictureBox1, global::Delegate86.smethod_0(302, 476));
			global::Delegate27.smethod_0(this.pictureBox1, global::System.Windows.Forms.PictureBoxSizeMode.StretchImage);
			global::Delegate23.smethod_0(this.pictureBox1, 20);
			global::Delegate249.smethod_0(this.pictureBox1, false);
			global::Delegate154.smethod_0(this.pictureBox1, global::Delegate20.smethod_0(this, ldftn(pictureBox1_Click)));
			global::Delegate52.smethod_0(this.AimbotBtt, true);
			global::Delegate284.smethod_0(this.AimbotBtt, true);
			global::Delegate320.smethod_0(global::Delegate15.smethod_0(this.AimbotBtt), global::Delegate283.smethod_0());
			global::Delegate282.smethod_0(global::Delegate15.smethod_0(this.AimbotBtt), 5);
			global::Delegate333.smethod_0(global::Delegate15.smethod_0(this.AimbotBtt), 0);
			global::Delegate171.smethod_0(global::Delegate15.smethod_0(this.AimbotBtt), global::Delegate283.smethod_0());
			global::Delegate246.smethod_0(this.AimbotBtt, global::Delegate152.smethod_0());
			global::Delegate156.smethod_0(this.AimbotBtt, global::Delegate346.smethod_0("Oswald", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0));
			global::Delegate220.smethod_0(this.AimbotBtt, global::Delegate210.smethod_0());
			global::Delegate257.smethod_0(this.AimbotBtt, global::Delegate136.smethod_0(67, 210));
			global::Delegate221.smethod_0(this.AimbotBtt, "AimbotBtt");
			global::Delegate352.smethod_0(this.AimbotBtt, global::Delegate86.smethod_0(74, 30));
			global::Delegate76.smethod_0(this.AimbotBtt, 21);
			global::Delegate124.smethod_0(this.AimbotBtt, "Aimbot");
			this.AimbotBtt.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			global::Delegate320.smethod_0(global::Delegate101.smethod_0(this.AimbotBtt), global::Delegate283.smethod_0());
			global::Delegate282.smethod_0(global::Delegate101.smethod_0(this.AimbotBtt), 5);
			global::Delegate333.smethod_0(global::Delegate101.smethod_0(this.AimbotBtt), 0);
			global::Delegate171.smethod_0(global::Delegate101.smethod_0(this.AimbotBtt), global::Delegate283.smethod_0());
			this.AimbotBtt.CheckedChanged += global::Delegate20.smethod_0(this, ldftn(guna2CheckBox1_CheckedChanged));
			global::Delegate52.smethod_0(this.TriggerbotBtt, true);
			global::Delegate284.smethod_0(this.TriggerbotBtt, true);
			global::Delegate320.smethod_0(global::Delegate15.smethod_0(this.TriggerbotBtt), global::Delegate283.smethod_0());
			global::Delegate282.smethod_0(global::Delegate15.smethod_0(this.TriggerbotBtt), 5);
			global::Delegate333.smethod_0(global::Delegate15.smethod_0(this.TriggerbotBtt), 0);
			global::Delegate171.smethod_0(global::Delegate15.smethod_0(this.TriggerbotBtt), global::Delegate283.smethod_0());
			global::Delegate246.smethod_0(this.TriggerbotBtt, global::Delegate152.smethod_0());
			global::Delegate156.smethod_0(this.TriggerbotBtt, global::Delegate346.smethod_0("Oswald", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0));
			global::Delegate220.smethod_0(this.TriggerbotBtt, global::Delegate210.smethod_0());
			global::Delegate257.smethod_0(this.TriggerbotBtt, global::Delegate136.smethod_0(147, 210));
			global::Delegate221.smethod_0(this.TriggerbotBtt, "TriggerbotBtt");
			global::Delegate352.smethod_0(this.TriggerbotBtt, global::Delegate86.smethod_0(97, 30));
			global::Delegate76.smethod_0(this.TriggerbotBtt, 22);
			global::Delegate124.smethod_0(this.TriggerbotBtt, "Triggerbot");
			this.TriggerbotBtt.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			global::Delegate320.smethod_0(global::Delegate101.smethod_0(this.TriggerbotBtt), global::Delegate283.smethod_0());
			global::Delegate282.smethod_0(global::Delegate101.smethod_0(this.TriggerbotBtt), 5);
			global::Delegate333.smethod_0(global::Delegate101.smethod_0(this.TriggerbotBtt), 0);
			global::Delegate171.smethod_0(global::Delegate101.smethod_0(this.TriggerbotBtt), global::Delegate283.smethod_0());
			this.TriggerbotBtt.CheckedChanged += global::Delegate20.smethod_0(this, ldftn(guna2CheckBox1_CheckedChanged_1));
			global::Delegate212.smethod_0(this.RedRadio, true);
			global::Delegate284.smethod_0(this.RedRadio, true);
			global::Delegate280.smethod_0(global::Delegate19.smethod_0(this.RedRadio), global::Delegate283.smethod_0());
			global::Delegate146.smethod_0(global::Delegate19.smethod_0(this.RedRadio), 0);
			global::Delegate328.smethod_0(global::Delegate19.smethod_0(this.RedRadio), global::Delegate283.smethod_0());
			global::Delegate300.smethod_0(global::Delegate19.smethod_0(this.RedRadio), global::Delegate152.smethod_0());
			global::Delegate12.smethod_0(global::Delegate19.smethod_0(this.RedRadio), -4);
			global::Delegate156.smethod_0(this.RedRadio, global::Delegate199.smethod_0("Oswald", 11.25f, global::System.Drawing.FontStyle.Bold));
			global::Delegate220.smethod_0(this.RedRadio, global::Delegate210.smethod_0());
			global::Delegate257.smethod_0(this.RedRadio, global::Delegate136.smethod_0(200, 238));
			global::Delegate221.smethod_0(this.RedRadio, "RedRadio");
			global::Delegate352.smethod_0(this.RedRadio, global::Delegate86.smethod_0(54, 30));
			global::Delegate76.smethod_0(this.RedRadio, 23);
			global::Delegate124.smethod_0(this.RedRadio, "Red");
			global::Delegate280.smethod_0(global::Delegate321.smethod_0(this.RedRadio), global::Delegate283.smethod_0());
			global::Delegate146.smethod_0(global::Delegate321.smethod_0(this.RedRadio), 2);
			global::Delegate328.smethod_0(global::Delegate321.smethod_0(this.RedRadio), global::Delegate293.smethod_0());
			global::Delegate300.smethod_0(global::Delegate321.smethod_0(this.RedRadio), global::Delegate293.smethod_0());
			this.RedRadio.CheckedChanged += global::Delegate20.smethod_0(this, ldftn(guna2RadioButton1_CheckedChanged));
			global::Delegate212.smethod_0(this.PurpleRadio, true);
			global::Delegate284.smethod_0(this.PurpleRadio, true);
			global::Delegate280.smethod_0(global::Delegate19.smethod_0(this.PurpleRadio), global::Delegate283.smethod_0());
			global::Delegate146.smethod_0(global::Delegate19.smethod_0(this.PurpleRadio), 0);
			global::Delegate328.smethod_0(global::Delegate19.smethod_0(this.PurpleRadio), global::Delegate283.smethod_0());
			global::Delegate300.smethod_0(global::Delegate19.smethod_0(this.PurpleRadio), global::Delegate152.smethod_0());
			global::Delegate12.smethod_0(global::Delegate19.smethod_0(this.PurpleRadio), -4);
			global::Delegate156.smethod_0(this.PurpleRadio, global::Delegate199.smethod_0("Oswald", 11.25f, global::System.Drawing.FontStyle.Bold));
			global::Delegate220.smethod_0(this.PurpleRadio, global::Delegate210.smethod_0());
			global::Delegate257.smethod_0(this.PurpleRadio, global::Delegate136.smethod_0(197, 274));
			global::Delegate221.smethod_0(this.PurpleRadio, "PurpleRadio");
			global::Delegate352.smethod_0(this.PurpleRadio, global::Delegate86.smethod_0(72, 30));
			global::Delegate76.smethod_0(this.PurpleRadio, 24);
			global::Delegate124.smethod_0(this.PurpleRadio, "Purple");
			global::Delegate280.smethod_0(global::Delegate321.smethod_0(this.PurpleRadio), global::Delegate283.smethod_0());
			global::Delegate146.smethod_0(global::Delegate321.smethod_0(this.PurpleRadio), 2);
			global::Delegate328.smethod_0(global::Delegate321.smethod_0(this.PurpleRadio), global::Delegate293.smethod_0());
			global::Delegate300.smethod_0(global::Delegate321.smethod_0(this.PurpleRadio), global::Delegate293.smethod_0());
			this.PurpleRadio.CheckedChanged += global::Delegate20.smethod_0(this, ldftn(guna2RadioButton1_CheckedChanged_1));
			global::Delegate52.smethod_0(this.AimKeyToggle, true);
			global::Delegate284.smethod_0(this.AimKeyToggle, true);
			global::Delegate320.smethod_0(global::Delegate15.smethod_0(this.AimKeyToggle), global::Delegate283.smethod_0());
			global::Delegate282.smethod_0(global::Delegate15.smethod_0(this.AimKeyToggle), 5);
			global::Delegate333.smethod_0(global::Delegate15.smethod_0(this.AimKeyToggle), 0);
			global::Delegate171.smethod_0(global::Delegate15.smethod_0(this.AimKeyToggle), global::Delegate283.smethod_0());
			global::Delegate246.smethod_0(this.AimKeyToggle, global::Delegate152.smethod_0());
			global::Delegate156.smethod_0(this.AimKeyToggle, global::Delegate346.smethod_0("Oswald", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0));
			global::Delegate220.smethod_0(this.AimKeyToggle, global::Delegate210.smethod_0());
			global::Delegate257.smethod_0(this.AimKeyToggle, global::Delegate136.smethod_0(198, 312));
			global::Delegate221.smethod_0(this.AimKeyToggle, "AimKeyToggle");
			global::Delegate352.smethod_0(this.AimKeyToggle, global::Delegate86.smethod_0(77, 30));
			global::Delegate76.smethod_0(this.AimKeyToggle, 25);
			global::Delegate124.smethod_0(this.AimKeyToggle, "AimKey");
			this.AimKeyToggle.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			global::Delegate320.smethod_0(global::Delegate101.smethod_0(this.AimKeyToggle), global::Delegate283.smethod_0());
			global::Delegate282.smethod_0(global::Delegate101.smethod_0(this.AimKeyToggle), 5);
			global::Delegate333.smethod_0(global::Delegate101.smethod_0(this.AimKeyToggle), 0);
			global::Delegate171.smethod_0(global::Delegate101.smethod_0(this.AimKeyToggle), global::Delegate283.smethod_0());
			this.AimKeyToggle.CheckedChanged += global::Delegate20.smethod_0(this, ldftn(AimKeyToggle_CheckedChanged_1));
			global::Delegate52.smethod_0(this.IsHoldToggle, true);
			global::Delegate284.smethod_0(this.IsHoldToggle, true);
			global::Delegate320.smethod_0(global::Delegate15.smethod_0(this.IsHoldToggle), global::Delegate283.smethod_0());
			global::Delegate282.smethod_0(global::Delegate15.smethod_0(this.IsHoldToggle), 5);
			global::Delegate333.smethod_0(global::Delegate15.smethod_0(this.IsHoldToggle), 0);
			global::Delegate171.smethod_0(global::Delegate15.smethod_0(this.IsHoldToggle), global::Delegate283.smethod_0());
			global::Delegate246.smethod_0(this.IsHoldToggle, global::Delegate152.smethod_0());
			global::Delegate156.smethod_0(this.IsHoldToggle, global::Delegate346.smethod_0("Oswald", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0));
			global::Delegate220.smethod_0(this.IsHoldToggle, global::Delegate210.smethod_0());
			global::Delegate257.smethod_0(this.IsHoldToggle, global::Delegate136.smethod_0(202, 344));
			global::Delegate221.smethod_0(this.IsHoldToggle, "IsHoldToggle");
			global::Delegate352.smethod_0(this.IsHoldToggle, global::Delegate86.smethod_0(59, 30));
			global::Delegate76.smethod_0(this.IsHoldToggle, 26);
			global::Delegate124.smethod_0(this.IsHoldToggle, "Hold");
			this.IsHoldToggle.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			global::Delegate320.smethod_0(global::Delegate101.smethod_0(this.IsHoldToggle), global::Delegate283.smethod_0());
			global::Delegate282.smethod_0(global::Delegate101.smethod_0(this.IsHoldToggle), 5);
			global::Delegate333.smethod_0(global::Delegate101.smethod_0(this.IsHoldToggle), 0);
			global::Delegate171.smethod_0(global::Delegate101.smethod_0(this.IsHoldToggle), global::Delegate283.smethod_0());
			this.IsHoldToggle.CheckedChanged += global::Delegate20.smethod_0(this, ldftn(guna2CheckBox1_CheckedChanged_2));
			global::Delegate141.smethod_0(this.guna2ControlBox1, global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			global::Delegate279.smethod_0(this.guna2ControlBox1, global::Delegate293.smethod_0());
			global::Delegate266.smethod_0(this.guna2ControlBox1, global::Delegate232.smethod_0(255, 128, 0));
			global::Delegate26.smethod_0(this.guna2ControlBox1, 9);
			global::Delegate281.smethod_0(this.guna2ControlBox1, 3);
			global::Delegate188.smethod_0(this.guna2ControlBox1, global::Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom);
			global::Delegate163.smethod_0(this.guna2ControlBox1, global::Delegate293.smethod_0());
			global::Delegate64.smethod_0(this.guna2ControlBox1, global::Delegate210.smethod_0());
			global::Delegate257.smethod_0(this.guna2ControlBox1, global::Delegate136.smethod_0(264, 2));
			global::Delegate221.smethod_0(this.guna2ControlBox1, "guna2ControlBox1");
			global::Delegate352.smethod_0(this.guna2ControlBox1, global::Delegate86.smethod_0(34, 29));
			global::Delegate76.smethod_0(this.guna2ControlBox1, 27);
			global::Delegate154.smethod_0(this.guna2ControlBox1, global::Delegate20.smethod_0(this, ldftn(guna2ControlBox1_Click)));
			global::Delegate141.smethod_0(this.guna2ControlBox2, global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			global::Delegate279.smethod_0(this.guna2ControlBox2, global::Delegate293.smethod_0());
			global::Delegate266.smethod_0(this.guna2ControlBox2, global::Delegate232.smethod_0(255, 128, 0));
			global::Delegate26.smethod_0(this.guna2ControlBox2, 9);
			global::Delegate281.smethod_0(this.guna2ControlBox2, 3);
			global::Delegate188.smethod_0(this.guna2ControlBox2, global::Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom);
			global::Delegate189.smethod_0(this.guna2ControlBox2, global::Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox);
			global::Delegate163.smethod_0(this.guna2ControlBox2, global::Delegate293.smethod_0());
			global::Delegate64.smethod_0(this.guna2ControlBox2, global::Delegate210.smethod_0());
			global::Delegate257.smethod_0(this.guna2ControlBox2, global::Delegate136.smethod_0(224, 2));
			global::Delegate221.smethod_0(this.guna2ControlBox2, "guna2ControlBox2");
			global::Delegate352.smethod_0(this.guna2ControlBox2, global::Delegate86.smethod_0(34, 29));
			global::Delegate76.smethod_0(this.guna2ControlBox2, 28);
			global::Delegate164.smethod_0(this.pictureBox2, (global::System.Drawing.Image)global::Delegate181.smethod_0(object_, "pictureBox2.Image"));
			global::Delegate257.smethod_0(this.pictureBox2, global::Delegate136.smethod_0(12, 2));
			global::Delegate221.smethod_0(this.pictureBox2, "pictureBox2");
			global::Delegate352.smethod_0(this.pictureBox2, global::Delegate86.smethod_0(57, 54));
			global::Delegate27.smethod_0(this.pictureBox2, global::System.Windows.Forms.PictureBoxSizeMode.StretchImage);
			global::Delegate23.smethod_0(this.pictureBox2, 29);
			global::Delegate249.smethod_0(this.pictureBox2, false);
			global::Delegate257.smethod_0(this.toggleSwitch1, global::Delegate136.smethod_0(7, 62));
			global::Delegate221.smethod_0(this.toggleSwitch1, "toggleSwitch1");
			global::Delegate144.smethod_0(this.toggleSwitch1, global::Delegate346.smethod_0("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0));
			global::Delegate317.smethod_0(this.toggleSwitch1, "OFF");
			global::Delegate137.smethod_0(this.toggleSwitch1, global::Delegate346.smethod_0("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0));
			global::Delegate271.smethod_0(this.toggleSwitch1, "ON");
			global::Delegate352.smethod_0(this.toggleSwitch1, global::Delegate86.smethod_0(73, 19));
			global::Delegate37.smethod_0(this.toggleSwitch1, global::JCS.ToggleSwitch.ToggleSwitchStyle.Carbon);
			global::Delegate76.smethod_0(this.toggleSwitch1, 30);
			global::Delegate130.smethod_0(this.toggleSwitch1, new global::JCS.ToggleSwitch.CheckedChangedDelegate(this.toggleSwitch1_CheckedChanged));
			global::Delegate242.smethod_0(this.guna2Elipse2, 20);
			global::Delegate50.smethod_0(this.guna2Elipse2, this.pictureBox1);
			global::Delegate75.smethod_0(this.backgroundWorker1, global::Delegate176.smethod_0(this, ldftn(backgroundWorker1_DoWork)));
			global::Delegate75.smethod_0(this.backgroundWorker2, global::Delegate176.smethod_0(this, ldftn(backgroundWorker2_DoWork_1)));
			global::Delegate75.smethod_0(this.CheckCrack, global::Delegate176.smethod_0(this, ldftn(CheckCrack_DoWork)));
			global::Delegate235.smethod_0(this.ANTICRACK, true);
			global::Delegate230.smethod_0(this.ANTICRACK, global::Delegate20.smethod_0(this, ldftn(ANTICRACK_Tick)));
			global::Delegate235.smethod_0(this.AppClose, true);
			global::Delegate230.smethod_0(this.AppClose, global::Delegate20.smethod_0(this, ldftn(AppClose_Tick)));
			global::Delegate75.smethod_0(this.Closingmm, global::Delegate176.smethod_0(this, ldftn(Closingmm_DoWork)));
			global::Delegate52.smethod_0(this.guna2CheckBox1, true);
			global::Delegate284.smethod_0(this.guna2CheckBox1, true);
			global::Delegate320.smethod_0(global::Delegate15.smethod_0(this.guna2CheckBox1), global::Delegate283.smethod_0());
			global::Delegate282.smethod_0(global::Delegate15.smethod_0(this.guna2CheckBox1), 5);
			global::Delegate333.smethod_0(global::Delegate15.smethod_0(this.guna2CheckBox1), 0);
			global::Delegate171.smethod_0(global::Delegate15.smethod_0(this.guna2CheckBox1), global::Delegate283.smethod_0());
			global::Delegate246.smethod_0(this.guna2CheckBox1, global::Delegate152.smethod_0());
			global::Delegate156.smethod_0(this.guna2CheckBox1, global::Delegate346.smethod_0("Oswald", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0));
			global::Delegate220.smethod_0(this.guna2CheckBox1, global::Delegate210.smethod_0());
			global::Delegate257.smethod_0(this.guna2CheckBox1, global::Delegate136.smethod_0(67, 174));
			global::Delegate221.smethod_0(this.guna2CheckBox1, "guna2CheckBox1");
			global::Delegate352.smethod_0(this.guna2CheckBox1, global::Delegate86.smethod_0(83, 30));
			global::Delegate76.smethod_0(this.guna2CheckBox1, 31);
			global::Delegate124.smethod_0(this.guna2CheckBox1, "AimLock");
			this.guna2CheckBox1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			global::Delegate320.smethod_0(global::Delegate101.smethod_0(this.guna2CheckBox1), global::Delegate283.smethod_0());
			global::Delegate282.smethod_0(global::Delegate101.smethod_0(this.guna2CheckBox1), 5);
			global::Delegate333.smethod_0(global::Delegate101.smethod_0(this.guna2CheckBox1), 0);
			global::Delegate171.smethod_0(global::Delegate101.smethod_0(this.guna2CheckBox1), global::Delegate283.smethod_0());
			this.guna2CheckBox1.CheckedChanged += global::Delegate20.smethod_0(this, ldftn(guna2CheckBox1_CheckedChanged_4));
			base.AutoScaleDimensions = global::Delegate197.smethod_0(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			global::Delegate279.smethod_0(this, global::Delegate14.smethod_0());
			global::Delegate175.smethod_0(this, (global::System.Drawing.Image)global::Delegate181.smethod_0(object_, "$this.BackgroundImage"));
			global::Delegate82.smethod_0(this, global::System.Windows.Forms.ImageLayout.Stretch);
			global::Delegate44.smethod_0(this, global::Delegate86.smethod_0(302, 476));
			global::Delegate194.smethod_0(this).Add(this.guna2CheckBox1);
			global::Delegate194.smethod_0(this).Add(this.toggleSwitch1);
			global::Delegate194.smethod_0(this).Add(this.pictureBox2);
			global::Delegate194.smethod_0(this).Add(this.guna2ControlBox2);
			global::Delegate194.smethod_0(this).Add(this.guna2ControlBox1);
			global::Delegate194.smethod_0(this).Add(this.IsHoldToggle);
			global::Delegate194.smethod_0(this).Add(this.AimKeyToggle);
			global::Delegate194.smethod_0(this).Add(this.PurpleRadio);
			global::Delegate194.smethod_0(this).Add(this.RedRadio);
			global::Delegate194.smethod_0(this).Add(this.TriggerbotBtt);
			global::Delegate194.smethod_0(this).Add(this.AimbotBtt);
			global::Delegate194.smethod_0(this).Add(this.label5);
			global::Delegate194.smethod_0(this).Add(this.FireRateNum);
			global::Delegate194.smethod_0(this).Add(this.label4);
			global::Delegate194.smethod_0(this).Add(this.offsetNum);
			global::Delegate194.smethod_0(this).Add(this.StartBtt);
			global::Delegate194.smethod_0(this).Add(this.AimkeyBtt);
			global::Delegate194.smethod_0(this).Add(this.ChangeMonitorBtt);
			global::Delegate194.smethod_0(this).Add(this.label3);
			global::Delegate194.smethod_0(this).Add(this.FovYNum);
			global::Delegate194.smethod_0(this).Add(this.label2);
			global::Delegate194.smethod_0(this).Add(this.FovXNum);
			global::Delegate194.smethod_0(this).Add(this.label1);
			global::Delegate194.smethod_0(this).Add(this.Speed);
			global::Delegate194.smethod_0(this).Add(this.pictureBox1);
			global::Delegate151.smethod_0(this, true);
			global::Delegate5.smethod_0(this, global::System.Windows.Forms.FormBorderStyle.None);
			global::Delegate350.smethod_0(this, global::Delegate318.smethod_0(2));
			global::Delegate222.smethod_0(this, "Main");
			global::Delegate343.smethod_0(this, global::System.Windows.Forms.FormStartPosition.CenterScreen);
			global::Delegate124.smethod_0(this, "TNA_PRIVET");
			global::Delegate349.smethod_0(this, global::Delegate20.smethod_0(this, ldftn(Main_load)));
			((global::System.ComponentModel.ISupportInitialize)this.Speed).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FovXNum).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FovYNum).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.offsetNum).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FireRateNum).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			global::Delegate57.smethod_0(this, false);
			global::Delegate351.smethod_0(this);
		}

		// Token: 0x04000063 RID: 99
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.NumericUpDown Speed;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.NumericUpDown FovXNum;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.NumericUpDown FovYNum;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.Button ChangeMonitorBtt;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.Button AimkeyBtt;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.Button StartBtt;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.NumericUpDown offsetNum;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.NumericUpDown FireRateNum;

		// Token: 0x04000072 RID: 114
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

		// Token: 0x04000073 RID: 115
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000075 RID: 117
		private global::Guna.UI2.WinForms.Guna2CheckBox AimbotBtt;

		// Token: 0x04000076 RID: 118
		private global::Guna.UI2.WinForms.Guna2CheckBox TriggerbotBtt;

		// Token: 0x04000077 RID: 119
		private global::Guna.UI2.WinForms.Guna2RadioButton RedRadio;

		// Token: 0x04000078 RID: 120
		private global::Guna.UI2.WinForms.Guna2RadioButton PurpleRadio;

		// Token: 0x04000079 RID: 121
		private global::Guna.UI2.WinForms.Guna2CheckBox AimKeyToggle;

		// Token: 0x0400007A RID: 122
		private global::Guna.UI2.WinForms.Guna2CheckBox IsHoldToggle;

		// Token: 0x0400007B RID: 123
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;

		// Token: 0x0400007C RID: 124
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x0400007E RID: 126
		private global::JCS.ToggleSwitch toggleSwitch1;

		// Token: 0x0400007F RID: 127
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;

		// Token: 0x04000080 RID: 128
		private global::System.ComponentModel.BackgroundWorker backgroundWorker1;

		// Token: 0x04000081 RID: 129
		private global::System.ComponentModel.BackgroundWorker backgroundWorker2;

		// Token: 0x04000082 RID: 130
		private global::System.ComponentModel.BackgroundWorker CheckCrack;

		// Token: 0x04000083 RID: 131
		private global::System.Windows.Forms.Timer ANTICRACK;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.Timer AppClose;

		// Token: 0x04000085 RID: 133
		private global::System.ComponentModel.BackgroundWorker Closingmm;

		// Token: 0x04000086 RID: 134
		private global::Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
	}
}

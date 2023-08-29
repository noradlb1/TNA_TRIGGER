namespace ValorantAimbotUI
{
	// Token: 0x02000018 RID: 24
	public partial class Login : global::System.Windows.Forms.Form
	{
		// Token: 0x060000FC RID: 252 RVA: 0x0000295C File Offset: 0x00000B5C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			global::Delegate66.smethod_0(this, disposing);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000084D0 File Offset: 0x000066D0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager object_ = global::Delegate348.smethod_0(global::Delegate340.smethod_0(typeof(global::ValorantAimbotUI.Login).TypeHandle));
			this.pictureBox1 = global::Delegate60.smethod_0();
			this.guna2Elipse1 = global::Delegate241.smethod_0(this.components);
			this.guna2DragControl1 = global::Delegate83.smethod_0(this.components);
			this.guna2ControlBox2 = global::Delegate54.smethod_0();
			this.guna2ControlBox1 = global::Delegate54.smethod_0();
			this.guna2Button1 = global::Delegate114.smethod_0();
			this.guna2TextBox1 = global::Delegate117.smethod_0();
			this.label1 = global::Delegate45.smethod_0();
			this.backgroundWorker1 = global::Delegate6.smethod_0();
			this.CheckCrack = global::Delegate6.smethod_0();
			this.ANTICRACK = global::Delegate111.smethod_0(this.components);
			this.Closingmm = global::Delegate6.smethod_0();
			this.AppClose = global::Delegate111.smethod_0(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			global::Delegate274.smethod_0(this);
			global::Delegate279.smethod_0(this.pictureBox1, global::Delegate293.smethod_0());
			global::Delegate164.smethod_0(this.pictureBox1, (global::System.Drawing.Image)global::Delegate181.smethod_0(object_, "pictureBox1.Image"));
			global::Delegate257.smethod_0(this.pictureBox1, global::Delegate136.smethod_0(-10, -11));
			global::Delegate221.smethod_0(this.pictureBox1, "pictureBox1");
			global::Delegate352.smethod_0(this.pictureBox1, global::Delegate86.smethod_0(302, 476));
			global::Delegate27.smethod_0(this.pictureBox1, global::System.Windows.Forms.PictureBoxSizeMode.StretchImage);
			global::Delegate23.smethod_0(this.pictureBox1, 0);
			global::Delegate249.smethod_0(this.pictureBox1, false);
			global::Delegate154.smethod_0(this.pictureBox1, global::Delegate20.smethod_0(this, ldftn(pictureBox1_Click)));
			global::Delegate242.smethod_0(this.guna2Elipse1, 20);
			global::Delegate50.smethod_0(this.guna2Elipse1, this);
			global::Delegate2.smethod_0(this.guna2DragControl1, 1.0);
			global::Delegate159.smethod_0(this.guna2DragControl1, 1.0);
			global::Delegate256.smethod_0(this.guna2DragControl1, this.pictureBox1);
			global::Delegate46.smethod_0(this.guna2DragControl1, true);
			global::Delegate141.smethod_0(this.guna2ControlBox2, global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			global::Delegate279.smethod_0(this.guna2ControlBox2, global::Delegate293.smethod_0());
			global::Delegate266.smethod_0(this.guna2ControlBox2, global::Delegate232.smethod_0(255, 128, 0));
			global::Delegate26.smethod_0(this.guna2ControlBox2, 9);
			global::Delegate281.smethod_0(this.guna2ControlBox2, 3);
			global::Delegate188.smethod_0(this.guna2ControlBox2, global::Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom);
			global::Delegate189.smethod_0(this.guna2ControlBox2, global::Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox);
			global::Delegate163.smethod_0(this.guna2ControlBox2, global::Delegate293.smethod_0());
			global::Delegate64.smethod_0(this.guna2ControlBox2, global::Delegate210.smethod_0());
			global::Delegate257.smethod_0(this.guna2ControlBox2, global::Delegate136.smethod_0(208, 2));
			global::Delegate221.smethod_0(this.guna2ControlBox2, "guna2ControlBox2");
			global::Delegate352.smethod_0(this.guna2ControlBox2, global::Delegate86.smethod_0(34, 29));
			global::Delegate76.smethod_0(this.guna2ControlBox2, 30);
			global::Delegate141.smethod_0(this.guna2ControlBox1, global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			global::Delegate279.smethod_0(this.guna2ControlBox1, global::Delegate293.smethod_0());
			global::Delegate266.smethod_0(this.guna2ControlBox1, global::Delegate232.smethod_0(255, 128, 0));
			global::Delegate26.smethod_0(this.guna2ControlBox1, 9);
			global::Delegate281.smethod_0(this.guna2ControlBox1, 3);
			global::Delegate188.smethod_0(this.guna2ControlBox1, global::Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom);
			global::Delegate163.smethod_0(this.guna2ControlBox1, global::Delegate293.smethod_0());
			global::Delegate64.smethod_0(this.guna2ControlBox1, global::Delegate210.smethod_0());
			global::Delegate257.smethod_0(this.guna2ControlBox1, global::Delegate136.smethod_0(248, 2));
			global::Delegate221.smethod_0(this.guna2ControlBox1, "guna2ControlBox1");
			global::Delegate352.smethod_0(this.guna2ControlBox1, global::Delegate86.smethod_0(34, 29));
			global::Delegate76.smethod_0(this.guna2ControlBox1, 29);
			global::Delegate154.smethod_0(this.guna2ControlBox1, global::Delegate20.smethod_0(this, ldftn(guna2ControlBox1_Click)));
			global::Delegate191.smethod_0(this.guna2Button1, true);
			global::Delegate279.smethod_0(this.guna2Button1, global::Delegate293.smethod_0());
			global::Delegate272.smethod_0(this.guna2Button1, global::Delegate232.smethod_0(255, 128, 0));
			global::Delegate233.smethod_0(this.guna2Button1, 15);
			global::Delegate34.smethod_0(this.guna2Button1, 5);
			global::Delegate62.smethod_0(global::Delegate149.smethod_0(this.guna2Button1), global::Delegate267.smethod_0());
			global::Delegate295.smethod_0(global::Delegate149.smethod_0(this.guna2Button1), global::Delegate267.smethod_0());
			global::Delegate3.smethod_0(global::Delegate149.smethod_0(this.guna2Button1), global::Delegate232.smethod_0(169, 169, 169));
			global::Delegate224.smethod_0(global::Delegate149.smethod_0(this.guna2Button1), global::Delegate232.smethod_0(141, 141, 141));
			global::Delegate326.smethod_0(this.guna2Button1, global::Delegate293.smethod_0());
			global::Delegate156.smethod_0(this.guna2Button1, global::Delegate127.smethod_0("Chinese Rocks", 14.25f));
			global::Delegate220.smethod_0(this.guna2Button1, global::Delegate283.smethod_0());
			global::Delegate257.smethod_0(this.guna2Button1, global::Delegate136.smethod_0(63, 301));
			global::Delegate221.smethod_0(this.guna2Button1, "guna2Button1");
			global::Delegate352.smethod_0(this.guna2Button1, global::Delegate86.smethod_0(150, 45));
			global::Delegate76.smethod_0(this.guna2Button1, 31);
			global::Delegate124.smethod_0(this.guna2Button1, "Login");
			global::Delegate154.smethod_0(this.guna2Button1, global::Delegate20.smethod_0(this, ldftn(guna2Button1_Click)));
			global::Delegate308.smethod_0(this.guna2TextBox1, true);
			global::Delegate42.smethod_0(this.guna2TextBox1, global::Delegate129.smethod_0());
			global::Delegate355.smethod_0(this.guna2TextBox1, 9);
			global::Delegate99.smethod_0(this.guna2TextBox1, 2);
			global::Delegate72.smethod_0(this.guna2TextBox1, global::Delegate357.smethod_0());
			global::Delegate70.smethod_0(this.guna2TextBox1, "");
			global::Delegate1.smethod_0(global::Delegate200.smethod_0(this.guna2TextBox1), global::Delegate232.smethod_0(208, 208, 208));
			global::Delegate247.smethod_0(global::Delegate200.smethod_0(this.guna2TextBox1), global::Delegate232.smethod_0(226, 226, 226));
			global::Delegate150.smethod_0(global::Delegate200.smethod_0(this.guna2TextBox1), global::Delegate232.smethod_0(138, 138, 138));
			global::Delegate131.smethod_0(global::Delegate200.smethod_0(this.guna2TextBox1), global::Delegate232.smethod_0(138, 138, 138));
			global::Delegate311.smethod_0(this.guna2TextBox1, global::Delegate293.smethod_0());
			global::Delegate1.smethod_0(global::Delegate135.smethod_0(this.guna2TextBox1), global::Delegate232.smethod_0(94, 148, 255));
			global::Delegate156.smethod_0(this.guna2TextBox1, global::Delegate127.smethod_0("Segoe UI", 9f));
			global::Delegate1.smethod_0(global::Delegate178.smethod_0(this.guna2TextBox1), global::Delegate232.smethod_0(94, 148, 255));
			global::Delegate257.smethod_0(this.guna2TextBox1, global::Delegate136.smethod_0(22, 241));
			global::Delegate221.smethod_0(this.guna2TextBox1, "guna2TextBox1");
			global::Delegate277.smethod_0(this.guna2TextBox1, '\0');
			global::Delegate287.smethod_0(this.guna2TextBox1, "");
			global::Delegate142.smethod_0(this.guna2TextBox1, "");
			global::Delegate352.smethod_0(this.guna2TextBox1, global::Delegate86.smethod_0(248, 23));
			global::Delegate76.smethod_0(this.guna2TextBox1, 32);
			global::Delegate193.smethod_0(this.guna2TextBox1, global::Delegate20.smethod_0(this, ldftn(guna2TextBox1_TextChanged)));
			this.guna2TextBox1.Load += global::Delegate20.smethod_0(this, ldftn(guna2TextBox1_Load));
			global::Delegate284.smethod_0(this.label1, true);
			global::Delegate156.smethod_0(this.label1, global::Delegate346.smethod_0("Chinese Rocks", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0));
			global::Delegate220.smethod_0(this.label1, global::Delegate210.smethod_0());
			global::Delegate257.smethod_0(this.label1, global::Delegate136.smethod_0(22, 215));
			global::Delegate221.smethod_0(this.label1, "label1");
			global::Delegate352.smethod_0(this.label1, global::Delegate86.smethod_0(93, 21));
			global::Delegate76.smethod_0(this.label1, 33);
			global::Delegate124.smethod_0(this.label1, "YOUR KEY : ");
			global::Delegate230.smethod_0(this.ANTICRACK, global::Delegate20.smethod_0(this, ldftn(ANTICRACK_Tick)));
			global::Delegate235.smethod_0(this.AppClose, true);
			global::Delegate230.smethod_0(this.AppClose, global::Delegate20.smethod_0(this, ldftn(AppClose_Tick)));
			base.AutoScaleDimensions = global::Delegate197.smethod_0(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			global::Delegate279.smethod_0(this, global::Delegate14.smethod_0());
			global::Delegate175.smethod_0(this, (global::System.Drawing.Image)global::Delegate181.smethod_0(object_, "$this.BackgroundImage"));
			global::Delegate82.smethod_0(this, global::System.Windows.Forms.ImageLayout.Stretch);
			global::Delegate44.smethod_0(this, global::Delegate86.smethod_0(286, 437));
			global::Delegate194.smethod_0(this).Add(this.label1);
			global::Delegate194.smethod_0(this).Add(this.guna2TextBox1);
			global::Delegate194.smethod_0(this).Add(this.guna2Button1);
			global::Delegate194.smethod_0(this).Add(this.guna2ControlBox2);
			global::Delegate194.smethod_0(this).Add(this.guna2ControlBox1);
			global::Delegate194.smethod_0(this).Add(this.pictureBox1);
			global::Delegate151.smethod_0(this, true);
			global::Delegate5.smethod_0(this, global::System.Windows.Forms.FormBorderStyle.None);
			global::Delegate222.smethod_0(this, "Login");
			global::Delegate343.smethod_0(this, global::System.Windows.Forms.FormStartPosition.CenterScreen);
			global::Delegate124.smethod_0(this, "Login");
			global::Delegate349.smethod_0(this, global::Delegate20.smethod_0(this, ldftn(Login_Load)));
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			global::Delegate57.smethod_0(this, false);
			global::Delegate351.smethod_0(this);
		}

		// Token: 0x040000A3 RID: 163
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000A4 RID: 164
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040000A5 RID: 165
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

		// Token: 0x040000A6 RID: 166
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;

		// Token: 0x040000A7 RID: 167
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;

		// Token: 0x040000A8 RID: 168
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x040000A9 RID: 169
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x040000AA RID: 170
		private global::Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000AC RID: 172
		private global::System.ComponentModel.BackgroundWorker backgroundWorker1;

		// Token: 0x040000AD RID: 173
		private global::System.ComponentModel.BackgroundWorker CheckCrack;

		// Token: 0x040000AE RID: 174
		private global::System.Windows.Forms.Timer ANTICRACK;

		// Token: 0x040000AF RID: 175
		private global::System.ComponentModel.BackgroundWorker Closingmm;

		// Token: 0x040000B0 RID: 176
		private global::System.Windows.Forms.Timer AppClose;
	}
}

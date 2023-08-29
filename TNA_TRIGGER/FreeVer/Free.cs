using System;
using System.Windows;
using ValorantAimbotUI;
using ValorantAimbotUI.Properties;

namespace FreeVer
{
	// Token: 0x02000010 RID: 16
	public class Free
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x00002487 File Offset: 0x00000687
		public Free(Main main)
		{
			this.main = main;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00004AFC File Offset: 0x00002CFC
		public unsafe void CheckTrail()
		{
			if (!Settings.Default.isFirstOpen)
			{
				DateTime dateTime = Delegate102.smethod_0();
				Settings.Default.StartDate = Delegate102.smethod_0();
				Settings.Default.EndDate = Delegate228.smethod_0(&dateTime, 1.0);
				Settings.Default.isFirstOpen = true;
				Delegate297.smethod_0(Settings.Default);
				string string_ = "Your Free Version Will Expire In : ";
				DateTime endDate = Settings.Default.EndDate;
				Delegate234.smethod_0(Delegate301.smethod_0(string_, Delegate18.smethod_0(&endDate)), "INFO", MessageBoxButton.OK, MessageBoxImage.Asterisk);
				return;
			}
			if (Delegate97.smethod_0(Delegate102.smethod_0(), Settings.Default.EndDate) && !Settings.Default.IsActive)
			{
				Delegate113.smethod_0(this.main);
				Delegate234.smethod_0("Your Free Version Has Been Expired", "INFO", MessageBoxButton.OK, MessageBoxImage.Asterisk);
				Delegate95.smethod_0(new Login());
				return;
			}
			if (!Settings.Default.IsActive)
			{
				Delegate234.smethod_0("Your Are Using Free Version", "INFO", MessageBoxButton.OK, MessageBoxImage.Asterisk);
				return;
			}
			Delegate234.smethod_0("Your Are Using Pro Version", "INFO", MessageBoxButton.OK, MessageBoxImage.Asterisk);
		}

		// Token: 0x04000046 RID: 70
		private readonly Main main;
	}
}

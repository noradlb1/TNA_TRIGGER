using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ValorantAimbotUI.Properties
{
	// Token: 0x0200001C RID: 28
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.7.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00002A38 File Offset: 0x00000C38
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00002A3F File Offset: 0x00000C3F
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00002A51 File Offset: 0x00000C51
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool isTriggerbot
		{
			get
			{
				return (bool)Delegate10.smethod_0(this, "isTriggerbot");
			}
			set
			{
				Delegate296.smethod_0(this, "isTriggerbot", value);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00002A64 File Offset: 0x00000C64
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00002A76 File Offset: 0x00000C76
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool isAimbot
		{
			get
			{
				return (bool)Delegate10.smethod_0(this, "isAimbot");
			}
			set
			{
				Delegate296.smethod_0(this, "isAimbot", value);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00002A89 File Offset: 0x00000C89
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00002A9B File Offset: 0x00000C9B
		[DefaultSettingValue("1")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public decimal speed
		{
			get
			{
				return (decimal)Delegate10.smethod_0(this, "speed");
			}
			set
			{
				Delegate296.smethod_0(this, "speed", value);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00002AAE File Offset: 0x00000CAE
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("100")]
		public int fovX
		{
			get
			{
				return (int)Delegate10.smethod_0(this, "fovX");
			}
			set
			{
				Delegate296.smethod_0(this, "fovX", value);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00002AD3 File Offset: 0x00000CD3
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00002AE5 File Offset: 0x00000CE5
		[DefaultSettingValue("100")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public int fovY
		{
			get
			{
				return (int)Delegate10.smethod_0(this, "fovY");
			}
			set
			{
				Delegate296.smethod_0(this, "fovY", value);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00002AF8 File Offset: 0x00000CF8
		// (set) Token: 0x06000115 RID: 277 RVA: 0x00002B0A File Offset: 0x00000D0A
		[DefaultSettingValue("0")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public int color
		{
			get
			{
				return (int)Delegate10.smethod_0(this, "color");
			}
			set
			{
				Delegate296.smethod_0(this, "color", value);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00002B1D File Offset: 0x00000D1D
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00002B2F File Offset: 0x00000D2F
		[DefaultSettingValue("164")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public int mainAimKey
		{
			get
			{
				return (int)Delegate10.smethod_0(this, "mainAimKey");
			}
			set
			{
				Delegate296.smethod_0(this, "mainAimKey", value);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00002B42 File Offset: 0x00000D42
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00002B54 File Offset: 0x00000D54
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool isHold
		{
			get
			{
				return (bool)Delegate10.smethod_0(this, "isHold");
			}
			set
			{
				Delegate296.smethod_0(this, "isHold", value);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00002B67 File Offset: 0x00000D67
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00002B79 File Offset: 0x00000D79
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool isAimKey
		{
			get
			{
				return (bool)Delegate10.smethod_0(this, "isAimKey");
			}
			set
			{
				Delegate296.smethod_0(this, "isAimKey", value);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00002B8C File Offset: 0x00000D8C
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002B9E File Offset: 0x00000D9E
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("0")]
		public int monitor
		{
			get
			{
				return (int)Delegate10.smethod_0(this, "monitor");
			}
			set
			{
				Delegate296.smethod_0(this, "monitor", value);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00002BB1 File Offset: 0x00000DB1
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00002BC3 File Offset: 0x00000DC3
		[DefaultSettingValue("5")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public int offsetY
		{
			get
			{
				return (int)Delegate10.smethod_0(this, "offsetY");
			}
			set
			{
				Delegate296.smethod_0(this, "offsetY", value);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00002BD6 File Offset: 0x00000DD6
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00002BE8 File Offset: 0x00000DE8
		[DefaultSettingValue("130")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public int msShootTime
		{
			get
			{
				return (int)Delegate10.smethod_0(this, "msShootTime");
			}
			set
			{
				Delegate296.smethod_0(this, "msShootTime", value);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00002BFB File Offset: 0x00000DFB
		// (set) Token: 0x06000123 RID: 291 RVA: 0x00002C0D File Offset: 0x00000E0D
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool isFirstOpen
		{
			get
			{
				return (bool)Delegate10.smethod_0(this, "isFirstOpen");
			}
			set
			{
				Delegate296.smethod_0(this, "isFirstOpen", value);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00002C6A File Offset: 0x00000E6A
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00002C7C File Offset: 0x00000E7C
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool IsActive
		{
			get
			{
				return (bool)Delegate10.smethod_0(this, "IsActive");
			}
			set
			{
				Delegate296.smethod_0(this, "IsActive", value);
			}
		}

		// Token: 0x040000B6 RID: 182
		private static Settings defaultInstance = (Settings)Delegate264.smethod_0(new Settings());
	}
}

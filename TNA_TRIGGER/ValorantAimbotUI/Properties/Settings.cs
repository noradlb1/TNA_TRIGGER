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
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00002C20 File Offset: 0x00000E20
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00002C32 File Offset: 0x00000E32
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public DateTime StartDate
		{
			get
			{
				return (DateTime)Delegate10.smethod_0(this, "StartDate");
			}
			set
			{
				Delegate296.smethod_0(this, "StartDate", value);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00002C45 File Offset: 0x00000E45
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00002C57 File Offset: 0x00000E57
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public DateTime EndDate
		{
			get
			{
				return (DateTime)Delegate10.smethod_0(this, "EndDate");
			}
			set
			{
				Delegate296.smethod_0(this, "EndDate", value);
			}
		}
	}
}

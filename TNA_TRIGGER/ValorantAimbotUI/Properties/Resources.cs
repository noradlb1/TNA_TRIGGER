using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ValorantAimbotUI.Properties
{
	// Token: 0x0200001B RID: 27
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[CompilerGenerated]
	[DebuggerNonUserCode]
	internal class Resources
	{
		// Token: 0x06000104 RID: 260 RVA: 0x0000219C File Offset: 0x0000039C
		internal Resources()
		{
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000105 RID: 261 RVA: 0x000029E7 File Offset: 0x00000BE7
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = Delegate112.smethod_0("ValorantAimbotUI.Properties.Resources", Delegate25.smethod_0(Delegate340.smethod_0(typeof(Resources).TypeHandle)));
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00002A13 File Offset: 0x00000C13
		// (set) Token: 0x06000107 RID: 263 RVA: 0x00002A1A File Offset: 0x00000C1A
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00002A22 File Offset: 0x00000C22
		internal static UnmanagedMemoryStream david_kushner_daylight__slowed_reverb___64_kbps_
		{
			get
			{
				return Delegate347.smethod_0(Resources.ResourceManager, "david_kushner_daylight__slowed_reverb___64_kbps_", Resources.resourceCulture);
			}
		}

		// Token: 0x040000B4 RID: 180
		private static ResourceManager resourceMan;

		// Token: 0x040000B5 RID: 181
		private static CultureInfo resourceCulture;
	}
}

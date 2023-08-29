using System;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

// Token: 0x020001A2 RID: 418
public class GClass12
{
	// Token: 0x0600060E RID: 1550 RVA: 0x00010754 File Offset: 0x0000E954
	public GClass12(long long_1)
	{
		object[] array = new object[]
		{
			this,
			long_1
		};
		new GClass18().method_112(array, 47618);
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x0001078C File Offset: 0x0000E98C
	public GClass12(byte[] byte_2)
	{
		object[] array = new object[]
		{
			this,
			byte_2
		};
		new GClass18().method_112(array, 43948);
	}

	// Token: 0x04000156 RID: 342
	private readonly byte[] byte_0;

	// Token: 0x04000157 RID: 343
	private byte[] byte_1;

	// Token: 0x04000158 RID: 344
	private readonly object object_0;

	// Token: 0x04000159 RID: 345
	private GEnum0 genum0_0;

	// Token: 0x0400015A RID: 346
	private long long_0;

	// Token: 0x0400015B RID: 347
	private readonly int int_0;

	// Token: 0x0400015C RID: 348
	private int int_1;

	// Token: 0x0400015D RID: 349
	private uint uint_0;

	// Token: 0x020001A3 RID: 419
	public class GClass13
	{
		// Token: 0x06000610 RID: 1552 RVA: 0x000107C0 File Offset: 0x0000E9C0
		protected bool method_0(byte[] byte_0)
		{
			int num = BitConverter.ToInt32(byte_0, 32);
			if (num == 0)
			{
				return false;
			}
			int index = BitConverter.ToInt32(byte_0, 28);
			this.String_0 = Encoding.UTF8.GetString(byte_0, index, num);
			if (this.String_0[this.String_0.Length - 1] != '/')
			{
				this.String_0 += "/";
			}
			return true;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00003356 File Offset: 0x00001556
		protected void method_1()
		{
			this.String_0 = Convert.ToBase64String(Encoding.UTF8.GetBytes(this.String_0));
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00003373 File Offset: 0x00001573
		protected void method_2(string string_2, string string_3)
		{
			this.method_3(string_2, false);
			this.method_3(string_3, true);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0001082C File Offset: 0x0000EA2C
		private void method_3(string string_2, bool bool_0)
		{
			if (bool_0)
			{
				StringBuilder stringBuilder = new StringBuilder(this.String_0);
				foreach (char c in string_2)
				{
					if (c != '+')
					{
						if (c != '/')
						{
							if (c != '=')
							{
								stringBuilder.Append(c);
							}
							else
							{
								stringBuilder.Append("%3D");
							}
						}
						else
						{
							stringBuilder.Append("%2F");
						}
					}
					else
					{
						stringBuilder.Append("%2B");
					}
				}
				this.String_0 = stringBuilder.ToString();
				return;
			}
			this.String_0 += string_2;
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x00003385 File Offset: 0x00001585
		// (set) Token: 0x06000615 RID: 1557 RVA: 0x0000338D File Offset: 0x0000158D
		public string String_0 { get; private set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x00003396 File Offset: 0x00001596
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x0000339E File Offset: 0x0000159E
		public string String_1 { get; private set; }

		// Token: 0x06000619 RID: 1561 RVA: 0x000108C4 File Offset: 0x0000EAC4
		public unsafe static object smethod_0(void* pVoid_0)
		{
			return Pointer.Box(pVoid_0, typeof(void*));
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x000108E4 File Offset: 0x0000EAE4
		public unsafe static void* smethod_1(object object_0)
		{
			return Pointer.Unbox(object_0);
		}

		// Token: 0x0400015E RID: 350
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400015F RID: 351
		[CompilerGenerated]
		private string string_1;

		// Token: 0x020001A4 RID: 420
		[CompilerGenerated]
		[Serializable]
		private sealed class Class5
		{
			// Token: 0x0600061D RID: 1565 RVA: 0x00002459 File Offset: 0x00000659
			internal bool method_0(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
			{
				return true;
			}

			// Token: 0x04000160 RID: 352
			public static readonly GClass12.GClass13.Class5 class5_0 = new GClass12.GClass13.Class5();

			// Token: 0x04000161 RID: 353
			public static RemoteCertificateValidationCallback remoteCertificateValidationCallback_0;
		}
	}

	// Token: 0x020001A5 RID: 421
	public class GClass14 : GClass12.GClass13
	{
		// Token: 0x04000162 RID: 354
		[CompilerGenerated]
		private string string_2;
	}

	// Token: 0x020001A6 RID: 422
	public class GClass15 : GClass12.GClass13
	{
	}
}

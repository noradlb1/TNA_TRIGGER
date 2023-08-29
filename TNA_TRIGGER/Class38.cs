using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x020001CB RID: 459
internal static class Class38
{
	// Token: 0x06000815 RID: 2069
	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, int int_5, int int_6, IntPtr intptr_3, int int_7, int int_8, IntPtr intptr_4);

	// Token: 0x06000816 RID: 2070
	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CreateFileMapping(IntPtr intptr_3, IntPtr intptr_4, Class38.Enum2 enum2_0, int int_5, int int_6, string string_0);

	// Token: 0x06000817 RID: 2071
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool FlushViewOfFile(IntPtr intptr_3, int int_5);

	// Token: 0x06000818 RID: 2072
	[DllImport("kernel32", SetLastError = true)]
	public static extern IntPtr MapViewOfFile(IntPtr intptr_3, Class38.Enum3 enum3_0, int int_5, int int_6, IntPtr intptr_4);

	// Token: 0x06000819 RID: 2073
	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr OpenFileMapping(int int_5, bool bool_0, string string_0);

	// Token: 0x0600081A RID: 2074
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool UnmapViewOfFile(IntPtr intptr_3);

	// Token: 0x0600081B RID: 2075
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool CloseHandle(IntPtr intptr_3);

	// Token: 0x0600081C RID: 2076
	[DllImport("kernel32", SetLastError = true)]
	public static extern uint GetFileSize(IntPtr intptr_3, IntPtr intptr_4);

	// Token: 0x0600081D RID: 2077
	[DllImport("kernel32", SetLastError = true)]
	public static extern IntPtr VirtualAlloc(IntPtr intptr_3, UIntPtr uintptr_0, Class38.Enum1 enum1_0, Class38.Enum2 enum2_0);

	// Token: 0x0600081E RID: 2078
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool VirtualFree(IntPtr intptr_3, uint uint_0, uint uint_1);

	// Token: 0x0600081F RID: 2079
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool VirtualProtect(IntPtr intptr_3, UIntPtr uintptr_0, Class38.Enum2 enum2_0, out Class38.Enum2 enum2_1);

	// Token: 0x06000820 RID: 2080
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool GetVolumeInformation(string string_0, StringBuilder stringBuilder_0, uint uint_0, ref uint uint_1, ref uint uint_2, ref uint uint_3, StringBuilder stringBuilder_1, uint uint_4);

	// Token: 0x06000821 RID: 2081
	[DllImport("kernel32")]
	public static extern bool IsDebuggerPresent();

	// Token: 0x06000822 RID: 2082
	[DllImport("kernel32")]
	public static extern bool CheckRemoteDebuggerPresent();

	// Token: 0x06000823 RID: 2083
	[DllImport("kernel32", SetLastError = true)]
	public static extern uint EnumSystemFirmwareTables(uint uint_0, IntPtr intptr_3, uint uint_1);

	// Token: 0x06000824 RID: 2084
	[DllImport("kernel32", SetLastError = true)]
	public static extern uint GetSystemFirmwareTable(uint uint_0, uint uint_1, IntPtr intptr_3, uint uint_2);

	// Token: 0x06000825 RID: 2085
	[DllImport("ntdll")]
	public static extern int NtQueryInformationProcess(IntPtr intptr_3, int int_5, IntPtr intptr_4, uint uint_0, out uint uint_1);

	// Token: 0x040001A0 RID: 416
	public const int int_0 = -2147483648;

	// Token: 0x040001A1 RID: 417
	public const int int_1 = 3;

	// Token: 0x040001A2 RID: 418
	public const int int_2 = 128;

	// Token: 0x040001A3 RID: 419
	public const int int_3 = 1;

	// Token: 0x040001A4 RID: 420
	public const int int_4 = 2;

	// Token: 0x040001A5 RID: 421
	public static readonly IntPtr intptr_0 = new IntPtr(-1);

	// Token: 0x040001A6 RID: 422
	public static readonly IntPtr intptr_1 = IntPtr.Zero;

	// Token: 0x040001A7 RID: 423
	public static readonly IntPtr intptr_2 = new IntPtr(-1);

	// Token: 0x020001CC RID: 460
	[Flags]
	public enum Enum1 : uint
	{
		// Token: 0x040001A9 RID: 425
		flag_0 = 4096U,
		// Token: 0x040001AA RID: 426
		flag_1 = 8192U
	}

	// Token: 0x020001CD RID: 461
	[Flags]
	public enum Enum2 : uint
	{
		// Token: 0x040001AC RID: 428
		flag_0 = 1U,
		// Token: 0x040001AD RID: 429
		flag_1 = 2U,
		// Token: 0x040001AE RID: 430
		flag_2 = 4U,
		// Token: 0x040001AF RID: 431
		flag_3 = 8U,
		// Token: 0x040001B0 RID: 432
		flag_4 = 16U,
		// Token: 0x040001B1 RID: 433
		flag_5 = 32U,
		// Token: 0x040001B2 RID: 434
		flag_6 = 64U,
		// Token: 0x040001B3 RID: 435
		flag_7 = 256U
	}

	// Token: 0x020001CE RID: 462
	[Flags]
	public enum Enum3 : uint
	{
		// Token: 0x040001B5 RID: 437
		flag_0 = 1U,
		// Token: 0x040001B6 RID: 438
		flag_1 = 2U,
		// Token: 0x040001B7 RID: 439
		flag_2 = 4U,
		// Token: 0x040001B8 RID: 440
		flag_3 = 31U
	}

	// Token: 0x020001CF RID: 463
	[Flags]
	public enum Enum4 : uint
	{
		// Token: 0x040001BA RID: 442
		flag_0 = 536870912U,
		// Token: 0x040001BB RID: 443
		flag_1 = 1073741824U,
		// Token: 0x040001BC RID: 444
		flag_2 = 2147483648U
	}
}

using System;
using System.Runtime.InteropServices;

// Token: 0x02000198 RID: 408
public static class GClass5
{
	// Token: 0x060005EE RID: 1518 RVA: 0x0000FD20 File Offset: 0x0000DF20
	public static int[] smethod_0(int int_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		int[] result;
		try
		{
			byte[] array = (IntPtr.Size == 4) ? GClass5.byte_0 : GClass5.byte_1;
			intPtr = Class38.VirtualAlloc(IntPtr.Zero, new UIntPtr((uint)array.Length), Class38.Enum1.flag_0 | Class38.Enum1.flag_1, Class38.Enum2.flag_6);
			Marshal.Copy(array, 0, intPtr, array.Length);
			GClass5.Delegate358 @delegate = (GClass5.Delegate358)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(GClass5.Delegate358));
			GCHandle a = default(GCHandle);
			int[] array2 = new int[4];
			try
			{
				a = GCHandle.Alloc(array2, GCHandleType.Pinned);
				@delegate(int_0, array2);
			}
			finally
			{
				if (a != default(GCHandle))
				{
					a.Free();
				}
			}
			result = array2;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Class38.VirtualFree(intPtr, 0U, 32768U);
			}
		}
		return result;
	}

	// Token: 0x0400013C RID: 316
	private static readonly byte[] byte_0 = new byte[]
	{
		85,
		139,
		236,
		83,
		87,
		139,
		69,
		8,
		15,
		162,
		139,
		125,
		12,
		137,
		7,
		137,
		95,
		4,
		137,
		79,
		8,
		137,
		87,
		12,
		95,
		91,
		139,
		229,
		93,
		195
	};

	// Token: 0x0400013D RID: 317
	private static readonly byte[] byte_1 = new byte[]
	{
		83,
		73,
		137,
		208,
		137,
		200,
		15,
		162,
		65,
		137,
		64,
		0,
		65,
		137,
		88,
		4,
		65,
		137,
		72,
		8,
		65,
		137,
		80,
		12,
		91,
		195
	};

	// Token: 0x02000199 RID: 409
	// (Invoke) Token: 0x060005F1 RID: 1521
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void Delegate358(int int_0, int[] int_1);
}

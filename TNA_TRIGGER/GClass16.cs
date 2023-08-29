using System;

// Token: 0x020001A7 RID: 423
public static class GClass16
{
	// Token: 0x0600061E RID: 1566 RVA: 0x000108F8 File Offset: 0x0000EAF8
	internal static bool smethod_0(byte[] byte_0)
	{
		for (int i = 0; i < byte_0.Length; i++)
		{
			if (i + 3 < byte_0.Length && byte_0[i] == 81 && byte_0[i + 1] == 69 && byte_0[i + 2] == 77 && byte_0[i + 3] == 85)
			{
				return true;
			}
			if (i + 8 < byte_0.Length && byte_0[i] == 77 && byte_0[i + 1] == 105 && byte_0[i + 2] == 99 && byte_0[i + 3] == 114 && byte_0[i + 4] == 111 && byte_0[i + 5] == 115 && byte_0[i + 6] == 111 && byte_0[i + 7] == 102 && byte_0[i + 8] == 116)
			{
				return true;
			}
			if (i + 6 < byte_0.Length && byte_0[i] == 105 && byte_0[i + 1] == 110 && byte_0[i + 2] == 110 && byte_0[i + 3] == 111 && byte_0[i + 4] == 116 && byte_0[i + 5] == 101 && byte_0[i + 6] == 107)
			{
				return true;
			}
			if (i + 9 < byte_0.Length && byte_0[i] == 86 && byte_0[i + 1] == 105 && byte_0[i + 2] == 114 && byte_0[i + 3] == 116 && byte_0[i + 4] == 117 && byte_0[i + 5] == 97 && byte_0[i + 6] == 108 && byte_0[i + 7] == 66 && byte_0[i + 8] == 111 && byte_0[i + 9] == 120)
			{
				return true;
			}
			if (i + 5 < byte_0.Length && byte_0[i] == 86 && byte_0[i + 1] == 77 && byte_0[i + 2] == 119 && byte_0[i + 3] == 97 && byte_0[i + 4] == 114 && byte_0[i + 5] == 101)
			{
				return true;
			}
			if (i + 8 < byte_0.Length && byte_0[i] == 80 && byte_0[i + 1] == 97 && byte_0[i + 2] == 114 && byte_0[i + 3] == 97 && byte_0[i + 4] == 108 && byte_0[i + 5] == 108 && byte_0[i + 6] == 101 && byte_0[i + 7] == 108 && byte_0[i + 8] == 115)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x04000163 RID: 355
	public static object[] object_0;
}

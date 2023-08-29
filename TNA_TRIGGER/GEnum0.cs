using System;

// Token: 0x02000193 RID: 403
[Flags]
public enum GEnum0
{
	// Token: 0x0400011C RID: 284
	Success = 0,
	// Token: 0x0400011D RID: 285
	Corrupted = 1,
	// Token: 0x0400011E RID: 286
	Invalid = 2,
	// Token: 0x0400011F RID: 287
	Blacklisted = 4,
	// Token: 0x04000120 RID: 288
	DateExpired = 8,
	// Token: 0x04000121 RID: 289
	RunningTimeOver = 16,
	// Token: 0x04000122 RID: 290
	BadHwid = 32,
	// Token: 0x04000123 RID: 291
	MaxBuildExpired = 64
}

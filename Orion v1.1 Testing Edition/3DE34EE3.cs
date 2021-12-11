using System;

[Flags]
public enum _3DE34EE3
{
	Success = 0x0,
	Corrupted = 0x1,
	Invalid = 0x2,
	Blacklisted = 0x4,
	DateExpired = 0x8,
	RunningTimeOver = 0x10,
	BadHwid = 0x20,
	MaxBuildExpired = 0x40
}

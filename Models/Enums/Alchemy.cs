using System;
using static IO.Models.Enums.BitOffset32;
using static IO.Models.Enums.BitOffset64;

namespace SoE.Models.Enums
{
	/// <summary>
	/// The alchemies the boy can learn
	/// </summary>
	/// <remarks>48 bits (38 used)</remarks>
	[Flags]
	public enum Alchemy: UInt64
	{
		None = 0x0,

		// byte 1
		AcidRain = 0x1,
		Atlas = 0x2,
		Barrier = 0x4,
		CallUp = 0x8,
		Corrosion = 0x10,
		Crush = 0x20,
		Cure = 0x40,
		Defend = 0x80,

		// byte 2
		DoubleDrain = 0x1 + Offset8,
		Drain = 0x2 + Offset8,
		Energize = 0x4 + Offset8,
		Escape = 0x8 + Offset8,
		Explosion = 0x10 + Offset8,
		FireBall = 0x20 + Offset8,
		FirePower = 0x40 + Offset8,
		Flash = 0x80 + Offset8,

		// byte 3
		ForceField = 0x1 + Offset16,
		HardBall = 0x2 + Offset16,
		Heal = 0x4 + Offset16,
		Lance = 0x8 + Offset16,
		Laser = 0x10 + Offset16,
		Levitate = 0x20 + Offset16,
		LightningStorm = 0x40 + Offset16,
		MiracleCure = 0x80 + Offset16,

		// byte 4
		Nitro = 0x1 + Offset24,
		OneUp = 0x2 + Offset24,
		Reflect = 0x4 + Offset24,
		Regrowth = 0x8 + Offset24,
		Revealer = 0x10 + Offset24,
		Revive = 0x20 + Offset24,
		SlowBurn = 0x40 + Offset24,
		Speed = 0x80 + Offset24,

		// byte 5
		Sting = 0x1 + Offset32,
		Stop = 0x2 + Offset32,
		SuperHeal = 0x4 + Offset32,

		Unknown1 = 0x8 + Offset32,
		Unknown2 = 0x10 + Offset32,
		Unknown3 = 0x20 + Offset32,
		Unknown4 = 0x40 + Offset32,
		Horace = 0x80 + Offset32,

		// byte 6
		Camellia = 0x1 + Offset40,
		Sidney = 0x2 + Offset40,
		Unknown5 = 0x4 + Offset40,
		Unknown6 = 0x8 + Offset40,
		Unknown7 = 0x10 + Offset40,
		Unknown8 = 0x20 + Offset40,
		Unknown9 = 0x40 + Offset40,
		Unknown10 = 0x80 + Offset40
	}
}
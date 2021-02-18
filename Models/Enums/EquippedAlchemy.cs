namespace SoE.Models.Enums
{
	/// <summary>
	/// The alchemies the boy can equip
	/// </summary>
	/// <remarks>1 byte</remarks>
	public enum EquippedAlchemy: byte
	{
		// byte 1
		AcidRain = 0,
		Atlas = 2,
		Barrier = 4,
		CallUp = 6,
		Corrosion = 8,
		Crush = 10,
		Cure = 12,
		Defend = 14,

		// byte 2
		DoubleDrain = 16,
		Drain = 18,
		Energize = 20,
		Escape = 22,
		Explosion = 24,
		FireBall = 26,
		FirePower = 28,
		Flash = 30,

		// byte 3
		ForceField = 32,
		HardBall = 34,
		Heal = 36,
		Lance = 38,
		Laser = 40,
		Levitate = 42,
		LightningStorm = 44,
		MiracleCure = 46,

		// byte 4
		Nitro = 48,
		OneUp = 50,
		Reflect = 52,
		Regrowth = 54,
		Revealer = 56,
		Revive = 58,
		SlowBurn = 60,
		Speed = 62,

		// byte 5
		Sting = 64,
		Stop = 66,
		SuperHeal = 68
	}
}
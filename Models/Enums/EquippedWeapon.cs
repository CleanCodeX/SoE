using System;

namespace SoE.Models.Enums
{
	/// <summary>
	/// The boy's equipped weapon
	/// </summary>
	[Flags]
	public enum EquippedWeapon : UInt16
	{
		BareHands = 0, // Never used

		// Swords
		BoneCrusher = 2,
		GladiatorSword = 4,
		CrusaderSword = 6,
		NeutronBlade = 8,

		// Axes
		SpidersClaw = 10,
		BronzeAxe = 12,
		KnightBasher = 14,

		AtomSmasher = 16,

		// Spears
		HornSpear = 18,
		BronzeSpear = 20,
		LanceWeapon = 22,
		LaserLance = 24,

		// Bazooka
		Bazooka = 26
	}
}
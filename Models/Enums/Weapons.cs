using System;

namespace SoE.Models.Enums
{
	/// <summary>
	/// The boy's weapons and optional call bead spells
	/// </summary>
	/// <remarks>16 bis (all used)</remarks>
	[Flags]
	public enum Weapons : UInt16
	{
		/* byte 1 */

		BareHands = 0x1, // Never used

		// Swords
		BoneCrusher = 0x2,
		GladiatorSword = 0x4,
		CrusaderSword = 0x8,
		NeutronBlade = 0x10,

		// Axes
		SpidersClaw = 0x20,
		BronzeAxe = 0x40,
		KnightBasher = 0x80,

		/* byte 2 */

		AtomSmasher = 0x1 + 0xFF,

		// Spears
		HornSpear = 0x2 + 0xFF,
		BronzeSpear = 0x4 + 0xFF,
		LanceWeapon = 0x8 + 0xFF,
		LaserLance = 0x10 + 0xFF,

		// Bazooka
		Bazooka = 0x20 + 0xFF,

		// Call bead spells
		HoraceAura = 0x40 + 0xFF, 
		HoraceRegenerate = 0x80 + 0xFF
	}
}
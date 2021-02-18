using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SoE.Models.Structs
{
	/// <summary>
	/// The boy's weapon levels
	/// </summary>
	/// <remarks>28 bytes</remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2, Size = 28)]
	public struct WeaponLevels
	{
		// you can't ever fight with them
		public WeaponLevel BareHands; // [$7E:0ADD]

		// %256 * 100 gives in-game display)
		public WeaponLevel BoneCrusher;  // [$7E:0ADF]
		public WeaponLevel GladiatorSword; // [$7E:0AE1]
		public WeaponLevel CrusaderSword; // [$7E:0AE3]
		public WeaponLevel NeutronBlade; // [$7E:0AE5]

		public WeaponLevel SpidersClaw; // [$7E:0AE7]
		public WeaponLevel BronzeAxe; // [$7E:0AE9]
		public WeaponLevel KnightBasher; // [$7E:0AEB]
		public WeaponLevel AtomSmasher; // [$7E:0AED]

		public WeaponLevel HornSpear; // [$7E:0AEF]
		public WeaponLevel BronzeSpear; // [$7E:0AF1]
		public WeaponLevel LanceWeapon; // [$7E:0AF3]
		public WeaponLevel LaserLance; // [$7E:0AF5]

		// high part never initialized to 1 like the other weapons are, and its default of 0 causes bugs with the computer-controlled character and with Energize.
		public WeaponLevel Bazooka;  // [$7E:0AF7]
	}
}
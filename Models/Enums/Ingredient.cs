using System;

namespace SoE.Models.Enums
{
	/// <summary>
	/// The available ingredients alchemies can have
	/// </summary>
	/// <remarks>Max value by the game: 99</remarks>
	[Flags]
	public enum Ingredient : UInt32
	{
		// byte 1
		Wax = 0x1,
		Water = 0x2,
		Vinegar = 0x4,
		Root = 0x8,
		Oil = 0x10,
		Mushroom = 0x20,
		MudPepper = 0x40,
		Meteorite = 0x80,

		// byte 2
		Limestone = 0x1 + 0xFF,
		Iron = 0x2 + 0xFF,
		GunPowder = 0x4 + 0xFF,
		Grease = 0x8 + 0xFF,
		Feather = 0x10 + 0xFF,
		Ethanol = 0x20 + 0xFF,
		Dryice = 0x40 + 0xFF,
		Crystal = 0x80 + 0xFF,

		// byte 3
		Clay = 0x1 + 0xFFFF,
		Brimstone = 0x2 + 0xFFFF,
		Bone = 0x4 + 0xFFFF,
		AtlasMedallion = 0x8 + 0xFFFF,
		Ash = 0x10 + 0xFFFF,
		Acorn = 0x20 + 0xFFFF,

#if false
		Unknown1 = 0x40 + 0xFFFF,
		Unknown2 = 0x80 + 0xFFFF
#endif
	}
}
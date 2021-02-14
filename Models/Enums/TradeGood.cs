using System;

namespace SoE.Models.Enums
{
	/// <summary>
	/// The market trading goods
	/// </summary>
	/// <remarks>16 bits (13 bits used)</remarks>
	[Flags]
	public enum TradeGood : UInt16
	{
		// byte 1
		AnnihilationAmulet = 0x1,
		Beads = 0x2,
		CeramicPot = 0x4,
		Chicken = 0x8,
		GoldenJackal = 0x10,
		JeweledScarab = 0x20,
		LimestoneTablet = 0x40,
		Perfume = 0x80,

		// byte 2
		Rice = 0x1 + 0xFF,
		Spice = 0x2 + 0xFF,
		SouvenirSpoon = 0x4 + 0xFF,
		Tapestry = 0x8 + 0xFF,
		TicketForExhibition = 0x10 + 0xFF,

		// bits 0x20 - 0x80 Unknown
		Unknown1 = 0x20 + 0xFF,
		Unknown2 = 0x40 + 0xFF,
		Unknown3 = 0x80 + 0xFF,
	}
}
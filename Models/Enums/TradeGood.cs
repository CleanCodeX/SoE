using System;

namespace SoE.Models.Enums
{
	/// <summary>
	/// The market trading goods
	/// </summary>
	/// <remarks>16 bits (13 bits used)</remarks>
	public enum TradeGood : UInt16
	{
		AnnihilationAmulet,
		Beads,
		CeramicPot,
		Chicken,
		GoldenJackal,
		JeweledScarab,
		LimestoneTablet,
		Perfume,

		Rice,
		Spice,
		SouvenirSpoon,
		Tapestry,
		TicketForExhibition

		// bits 0x20 - 0x80 Unknown
	}
}
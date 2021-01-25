namespace SoE.Models.Enums
{
	/// <summary>
	/// The armors the boy can possess
	/// </summary>
	/// <remarks>40 bits (all used)</remarks>
	/// <remarks>Max value by the game: 99</remarks>
	public enum Armor : ulong 
	{
		/* Byte 1 */

		// Vests
		GrassVest,
		ShellPlate,
		DinoSkin,
		BronzeArmor,
		StoneVest,
		CenturionCape,
		SilverMail,
		GoldPlatedVest,

		/* Byte 2 */

		ShiningArmor,
		MagnaMail,
		TitaniumVest,
		VirtualVest,

		// Hats
		GrassHat,
		ShellHat,
		DinoHelmet,
		BronzeHelmet,

		/* Byte 3 */

		ObsidianHelmet,
		CenturionHelmet,
		TitansCrown,
		DragonHelmet,
		KnightsHelmet,
		LightningHelmet,
		OldReliable,
		BrainStorm,

		/* Byte 4 */

		// Bracelets
		VineBracelet,
		MammothGuard,
		ClawGuard,
		SerpentBracer,
		BronzeGauntlet,
		GlovesOfRa,
		IronBracer,
		MagiciansRing,

		/* Byte 5 */

		DragonsClaw,
		CyberGlove,
		ProtectorRing,
		VirtualGlove,

		// Collars
		LeatherCollar,
		SpikyCollar,
		DefenderCollar,
		SpotsCollar,
	}
}
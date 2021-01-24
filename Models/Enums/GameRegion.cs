using Common.Shared.Min.Attributes;
using Res = SoE.Properties.Resources;

namespace SoE.Models.Enums
{
	/// The game's regions
	public enum GameRegion
	{
		[DisplayNameLocalized(nameof(Res.EnglishNtsc), typeof(Res))]
		EnglishNtsc,

		[DisplayNameLocalized(nameof(Res.EnglishPal), typeof(Res))]
		EnglishPal,

		[DisplayNameLocalized(nameof(Res.French), typeof(Res))]
		French,

		[DisplayNameLocalized(nameof(Res.German), typeof(Res))]
		German,

		[DisplayNameLocalized(nameof(Res.Spanish), typeof(Res))]
		Spanish
	}
}
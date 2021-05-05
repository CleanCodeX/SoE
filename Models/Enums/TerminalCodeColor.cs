using System;
using Common.Shared.Min.Attributes;
using SoE.Properties;

namespace SoE.Models.Enums
{
	public enum TerminalCodeColor : UInt16
	{
		[DisplayNameLocalized(nameof(Resources.Red), typeof(Resources))]
		Red = 1, // Value guessed

		[DisplayNameLocalized(nameof(Resources.Blue), typeof(Resources))]
		Blue = 2, // Value guessed

		[DisplayNameLocalized(nameof(Resources.Green), typeof(Resources))]
		Green = 3 // Value guessed
	}
}
using System.Diagnostics;
using System.Runtime.InteropServices;
using SoE.Models.Enums;

namespace SoE.Models.Structs
{
	/// <summary>
	/// The boy's equipped alchemy spells
	/// </summary>
	/// <remarks>9 bytes</remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 9)]
	public struct EquippedAlchemies
	{
		public EquippedAlchemy Spell9;
		public EquippedAlchemy Spell8;
		public EquippedAlchemy Spell7;
		public EquippedAlchemy Spell6;
		public EquippedAlchemy Spell5;
		public EquippedAlchemy Spell4;
		public EquippedAlchemy Spell3;
		public EquippedAlchemy Spell2;
		public EquippedAlchemy Spell1;
	}
}
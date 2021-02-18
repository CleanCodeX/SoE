using System.Diagnostics;
using System.Runtime.InteropServices;

// ReSharper disable BuiltInTypeReferenceStyle

namespace SoE.Models.Structs
{
	/// <summary>
	/// The boy's alchemy levels
	/// </summary>
	/// <remarks>70 bytes</remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 70)]
	public struct AlchemyLevels
	{
		public AlchemyLevel AcidRain;
		public AlchemyLevel Atlas;
		public AlchemyLevel Barrier;
		public AlchemyLevel CallUp;
		public AlchemyLevel Corrosion;
		public AlchemyLevel Crush;
		public AlchemyLevel Cure;
		public AlchemyLevel Defend;

		public AlchemyLevel DoubleDrain;
		public AlchemyLevel Drain;
		public AlchemyLevel Energize;
		public AlchemyLevel Escape;
		public AlchemyLevel Explosion;
		public AlchemyLevel FireBall;
		public AlchemyLevel FirePower;
		public AlchemyLevel Flash;

		public AlchemyLevel ForceField;
		public AlchemyLevel HardBall;
		public AlchemyLevel Heal;
		public AlchemyLevel Lance;
		public AlchemyLevel Laser;
		public AlchemyLevel Levitate;
		public AlchemyLevel LightningStorm;
		public AlchemyLevel MiracleCure;

		public AlchemyLevel Nitro;
		public AlchemyLevel OneUp;
		public AlchemyLevel Reflect;
		public AlchemyLevel Regrowth;
		public AlchemyLevel Revealer;
		public AlchemyLevel Revive;
		public AlchemyLevel SlowBurn;
		public AlchemyLevel Speed;

		public AlchemyLevel Sting;
		public AlchemyLevel Stop;
		public AlchemyLevel SuperHeal;
	}
}
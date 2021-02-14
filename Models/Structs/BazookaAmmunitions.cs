using System.Diagnostics;
using System.Runtime.InteropServices;
using SoE.Models.Enums;

namespace SoE.Models.Structs
{
	/// <summary>
	/// The bazooka ammunitions the boy can hold
	/// </summary>
	/// <remarks>4 bytes</remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct BazookaAmmunitions
	{
		public byte ThunderBall; // 0 - 99
		public byte ParticleBomb; // 0 - 99
		public byte CryoBlast; // 0 - 99
		public BazookaAmmunition CurrentAmmunitionType; // (1 byte)
	}
}
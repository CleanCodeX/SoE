using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SoE.Models.Structs
{
	/// <summary>
	/// The bazooka ammunitions the boy can hold
	/// </summary>
	/// <remarks>4 bytes</remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 3)]
	public struct BazookaAmmunitions
	{
		public byte ThunderBall; // 0 - 99
		public byte ParticleBomb; // 0 - 99
		public byte CryoBlast; // 0 - 99
	}
}
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SoE.Models.Structs
{
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2, Size = 2)]
	public struct WeaponLevel
	{
		public byte Minor; // 0-255
		public byte Major; // 1-3
		
		public override string ToString() => $"{Major}:{Minor}";
	}
}
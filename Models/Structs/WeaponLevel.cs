using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Helpers;

namespace SoE.Models.Structs
{
	[HasToStringOverride]
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct WeaponLevel
	{
		public byte Minor; // 0-255
		public byte Major; // 1-3
		
		public override string ToString() => $"{Major}.{Minor}";
	}
}
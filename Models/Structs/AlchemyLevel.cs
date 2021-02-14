using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Helpers;

namespace SoE.Models.Structs
{
	[HasToStringOverride]
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct AlchemyLevel
	{
		public byte Minor; // 0-255
		public byte Major; // 0-8
		
		public override string ToString() => Minor.ToString();
	}
}
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SoE.Models.Structs
{
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2, Size = 2)]
	public struct AlchemyLevel
	{
		public byte Low; 
		public byte High; // Not used
		
		public override string ToString() => $"{Low}";
	}
}
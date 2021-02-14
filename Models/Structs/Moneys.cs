using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Helpers;
using IO.Models.Structs;

namespace SoE.Models.Structs
{
	/// <summary>
	/// The money the characters can hold
	/// </summary>
	/// <remarks>12 bytes, 3 bytes each (16.7M)</remarks>
	[HasToStringOverride]
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
	public struct Moneys
	{
		// [S:252|xFC] [$7E:0AC6] 
		public UInt24 Talons;

		// [S:255|0xFF] [$7E:0AC9] 
		public UInt24 Jewels;

		// [S:258|0x102] [$7E:0ACC] 
		public UInt24 GoldCoins;

		// [S:261|0x105] [$7E:0ACF]
		public UInt24 Credits; 

		public override string ToString() => $"T: {Talons} | J: {Jewels} | GC: {GoldCoins} | C: {Credits}";
	}
}
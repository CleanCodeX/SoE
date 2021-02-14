using System.Runtime.InteropServices;
using IO.Extensions;
using IO.Helpers;

namespace SoE.Models.Structs
{
	/// <summary>
	/// Ingredient SniffSpots
	/// </summary>
	/// <remarks>89 bytes</remarks>
	[HasToStringOverride]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct IngredientSniffSpots
	{
		// Unknown 16
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 89)]
		public byte[] SniffSpots; // [520|x208] (89 bytes)

		public override string ToString() => SniffSpots.Format();
	}
}
using System.Runtime.InteropServices;
using IO.Extensions;

namespace SoE.Models.Structs
{
	/// <summary>
	/// Ingredient SniffSpots
	/// </summary>
	/// <remarks>89 bytes</remarks>
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 89)]
	public struct IngredientSniffSpots
	{
		// Unknown 16
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 89)]
		public byte[] Data; // [520|x208] (89 bytes)

		public override string ToString() => "Byte[89] " + Data.Format();
	}
}
using System.Runtime.InteropServices;
using Common.Shared.Min.Extensions;
using IO.Extensions;
using SoE.Models.Enums;

namespace SoE.Models.Structs
{
	/// <summary>
	/// Gourd spots
	/// </summary>
	/// <remarks>4 bytes</remarks>
	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 4)]
	public struct GourdSpots
	{
		public GourdLocation Value;

		public override string ToString() => $"(Enum) {Value.ToUInt()} [{Value.ToUInt().FormatBinary()}] {{{Value.GetSetFlags().Join()}}}";
	}
}
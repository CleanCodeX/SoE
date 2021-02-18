using System.Runtime.InteropServices;
using Common.Shared.Min.Extensions;
using IO.Extensions;
using SoE.Models.Enums.Unknown;

namespace SoE.Models.Structs
{
	/// <summary>
	/// Unknown 14
	/// </summary>
	/// <remarks>4 bytes</remarks>
	[StructLayout(LayoutKind.Sequential, Pack = 2, Size = 2)]
	public struct Unknown14
	{
		public Unknown14Flags Value;

		public override string ToString() => $"{Value.ToUShort()} [{Value.ToUShort().FormatBinary()}] {{{Value.GetSetFlags().Join()}}}";
	}
}
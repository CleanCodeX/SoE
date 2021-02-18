using System.Runtime.InteropServices;
using IO.Extensions;

namespace SoE.Models.Structs.Unknown
{
	/// <summary>
	/// Unknown 16C
	/// </summary>
	/// <remarks>6 bytes</remarks>
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = Sizes.Unknown16C)] 
	public struct Unknown16C
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
		public byte[] Data;

		public override string ToString() => "Byte[6] " + Data.Format();
	}
}

using System.Runtime.InteropServices;

// ReSharper disable InconsistentNaming

namespace SoE.Models.Structs.Unknown
{
	/// <summary>
	/// Unknown 15
	/// </summary>
	/// <remarks>24 bytes</remarks>
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = Sizes.Unknown15)] 
	public struct Unknown15
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.Unknown15)]
		public byte[] Offset0To23;
	}
}
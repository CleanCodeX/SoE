﻿using System.Runtime.InteropServices;
using SoE.Models.Enums.Unknown;

namespace SoE.Models.Structs.Unknown
{
	/// <summary>
	/// Unknown 16C
	/// </summary>
	/// <remarks>6 bytes</remarks>
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = Sizes.Unknown16C)] 
	public struct Unknown16C
	{
		public Unknown16C_Offset1 Offset0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
		public byte[] Offset1To5;
	}
}

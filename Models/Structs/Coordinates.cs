using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Helpers;

namespace SoE.Models.Structs
{
	/// <summary>
	/// X, Y coordinates
	/// </summary>
	/// <remarks>4 bytes</remarks>
	[HasOffsetMembers]
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Coordinates
	{
		public UInt16 X;
		public UInt16 Y;
	}
}
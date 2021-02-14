using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using IO.Extensions;
using IO.Helpers;

namespace SoE.Models.Structs
{
	/// <summary>
	/// Null terminated ANSI string
	/// </summary>
	/// <remarks>36 bytes</remarks>
	[HasToStringOverride]
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
	public struct FixedLengthString
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
		public byte[] Bytes; // (36 Bytes) Null terminated

		public char[] AsChars => Encoding.ASCII.GetChars(Bytes);
		public string AsString => AsChars.GetString();

		public override string ToString() => AsString;
	}
}
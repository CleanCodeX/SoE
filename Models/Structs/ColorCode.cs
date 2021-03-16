using System.Diagnostics;
using System.Runtime.InteropServices;
using SoE.Models.Enums;

namespace SoE.Models.Structs
{
	/// <summary>
	/// Color code
	/// </summary>
	/// <remarks><see cref="Size"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct ColorCode
	{
		public const int Size = 6;

		public Color Code1;
		public Color Code2;
		public Color Code3;

		public override string ToString() => $"{Code1}-{Code2}-{Code3}";
	}
}
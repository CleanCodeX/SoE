using System.Diagnostics;
using System.Runtime.InteropServices;
using Common.Shared.Min.Extensions;
using SoE.Models.Enums;
using SoE.Properties;

namespace SoE.Models.Structs
{
	/// <summary>
	/// Color code
	/// </summary>
	/// <remarks><see cref="Size"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct TerminalCode
	{
		public const int Size = 6;

		public TerminalCodeColor Code1;
		public TerminalCodeColor Code2;
		public TerminalCodeColor Code3;

		public override string ToString()
		{
			if (IsDefault)
				return Resources.StatusNoTerminalCodeSet;

			if (!IsValid)
				return $"{Resources.StatusInvalidTerminalCode} ({Code1}-{Code2}-{Code3})";

			return $"{Code1.GetDisplayName()}-{Code2.GetDisplayName()}-{Code3.GetDisplayName()} | {(ushort)Code1}-{(ushort)Code2}-{(ushort)Code3}";
		}

		public bool IsDefault => Equals(this, default(TerminalCode));
		public bool IsValid => !IsDefault && Code1 <= TerminalCodeColor.Green && Code2 <= TerminalCodeColor.Green && Code3 <= TerminalCodeColor.Green;
	}
}
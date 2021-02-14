using System;

namespace SoE.Models.Enums
{
	/// <summary>
	/// The acts of the game
	/// </summary>
	/// <remarks>2 bytes</remarks>
	public enum Act: UInt16
	{
		Prehistoria = 0, 
		Antiqua = 2, 
		Gothica = 4,
		Omnitopia = 6
	}
}
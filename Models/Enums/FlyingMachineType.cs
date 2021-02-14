using System;

namespace SoE.Models.Enums
{
	/// <summary>
	/// The type of flying machine
	/// </summary>
	/// <remarks>1 byte</remarks>
	public enum FlyingMachineType : UInt16
	{
		None = 0, 
		Windwalker = 1,
		EscapePod = 2,
	}
}
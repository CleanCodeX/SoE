using System;

namespace SoE.Models.Enums
{
	/// <summary>
	/// The dog's available appearances
	/// </summary>
	public enum DogAppearance : UInt16
	{
		Prehistorica = 2, // Wolf, Prehistorica
		PrehistoricaBoneChaser = 4, //  only used in the scene where the dog fetches the Bone Crusher. It is mostly identical to 02.
		Antiqua = 6, // Greyhound
		Gothica = 8, // Poodle
		Podunk = 10, // Normal
		Omnitopia = 12 // Toaster
	}
}
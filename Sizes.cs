// ReSharper disable MemberHidesStaticFromOuterClass
// ReSharper disable PossibleLossOfFraction

namespace SoE
{
	/// <summary>
	/// Known sizes of SoE's S-RAM buffer
	/// </summary>
	public static class Sizes
	{
		public const int LastSavePointName = 36;

		public const int Unknown4 = 6;
		public const int Unknown6 = 14;
		public const int Unknown7 = 6;
		public const int Unknown8 = 10;
		public const int Unknown9 = 2;
		public const int Unknown10 = 3;
		public const int Unknown11 = 14;

		#region Unknown12

		public const int Unknown12A = 16;
		public const int Unknown12B = 2;
		public const int Unknown12C = 4;

		#endregion

		public const int Unknown13 = 22;
		public const int Unknown14 = 3;
		public const int Unknown15 = 24;

		#region Unknown16

		public const int Unknown16A = 4;
		public const int Unknown16B_GothicaFlags = 4;
		public const int Unknown16C = 6;

		#endregion

		#region Unknown17

		public const int Unknown17A = 11;
		public const int Unknown17B = 5;
		public const int Unknown17C = 2;
		public const int Unknown17D = 3;
		public const int Unknown17E = 16;
		public const int Unknown17F = 14;
		public const int Unknown17G = 4;

		#endregion

		public const int Unknown18 = 2;

		#region Quasi unknown offsets

		/* Chunk16 */
		private const int CurrentEquippedWeaponChunk16 = 2;
		private const int EquippedAlchemies = 9;

		/* Chunk 18 */
		private const int GourdSpots = 4;
		private const int IngredientSniffSpots = 89;
		
		/* Chunk 19 */
		private const int FlyingMachineType = 1;

		/* Chunk 20 */
		private const int CurrentEquippedWeaponChunk20 = 1;
		private const int LastLandingLocation = 1;

		#endregion

		public const int AllUnknown = Unknown4 + Unknown6 + Unknown7 + Unknown8 + Unknown9 + 
		                              Unknown10 + Unknown11 + 
		                              Unknown12A + Unknown12B + Unknown12C + 
		                              Unknown13 + Unknown14 + Unknown15 + 
		                              Unknown16A + Unknown16B_GothicaFlags + Unknown16C + 
		                              Unknown17A + Unknown17B + Unknown17C + Unknown17D + 
		                              Unknown17E + Unknown17F + Unknown17G + 
		                              Unknown18 +
									  /* Chunk16 */
		                              CurrentEquippedWeaponChunk16 + EquippedAlchemies +
		                              /* Chunk 18 */
									  GourdSpots + IngredientSniffSpots +
		                              /* Chunk 19 */
									  FlyingMachineType +
									  /* Chunk 20 */
									  LastLandingLocation + CurrentEquippedWeaponChunk20;
	}
}
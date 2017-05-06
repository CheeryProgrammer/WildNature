namespace WildNature.ModelUnit.Entities.Bonuses
{
	internal class Cherry : Entity, IBonus
	{
		public int PowerAddition { get; } = 6;
		public int HealthAddition { get; } = 8;
	}
}

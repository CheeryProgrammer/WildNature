namespace WildNature.ModelUnit.Entities.Bonuses
{
	internal class Apple : Entity, IBonus
	{
		public int PowerAddition { get; } = 10;
		public int HealthAddition { get; } = 10;
	}
}

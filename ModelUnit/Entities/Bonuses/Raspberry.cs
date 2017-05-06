namespace WildNature.ModelUnit.Entities.Bonuses
{
	internal class Raspberry : Entity, IBonus
	{
		public int PowerAddition { get; } = 12;
		public int HealthAddition { get; } = 5;
	}
}

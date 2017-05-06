namespace WildNature.ModelUnit.Entities.Alives
{
	internal interface IVictim
	{
		int Defense { get; }
		int TakeDamage(int damage);
	}
}

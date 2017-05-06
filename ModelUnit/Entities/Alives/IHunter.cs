namespace WildNature.ModelUnit.Entities.Alives
{
	internal interface IHunter
	{
		int AttackPower { get; }
		void Attack(IVictim victim);
	}
}

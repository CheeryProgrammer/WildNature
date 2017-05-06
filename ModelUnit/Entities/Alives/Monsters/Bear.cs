namespace WildNature.ModelUnit.Entities.Alives.Monsters
{
	class Bear : AliveEntity, IHunter, IVictim
	{
		public int AttackPower { get; }
		public int Defense { get; }

		public void Attack(IVictim victim)
		{
			throw new System.NotImplementedException();
		}

		public int TakeDamage(int damage)
		{
			throw new System.NotImplementedException();
		}


		public override void MakeStep()
		{
			throw new System.NotImplementedException();
		}
	}
}

namespace WildNature.ModelUnit.Entities.Alives.Monsters
{
	class Bear : Entity, IAlive, IHunter, IVictim
	{
		public int Health { get; set; }
		public void Attack(IVictim victim)
		{
			throw new System.NotImplementedException();
		}

		public int TakeDamage(int damage)
		{
			throw new System.NotImplementedException();
		}
	}
}

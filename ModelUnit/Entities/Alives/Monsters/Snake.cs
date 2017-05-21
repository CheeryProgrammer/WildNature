using WildNature.ModelUnit.Entities.Bonuses;

namespace WildNature.ModelUnit.Entities.Alives.Monsters
{
	class Snake : AliveEntity, IHunter, IVictim
	{
		private int _attackPower;
		public int AttackPower => _attackPower;
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

		public override void EatBonus(IBonus bonus)
		{
			_attackPower += bonus.PowerAddition;
			Health += bonus.HealthAddition;
		}
	}
}

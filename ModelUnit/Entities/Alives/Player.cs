using WildNature.Common;
using WildNature.ModelUnit.Entities.Bonuses;

namespace WildNature.ModelUnit.Entities.Alives
{
	class Player : AliveEntity, IHunter, IVictim
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
			MakeStep(LookTo);
		}

		public void MakeStep(Direction direction)
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

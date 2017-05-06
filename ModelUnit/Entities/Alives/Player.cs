using WildNature.Common;

namespace WildNature.ModelUnit.Entities.Alives
{
	class Player : AliveEntity, IHunter, IVictim
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
			MakeStep(LookTo);
		}

		public void MakeStep(Direction direction)
		{
			throw new System.NotImplementedException();
		}
	}
}

using WildNature.Common;
using WildNature.ModelUnit.Entities.Bonuses;

namespace WildNature.ModelUnit.Entities.Alives
{
	internal abstract class AliveEntity : Entity
	{
		public int Health { get; set; }
		public Direction LookTo { get; private set; }

		public abstract void MakeStep();

		public virtual void MoveFaceTo(Direction direction)
		{
			LookTo = direction;
		}

		public abstract void EatBonus(IBonus bonus);
	}
}
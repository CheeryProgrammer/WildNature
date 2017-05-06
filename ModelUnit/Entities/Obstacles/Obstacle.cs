using WildNature.ModelUnit.Entities.Alives;

namespace WildNature.ModelUnit.Entities.Obstacles
{
	internal abstract class Obstacle : Entity
	{
		public abstract void GiveDamage(IVictim victim);
	}
}

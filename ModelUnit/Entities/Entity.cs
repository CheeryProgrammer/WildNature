using System.Drawing;

namespace WildNature.ModelUnit.Entities
{
	abstract class Entity
	{
		public Point Location { get; set; }

		public virtual void SetLocation(int x, int y)
		{
			Location = new Point(x, y);
		}
	}
}

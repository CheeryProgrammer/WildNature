using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildNature.ModelUnit.Entities.Alives
{
	class Player : Entity, IAlive
	{
		public int Health { get; set; }
	}
}

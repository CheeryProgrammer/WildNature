using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildNature.ModelUnit
{
	class Model
	{
		private readonly int _fieldWidth;
		private readonly int _fieldHeight;

		public Model(int fieldWidth, int fieldHeight)
		{
			_fieldWidth = fieldWidth;
			_fieldHeight = fieldHeight;
		}
	}
}

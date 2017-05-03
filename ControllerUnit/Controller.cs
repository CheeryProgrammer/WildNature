using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildNature.ModelUnit;

namespace WildNature.ControllerUnit
{
	class Controller
	{
		private readonly int _fieldWidth;
		private readonly int _fieldHeight;
		private Model _model;

		public Controller(int fieldWidth, int fieldHeight)
		{
			_fieldWidth = fieldWidth;
			_fieldHeight = fieldHeight;
			_model = new Model(fieldWidth, fieldHeight);
		}
	}
}

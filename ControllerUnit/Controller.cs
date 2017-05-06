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
		private bool _inGame;

		public Controller(int fieldWidth, int fieldHeight)
		{
			_fieldWidth = fieldWidth;
			_fieldHeight = fieldHeight;
			_model = new Model(fieldWidth, fieldHeight);
			_inGame = false;
		}

		public void StartGame()
		{
			_inGame = true;
			Task.Run(()=>_model.StartGame());
		}

		private void MainLoop()
		{
			while (_inGame)
			{
				_model.MakeStep();
			}
		}
	}
}

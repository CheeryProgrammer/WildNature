using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WildNature.ModelUnit.Entities;
using WildNature.ModelUnit.Entities.Alives.Monsters;
using WildNature.ModelUnit.Entities.Bonuses;
using WildNature.ModelUnit.Entities.Obstacles;

namespace WildNature.ModelUnit
{
	class Model
	{
		private readonly int _fieldWidth;
		private readonly int _fieldHeight;
		private bool _inGame;

		public Model(int fieldWidth, int fieldHeight)
		{
			_fieldWidth = fieldWidth;
			_fieldHeight = fieldHeight;
			_inGame = false;
		}

		public void StartGame()
		{
			while (_inGame)
			{
				MakeStep();
				Thread.Sleep(10);
			}
		}

		public void MakeStep()
		{
			RecalculateEntities();
			HandleCollisions();
		}

		private void RecalculateEntities()
		{
			throw new NotImplementedException();
		}

		private void HandleCollisions()
		{
			CreateEntity<Apple>();
			throw new NotImplementedException();
		}

		private Entity CreateEntity<T>() where T: Entity, new()
		{
			return new T();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using WildNature.ModelUnit.Entities;
using WildNature.ModelUnit.Entities.Alives;
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
		private List<Entity> _entities;

		public IEnumerable<AliveEntity> Alives
		{
			get { return _entities.OfType<AliveEntity>(); }
		}

		public IEnumerable<IBonus> Bonuses
		{
			get { return _entities.OfType<IBonus>(); }
		}

		public IEnumerable<Obstacle> Obstacles
		{
			get { return _entities.OfType<Obstacle>(); }
		}

		public Model(int fieldWidth, int fieldHeight)
		{
			_fieldWidth = fieldWidth;
			_fieldHeight = fieldHeight;
			_inGame = false;
			_entities = new List<Entity>();
		}

		public void StartGame()
		{
			LoadEntities();
			while (_inGame)
			{
				MakeStep();
				Thread.Sleep(10);
			}
		}

		private void LoadEntities()
		{
			LoadObstacles();
			LoadMonsters();
			LoadBonuses();
		}

		private void LoadObstacles()
		{
			for (int i = 0; i < 10; i++)
			{
				_entities.Add(CreateEntity<Tree>());
				_entities.Add(CreateEntity<Pit>());
				_entities.Add(CreateEntity<Stone>());
			}
		}

		private void LoadMonsters()
		{
			for (int i = 0; i < 10; i++)
			{
				_entities.Add(CreateEntity<Bear>());
				_entities.Add(CreateEntity<Snake>());
				_entities.Add(CreateEntity<Wolf>());
			}
		}

		private void LoadBonuses()
		{
			for (int i = 0; i < 10; i++)
			{
				_entities.Add(CreateEntity<Cherry>());
				_entities.Add(CreateEntity<Apple>());
				_entities.Add(CreateEntity<Raspberry>());
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

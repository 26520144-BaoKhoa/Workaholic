using System.Collections.Generic;
using FakeMG.PowerUps;
using FakeMG.Server.SaveLoad;
using UnityEngine;

namespace FakeMG.Level.InfiniteSpawner
{
	public class InfiniteLevelSpawner : InfiniteSpawner<LevelData>
	{
		[SerializeField]
		[Header("Model")]
		private ObstacleModelPool obstacleModelPool;

		[SerializeField]
		private GameObjectPool coinPool;

		[Header("Level")]
		private LevelData[] _spawnedLevels;

		private RandomizeLevel _randomizeLevel;

		[Header("Power Up")]
		[SerializeField]
		private int levelsBetweenPowerUps;

		[SerializeField]
		private GameObject powerUpList;

		[SerializeField]
		private PlayerDataSO playerDataSO;

		private int _levelsSinceLastPowerUp;

		private List<PowerUp> _powerUps;

		[Header("Bonus Run")]
		[SerializeField]
		private int levelsBetweenBonusRuns;

		[SerializeField]
		private GameObject bonusRunList;

		private int _levelsSinceLastBonusRun;

		[SerializeField]
		[Header("Mystery Box Level")]
		private LevelData mysteryBoxLevel;

		private LevelData _spawnedMysteryBoxLevel;

		private float _timePassedSinceLastMysteryBox;

		private const float MYSTERY_BOX_INTERVAL = 40f;

		private Rigidbody _playerRb;

		protected override float EndOfFirstTileWorld => 0f;

		protected override void Start()
		{
		}

		public override void Update()
		{
		}

		protected override LevelData SpawnObject(int index)
		{
			return null;
		}

		protected override void SetupSpawnedObject(LevelData levelData, int index)
		{
		}

		protected override void HandleRemovedObject(LevelData levelData)
		{
		}

		private void ReleaseLevelModels(LevelData levelData)
		{
		}

		private void ReleaseToPool(List<Transform> obstaclesList, ObstacleType obstacleType)
		{
		}

		private void SpawnPowerUpAtLevel(int levelIndex)
		{
		}

		private void SpawnBonusRunAtLevel(int levelIndex)
		{
		}
	}
}

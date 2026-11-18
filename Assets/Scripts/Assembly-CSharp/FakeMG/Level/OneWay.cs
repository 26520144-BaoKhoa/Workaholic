using System.Collections.Generic;
using FakeMG.Movement;
using UnityEngine;

namespace FakeMG.Level
{
	public class OneWay : MonoBehaviour
	{
		[SerializeField]
		private LevelData levelData;

		[SerializeField]
		private KartController player;

		[SerializeField]
		private ObstacleModelPool obstacleModelPool;

		[SerializeField]
		private GameObject coinCurvePrefab;

		[SerializeField]
		private GameObject movingObstaclePrefab;

		[SerializeField]
		private GameObject levelEnd;

		[Header("Distance")]
		[SerializeField]
		private float maxForwardDistance;

		private const float OBSTACLE_SPAWN_OFFSET = 30f;

		private const float LEVEL_TIME = 15f;

		private int _lastX;

		private int _currentCoinCurveIndex;

		private Coroutine _spawnObstacleCoroutine;

		private PoolInitializer _movingObstaclePool;

		private readonly LinkedList<GameObject> _activeMovingObstacles;

		private readonly LinkedList<GameObject> _activeObstacleModels;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Setup()
		{
		}

		private void SpawnObstacle()
		{
		}
	}
}

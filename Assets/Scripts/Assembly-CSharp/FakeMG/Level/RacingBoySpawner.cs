using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FakeMG.Movement;
using UnityEngine;

namespace FakeMG.Level
{
	public class RacingBoySpawner : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSpawnRacingBoy_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RacingBoySpawner _003C_003E4__this;

			private float _003CcurrentZ_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSpawnRacingBoy_003Ed__30(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		[Header("Prefabs")]
		private LevelData levelData;

		[SerializeField]
		private KartController player;

		[SerializeField]
		private ObstacleModelPool obstacleModelPool;

		[SerializeField]
		private GameObject racingBoyPrefab;

		[SerializeField]
		private GameObject movingObstaclePrefab;

		[SerializeField]
		private GameObject levelEnd;

		[SerializeField]
		private GameObject coinCurvePrefab;

		[SerializeField]
		[Header("Distance")]
		private float maxForwardDistance;

		[SerializeField]
		private float minRacingBoyForwardDistance;

		[SerializeField]
		private float maxRacingBoyForwardDistance;

		private const float RACING_BOY_SPAWN_OFFSET = -50f;

		private const float OBSTACLE_SPAWN_OFFSET = -30f;

		private const float LEVEL_TIME = 15f;

		private int _lastX;

		private int _currentCoinCurveIndex;

		private const float HALF_LEVEL_WIDTH = 3.5f;

		private readonly WaitForSeconds _waitTime;

		private Coroutine _spawnRacingBoyCoroutine;

		private PoolInitializer _racingBoyPool;

		private readonly LinkedList<GameObject> _activeRacingBoys;

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

		private void SetupMovingObstacle()
		{
		}

		private void SpawnObstacle()
		{
		}

		[IteratorStateMachine(typeof(_003CSpawnRacingBoy_003Ed__30))]
		private IEnumerator SpawnRacingBoy()
		{
			return null;
		}
	}
}

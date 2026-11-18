using System.Collections.Generic;
using FakeMG.Curve;
using UnityEngine;

namespace FakeMG.Level
{
	public class LevelData : MonoBehaviour
	{
		public List<Transform> flyingBonusRunSpawnPoints;

		public List<Transform> mediumObstacleSpawnPoints;

		public List<Transform> bigObstacleSpawnPoints;

		public List<Transform> bikeSpawnPoints;

		public List<Transform> powerUpSpawnPoints;

		public List<GameObjectCurve> coinCurves;

		public Transform endPos;

		public List<Transform> Coins { get; }
	}
}

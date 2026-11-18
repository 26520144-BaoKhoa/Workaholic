using UnityEngine;

namespace FakeMG.Level.InfiniteSpawner
{
	public class InfiniteObjectSpawnerBound : InfiniteObjectSpawner
	{
		private Bounds[] _gameObjectBounds;

		protected override void Start()
		{
		}

		protected override void SetupSpawnedObject(GameObject levelData, int index)
		{
		}

		private void CalculateBounds(GameObject[] gameObjects)
		{
		}
	}
}

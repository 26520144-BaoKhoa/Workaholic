using UnityEngine;

namespace FakeMG.Level.InfiniteSpawner
{
	public class InfiniteObjectSpawnerDistance : InfiniteObjectSpawner
	{
		[SerializeField]
		[Header("Randomize Distance")]
		private bool randomizeDistance;

		[SerializeField]
		private float distance;

		protected override void SetupSpawnedObject(GameObject levelData, int index)
		{
		}
	}
}

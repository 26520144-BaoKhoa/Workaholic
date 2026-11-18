using UnityEngine;

namespace FakeMG.BonusRun.Flying
{
	public class CoinSpawner : MonoBehaviour
	{
		[SerializeField]
		private GameObjectPool coinPool;

		[SerializeField]
		private float coinDistance;

		[SerializeField]
		private int maxChangeDirInterval;

		[SerializeField]
		private int minChangeDirInterval;

		[SerializeField]
		private float height;

		public float Height => 0f;

		public void StartSpawningCoins(float startZWorldPos, float length)
		{
		}

		public void Reset()
		{
		}
	}
}

using UnityEngine;

namespace FakeMG
{
	public class GameObjectPool : MonoBehaviour
	{
		[SerializeField]
		private GameObject prefab;

		private PoolInitializer _pool;

		private void Awake()
		{
		}

		public GameObject GetFromPool()
		{
			return null;
		}

		public void ReleaseToPool(GameObject obj)
		{
		}
	}
}

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

namespace FakeMG
{
	public class PoolInitializer
	{
		private readonly LinkedPool<GameObject> _pool;

		private readonly GameObject _prefab;

		private readonly LinkedList<GameObject> _collection;

		private readonly int _maxSize;

		public PoolInitializer(GameObject prefab, int maxSize)
		{
		}

		public bool IsFromPool(GameObject obj)
		{
			return false;
		}

		public GameObject GetObject()
		{
			return null;
		}

		public void ReleaseObject(GameObject obj)
		{
		}

		public void CleanPool()
		{
		}
	}
}

using System.Collections.Generic;
using UnityEngine;

namespace FakeMG.Level.InfiniteSpawner
{
	public abstract class InfiniteSpawner<T> : MonoBehaviour where T : Object
	{
		[SerializeField]
		protected Transform player;

		[SerializeField]
		[Header("Parameters")]
		protected List<T> objectPrefabs;

		[SerializeField]
		private int minDistanceToSpawn;

		[SerializeField]
		private int minDistanceToDespawn;

		[SerializeField]
		private int distanceBeforeRepeat;

		protected LinkedList<T> ActiveTiles;

		private int[] _objectStatus;

		private GameObject _endPosObject;

		protected float EndPosLocal
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected abstract float EndOfFirstTileWorld { get; }

		private void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		public virtual void Update()
		{
		}

		private void RemoveFirstActiveObject()
		{
		}

		protected abstract void HandleRemovedObject(T go);

		private void SpawnObjectAtTheEnd()
		{
		}

		private int GetAvailableObjectIndex()
		{
			return 0;
		}

		private void UpdateAllObjectsStatus(int index)
		{
		}

		protected abstract T SpawnObject(int index);

		protected abstract void SetupSpawnedObject(T go, int index);
	}
}

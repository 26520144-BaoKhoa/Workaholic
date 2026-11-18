using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace FakeMG.Level
{
	public class ObstacleModelPool : MonoBehaviour
	{
		[SerializeField]
		private UnityEvent onAllObstaclesLoaded;

		[SerializeField]
		private AssetLabelReference bigObstacleLabelReference;

		[SerializeField]
		private AssetLabelReference mediumObstacleLabelReference;

		[SerializeField]
		private AssetLabelReference bikeObstacleLabelReference;

		private List<PoolInitializer> _bigObstaclePools;

		private List<PoolInitializer> _mediumObstaclePools;

		private List<PoolInitializer> _bikeObstaclePools;

		private AsyncOperationHandle<IList<GameObject>> _bigObstacleHandle;

		private AsyncOperationHandle<IList<GameObject>> _mediumObstacleHandle;

		private AsyncOperationHandle<IList<GameObject>> _bikeObstacleHandle;

		private readonly Vector3[] _modelSizes;

		private int _loadedCount;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void CheckIfLoaded()
		{
		}

		public int GetModelCount(ObstacleType type)
		{
			return 0;
		}

		public Vector3 GetObstacleSize(ObstacleType type)
		{
			return default;
		}

		public GameObject GetFromPool(int index, ObstacleType type)
		{
			return null;
		}

		public void ReleaseToPool(GameObject obj, ObstacleType type)
		{
		}

		public bool ReleaseToPool(GameObject obj)
		{
			return false;
		}

		private void ReleaseToPool(PoolInitializer pool, GameObject obj)
		{
		}
	}
}

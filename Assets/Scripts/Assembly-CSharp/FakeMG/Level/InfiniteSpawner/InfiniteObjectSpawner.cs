using System.Collections.Generic;
using UnityEngine;

namespace FakeMG.Level.InfiniteSpawner
{
	public abstract class InfiniteObjectSpawner : InfiniteSpawner<GameObject>
	{
		[SerializeField]
		private bool flip;

		[SerializeField]
		[Header("Randomization")]
		private bool randomizeXPos;

		[SerializeField]
		[Header("Scale")]
		private bool randomizeScale;

		[SerializeField]
		private float minScale;

		[SerializeField]
		private float maxScale;

		[SerializeField]
		[Header("Rotation")]
		private bool randomizeRotation;

		[SerializeField]
		private float minRotation;

		[SerializeField]
		private float maxRotation;

		[SerializeField]
		private float isMultipleOf;

		private int _numberOfConsecutiveSameXPosObject;

		private float _xPos;

		private List<PoolInitializer> _pools;

		protected override float EndOfFirstTileWorld => 0f;

		protected override void Start()
		{
		}

		protected override GameObject SpawnObject(int index)
		{
			return null;
		}

		protected void Setup(GameObject go)
		{
		}

		protected override void HandleRemovedObject(GameObject levelData)
		{
		}

		private void CalculateXPosition()
		{
		}
	}
}

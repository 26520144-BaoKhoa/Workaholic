using FakeMG.Movement;
using UnityEngine;

namespace FakeMG.Obstacle.MovingToPlayer
{
	public class MovingObstaclePath : ResettableTransform
	{
		[SerializeField]
		private KartController player;

		[SerializeField]
		public Transform intersectionPoint;

		[SerializeField]
		public Transform[] path;

		[SerializeField]
		public float multiplier;

		[SerializeField]
		private float playerOffset;

		private int _currentPathIndex;

		private float _currentSpeed;

		private bool _isMoving;

		private float _v1;

		private const float STEER_SENSITIVITY = 5f;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void FollowPath()
		{
		}

		private float CalculateSpeed()
		{
			return 0f;
		}

		protected override void ResetState()
		{
		}
	}
}

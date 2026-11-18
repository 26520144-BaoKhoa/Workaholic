using FakeMG.Movement;
using UnityEngine;

namespace FakeMG.Obstacle.MovingToPlayer
{
	public class MovingObstacleStraight : ResettableTransform
	{
		[SerializeField]
		private KartController player;

		[SerializeField]
		public Transform intersectionPoint;

		private float _currentSpeed;

		private bool _isMoving;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private float CalculateForwardSpeed()
		{
			return 0f;
		}

		protected override void ResetState()
		{
		}
	}
}

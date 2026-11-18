using UnityEngine;

namespace FakeMG.PowerUps.Magnet
{
	public class MoveToTarget : MonoBehaviour
	{
		[SerializeField]
		private Transform target;

		[SerializeField]
		private float startSpeed;

		public bool move;

		private float _currentSpeed;

		private float _lastFrameTargetZ;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void OnDisable()
		{
		}
	}
}

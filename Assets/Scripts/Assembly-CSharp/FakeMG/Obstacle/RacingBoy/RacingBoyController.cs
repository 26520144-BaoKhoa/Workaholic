using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.Obstacle.RacingBoy
{
	public class RacingBoyController : MonoBehaviour
	{
		[SerializeField]
		private UnityEvent onDead;

		private Rigidbody _rb;

		private Transform _transform;

		private float Speed { get; set; }

		public bool IsColliding { get; private set; }

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void OnCollisionEnter(Collision other)
		{
		}

		private void OnCollisionExit(Collision other)
		{
		}

		private void OnDisable()
		{
		}

		public void UnFreeze(float speed)
		{
		}

		public void Kill()
		{
		}
	}
}

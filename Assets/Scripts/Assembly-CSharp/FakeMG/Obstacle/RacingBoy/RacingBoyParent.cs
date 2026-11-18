using UnityEngine;
using UnityEngine.Serialization;

namespace FakeMG.Obstacle.RacingBoy
{
	public class RacingBoyParent : MonoBehaviour
	{
		[SerializeField]
		private Flashing flashing;

		[SerializeField]
		private Transform bike;

		[SerializeField]
		[FormerlySerializedAs("collisionDetect")]
		private RacingBoyController controller;

		private Transform _player;

		private const float BIKE_SPEED_MULTIPLIER = 2f;

		private const float OFFSET = 8f;

		private bool _followZ;

		private const float FOLLOW_SPEED = 10f;

		private bool _followX;

		private Transform _transform;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnDisable()
		{
		}

		private void SetSpeedToPlayer()
		{
		}

		private void StopFollowingPlayerX()
		{
		}
	}
}

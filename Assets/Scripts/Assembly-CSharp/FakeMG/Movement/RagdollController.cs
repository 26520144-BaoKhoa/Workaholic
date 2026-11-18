using UnityEngine;

namespace FakeMG.Movement
{
	public class RagdollController : MonoBehaviour
	{
		private Collider[] _colliders;

		private Rigidbody[] _rigidbodies;

		private Vector3[] _originalLocalPositions;

		private Quaternion[] _originalLocalRotations;

		private Transform _transform;

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		public void SetRagdollActive(bool active)
		{
		}

		public void LaunchRagdollUp()
		{
		}

		private void ResetRagdoll()
		{
		}

		public void ResetRagdollAnimation()
		{
		}
	}
}

using UnityEngine;

namespace FakeMG.Obstacle
{
	public class ResettableTransform : MonoBehaviour
	{
		private Vector3 _initialLocalPosition;

		protected Transform Transform;

		protected Quaternion InitialLocalRotation { get; private set; }

		protected virtual void Awake()
		{
		}

		protected virtual void ResetState()
		{
		}

		private void OnDisable()
		{
		}
	}
}

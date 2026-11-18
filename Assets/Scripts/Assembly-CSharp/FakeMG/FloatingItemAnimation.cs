using UnityEngine;

namespace FakeMG
{
	public class FloatingItemAnimation : MonoBehaviour
	{
		[Header("Floating")]
		[SerializeField]
		private float amplitude;

		[SerializeField]
		private float frequency;

		[Header("Rotation")]
		[SerializeField]
		private float rotationSpeed;

		private Vector3 _originalPosLocal;

		private Vector3 _tempPos;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}

using UnityEngine;

namespace FakeMG
{
	public class FollowGameObject : MonoBehaviour
	{
		[SerializeField]
		private bool x;

		[SerializeField]
		private bool y;

		[SerializeField]
		private bool z;

		[SerializeField]
		private float offsetX;

		[SerializeField]
		private float offsetY;

		[SerializeField]
		private float offsetZ;

		[SerializeField]
		private GameObject target;

		private void Update()
		{
		}
	}
}

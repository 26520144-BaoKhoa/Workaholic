using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.PowerUps.Shield
{
	public class ShieldBehavior : MonoBehaviour
	{
		[SerializeField]
		private UnityEvent onShieldHit;

		[SerializeField]
		private LayerMask enemyLayer;

		private float _previousTouchTime;

		public bool IsEnable { get; set; }

		private void Start()
		{
		}

		private void OnCollisionEnter(Collision other)
		{
		}

		private bool ContainsLayer(LayerMask mask, int layer)
		{
			return false;
		}
	}
}

using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.PowerUps.Shield
{
	public class Destroyable : MonoBehaviour
	{
		[SerializeField]
		private UnityEvent onDestroy;

		[SerializeField]
		[Header("Explosion")]
		private ParticleSystem explosionPrefab;

		[SerializeField]
		private float explosionScale;

		[SerializeField]
		private Vector3 explosionOffset;

		private ParticleSystem _explosion;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void Destroy()
		{
		}
	}
}

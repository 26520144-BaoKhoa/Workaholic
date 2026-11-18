using UnityEngine;

namespace FakeMG.VFX
{
	public class ImpactEffect : MonoBehaviour
	{
		[SerializeField]
		private ParticleSystem impactEffect;

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}

using Cinemachine;
using UnityEngine;

namespace FakeMG.VFX
{
	public class SpeedEffect : MonoBehaviour
	{
		[SerializeField]
		private CinemachineVirtualCamera virtualCamera;

		[SerializeField]
		private ParticleSystem speedEffect;

		[SerializeField]
		private ParticleSystem nitroEffect;

		public void SetUpNitroEffect(ParticleSystem pNitroEffect)
		{
		}

		public void PlaySpeedEffect()
		{
		}

		public void StopSpeedEffect()
		{
		}
	}
}

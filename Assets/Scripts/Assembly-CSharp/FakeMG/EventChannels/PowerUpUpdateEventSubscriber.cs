using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.EventChannels
{
	public class PowerUpUpdateEventSubscriber : MonoBehaviour
	{
		[SerializeField]
		private PowerUpUpdateEventChannel powerUpUpdateEventChannel;

		[SerializeField]
		private UnityEvent<string, Sprite, float> onPowerUpUpdate;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}

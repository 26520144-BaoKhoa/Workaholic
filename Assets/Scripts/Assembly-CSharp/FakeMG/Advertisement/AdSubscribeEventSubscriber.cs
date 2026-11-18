using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.Advertisement
{
	public class AdSubscribeEventSubscriber : MonoBehaviour
	{
		[SerializeField]
		private AdSubscribeEventChannel adSubscribeEventChannel;

		[SerializeField]
		private UnityEvent<UnityAction> onEventRaised;

		private void Start()
		{
		}

		private void OnDisable()
		{
		}
	}
}

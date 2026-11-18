using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.EventChannels
{
	public class SimpleEventSubscriber : MonoBehaviour
	{
		[SerializeField]
		private SimpleEventChannel simpleEventChannel;

		[SerializeField]
		private UnityEvent onEventRaised;

		private void Start()
		{
		}

		private void OnDisable()
		{
		}
	}
}

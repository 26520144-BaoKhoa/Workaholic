using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.EventChannels
{
	public class ScoreIncreaseEventSubscriber : MonoBehaviour
	{
		[SerializeField]
		private ScoreIncreaseEventChannel scoreIncreaseEventChannel;

		[SerializeField]
		private UnityEvent<double, double> onEventRaised;

		private void Start()
		{
		}

		private void OnDisable()
		{
		}
	}
}

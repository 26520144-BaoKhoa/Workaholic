using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.EventChannels
{
	[CreateAssetMenu(menuName = "Event Channels/Score Increase Event")]
	public class ScoreIncreaseEventChannel : ScriptableObject
	{
		public UnityAction<double, double> OnEventRaised;

		public void RaiseEvent(double increaseValue, double totalValue)
		{
		}
	}
}

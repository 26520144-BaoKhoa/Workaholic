using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.EventChannels
{
	[CreateAssetMenu(menuName = "Event Channels/PowerUp Update Event")]
	public class PowerUpUpdateEventChannel : ScriptableObject
	{
		public UnityAction<string, Sprite, float> OnEventRaised;

		public void RaiseEvent(string powerUpName, Sprite powerUpIcon, float remainingUsage)
		{
		}
	}
}

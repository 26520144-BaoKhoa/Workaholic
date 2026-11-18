using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.EventChannels
{
	[CreateAssetMenu(menuName = "Event Channels/Simple Event")]
	public class SimpleEventChannel : ScriptableObject
	{
		public UnityAction OnEventRaised;

		public void RaiseEvent()
		{
		}
	}
}

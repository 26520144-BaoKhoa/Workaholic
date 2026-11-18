using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.Advertisement
{
	[CreateAssetMenu(menuName = "Event Channels/Ad Subscribe Event")]
	public class AdSubscribeEventChannel : ScriptableObject
	{
		public UnityAction<UnityAction> OnEventRaised;

		public void RaiseEvent(UnityAction action)
		{
		}
	}
}

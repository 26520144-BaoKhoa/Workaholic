using FakeMG.IAP;
using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.EventChannels
{
	[CreateAssetMenu(menuName = "Event Channels/IAP Item Purchase Event")]
	public class ItemPurchaseEventChannel : ScriptableObject
	{
		public UnityAction<InAppPurchaseItemSO> OnEventRaised;

		public void RaiseEvent(InAppPurchaseItemSO itemSO)
		{
		}
	}
}

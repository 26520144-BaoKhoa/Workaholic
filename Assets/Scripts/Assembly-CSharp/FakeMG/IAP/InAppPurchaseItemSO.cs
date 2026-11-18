using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing;

namespace FakeMG.IAP
{
	public abstract class InAppPurchaseItemSO : ScriptableObject
	{
		[SerializeField]
		protected string id;

		[SerializeField]
		protected string itemName;

		[SerializeField]
		protected Sprite icon;

		public ProductType type;

		public UnityEvent<InAppPurchaseItemSO> onPurchaseClick;

		public UnityEvent onPurchaseSuccess;

		public string ID => null;

		public string ItemName => null;

		public Sprite Icon => null;

		public abstract void HandlePurchase(StoreController storeController, PendingOrder pendingOrder);

		public void OnPurchaseClick()
		{
		}
	}
}

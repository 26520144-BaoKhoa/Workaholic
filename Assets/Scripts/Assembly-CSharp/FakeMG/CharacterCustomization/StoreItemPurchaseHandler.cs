using FakeMG.CharacterCustomization.Item;
using FakeMG.Server.SaveLoad;
using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.CharacterCustomization
{
	public abstract class StoreItemPurchaseHandler : MonoBehaviour
	{
		[SerializeField]
		protected PlayerDataSO playerData;

		[SerializeField]
		private UnityEvent onNotEnoughCoins;

		protected bool CheckAndDeductCurrency(StoreItemSO item)
		{
			return false;
		}
	}
}

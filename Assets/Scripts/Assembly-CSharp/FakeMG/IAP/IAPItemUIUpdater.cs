using FakeMG.UI;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.UI;

namespace FakeMG.IAP
{
	public class IAPItemUIUpdater : MonoBehaviour
	{
		[SerializeField]
		private CustomButton button;

		[SerializeField]
		private TextMeshProUGUI priceText;

		[SerializeField]
		private TextMeshProUGUI nameText;

		[SerializeField]
		private Image iconImage;

		[SerializeField]
		private TextMeshProUGUI purchasedText;

		public void SetItem(Product product, InAppPurchaseItemSO item)
		{
		}

		public void ShowPurchasedUI()
		{
		}
	}
}

using FakeMG.CharacterCustomization.Item;
using FakeMG.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace FakeMG.Utilities
{
	public class UtilitiesItemUIUpdater : MonoBehaviour
	{
		[SerializeField]
		protected TextMeshProUGUI priceText;

		[SerializeField]
		protected TextMeshProUGUI nameText;

		[SerializeField]
		protected Image iconImage;

		[SerializeField]
		protected Image currencyIcon;

		public CustomButton button;

		public void UpdateUI(StoreItemSO item)
		{
		}
	}
}

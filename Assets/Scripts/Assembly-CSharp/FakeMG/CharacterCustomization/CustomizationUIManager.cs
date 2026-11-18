using FakeMG.Server.SaveLoad;
using UnityEngine;
using UnityEngine.UI;

namespace FakeMG.CharacterCustomization
{
	public class CustomizationUIManager : MonoBehaviour
	{
		[SerializeField]
		private PlayerDataSO playerData;

		[SerializeField]
		[Header("Coin")]
		private Text coinText;

		[SerializeField]
		private Text gemText;

		[SerializeField]
		private RectTransform notEnoughCoinScreenRect;

		[SerializeField]
		private CanvasGroup notEnoughCoinCanvasGroup;

		[SerializeField]
		private RectTransform purchaseSuccessfulScreenRect;

		[SerializeField]
		private CanvasGroup purchaseSuccessfulCanvasGroup;

		[SerializeField]
		private RectTransform upgradeUIRect;

		[SerializeField]
		private CanvasGroup upgradeUICanvasGroup;

		[SerializeField]
		private Image upgradeUIBlackBG;

		[SerializeField]
		private Image blackBG;

		private const float BLACK_BG_ALPHA = 0.8f;

		private void OnEnable()
		{
		}

		public void UpdateCurrencyText()
		{
		}

		public void ShowUpgradeUI()
		{
		}

		public void HideUpgradeUI()
		{
		}

		public void ShowPurchaseSuccessful()
		{
		}

		public void HidePurchaseSuccessful()
		{
		}

		public void ShowNotEnoughCoin()
		{
		}

		public void HideNotEnoughCoin()
		{
		}

		private void PopupUI(CanvasGroup canvasGroup, RectTransform rectTransform)
		{
		}

		private void CloseUI(CanvasGroup canvasGroup, RectTransform rectTransform)
		{
		}

		private void ShowBlackBG()
		{
		}

		private void HideBlackBG()
		{
		}
	}
}

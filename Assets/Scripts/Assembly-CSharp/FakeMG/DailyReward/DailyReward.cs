using System.Collections.Generic;
using AYellowpaper.SerializedCollections;
using FakeMG.Advertisement;
using FakeMG.EventChannels;
using FakeMG.MysteryBox;
using FakeMG.Server.SaveLoad;
using FakeMG.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace FakeMG.DailyReward
{
	public class DailyReward : MonoBehaviour
	{
		[SerializeField]
		private SerializedDictionary<MysteryItemSO, float> items;

		[SerializeField]
		private PlayerDataSO playerDataSO;

		[SerializeField]
		private GameObject dailyRewardButton;

		[SerializeField]
		private SimpleEventChannel saveDataEventChannel;

		[SerializeField]
		private AdvertisementSubscriber advertisementSubscriber;

		[Header("Button UI")]
		[SerializeField]
		private GameObject questionMark;

		[SerializeField]
		private Image itemIcon;

		[SerializeField]
		private TextMeshProUGUI timerText;

		[SerializeField]
		private GameObject watchAdText;

		[SerializeField]
		private CustomButton claimButton;

		[SerializeField]
		[Header("Success UI")]
		private TextMeshProUGUI itemText;

		[SerializeField]
		private RectTransform successUIRectTransform;

		[SerializeField]
		private CanvasGroup successUICanvasGroup;

		[SerializeField]
		private Image blackBG;

		private const float BLACK_BG_ALPHA = 0.8f;

		private Dictionary<string, MysteryItemSO> _itemsWithStringKeys;

		private AndroidNotifications _androidNotifications;

		private const float DAYS_BETWEEN_DAILY_REWARDS = 1f;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnApplicationFocus(bool hasFocus)
		{
		}

		private void SetupButton()
		{
		}

		private MysteryItemSO Spin()
		{
			return null;
		}

		public void AddCoins(int amount)
		{
		}

		public void AddGems(int amount)
		{
		}

		public void AddRevive(int amount)
		{
		}

		private void ShowSuccessUI()
		{
		}

		public void HideSuccessUI()
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

using FakeMG.IAP;
using FakeMG.Server.SaveLoad;
using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.Advertisement
{
	public class Advertisement : MonoBehaviour
	{
		[SerializeField]
		private PlayerDataSO playerDataSO;

		[SerializeField]
		private InAppPurchaseItemSO noAdsItem;

		public UnityAction RewardedVideoCallback;

		private bool _rewardedVideoPlayed;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnApplicationPause(bool isPaused)
		{
		}

		private void OnDisable()
		{
		}

		public void ShowRewardedVideo()
		{
		}

		public void SubscribeToRewardAd(UnityAction callback)
		{
		}

		private void LoadInterstitial()
		{
		}

		public void ShowInterstitial()
		{
		}

		public void LoadBanner()
		{
		}

		public void DestroyBanner()
		{
		}

		private void SdkInitializationCompletedEvent()
		{
		}

		private void RewardedVideoOnAdOpenedEvent(IronSourceAdInfo adInfo)
		{
		}

		private void RewardedVideoOnAdClosedEvent(IronSourceAdInfo adInfo)
		{
		}

		private void RewardedVideoOnAdAvailable(IronSourceAdInfo adInfo)
		{
		}

		private void RewardedVideoOnAdUnavailable()
		{
		}

		private void RewardedVideoOnAdShowFailedEvent(IronSourceError ironSourceError, IronSourceAdInfo adInfo)
		{
		}

		private void RewardedVideoOnAdRewardedEvent(IronSourcePlacement ironSourcePlacement, IronSourceAdInfo adInfo)
		{
		}

		private void RewardedVideoOnAdClickedEvent(IronSourcePlacement ironSourcePlacement, IronSourceAdInfo adInfo)
		{
		}

		private void InterstitialOnAdReadyEvent(IronSourceAdInfo adInfo)
		{
		}

		private void InterstitialOnAdLoadFailed(IronSourceError ironSourceError)
		{
		}

		private void InterstitialOnAdOpenedEvent(IronSourceAdInfo adInfo)
		{
		}

		private void InterstitialOnAdClickedEvent(IronSourceAdInfo adInfo)
		{
		}

		private void InterstitialOnAdShowSucceededEvent(IronSourceAdInfo adInfo)
		{
		}

		private void InterstitialOnAdShowFailedEvent(IronSourceError ironSourceError, IronSourceAdInfo adInfo)
		{
		}

		private void InterstitialOnAdClosedEvent(IronSourceAdInfo adInfo)
		{
		}

		private void BannerOnAdLoadedEvent(IronSourceAdInfo adInfo)
		{
		}

		private void BannerOnAdLoadFailedEvent(IronSourceError ironSourceError)
		{
		}

		private void BannerOnAdClickedEvent(IronSourceAdInfo adInfo)
		{
		}

		private void BannerOnAdScreenPresentedEvent(IronSourceAdInfo adInfo)
		{
		}

		private void BannerOnAdScreenDismissedEvent(IronSourceAdInfo adInfo)
		{
		}

		private void BannerOnAdLeftApplicationEvent(IronSourceAdInfo adInfo)
		{
		}

		private void ImpressionDataReadyEvent(IronSourceImpressionData impressionData)
		{
		}
	}
}

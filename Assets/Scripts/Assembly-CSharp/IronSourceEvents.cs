using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IronSourceEvents : MonoBehaviour
{
	[CompilerGenerated]
	private static Action m_onSdkInitializationCompletedEvent;

	[CompilerGenerated]
	private static Action<IronSourceError> m_onRewardedVideoAdShowFailedEvent;

	[CompilerGenerated]
	private static Action m_onRewardedVideoAdOpenedEvent;

	[CompilerGenerated]
	private static Action m_onRewardedVideoAdClosedEvent;

	[CompilerGenerated]
	private static Action m_onRewardedVideoAdStartedEvent;

	[CompilerGenerated]
	private static Action m_onRewardedVideoAdEndedEvent;

	[CompilerGenerated]
	private static Action<IronSourcePlacement> m_onRewardedVideoAdRewardedEvent;

	[CompilerGenerated]
	private static Action<IronSourcePlacement> m_onRewardedVideoAdClickedEvent;

	[CompilerGenerated]
	private static Action<bool> m_onRewardedVideoAvailabilityChangedEvent;

	[CompilerGenerated]
	private static Action<IronSourceError> m_onRewardedVideoAdLoadFailedEvent;

	[CompilerGenerated]
	private static Action m_onRewardedVideoAdReadyEvent;

	[CompilerGenerated]
	private static Action<string> m_onRewardedVideoAdOpenedDemandOnlyEvent;

	[CompilerGenerated]
	private static Action<string> m_onRewardedVideoAdClosedDemandOnlyEvent;

	[CompilerGenerated]
	private static Action<string> m_onRewardedVideoAdLoadedDemandOnlyEvent;

	[CompilerGenerated]
	private static Action<string> m_onRewardedVideoAdRewardedDemandOnlyEvent;

	[CompilerGenerated]
	private static Action<string, IronSourceError> m_onRewardedVideoAdShowFailedDemandOnlyEvent;

	[CompilerGenerated]
	private static Action<string> m_onRewardedVideoAdClickedDemandOnlyEvent;

	[CompilerGenerated]
	private static Action<string, IronSourceError> m_onRewardedVideoAdLoadFailedDemandOnlyEvent;

	[CompilerGenerated]
	private static Action m_onInterstitialAdReadyEvent;

	[CompilerGenerated]
	private static Action<IronSourceError> m_onInterstitialAdLoadFailedEvent;

	[CompilerGenerated]
	private static Action m_onInterstitialAdOpenedEvent;

	[CompilerGenerated]
	private static Action m_onInterstitialAdClosedEvent;

	[CompilerGenerated]
	private static Action m_onInterstitialAdShowSucceededEvent;

	[CompilerGenerated]
	private static Action<IronSourceError> m_onInterstitialAdShowFailedEvent;

	[CompilerGenerated]
	private static Action m_onInterstitialAdClickedEvent;

	[CompilerGenerated]
	private static Action<string> m_onInterstitialAdReadyDemandOnlyEvent;

	[CompilerGenerated]
	private static Action<string> m_onInterstitialAdOpenedDemandOnlyEvent;

	[CompilerGenerated]
	private static Action<string> m_onInterstitialAdClosedDemandOnlyEvent;

	[CompilerGenerated]
	private static Action<string, IronSourceError> m_onInterstitialAdLoadFailedDemandOnlyEvent;

	[CompilerGenerated]
	private static Action<string> m_onInterstitialAdClickedDemandOnlyEvent;

	[CompilerGenerated]
	private static Action<string, IronSourceError> m_onInterstitialAdShowFailedDemandOnlyEvent;

	[CompilerGenerated]
	private static Action<bool> m_onOfferwallAvailableEvent;

	[CompilerGenerated]
	private static Action m_onOfferwallOpenedEvent;

	[CompilerGenerated]
	private static Action<Dictionary<string, object>> m_onOfferwallAdCreditedEvent;

	[CompilerGenerated]
	private static Action<IronSourceError> m_onGetOfferwallCreditsFailedEvent;

	[CompilerGenerated]
	private static Action m_onOfferwallClosedEvent;

	[CompilerGenerated]
	private static Action<IronSourceError> m_onOfferwallShowFailedEvent;

	[CompilerGenerated]
	private static Action m_onBannerAdLoadedEvent;

	[CompilerGenerated]
	private static Action m_onBannerAdLeftApplicationEvent;

	[CompilerGenerated]
	private static Action m_onBannerAdScreenDismissedEvent;

	[CompilerGenerated]
	private static Action m_onBannerAdScreenPresentedEvent;

	[CompilerGenerated]
	private static Action m_onBannerAdClickedEvent;

	[CompilerGenerated]
	private static Action<IronSourceError> m_onBannerAdLoadFailedEvent;

	[CompilerGenerated]
	private static Action<string> m_onSegmentReceivedEvent;

	[CompilerGenerated]
	private static Action<IronSourceImpressionData> m_onImpressionSuccessEvent;

	private const string ERROR_CODE = "error_code";

	private const string ERROR_DESCRIPTION = "error_description";

	private const string INSTANCE_ID_KEY = "instanceId";

	private const string PLACEMENT_KEY = "placement";

	[CompilerGenerated]
	private static Action<IronSourceImpressionData> m_onImpressionDataReadyEvent;

	private IUnityInitialization initializationAndroid;

	private IUnityRewardedVideo rewardedVideoAndroid;

	private IUnityRewardedVideoManual rewardedVideoAndroidManual;

	private IUnityInterstitial interstitialAndroid;

	private IUnityOfferwall offerwallAndroid;

	private IUnityBanner bannerAndroid;

	private IUnitySegment segmentAndroid;

	private IUnityImpressionData impressionDataAndroid;

	[CompilerGenerated]
	private static Action<string, IronSourceError> m__onConsentViewDidFailToLoadWithErrorEvent;

	[CompilerGenerated]
	private static Action<string, IronSourceError> m__onConsentViewDidFailToShowWithErrorEvent;

	[CompilerGenerated]
	private static Action<string> m__onConsentViewDidAcceptEvent;

	[CompilerGenerated]
	private static Action<string> m__onConsentViewDidDismissEvent;

	[CompilerGenerated]
	private static Action<string> m__onConsentViewDidLoadSuccessEvent;

	[CompilerGenerated]
	private static Action<string> m__onConsentViewDidShowSuccessEvent;

	public static event Action onSdkInitializationCompletedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceRewardedVideoEvents listener instead.", false)]
	public static event Action<IronSourceError> onRewardedVideoAdShowFailedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceRewardedVideoEvents listener instead.", false)]
	public static event Action onRewardedVideoAdOpenedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceRewardedVideoEvents listener instead.", false)]
	public static event Action onRewardedVideoAdClosedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceRewardedVideoEvents listener instead.", false)]
	public static event Action onRewardedVideoAdStartedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceRewardedVideoEvents listener instead.", false)]
	public static event Action onRewardedVideoAdEndedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceRewardedVideoEvents listener instead.", false)]
	public static event Action<IronSourcePlacement> onRewardedVideoAdRewardedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceRewardedVideoEvents listener instead.", false)]
	public static event Action<IronSourcePlacement> onRewardedVideoAdClickedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceRewardedVideoEvents listener instead.", false)]
	public static event Action<bool> onRewardedVideoAvailabilityChangedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceRewardedVideoEvents listener instead.", false)]
	public static event Action<IronSourceError> onRewardedVideoAdLoadFailedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceRewardedVideoEvents listener instead.", false)]
	public static event Action onRewardedVideoAdReadyEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
	public static event Action<string> onRewardedVideoAdOpenedDemandOnlyEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
	public static event Action<string> onRewardedVideoAdClosedDemandOnlyEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
	public static event Action<string> onRewardedVideoAdLoadedDemandOnlyEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
	public static event Action<string> onRewardedVideoAdRewardedDemandOnlyEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
	public static event Action<string, IronSourceError> onRewardedVideoAdShowFailedDemandOnlyEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
	public static event Action<string> onRewardedVideoAdClickedDemandOnlyEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
	public static event Action<string, IronSourceError> onRewardedVideoAdLoadFailedDemandOnlyEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceInterstitialEvents listener instead.", false)]
	public static event Action onInterstitialAdReadyEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceInterstitialEvents listener instead.", false)]
	public static event Action<IronSourceError> onInterstitialAdLoadFailedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceInterstitialEvents listener instead.", false)]
	public static event Action onInterstitialAdOpenedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceInterstitialEvents listener instead.", false)]
	public static event Action onInterstitialAdClosedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceInterstitialEvents listener instead.", false)]
	public static event Action onInterstitialAdShowSucceededEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceInterstitialEvents listener instead.", false)]
	public static event Action<IronSourceError> onInterstitialAdShowFailedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceInterstitialEvents listener instead.", false)]
	public static event Action onInterstitialAdClickedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
	public static event Action<string> onInterstitialAdReadyDemandOnlyEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
	public static event Action<string> onInterstitialAdOpenedDemandOnlyEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
	public static event Action<string> onInterstitialAdClosedDemandOnlyEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
	public static event Action<string, IronSourceError> onInterstitialAdLoadFailedDemandOnlyEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
	public static event Action<string> onInterstitialAdClickedDemandOnlyEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
	public static event Action<string, IronSourceError> onInterstitialAdShowFailedDemandOnlyEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API call is for the ironSource Offerwall, which will soon be deprecated. Please migrate to the Tapjoy Offerwall using the 'Offerwall migration checklist'.", false)]
	public static event Action<bool> onOfferwallAvailableEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API call is for the ironSource Offerwall, which will soon be deprecated. Please migrate to the Tapjoy Offerwall using the 'Offerwall migration checklist'.", false)]
	public static event Action onOfferwallOpenedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API call is for the ironSource Offerwall, which will soon be deprecated. Please migrate to the Tapjoy Offerwall using the 'Offerwall migration checklist'.", false)]
	public static event Action<Dictionary<string, object>> onOfferwallAdCreditedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API call is for the ironSource Offerwall, which will soon be deprecated. Please migrate to the Tapjoy Offerwall using the 'Offerwall migration checklist'.", false)]
	public static event Action<IronSourceError> onGetOfferwallCreditsFailedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API call is for the ironSource Offerwall, which will soon be deprecated. Please migrate to the Tapjoy Offerwall using the 'Offerwall migration checklist'.", false)]
	public static event Action onOfferwallClosedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API call is for the ironSource Offerwall, which will soon be deprecated. Please migrate to the Tapjoy Offerwall using the 'Offerwall migration checklist'.", false)]
	public static event Action<IronSourceError> onOfferwallShowFailedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceBannerEvents listener instead.", false)]
	public static event Action onBannerAdLoadedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceBannerEvents listener instead.", false)]
	public static event Action onBannerAdLeftApplicationEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceBannerEvents listener instead.", false)]
	public static event Action onBannerAdScreenDismissedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceBannerEvents listener instead.", false)]
	public static event Action onBannerAdScreenPresentedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceBannerEvents listener instead.", false)]
	public static event Action onBannerAdClickedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0. Please use the alternate API in IronSourceBannerEvents listener instead.", false)]
	public static event Action<IronSourceError> onBannerAdLoadFailedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<string> onSegmentReceivedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0. Please use OnImpressionDataReady instead.")]
	public static event Action<IronSourceImpressionData> onImpressionSuccessEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<IronSourceImpressionData> onImpressionDataReadyEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private static event Action<string, IronSourceError> _onConsentViewDidFailToLoadWithErrorEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<string, IronSourceError> onConsentViewDidFailToLoadWithErrorEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	private static event Action<string, IronSourceError> _onConsentViewDidFailToShowWithErrorEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<string, IronSourceError> onConsentViewDidFailToShowWithErrorEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	private static event Action<string> _onConsentViewDidAcceptEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<string> onConsentViewDidAcceptEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	private static event Action<string> _onConsentViewDidDismissEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<string> onConsentViewDidDismissEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	private static event Action<string> _onConsentViewDidLoadSuccessEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<string> onConsentViewDidLoadSuccessEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	private static event Action<string> _onConsentViewDidShowSuccessEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<string> onConsentViewDidShowSuccessEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void registerInitializationEvents()
	{
	}

	private void registerBannerEvents()
	{
	}

	private void registerInterstitialEvents()
	{
	}

	private void registerInterstitialDemandOnlyEvents()
	{
	}

	private void registerOfferwallEvents()
	{
	}

	private void registerSegmentEvents()
	{
	}

	private void registerImpressionDataEvents()
	{
	}

	public void registerRewardedVideoDemandOnlyEvents()
	{
	}

	private void registerRewardedVideoEvents()
	{
	}

	public void registerRewardedVideoManualEvents()
	{
	}

	public void onConsentViewDidFailToLoadWithError(string args)
	{
	}

	public void onConsentViewDidFailToShowWithError(string args)
	{
	}

	public void onConsentViewDidAccept(string consentViewType)
	{
	}

	public void onConsentViewDidDismiss(string consentViewType)
	{
	}

	public void onConsentViewDidLoadSuccess(string consentViewType)
	{
	}

	public void onConsentViewDidShowSuccess(string consentViewType)
	{
	}

	private IronSourceError getErrorFromErrorObject(object descriptionObject)
	{
		return null;
	}

	private IronSourcePlacement getPlacementFromObject(object placementObject)
	{
		return null;
	}

	private static void InvokeEvent(Action<IronSourceImpressionData> evt, string args)
	{
	}
}

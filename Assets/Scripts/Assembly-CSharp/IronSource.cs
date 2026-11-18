using System;
using System.Collections.Generic;

public class IronSource : IronSourceIAgent
{
	private IronSourceIAgent _platformAgent;

	private static IronSource _instance;

	public static string UNITY_PLUGIN_VERSION;

	private static bool isUnsupportedPlatform;

	public static IronSource Agent => null;

	private IronSource()
	{
	}

	public static string pluginVersion()
	{
		return null;
	}

	public static string unityVersion()
	{
		return null;
	}

	public static void setUnsupportedPlatform()
	{
	}

	public void SetWaterfallConfiguration(WaterfallConfiguration waterfallConfiguration, AdFormat adFormat)
	{
	}

	public void onApplicationPause(bool pause)
	{
	}

	public string getAdvertiserId()
	{
		return null;
	}

	public void validateIntegration()
	{
	}

	public void shouldTrackNetworkState(bool track)
	{
	}

	public bool setDynamicUserId(string dynamicUserId)
	{
		return false;
	}

	public void setAdaptersDebug(bool enabled)
	{
	}

	public void setMetaData(string key, string value)
	{
	}

	public void setMetaData(string key, params string[] values)
	{
	}

	public int? getConversionValue()
	{
		return null;
	}

	public void setManualLoadRewardedVideo(bool isOn)
	{
	}

	public void setNetworkData(string networkKey, string networkData)
	{
	}

	public void SetPauseGame(bool pause)
	{
	}

	public void setUserId(string userId)
	{
	}

	public void init(string appKey)
	{
	}

	public void init(string appKey, params string[] adUnits)
	{
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
	public void initISDemandOnly(string appKey, params string[] adUnits)
	{
	}

	public void loadRewardedVideo()
	{
	}

	public void showRewardedVideo()
	{
	}

	public void showRewardedVideo(string placementName)
	{
	}

	public IronSourcePlacement getPlacementInfo(string placementName)
	{
		return null;
	}

	public bool isRewardedVideoAvailable()
	{
		return false;
	}

	public bool isRewardedVideoPlacementCapped(string placementName)
	{
		return false;
	}

	public void setRewardedVideoServerParams(Dictionary<string, string> parameters)
	{
	}

	public void clearRewardedVideoServerParams()
	{
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
	public void showISDemandOnlyRewardedVideo(string instanceId)
	{
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
	public void loadISDemandOnlyRewardedVideo(string instanceId)
	{
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
	public bool isISDemandOnlyRewardedVideoAvailable(string instanceId)
	{
		return false;
	}

	public void loadInterstitial()
	{
	}

	public void showInterstitial()
	{
	}

	public void showInterstitial(string placementName)
	{
	}

	public bool isInterstitialReady()
	{
		return false;
	}

	public bool isInterstitialPlacementCapped(string placementName)
	{
		return false;
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
	public void loadISDemandOnlyInterstitial(string instanceId)
	{
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
	public void showISDemandOnlyInterstitial(string instanceId)
	{
	}

	[Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
	public bool isISDemandOnlyInterstitialReady(string instanceId)
	{
		return false;
	}

	[Obsolete("This API call is for the ironSource Offerwall, which will soon be deprecated. Please migrate to the Tapjoy Offerwall using the 'Offerwall migration checklist'.", false)]
	public void showOfferwall()
	{
	}

	[Obsolete("This API call is for the ironSource Offerwall, which will soon be deprecated. Please migrate to the Tapjoy Offerwall using the 'Offerwall migration checklist'.", false)]
	public void showOfferwall(string placementName)
	{
	}

	[Obsolete("This API call is for the ironSource Offerwall, which will soon be deprecated. Please migrate to the Tapjoy Offerwall using the 'Offerwall migration checklist'.", false)]
	public void getOfferwallCredits()
	{
	}

	[Obsolete("This API call is for the ironSource Offerwall, which will soon be deprecated. Please migrate to the Tapjoy Offerwall using the 'Offerwall migration checklist'.", false)]
	public bool isOfferwallAvailable()
	{
		return false;
	}

	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position)
	{
	}

	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName)
	{
	}

	public void destroyBanner()
	{
	}

	public void displayBanner()
	{
	}

	public void hideBanner()
	{
	}

	public bool isBannerPlacementCapped(string placementName)
	{
		return false;
	}

	public float getMaximalAdaptiveHeight(float width)
	{
		return 0f;
	}

	public float getDeviceScreenWidth()
	{
		return 0f;
	}

	public void setSegment(IronSourceSegment segment)
	{
	}

	public void setConsent(bool consent)
	{
	}

	public void loadConsentViewWithType(string consentViewType)
	{
	}

	public void showConsentViewWithType(string consentViewType)
	{
	}

	public void setAdRevenueData(string dataSource, Dictionary<string, string> impressionData)
	{
	}

	public void launchTestSuite()
	{
	}
}

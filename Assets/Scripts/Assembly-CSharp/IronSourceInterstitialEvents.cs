using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IronSourceInterstitialEvents : MonoBehaviour
{
	[CompilerGenerated]
	private static Action<IronSourceAdInfo> m_onAdReadyEvent;

	[CompilerGenerated]
	private static Action<IronSourceError> m_onAdLoadFailedEvent;

	[CompilerGenerated]
	private static Action<IronSourceAdInfo> m_onAdOpenedEvent;

	[CompilerGenerated]
	private static Action<IronSourceAdInfo> m_onAdClosedEvent;

	[CompilerGenerated]
	private static Action<IronSourceAdInfo> m_onAdShowSucceededEvent;

	[CompilerGenerated]
	private static Action<IronSourceError, IronSourceAdInfo> m_onAdShowFailedEvent;

	[CompilerGenerated]
	private static Action<IronSourceAdInfo> m_onAdClickedEvent;

	private IUnityLevelPlayInterstitial LevelPlayInterstitialAndroid;

	public static event Action<IronSourceAdInfo> onAdReadyEvent
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

	public static event Action<IronSourceError> onAdLoadFailedEvent
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

	public static event Action<IronSourceAdInfo> onAdOpenedEvent
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

	public static event Action<IronSourceAdInfo> onAdClosedEvent
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

	public static event Action<IronSourceAdInfo> onAdShowSucceededEvent
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

	public static event Action<IronSourceError, IronSourceAdInfo> onAdShowFailedEvent
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

	public static event Action<IronSourceAdInfo> onAdClickedEvent
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

	private void Awake()
	{
	}

	private void registerInterstitialEvents()
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
}

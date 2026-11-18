using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IronSourceBannerEvents : MonoBehaviour
{
	[CompilerGenerated]
	private static Action<IronSourceAdInfo> m_onAdLoadedEvent;

	[CompilerGenerated]
	private static Action<IronSourceAdInfo> m_onAdLeftApplicationEvent;

	[CompilerGenerated]
	private static Action<IronSourceAdInfo> m_onAdScreenDismissedEvent;

	[CompilerGenerated]
	private static Action<IronSourceAdInfo> m_onAdScreenPresentedEvent;

	[CompilerGenerated]
	private static Action<IronSourceAdInfo> m_onAdClickedEvent;

	[CompilerGenerated]
	private static Action<IronSourceError> m_onAdLoadFailedEvent;

	private IUnityLevelPlayBanner LevelPlaybannerAndroid;

	public static event Action<IronSourceAdInfo> onAdLoadedEvent
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

	public static event Action<IronSourceAdInfo> onAdLeftApplicationEvent
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

	public static event Action<IronSourceAdInfo> onAdScreenDismissedEvent
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

	public static event Action<IronSourceAdInfo> onAdScreenPresentedEvent
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

	private void Awake()
	{
	}

	private void registerBannerEvents()
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

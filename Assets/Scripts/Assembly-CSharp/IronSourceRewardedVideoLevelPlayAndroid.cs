using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IronSourceRewardedVideoLevelPlayAndroid : AndroidJavaProxy, IUnityLevelPlayRewardedVideo
{
	[CompilerGenerated]
	private Action<IronSourceError, IronSourceAdInfo> m_OnAdShowFailed;

	[CompilerGenerated]
	private Action<IronSourceAdInfo> m_OnAdOpened;

	[CompilerGenerated]
	private Action<IronSourceAdInfo> m_OnAdClosed;

	[CompilerGenerated]
	private Action<IronSourcePlacement, IronSourceAdInfo> m_OnAdRewarded;

	[CompilerGenerated]
	private Action<IronSourcePlacement, IronSourceAdInfo> m_OnAdClicked;

	[CompilerGenerated]
	private Action<IronSourceAdInfo> m_OnAdAvailable;

	[CompilerGenerated]
	private Action m_OnAdUnavailable;

	public event Action<IronSourceError, IronSourceAdInfo> OnAdShowFailed
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

	public event Action<IronSourceAdInfo> OnAdOpened
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

	public event Action<IronSourceAdInfo> OnAdClosed
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

	public event Action<IronSourcePlacement, IronSourceAdInfo> OnAdRewarded
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

	public event Action<IronSourcePlacement, IronSourceAdInfo> OnAdClicked
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

	public event Action<IronSourceAdInfo> OnAdAvailable
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

	public event Action OnAdUnavailable
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

	public IronSourceRewardedVideoLevelPlayAndroid()
		: base((string)null)
	{
	}

	private void onAdShowFailed(string description, string data)
	{
	}

	private void onAdClosed(string data)
	{
	}

	private void onAdOpened(string data)
	{
	}

	private void onAdRewarded(string description, string data)
	{
	}

	private void onAdClicked(string description, string data)
	{
	}

	private void onAdAvailable(string data)
	{
	}

	private void onAdUnavailable()
	{
	}
}

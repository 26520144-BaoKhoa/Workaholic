using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IronSourceBannerAndroid : AndroidJavaProxy, IUnityBanner
{
	[CompilerGenerated]
	private Action m_OnBannerAdLoaded;

	[CompilerGenerated]
	private Action m_OnBannerAdLeftApplication;

	[CompilerGenerated]
	private Action m_OnBannerAdScreenDismissed;

	[CompilerGenerated]
	private Action m_OnBannerAdScreenPresented;

	[CompilerGenerated]
	private Action m_OnBannerAdClicked;

	[CompilerGenerated]
	private Action<IronSourceError> m_OnBannerAdLoadFailed;

	public event Action OnBannerAdLoaded
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

	public event Action OnBannerAdLeftApplication
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

	public event Action OnBannerAdScreenDismissed
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

	public event Action OnBannerAdScreenPresented
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

	public event Action OnBannerAdClicked
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

	public event Action<IronSourceError> OnBannerAdLoadFailed
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

	public IronSourceBannerAndroid()
		: base((string)null)
	{
	}

	private void onBannerAdLoaded()
	{
	}

	private void onBannerAdLoadFailed(string args)
	{
	}

	private void onBannerAdClicked()
	{
	}

	private void onBannerAdScreenPresented()
	{
	}

	private void onBannerAdScreenDismissed()
	{
	}

	private void onBannerAdLeftApplication()
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IronSourceRewardedVideoAndroid : AndroidJavaProxy, IUnityRewardedVideo
{
	[CompilerGenerated]
	private Action<IronSourceError> m_OnRewardedVideoAdShowFailed;

	[CompilerGenerated]
	private Action m_OnRewardedVideoAdOpened;

	[CompilerGenerated]
	private Action m_OnRewardedVideoAdClosed;

	[CompilerGenerated]
	private Action m_OnRewardedVideoAdStarted;

	[CompilerGenerated]
	private Action m_OnRewardedVideoAdEnded;

	[CompilerGenerated]
	private Action<IronSourcePlacement> m_OnRewardedVideoAdRewarded;

	[CompilerGenerated]
	private Action<IronSourcePlacement> m_OnRewardedVideoAdClicked;

	[CompilerGenerated]
	private Action<bool> m_OnRewardedVideoAvailabilityChanged;

	[CompilerGenerated]
	private Action<string> m_OnRewardedVideoAdOpenedDemandOnlyEvent;

	[CompilerGenerated]
	private Action<string> m_OnRewardedVideoAdClosedDemandOnlyEvent;

	[CompilerGenerated]
	private Action<string> m_OnRewardedVideoAdLoadedDemandOnlyEvent;

	[CompilerGenerated]
	private Action<string> m_OnRewardedVideoAdRewardedDemandOnlyEvent;

	[CompilerGenerated]
	private Action<string, IronSourceError> m_OnRewardedVideoAdShowFailedDemandOnlyEvent;

	[CompilerGenerated]
	private Action<string> m_OnRewardedVideoAdClickedDemandOnlyEvent;

	[CompilerGenerated]
	private Action<string, IronSourceError> m_OnRewardedVideoAdLoadFailedDemandOnlyEvent;

	public event Action<IronSourceError> OnRewardedVideoAdShowFailed
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

	public event Action OnRewardedVideoAdOpened
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

	public event Action OnRewardedVideoAdClosed
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

	public event Action OnRewardedVideoAdStarted
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

	public event Action OnRewardedVideoAdEnded
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

	public event Action<IronSourcePlacement> OnRewardedVideoAdRewarded
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

	public event Action<IronSourcePlacement> OnRewardedVideoAdClicked
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

	public event Action<bool> OnRewardedVideoAvailabilityChanged
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

	public event Action<string> OnRewardedVideoAdOpenedDemandOnlyEvent
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

	public event Action<string> OnRewardedVideoAdClosedDemandOnlyEvent
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

	public event Action<string> OnRewardedVideoAdLoadedDemandOnlyEvent
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

	public event Action<string> OnRewardedVideoAdRewardedDemandOnlyEvent
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

	public event Action<string, IronSourceError> OnRewardedVideoAdShowFailedDemandOnlyEvent
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

	public event Action<string> OnRewardedVideoAdClickedDemandOnlyEvent
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

	public event Action<string, IronSourceError> OnRewardedVideoAdLoadFailedDemandOnlyEvent
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

	public IronSourceRewardedVideoAndroid()
		: base((string)null)
	{
	}

	private void onRewardedVideoAdShowFailed(string description)
	{
	}

	private void onRewardedVideoAdClosed()
	{
	}

	private void onRewardedVideoAdOpened()
	{
	}

	private void onRewardedVideoAdStarted()
	{
	}

	private void onRewardedVideoAdEnded()
	{
	}

	private void onRewardedVideoAdRewarded(string description)
	{
	}

	private void onRewardedVideoAdClicked(string description)
	{
	}

	private void onRewardedVideoAvailabilityChanged(string stringAvailable)
	{
	}

	private void onRewardedVideoAdShowFailedDemandOnly(string args)
	{
	}

	private void onRewardedVideoAdClosedDemandOnly(string instanceId)
	{
	}

	private void onRewardedVideoAdOpenedDemandOnly(string instanceId)
	{
	}

	private void onRewardedVideoAdRewardedDemandOnly(string instanceId)
	{
	}

	private void onRewardedVideoAdClickedDemandOnly(string instanceId)
	{
	}

	private void onRewardedVideoAdLoadedDemandOnly(string instanceId)
	{
	}

	private void onRewardedVideoAdLoadFailedDemandOnly(string args)
	{
	}
}

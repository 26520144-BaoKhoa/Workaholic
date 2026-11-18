using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IronSourceRewardedVideoManualAndroid : AndroidJavaProxy, IUnityRewardedVideoManual
{
	[CompilerGenerated]
	private Action<IronSourceError> m_OnRewardedVideoAdLoadFailed;

	[CompilerGenerated]
	private Action m_OnRewardedVideoAdReady;

	public event Action<IronSourceError> OnRewardedVideoAdLoadFailed
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

	public event Action OnRewardedVideoAdReady
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

	public IronSourceRewardedVideoManualAndroid()
		: base((string)null)
	{
	}

	private void onRewardedVideoAdReady()
	{
	}

	private void onRewardedVideoAdLoadFailed(string args)
	{
	}
}

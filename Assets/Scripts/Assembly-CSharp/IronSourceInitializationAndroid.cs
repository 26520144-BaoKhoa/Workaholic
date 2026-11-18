using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IronSourceInitializationAndroid : AndroidJavaProxy, IUnityInitialization
{
	[CompilerGenerated]
	private Action m_OnSdkInitializationCompletedEvent;

	public event Action OnSdkInitializationCompletedEvent
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

	public IronSourceInitializationAndroid()
		: base((string)null)
	{
	}

	private void onSdkInitializationCompleted()
	{
	}
}

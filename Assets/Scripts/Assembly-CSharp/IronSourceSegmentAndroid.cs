using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IronSourceSegmentAndroid : AndroidJavaProxy, IUnitySegment
{
	[CompilerGenerated]
	private Action<string> m_OnSegmentRecieved;

	public event Action<string> OnSegmentRecieved
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

	public IronSourceSegmentAndroid()
		: base((string)null)
	{
	}

	public void onSegmentRecieved(string segmentName)
	{
	}
}

using UnityEngine;

public static class Vibration
{
	public static AndroidJavaClass unityPlayer;

	public static AndroidJavaObject currentActivity;

	public static AndroidJavaObject vibrator;

	public static AndroidJavaObject context;

	public static AndroidJavaClass vibrationEffect;

	private static bool initialized;

	public static int AndroidVersion => 0;

	public static void Init()
	{
	}

	public static void VibrateIOS(ImpactFeedbackStyle style)
	{
	}

	public static void VibrateIOS(NotificationFeedbackStyle style)
	{
	}

	public static void VibrateIOS_SelectionChanged()
	{
	}

	public static void VibratePop()
	{
	}

	public static void VibratePeek()
	{
	}

	public static void VibrateNope()
	{
	}

	public static void VibrateAndroid(long milliseconds)
	{
	}

	public static void VibrateAndroid(long[] pattern, int repeat)
	{
	}

	public static void CancelAndroid()
	{
	}

	public static bool HasVibrator()
	{
		return false;
	}

	public static void Vibrate()
	{
	}
}

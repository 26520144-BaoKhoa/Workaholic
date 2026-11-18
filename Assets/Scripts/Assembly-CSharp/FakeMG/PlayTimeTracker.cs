using UnityEngine;
using UnityEngine.Events;

namespace FakeMG
{
	public class PlayTimeTracker : MonoBehaviour
	{
		[SerializeField]
		private float playTime;

		[SerializeField]
		private UnityEvent playAd;

		private static int _adCount;

		private float _startTime;

		private float _endTime;

		public void GetStartTime()
		{
		}

		public void GetEndTime()
		{
		}

		public void CheckPlayTimeToWatchAd()
		{
		}

		private float GetPlayTime()
		{
			return 0f;
		}
	}
}

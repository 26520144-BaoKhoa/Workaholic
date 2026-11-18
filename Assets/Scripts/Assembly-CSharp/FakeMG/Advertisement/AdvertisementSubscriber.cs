using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.Advertisement
{
	public class AdvertisementSubscriber : MonoBehaviour
	{
		public UnityEvent subscribeToRewardAd;

		[SerializeField]
		private AdSubscribeEventChannel adSubscribeEventChannel;

		public void Subscribe()
		{
		}
	}
}

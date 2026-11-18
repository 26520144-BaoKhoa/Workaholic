using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.Coin
{
	public class CoinBehavior : MonoBehaviour
	{
		[SerializeField]
		private CoinCounter coinCounter;

		[SerializeField]
		private UnityEvent onCoinCollected;

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}

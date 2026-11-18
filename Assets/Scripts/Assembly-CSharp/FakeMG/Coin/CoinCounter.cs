using FakeMG.IAP;
using FakeMG.Server.SaveLoad;
using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.Coin
{
	public class CoinCounter : MonoBehaviour
	{
		[SerializeField]
		private PlayerDataSO playerDataSO;

		[SerializeField]
		private InAppPurchaseItemSO doubleCoinsItemSO;

		[SerializeField]
		private UnityEvent<double, double> onCoinIncrease;

		private double _coinCount;

		private double _coinValue;

		private void Start()
		{
		}

		public void AddCoins(float coins)
		{
		}

		public void AddSingleCoin()
		{
		}

		public void AddCurrentCoinCountToCache()
		{
		}

		public void DoubleTheCoins()
		{
		}
	}
}

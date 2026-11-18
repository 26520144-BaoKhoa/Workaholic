using FakeMG.Server.SaveLoad;
using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.PowerUps
{
	public class UpgradePowerUp : MonoBehaviour
	{
		[SerializeField]
		private PowerUpSO powerUpSO;

		[SerializeField]
		private PlayerDataSO playerDataSO;

		[SerializeField]
		private UnityEvent onUpgradeSuccess;

		[SerializeField]
		private UnityEvent onNotEnoughCoins;

		public void Upgrade()
		{
		}
	}
}

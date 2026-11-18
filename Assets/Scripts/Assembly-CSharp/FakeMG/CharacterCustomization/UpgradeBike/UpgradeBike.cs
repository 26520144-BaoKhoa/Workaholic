using FakeMG.CharacterCustomization.Item;
using FakeMG.Server.SaveLoad;
using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.CharacterCustomization.UpgradeBike
{
	public class UpgradeBike : MonoBehaviour
	{
		[SerializeField]
		private PlayerDataSO playerDataSO;

		[SerializeField]
		public UnityEvent onUpgradeSuccess;

		[SerializeField]
		private UnityEvent onNotEnoughCoins;

		private BikeSO _bikeSO;

		public void SetBikeSO(BikeSO bikeSO)
		{
		}

		public void Upgrade()
		{
		}
	}
}

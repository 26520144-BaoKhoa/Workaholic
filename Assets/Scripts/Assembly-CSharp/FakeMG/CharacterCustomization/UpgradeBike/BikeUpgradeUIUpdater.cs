using FakeMG.CharacterCustomization.Item;
using FakeMG.Server.SaveLoad;
using UnityEngine;
using UnityEngine.UI;

namespace FakeMG.CharacterCustomization.UpgradeBike
{
	public class BikeUpgradeUIUpdater : MonoBehaviour
	{
		[SerializeField]
		[Header("UI Elements")]
		private Image bikeIcon;

		[SerializeField]
		private Text bikeName;

		[SerializeField]
		private Text currentDuration;

		[SerializeField]
		private Text nextDuration;

		[SerializeField]
		private Text price;

		[Header("Data")]
		[SerializeField]
		private PlayerDataSO playerDataSO;

		private BikeSO _bikeSO;

		public void UpdateUI()
		{
		}

		public void SetBikeSO(BikeSO bikeSO)
		{
		}
	}
}

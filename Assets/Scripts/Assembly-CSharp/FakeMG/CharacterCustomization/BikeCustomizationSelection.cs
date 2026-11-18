using FakeMG.CharacterCustomization.Item;
using FakeMG.CharacterCustomization.UpgradeBike;
using FakeMG.UI;
using UnityEngine;

namespace FakeMG.CharacterCustomization
{
	public class BikeCustomizationSelection : CustomizationSelection
	{
		[Header("Bike Customization")]
		[SerializeField]
		private CustomButton upgradeButton;

		[SerializeField]
		private BikeUpgradeUIUpdater bikeUpgradeUIUpdater;

		[SerializeField]
		private FakeMG.CharacterCustomization.UpgradeBike.UpgradeBike upgradeBike;

		protected new void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		protected override void ShowAsset(CustomizationItemSO assetSO)
		{
		}

		private void UpdateUpgradeButton()
		{
		}

		private void UpdateNitroTimeUI()
		{
		}

		private void SetBikeSO()
		{
		}

		protected override string Key()
		{
			return null;
		}

		protected override string DefaultValue()
		{
			return null;
		}
	}
}

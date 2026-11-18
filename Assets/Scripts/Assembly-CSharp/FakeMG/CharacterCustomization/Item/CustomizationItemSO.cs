using UnityEngine;

namespace FakeMG.CharacterCustomization.Item
{
	[CreateAssetMenu(menuName = "Customization/Item")]
	public class CustomizationItemSO : StoreItemSO
	{
		[SerializeField]
		private GameObject itemPrefab;

		public GameObject ItemPrefab => null;
	}
}

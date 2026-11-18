using UnityEngine;

namespace FakeMG.CharacterCustomization.Item
{
	[CreateAssetMenu(menuName = "StoreItem")]
	public class StoreItemSO : ScriptableObject
	{
		[SerializeField]
		private string id;

		[SerializeField]
		private string itemName;

		[SerializeField]
		private int price;

		[SerializeField]
		private Sprite icon;

		[SerializeField]
		private Sprite currencyIcon;

		[SerializeField]
		private bool isGem;

		public string ID => null;

		public string ItemName => null;

		public int Price => 0;

		public Sprite Icon => null;

		public Sprite CurrencyIcon => null;

		public bool IsGem => false;
	}
}

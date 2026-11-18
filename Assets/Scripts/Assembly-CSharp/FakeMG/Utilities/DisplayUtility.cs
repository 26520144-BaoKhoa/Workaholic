using FakeMG.CharacterCustomization.Item;
using FakeMG.Server.SaveLoad;
using FakeMG.UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace FakeMG.Utilities
{
	public class DisplayUtility : MonoBehaviour
	{
		[SerializeField]
		private StoreItemSO item;

		[SerializeField]
		private PlayerDataSO playerData;

		[SerializeField]
		private Text amountText;

		[SerializeField]
		private Text priceText;

		[SerializeField]
		private Color enoughCoinColor;

		[SerializeField]
		private Color notEnoughCoinColor;

		[SerializeField]
		private GameObject priceObject;

		[SerializeField]
		private CustomButton button;

		[SerializeField]
		private UnityEvent activateItem;

		private int _currentAmount;

		private int _coinInDebt;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		public void AddAmount(int amount)
		{
		}

		private void UpdateText()
		{
		}

		private void Buy()
		{
		}

		public void CacheData()
		{
		}
	}
}

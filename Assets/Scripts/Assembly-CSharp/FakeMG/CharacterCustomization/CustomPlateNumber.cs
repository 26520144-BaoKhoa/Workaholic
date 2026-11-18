using FakeMG.Server.SaveLoad;
using FakeMG.UI;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace FakeMG.CharacterCustomization
{
	public class CustomPlateNumber : MonoBehaviour
	{
		[Header("Plate Number")]
		[SerializeField]
		private TextMeshPro plateNumberLine1;

		[SerializeField]
		private TextMeshPro plateNumberLine2;

		[SerializeField]
		[Header("Input Field")]
		private InputField inputFieldLine1;

		[SerializeField]
		private InputField inputFieldLine2;

		[Header("Button")]
		[SerializeField]
		private CustomButton revertButton;

		[SerializeField]
		private CustomButton actionButton;

		[SerializeField]
		private CustomButton saveButton;

		[SerializeField]
		private Text saveButtonText;

		[Header("Event")]
		[SerializeField]
		private UnityEvent onNotEnoughCoins;

		[SerializeField]
		private UnityEvent onPlateNumberSaved;

		[Header("Other")]
		[SerializeField]
		private PlayerDataSO playerDataSO;

		[SerializeField]
		private float priceToSavePlateNumber;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnValueChangedLine1(string value)
		{
		}

		private void OnValueChangedLine2(string value)
		{
		}

		public void Revert()
		{
		}

		public void SavePlateNumber()
		{
		}
	}
}

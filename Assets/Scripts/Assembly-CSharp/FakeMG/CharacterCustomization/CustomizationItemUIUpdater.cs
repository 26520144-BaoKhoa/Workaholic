using FakeMG.UI;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace FakeMG.CharacterCustomization
{
	public class CustomizationItemUIUpdater : MonoBehaviour
	{
		[SerializeField]
		private Image icon;

		[SerializeField]
		private TextMeshProUGUI title;

		[SerializeField]
		private GameObject chosenOverlay;

		[SerializeField]
		private CustomButton customButton;

		private Image _background;

		public bool IsCurrentlyViewed { get; private set; }

		private void Awake()
		{
		}

		public void SetActive(Color color)
		{
		}

		public void SetInactive(Color color)
		{
		}

		public void EnableChosenOverlay()
		{
		}

		public void DisableChosenOverlay()
		{
		}

		public void SetUp(Sprite icon, string title)
		{
		}

		public void SetUpOnClicked(UnityAction action)
		{
		}
	}
}

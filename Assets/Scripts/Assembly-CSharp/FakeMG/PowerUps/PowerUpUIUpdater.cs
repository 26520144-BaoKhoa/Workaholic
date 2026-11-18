using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace FakeMG.PowerUps
{
	public class PowerUpUIUpdater : MonoBehaviour
	{
		[SerializeField]
		private Slider slider;

		[SerializeField]
		private Image fillImage;

		[SerializeField]
		private Image icon;

		[SerializeField]
		private Color[] colors;

		public UnityAction<string> OnPowerUpEnd;

		private string _powerUpName;

		private float _duration;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void UpdateDuration()
		{
		}

		public void UpdateUI(string powerUpName, Sprite icon, float duration)
		{
		}
	}
}

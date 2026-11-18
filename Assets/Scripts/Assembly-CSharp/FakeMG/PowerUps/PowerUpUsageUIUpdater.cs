using UnityEngine;
using UnityEngine.UI;

namespace FakeMG.PowerUps
{
	public class PowerUpUsageUIUpdater : MonoBehaviour
	{
		[SerializeField]
		private Image usageImagePrefab;

		private Image[] _usageImages;

		private void Start()
		{
		}

		public void UpdateUI(string powerUpName, Sprite icon, float usage)
		{
		}

		public void RemoveOne()
		{
		}
	}
}

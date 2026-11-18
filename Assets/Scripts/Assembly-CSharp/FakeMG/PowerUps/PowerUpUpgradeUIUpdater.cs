using FakeMG.Server.SaveLoad;
using UnityEngine;
using UnityEngine.UI;

namespace FakeMG.PowerUps
{
	public class PowerUpUpgradeUIUpdater : MonoBehaviour
	{
		[Header("UI Elements")]
		[SerializeField]
		private Image powerUpIcon;

		[SerializeField]
		private Text powerUpName;

		[SerializeField]
		private Text currentDuration;

		[SerializeField]
		private Text nextDuration;

		[SerializeField]
		private Text price;

		[Header("Data")]
		[SerializeField]
		private PowerUpSO powerUpSO;

		[SerializeField]
		private PlayerDataSO playerDataSO;

		private void Start()
		{
		}

		public void UpdateUI()
		{
		}
	}
}

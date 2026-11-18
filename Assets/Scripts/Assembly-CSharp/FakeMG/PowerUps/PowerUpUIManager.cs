using System.Collections.Generic;
using UnityEngine;

namespace FakeMG.PowerUps
{
	public class PowerUpUIManager : MonoBehaviour
	{
		[SerializeField]
		private GameObject powerUpUIPrefab;

		private readonly Dictionary<string, PowerUpUIUpdater> _powerUpUIs;

		public void AddPowerUpUI(string powerUpName, Sprite icon, float duration)
		{
		}

		private void CleanPowerUpUIs(string powerUpName)
		{
		}
	}
}

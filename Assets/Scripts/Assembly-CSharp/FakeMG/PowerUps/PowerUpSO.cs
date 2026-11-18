using UnityEngine;

namespace FakeMG.PowerUps
{
	[CreateAssetMenu(menuName = "PowerUp")]
	public class PowerUpSO : ScriptableObject
	{
		[Header("PowerUp")]
		public PowerUpType powerUpType;

		public Sprite powerUpIcon;

		[Header("Upgrade")]
		public int[] powerUpCost;

		public int[] upgradeDetail;

		public string PowerUpName => null;

		private void OnValidate()
		{
		}
	}
}

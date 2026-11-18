using FakeMG.Server.SaveLoad;
using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.PowerUps
{
	public abstract class PowerUp : MonoBehaviour
	{
		[SerializeField]
		private PlayerDataSO playerDataSO;

		[SerializeField]
		public PowerUpSO powerUpSo;

		[SerializeField]
		public GameObject powerUpPrefab;

		[SerializeField]
		private UnityEvent<string, Sprite, float> onRenewPowerUp;

		[SerializeField]
		private UnityEvent onStartPowerUp;

		[SerializeField]
		private UnityEvent onStopPowerUp;

		[HideInInspector]
		public float remainingUsage;

		public bool IsActive { get; private set; }

		public virtual void Activate()
		{
		}

		public void RenewPowerUp()
		{
		}

		protected void Deactivate()
		{
		}

		private void StartPowerUp()
		{
		}

		private void StopPowerUp()
		{
		}
	}
}

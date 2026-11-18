using DG.Tweening;
using UnityEngine;

namespace FakeMG.Movement
{
	public class IncreaseSpeed : MonoBehaviour
	{
		[SerializeField]
		private float minSpeed;

		[SerializeField]
		private float maxSpeed;

		[SerializeField]
		private float speedIncreaseDuration;

		private KartController _kartController;

		private Tweener _tweener;

		private void Start()
		{
		}

		public void Pause()
		{
		}

		public void Resume()
		{
		}
	}
}

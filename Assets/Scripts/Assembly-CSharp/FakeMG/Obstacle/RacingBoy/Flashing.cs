using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.Obstacle.RacingBoy
{
	public class Flashing : MonoBehaviour
	{
		public UnityEvent onFlashEnd;

		public UnityEvent onFlickeringStart;

		private Tween _firstHalfTween;

		private const float DURATION = 1.5f;

		private const float FLICKERING_DURATION = 0.1f;

		private const int FLICKERING_LOOP = 10;

		private Material _material;

		private Sequence _sequence;

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		public void Flash()
		{
		}
	}
}

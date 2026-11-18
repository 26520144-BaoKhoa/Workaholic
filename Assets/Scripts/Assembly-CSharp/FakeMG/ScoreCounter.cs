using FakeMG.Server.SaveLoad;
using UnityEngine;
using UnityEngine.Events;

namespace FakeMG
{
	public class ScoreCounter : MonoBehaviour
	{
		[SerializeField]
		private Transform player;

		[SerializeField]
		private PlayerDataSO playerDataSO;

		[SerializeField]
		private UnityEvent<double, double> onScoreIncrease;

		private double _score;

		private double _previousPos;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void CacheHighScore()
		{
		}

		public double GetScore()
		{
			return 0.0;
		}
	}
}

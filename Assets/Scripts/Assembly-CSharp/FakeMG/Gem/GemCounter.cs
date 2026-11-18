using FakeMG.Server.SaveLoad;
using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.Gem
{
	public class GemCounter : MonoBehaviour
	{
		[SerializeField]
		private PlayerDataSO playerDataSO;

		[SerializeField]
		private UnityEvent<double, double> onGemIncrease;

		private double _gemCount;

		public void AddGems(float gems)
		{
		}

		public void AddCurrentGemCountToCache()
		{
		}
	}
}

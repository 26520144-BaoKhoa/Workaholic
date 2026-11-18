using System;
using AYellowpaper.SerializedCollections;
using FakeMG.PowerUps;

namespace FakeMG.Server.SaveLoad
{
	[Serializable]
	public class PlayerData
	{
		public int age;

		public double highScore;

		public double coinCount;

		public double gemCount;

		public string plateNumberLine1;

		public string plateNumberLine2;

		public DateTime LastDailyRewardDate;

		public DateTime LastDailyRewardRollDate;

		public string lastDailyRewardItem;

		public SerializedDictionary<string, int> bikes;

		public SerializedDictionary<PowerUpType, int> powerUps;

		public SerializedDictionary<string, bool> nonConsumableItems;

		public SerializedDictionary<string, int> consumableItems;

		public PlayerData()
		{
		}

		public PlayerData(PlayerData playerData)
		{
		}
	}
}

using Unity.Services.Leaderboards.Models;
using UnityEngine;

namespace FakeMG.Server.SaveLoad
{
	[CreateAssetMenu(menuName = "PlayerData")]
	public class PlayerDataSO : ScriptableObject
	{
		public PlayerData playerData;

		public LeaderboardEntry PlayerScore;
	}
}

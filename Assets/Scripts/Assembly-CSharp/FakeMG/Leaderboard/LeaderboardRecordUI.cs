using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace FakeMG.Leaderboard
{
	public class LeaderboardRecordUI : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI rank;

		[SerializeField]
		private TextMeshProUGUI recordName;

		[SerializeField]
		private TextMeshProUGUI score;

		[SerializeField]
		private Image background;

		private readonly Color _isPlayerColor;

		private readonly Color _oddColor;

		private readonly Color _evenColor;

		public void SetRecord(int pRank, string pName, double pScore, bool isPlayer = false)
		{
		}

		public void SetPlayerName(string pName)
		{
		}
	}
}

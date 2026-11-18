using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FakeMG.Server.SaveLoad;
using Unity.Services.Leaderboards.Models;
using UnityEngine;

namespace FakeMG.Leaderboard
{
	public class PlayerLeaderboardScoreUpdater : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUpdatePlayerLeaderboardScore_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PlayerLeaderboardScoreUpdater _003C_003E4__this;

			private PlayerDataSO _003C_003E7__wrap1;

			private TaskAwaiter<LeaderboardEntry> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[SerializeField]
		private Rigidbody playerRigidbody;

		[SerializeField]
		private PlayerDataSO playerDataSO;

		[SerializeField]
		private OriginRebase originRebase;

		[SerializeField]
		private ScoreCounter scoreCounter;

		[AsyncStateMachine(typeof(_003CUpdatePlayerLeaderboardScore_003Ed__4))]
		public void UpdatePlayerLeaderboardScore()
		{
		}
	}
}

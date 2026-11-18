using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using FakeMG.Server.SaveLoad;
using Unity.Services.Leaderboards.Models;
using UnityEngine;

namespace FakeMG.Leaderboard
{
	public class Leaderboard : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetScoresByTier_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<LeaderboardTierScoresPage> _003C_003Et__builder;

			public Leaderboard _003C_003E4__this;

			private TaskAwaiter<LeaderboardTierScoresPage> _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStart_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public Leaderboard _003C_003E4__this;

			private TaskAwaiter<LeaderboardTierScoresPage> _003C_003Eu__1;

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
		private PlayerDataSO playerDataSO;

		[SerializeField]
		private LeaderboardRecordUI leaderboardRecordUI;

		[SerializeField]
		private Tier tierID;

		private const string LEADERBOARD_ID = "high_score";

		private const int OFFSET = 0;

		private const int LIMIT = 50;

		private LeaderboardRecordUI _playerRecord;

		private void OnEnable()
		{
		}

		[AsyncStateMachine(typeof(_003CStart_003Ed__8))]
		private void Start()
		{
		}

		[AsyncStateMachine(typeof(_003CGetScoresByTier_003Ed__9))]
		private Task<LeaderboardTierScoresPage> GetScoresByTier()
		{
			return null;
		}

		private void PopulateUI(LeaderboardTierScoresPage scoresPage)
		{
		}

		private void SpawnPlayerRecord()
		{
		}
	}
}

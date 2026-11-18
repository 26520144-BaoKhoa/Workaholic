using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Unity.Services.CloudSave.Models;
using Unity.Services.Leaderboards.Models;
using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.Server.SaveLoad
{
	public class Loader : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetPlayerScore_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<LeaderboardEntry> _003C_003Et__builder;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoad_003Ed__5<T> : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

			public string key;

			private TaskAwaiter<Dictionary<string, Item>> _003C_003Eu__1;

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
		private struct _003CLoadAll_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public Loader _003C_003E4__this;

			private PlayerDataSO _003C_003E7__wrap1;

			private TaskAwaiter<PlayerData> _003C_003Eu__1;

			private TaskAwaiter<LeaderboardEntry> _003C_003Eu__2;

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
		private UnityEvent onLoaded;

		private const string LEADERBOARD_ID = "high_score";

		[AsyncStateMachine(typeof(_003CLoadAll_003Ed__3))]
		public void LoadAll()
		{
		}

		[AsyncStateMachine(typeof(_003CGetPlayerScore_003Ed__4))]
		private Task<LeaderboardEntry> GetPlayerScore()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLoad_003Ed__5<>))]
		private Task<T> Load<T>(string key)
		{
			return null;
		}
	}
}

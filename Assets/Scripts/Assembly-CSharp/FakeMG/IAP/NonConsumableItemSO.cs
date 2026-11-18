using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FakeMG.Server.SaveLoad;
using UnityEngine;
using UnityEngine.Purchasing;

namespace FakeMG.IAP
{
	[CreateAssetMenu(menuName = "IAP Item/NonConsumable Item")]
	public class NonConsumableItemSO : InAppPurchaseItemSO
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSaveData_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NonConsumableItemSO _003C_003E4__this;

			public Action callback;

			private TaskAwaiter<Dictionary<string, string>> _003C_003Eu__1;

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

		public override void HandlePurchase(StoreController storeController, PendingOrder pendingOrder)
		{
		}

		[AsyncStateMachine(typeof(_003CSaveData_003Ed__2))]
		private void SaveData(Action callback = null)
		{
		}
	}
}

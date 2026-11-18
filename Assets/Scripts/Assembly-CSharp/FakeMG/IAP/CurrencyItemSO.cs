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
	[CreateAssetMenu(menuName = "IAP Item/Currency")]
	public class CurrencyItemSO : InAppPurchaseItemSO
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSaveData_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public CurrencyItemSO _003C_003E4__this;

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

		[SerializeField]
		private int value;

		[SerializeField]
		private bool isGem;

		public override void HandlePurchase(StoreController storeController, PendingOrder pendingOrder)
		{
		}

		[AsyncStateMachine(typeof(_003CSaveData_003Ed__4))]
		private void SaveData(Action callback = null)
		{
		}
	}
}

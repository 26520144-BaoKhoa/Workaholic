using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using FakeMG.EventChannels;
using FakeMG.Server.SaveLoad;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.Purchasing;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace FakeMG.IAP
{
	public class InAppPurchase : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitializeIAPAsync_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public InAppPurchase _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

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
		private bool useFakeStore;

		[SerializeField]
		private IAPItemUIUpdater iapItemPrefab;

		[SerializeField]
		private ItemPurchaseEventChannel itemPurchaseEventChannel;

		[SerializeField]
		private AssetLabelReference iapItemLabel;

		[SerializeField]
		private Image blackBG;

		[SerializeField]
		private PlayerDataSO playerDataSO;

		[SerializeField]
		private UnityEvent onPurchaseFailed;

		private StoreController _storeController;

		private InAppPurchaseItemSO _currentPurchaseItemSo;

		private List<InAppPurchaseItemSO> _iapItems;

		private AsyncOperationHandle<IList<InAppPurchaseItemSO>> _iapItemsHandle;

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		private void HandleIAPCatalogLoaded(AsyncOperationHandle<IList<InAppPurchaseItemSO>> asyncOperationHandle)
		{
		}

		[AsyncStateMachine(typeof(_003CInitializeIAPAsync_003Ed__14))]
		private Task InitializeIAPAsync()
		{
			return null;
		}

		private void PurchaseProduct(InAppPurchaseItemSO itemSo)
		{
		}

		private void CreateUI()
		{
		}

		private void OnProductsFetched(List<Product> products)
		{
		}

		private void OnPurchasesFetched(Orders orders)
		{
		}

		private void OnPurchasesFetchFailed(PurchasesFetchFailureDescription description)
		{
		}

		private void OnPurchasePending(PendingOrder pendingOrder)
		{
		}

		private void OnPurchaseFailedHandler(FailedOrder failedOrder)
		{
		}

		private void OnStoreDisconnected(StoreConnectionFailureDescription failureDescription)
		{
		}

		private void HideBlackBackground()
		{
		}
	}
}

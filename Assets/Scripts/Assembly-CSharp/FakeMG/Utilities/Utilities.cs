using System.Collections.Generic;
using FakeMG.CharacterCustomization;
using FakeMG.CharacterCustomization.Item;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace FakeMG.Utilities
{
	public class Utilities : StoreItemPurchaseHandler
	{
		[SerializeField]
		private AssetLabelReference utilitiesLabel;

		[SerializeField]
		private UtilitiesItemUIUpdater itemUIUpdater;

		[SerializeField]
		protected UnityEvent onPurchaseSuccess;

		private AsyncOperationHandle<IList<StoreItemSO>> _handle;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void HandlePurchase(StoreItemSO item)
		{
		}
	}
}

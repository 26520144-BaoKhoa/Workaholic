using System;
using System.Collections.Generic;
using FakeMG.CharacterCustomization.Item;
using FakeMG.UI;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace FakeMG.CharacterCustomization
{
	public abstract class CustomizationSelection : StoreItemPurchaseHandler
	{
		[SerializeField]
		private AssetLabelReference assetLabel;

		[SerializeField]
		private CustomizationItemUIUpdater customizationItemUIUpdater;

		[SerializeField]
		protected SetUpSelectedPlayerModel setUpSelectedPlayerModel;

		[SerializeField]
		protected UnityEvent onPurchaseSuccess;

		[SerializeField]
		[Header("Action Button")]
		private CustomButton actionButton;

		[SerializeField]
		private Text textOnActionButton;

		[SerializeField]
		private Image coinImageOnActionButton;

		protected List<CustomizationItemUIUpdater> AssetUI;

		protected AsyncOperationHandle<IList<CustomizationItemSO>> AssetHandle;

		private CustomizationItemUIUpdater _currentViewedAssetItemUI;

		protected CustomizationItemSO CurrentViewedAssetSO;

		protected Action OnDefaultAssetSelected;

		protected Action OnAllAssetUICreated;

		private readonly Color _normalColor;

		private readonly Color _pressedColor;

		protected void Awake()
		{
		}

		protected void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void ResetTabs()
		{
		}

		protected abstract void ShowAsset(CustomizationItemSO assetSO);

		private void UpdateActionButton(CustomizationItemSO item)
		{
		}

		protected abstract string Key();

		protected abstract string DefaultValue();
	}
}

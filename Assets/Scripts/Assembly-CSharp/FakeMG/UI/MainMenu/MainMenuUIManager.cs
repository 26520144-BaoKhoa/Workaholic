using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FakeMG.Server.SaveLoad;
using FakeMG.UI.Tab;
using Unity.Services.Authentication;
using UnityEngine;
using UnityEngine.UI;

namespace FakeMG.UI.MainMenu
{
	public class MainMenuUIManager : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCheck_003Ed__37 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public MainMenuUIManager _003C_003E4__this;

			private TaskAwaiter<PlayerInfo> _003C_003Eu__1;

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

		[CompilerGenerated]
		private sealed class _003CDelayCheckCoroutine_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MainMenuUIManager _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDelayCheckCoroutine_003Ed__36(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		[Header("Currency")]
		private Text coinText;

		[SerializeField]
		private Text gemText;

		[SerializeField]
		[Header("Google")]
		private Text buttonText;

		[SerializeField]
		private Text statusText;

		[Header("No internet")]
		[SerializeField]
		private RectTransform noInternetScreenRect;

		[SerializeField]
		private CanvasGroup noInternetCanvasGroup;

		[SerializeField]
		private GameObject noInternetOverlay;

		[SerializeField]
		[Header("Link conflict")]
		private RectTransform linkConflictScreenRect;

		[SerializeField]
		private CanvasGroup linkConflictCanvasGroup;

		[SerializeField]
		[Header("Not Enough Coin")]
		private RectTransform notEnoughCoinScreenRect;

		[SerializeField]
		private CanvasGroup notEnoughCoinCanvasGroup;

		[SerializeField]
		[Header("Purchase Successful")]
		private RectTransform purchaseSuccessfulScreenRect;

		[SerializeField]
		private CanvasGroup purchaseSuccessfulCanvasGroup;

		[SerializeField]
		[Header("Purchase Failed")]
		private RectTransform purchaseFailedScreenRect;

		[SerializeField]
		private CanvasGroup purchaseFailedCanvasGroup;

		[Header("Leaderboard")]
		[SerializeField]
		private RectTransform leaderboardRect;

		[SerializeField]
		private CanvasGroup leaderboardCanvasGroup;

		[SerializeField]
		private Text timeTillReset;

		[SerializeField]
		private TabGroup tabGroup;

		[SerializeField]
		private PlayerDataSO playerDataSO;

		[SerializeField]
		private List<GameObject> leaderboardPlayerIndicator;

		[SerializeField]
		[Header("Settings")]
		private RectTransform settingsRect;

		[SerializeField]
		private CanvasGroup settingsCanvasGroup;

		[SerializeField]
		private Slider sfxSlider;

		[SerializeField]
		private Slider musicSlider;

		[SerializeField]
		private Text playerIDText;

		[SerializeField]
		private Toggle tiltToSteerToggle;

		[SerializeField]
		[Header("Other")]
		private Image blackBG;

		[SerializeField]
		private RectTransform tapToPlayRect;

		private const float BLACK_BG_ALPHA = 0.8f;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private string TimeUntilNextMonday()
		{
			return null;
		}

		public void ShowLeaderboard()
		{
		}

		public void HideLeaderboard()
		{
		}

		public void DelayCheck()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayCheckCoroutine_003Ed__36))]
		private IEnumerator DelayCheckCoroutine()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCheck_003Ed__37))]
		private void Check()
		{
		}

		private void ShowNoInternetScreen()
		{
		}

		public void HideNoInternetScreen()
		{
		}

		public void ShowLinkConflict()
		{
		}

		public void HideLinkConflict()
		{
		}

		public void ShowNotEnoughCoin()
		{
		}

		public void HideNotEnoughCoin()
		{
		}

		public void ShowPurchaseSuccessful()
		{
		}

		public void HidePurchaseSuccessful()
		{
		}

		public void ShowPurchaseFailed()
		{
		}

		public void HidePurchaseFailed()
		{
		}

		public void ShowSettings()
		{
		}

		public void HideSettings()
		{
		}

		public void ToggleTiltToSteer(bool tiltToSteer)
		{
		}

		public void UpdateCurrencyText()
		{
		}

		private void PopupUI(CanvasGroup canvasGroup, RectTransform rectTransform)
		{
		}

		private void CloseUI(CanvasGroup canvasGroup, RectTransform rectTransform)
		{
		}

		private void ShowBlackBG()
		{
		}

		private void HideBlackBG()
		{
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FakeMG.Server.SaveLoad;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace FakeMG.UI.InGame
{
	public class InGameUIController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CChangeReviveScreenFillAmount_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public InGameUIController _003C_003E4__this;

			private float _003Ctime_003E5__2;

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
			public _003CChangeReviveScreenFillAmount_003Ed__48(int _003C_003E1__state)
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
		private GameObject canvas;

		[Header("Data")]
		[SerializeField]
		private PlayerDataSO playerDataSO;

		[Header("Utility")]
		[SerializeField]
		private RectTransform headStartNormalUtilityRectTransform;

		[SerializeField]
		private RectTransform headStartSuperUtilityRectTransform;

		[SerializeField]
		private CanvasGroup headStartParentUtilityCanvasGroup;

		[SerializeField]
		[Header("In-Game")]
		private Text coinCountText;

		[SerializeField]
		private Text gemCountText;

		[SerializeField]
		private Text scoreCountText;

		[SerializeField]
		private Text highScoreCountText;

		[SerializeField]
		private CanvasGroup inGameCanvasGroup;

		[SerializeField]
		[Header("End Screen")]
		private CanvasGroup endScreenCanvasGroup;

		private RectTransform _endScreenRectTransform;

		[SerializeField]
		private RectTransform endScreenScoreGroupRect;

		[SerializeField]
		private CanvasGroup endScreenScoreGroupCanvasGroup;

		[SerializeField]
		private Text endScreenCoinCountText;

		[SerializeField]
		private Text endScreenScoreCountText;

		[SerializeField]
		private Text endScreenAdCoinCountText;

		[SerializeField]
		private GameObject endScreenAdCoinButton;

		[SerializeField]
		private GameObject endScreenDoubleCoinText;

		[Header("Revive Screen")]
		[SerializeField]
		private CanvasGroup reviveScreenCanvasGroup;

		private RectTransform _reviveScreenRectTransform;

		[SerializeField]
		private Image reviveScreenFillImage;

		[SerializeField]
		private UnityEvent endGameEventChannel;

		[SerializeField]
		private PlayerInput playerInput;

		[Header("Pause Screen")]
		[SerializeField]
		private RectTransform pauseScreenRectTransform;

		[SerializeField]
		private Slider sfxSlider;

		[SerializeField]
		private Slider musicSlider;

		[SerializeField]
		private AudioSource uiAudioSource;

		[Header("Others")]
		[SerializeField]
		private Image blackBG;

		private const float BLACK_BG_ALPHA = 0.8f;

		private Coroutine _reviveScreenFillCoroutine;

		private InputAction _driftAction;

		private InputAction _driftDirectionAction;

		private float _elapsedTime;

		private double _tempHighScore;

		private const float START_OFFSET = 50f;

		private readonly List<RaycastResult> _rayCastResultsList;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnDisable()
		{
		}

		private void UpdateHighScoreText()
		{
		}

		public void UpdateCoinCount(double coinValue, double coinCount)
		{
		}

		public void UpdateGemCount(double gemValue, double gemCount)
		{
		}

		public void UpdateScoreText(double increaseValue, double totalValue)
		{
		}

		public void ShowReviveScreen()
		{
		}

		private void IncreaseReviveScreenFillAmount(InputAction.CallbackContext context)
		{
		}

		[IteratorStateMachine(typeof(_003CChangeReviveScreenFillAmount_003Ed__48))]
		private IEnumerator ChangeReviveScreenFillAmount()
		{
			return null;
		}

		public void HideReviveScreen()
		{
		}

		public void ShowHeadStartUtility()
		{
		}

		public void HideHeadStartUtility()
		{
		}

		public void ShowEndScreen()
		{
		}

		public void PauseGame()
		{
		}

		public void ResumeGame()
		{
		}

		private void SlideInUI(CanvasGroup canvasGroup, RectTransform rect, Vector2 startOffset, Action callback = null, bool setUpdate = false)
		{
		}

		private void SlideOutUI(CanvasGroup canvasGroup, RectTransform rect, Vector2 endOffset, bool setUpdate = false)
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

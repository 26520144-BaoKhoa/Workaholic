using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FakeMG.EventChannels;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

namespace FakeMG
{
	public class SceneLoader : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelayStartGameEvent_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SceneLoader _003C_003E4__this;

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
			public _003CDelayStartGameEvent_003Ed__13(int _003C_003E1__state)
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
		private SceneTransition sceneTransition;

		[SerializeField]
		private SimpleEventChannel startGameEventChannel;

		[SerializeField]
		private AssetLabelReference mainMenuUIScene;

		[SerializeField]
		private AssetLabelReference gameplayScene;

		[SerializeField]
		private AssetReference garageScene;

		private AsyncOperationHandle<SceneInstance> _mainMenuUIHandle;

		private AsyncOperationHandle<SceneInstance> _gameplayHandle;

		private AsyncOperationHandle<SceneInstance> _garageHandle;

		public void Init()
		{
		}

		public void StartGame()
		{
		}

		public void GoHome()
		{
		}

		public void Retry()
		{
		}

		public void LoadGarageScene()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayStartGameEvent_003Ed__13))]
		private IEnumerator DelayStartGameEvent()
		{
			return null;
		}
	}
}

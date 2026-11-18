using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace FakeMG.Audio
{
	public class AudioCue : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CPlayDelayed_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AudioCue _003C_003E4__this;

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
			public _003CPlayDelayed_003Ed__8(int _003C_003E1__state)
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
		[Header("Sound definition")]
		private AudioCueSO audioCue;

		[SerializeField]
		private bool playOnStart;

		[SerializeField]
		private float delay;

		[Header("Configuration")]
		[SerializeField]
		private AudioCueEventChannelSO audioCueEventChannel;

		[SerializeField]
		private AudioConfigurationSO audioConfiguration;

		[SerializeField]
		private bool followParent;

		private AudioCueKey _controlKey;

		private void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CPlayDelayed_003Ed__8))]
		private IEnumerator PlayDelayed()
		{
			return null;
		}

		public void PlayAudioCue()
		{
		}

		public void StopAudioCue()
		{
		}

		public void FinishAudioCue()
		{
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.Audio
{
	[RequireComponent(typeof(AudioSource))]
	public class SoundEmitter : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFinishedPlaying_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float clipLength;

			public SoundEmitter _003C_003E4__this;

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
			public _003CFinishedPlaying_003Ed__14(int _003C_003E1__state)
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

		private AudioSource _audioSource;

		[CompilerGenerated]
		private UnityAction<SoundEmitter> m_OnSoundFinishedPlaying;

		public AudioCueKey AudioCueKey;

		public event UnityAction<SoundEmitter> OnSoundFinishedPlaying
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		public void PlayAudioClip(AudioClip clip, AudioConfigurationSO settings, bool hasToLoop, Vector3 position = default(Vector3))
		{
		}

		public void FadeInAudioClip(AudioClip musicClip, AudioConfigurationSO settings, float duration)
		{
		}

		public void FadeOutAudioClip(float duration)
		{
		}

		public AudioClip GetClip()
		{
			return null;
		}

		public void Stop()
		{
		}

		public bool IsPlaying()
		{
			return false;
		}

		public void Finish()
		{
		}

		public void IgnoreListenerPause()
		{
		}

		[IteratorStateMachine(typeof(_003CFinishedPlaying_003Ed__14))]
		private IEnumerator FinishedPlaying(float clipLength)
		{
			return null;
		}

		private void NotifyBeingDone()
		{
		}
	}
}

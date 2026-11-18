using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;

namespace FakeMG.VFX
{
	public class CameraShake : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CExplode_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CameraShake _003C_003E4__this;

			public float intensity;

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
			public _003CExplode_003Ed__7(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CShakeCameraCoroutine_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CameraShake _003C_003E4__this;

			public float intensity;

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
			public _003CShakeCameraCoroutine_003Ed__5(int _003C_003E1__state)
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
		private CinemachineVirtualCamera virtualCamera;

		[SerializeField]
		private float fadeInTime;

		[SerializeField]
		private float fadeOutTime;

		private void Start()
		{
		}

		public void ShakeCamera(float velocityX)
		{
		}

		[IteratorStateMachine(typeof(_003CShakeCameraCoroutine_003Ed__5))]
		private IEnumerator ShakeCameraCoroutine(float intensity)
		{
			return null;
		}

		public void ExplodeCamera(float intensity)
		{
		}

		[IteratorStateMachine(typeof(_003CExplode_003Ed__7))]
		private IEnumerator Explode(float intensity)
		{
			return null;
		}
	}
}

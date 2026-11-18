using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;
using UnityEngine.Events;

namespace FakeMG
{
	public class SwitchCamera : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003COnCompleted_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SwitchCamera _003C_003E4__this;

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
			public _003COnCompleted_003Ed__5(int _003C_003E1__state)
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
		private CinemachineBrain brain;

		[SerializeField]
		private CinemachineVirtualCamera vcam1;

		[SerializeField]
		private CinemachineVirtualCamera vcam2;

		[SerializeField]
		private UnityEvent onCompleted;

		public void Switch()
		{
		}

		[IteratorStateMachine(typeof(_003COnCompleted_003Ed__5))]
		private IEnumerator OnCompleted()
		{
			return null;
		}
	}
}

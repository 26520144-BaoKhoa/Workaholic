using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.Movement
{
	public class PreventStuck : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCheck_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PreventStuck _003C_003E4__this;

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
			public _003CCheck_003Ed__9(int _003C_003E1__state)
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
		private Rigidbody playerRigidbody;

		[SerializeField]
		private UnityEvent onStuck;

		private const float RANGE = 5f;

		private readonly WaitForSeconds _checkInterval;

		private float _lastZPosition;

		private Coroutine _checkCoroutine;

		private void Start()
		{
		}

		public void StartCheck()
		{
		}

		public void StopCheck()
		{
		}

		[IteratorStateMachine(typeof(_003CCheck_003Ed__9))]
		private IEnumerator Check()
		{
			return null;
		}
	}
}

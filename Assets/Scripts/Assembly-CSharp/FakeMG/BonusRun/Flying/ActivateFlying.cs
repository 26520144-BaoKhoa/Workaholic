using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace FakeMG.BonusRun.Flying
{
	public class ActivateFlying : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCountDown_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ActivateFlying _003C_003E4__this;

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
			public _003CCountDown_003Ed__9(int _003C_003E1__state)
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
		private sealed class _003CLaunchPlayerUp_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ActivateFlying _003C_003E4__this;

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
			public _003CLaunchPlayerUp_003Ed__7(int _003C_003E1__state)
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
		private CoinSpawner coinSpawner;

		[SerializeField]
		private Rigidbody player;

		[SerializeField]
		private float duration;

		[SerializeField]
		private float coinOffsetZ;

		private bool _isLaunching;

		private void FixedUpdate()
		{
		}

		public void Activate(float startZWorldPos)
		{
		}

		[IteratorStateMachine(typeof(_003CLaunchPlayerUp_003Ed__7))]
		private IEnumerator LaunchPlayerUp()
		{
			return null;
		}

		private void ActivateCoinSpawner(float startZWorldPos)
		{
		}

		[IteratorStateMachine(typeof(_003CCountDown_003Ed__9))]
		private IEnumerator CountDown()
		{
			return null;
		}
	}
}

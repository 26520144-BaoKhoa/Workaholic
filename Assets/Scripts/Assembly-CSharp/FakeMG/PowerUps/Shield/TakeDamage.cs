using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.PowerUps.Shield
{
	public class TakeDamage : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CTriggerOnPlayerDies_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TakeDamage _003C_003E4__this;

			private Vector3 _003CplayerVel_003E5__2;

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
			public _003CTriggerOnPlayerDies_003Ed__19(int _003C_003E1__state)
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

		public UnityEvent onPlayerDying;

		[SerializeField]
		private UnityEvent onPlayerDies;

		[SerializeField]
		private UnityEvent<float> onHeavyCollisionEnter;

		public UnityEvent onRevive;

		public UnityEvent onReviveComplete;

		[SerializeField]
		private LayerMask obstacleLayer;

		[SerializeField]
		private ParticleSystem spark;

		private float _previousTouchTime;

		private Rigidbody _rigidbody;

		private bool _isDead;

		public bool IsEnable { get; set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnCollisionEnter(Collision other)
		{
		}

		public void Revive()
		{
		}

		public void KillPlayer()
		{
		}

		[IteratorStateMachine(typeof(_003CTriggerOnPlayerDies_003Ed__19))]
		private IEnumerator TriggerOnPlayerDies()
		{
			return null;
		}

		private bool ContainsLayer(LayerMask mask, int layer)
		{
			return false;
		}
	}
}

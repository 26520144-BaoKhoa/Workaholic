using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace FakeMG.PowerUps.Missile
{
	public class MissileSpawner : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSpawnMissile_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MissileSpawner _003C_003E4__this;

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
			public _003CSpawnMissile_003Ed__7(int _003C_003E1__state)
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
		private RocketPropel rocketPrefab;

		[SerializeField]
		private Transform spawnPoint;

		[SerializeField]
		private float spawnRate;

		private Coroutine _spawnMissileCoroutine;

		public void StartSpawning()
		{
		}

		public void StopSpawning()
		{
		}

		[IteratorStateMachine(typeof(_003CSpawnMissile_003Ed__7))]
		private IEnumerator SpawnMissile()
		{
			return null;
		}
	}
}

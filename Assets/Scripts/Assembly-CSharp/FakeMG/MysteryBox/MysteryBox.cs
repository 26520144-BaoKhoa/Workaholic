using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AYellowpaper.SerializedCollections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace FakeMG.MysteryBox
{
	public class MysteryBox : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCycleThroughItems_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MysteryBox _003C_003E4__this;

			private float _003CelapsedTime_003E5__2;

			private float _003CcycleTime_003E5__3;

			private float _003CwaitTime_003E5__4;

			private List<MysteryItemSO> _003Ckeys_003E5__5;

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
			public _003CCycleThroughItems_003Ed__9(int _003C_003E1__state)
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
		private SerializedDictionary<MysteryItemSO, float> items;

		[SerializeField]
		private Transform display;

		[SerializeField]
		private Image itemIcon;

		[SerializeField]
		private MysteryItemSO nothingItemSO;

		[SerializeField]
		private UnityEvent onOpen;

		[SerializeField]
		private UnityEvent onReceiveItem;

		[SerializeField]
		private UnityEvent onFailReceiveItem;

		private readonly Dictionary<MysteryItemSO, Image> _displayedItemIcons;

		public void Open()
		{
		}

		[IteratorStateMachine(typeof(_003CCycleThroughItems_003Ed__9))]
		private IEnumerator CycleThroughItems()
		{
			return null;
		}

		private MysteryItemSO Spin()
		{
			return null;
		}

		private void DisplayItem(MysteryItemSO item, float time, Action onComplete = null)
		{
		}
	}
}

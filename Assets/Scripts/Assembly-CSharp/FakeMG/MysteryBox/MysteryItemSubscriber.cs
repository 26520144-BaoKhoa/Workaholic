using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.MysteryBox
{
	public class MysteryItemSubscriber : MonoBehaviour
	{
		[SerializeField]
		private MysteryItemSO mysteryItemSO;

		[SerializeField]
		private UnityEvent onItemReceived;

		private void Start()
		{
		}

		private void OnDisable()
		{
		}
	}
}

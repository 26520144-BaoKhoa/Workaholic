using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.MysteryBox
{
	[CreateAssetMenu(menuName = "MysteryBox/Item")]
	public class MysteryItemSO : ScriptableObject
	{
		[SerializeField]
		private Sprite itemSprite;

		[SerializeField]
		private string itemName;

		public UnityAction OnItemReceived;

		public Sprite ItemSprite => null;

		public string ItemName => null;
	}
}

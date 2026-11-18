using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace FakeMG.UI.Tab
{
	public class TabButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
	{
		[SerializeField]
		private TabGroup tabGroup;

		public GameObject content;

		[HideInInspector]
		public Image background;

		private void Awake()
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}
	}
}

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace FakeMG.UI
{
	public class CustomButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
	{
		private enum State
		{
			Normal = 0,
			Hover = 1,
			Pressed = 2,
			Disabled = 3
		}

		[SerializeField]
		private Color normalColor;

		[SerializeField]
		private Color hoverColor;

		public ScrollRect scrollRect;

		public UnityEvent onClick;

		private RectTransform _rectTransform;

		private Image _imageBack;

		private Image _imageFront;

		private Vector3 _normalScale;

		private const float SCALE_DOWN = 0.85f;

		private bool _isDisabled;

		private bool _isDragging;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		public void DisableButton()
		{
		}

		public void EnableButton()
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}

		private void ChangeState(State buttonState)
		{
		}
	}
}

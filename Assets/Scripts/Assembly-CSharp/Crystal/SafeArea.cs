using UnityEngine;

namespace Crystal
{
	public class SafeArea : MonoBehaviour
	{
		public enum SimDevice
		{
			None = 0,
			IPhoneX = 1,
			IPhoneXsMax = 2,
			Pixel3XlLsl = 3,
			Pixel3XlLsr = 4
		}

		public static SimDevice Sim;

		private readonly Rect[] _nsaIPhoneX;

		private readonly Rect[] _nsaIPhoneXsMax;

		private readonly Rect[] _nsaPixel3XlLsl;

		private readonly Rect[] _nsaPixel3XlLsr;

		private RectTransform _panel;

		private Rect _lastSafeArea;

		private Vector2Int _lastScreenSize;

		private ScreenOrientation _lastOrientation;

		[SerializeField]
		private bool conformX;

		[SerializeField]
		private bool conformY;

		[SerializeField]
		private bool logging;

		private void Awake()
		{
		}

		private void Refresh()
		{
		}

		private Rect GetSafeArea()
		{
			return default;
		}

		private void ApplySafeArea(Rect safeArea)
		{
		}
	}
}

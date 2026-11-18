using UnityEngine;
using UnityEngine.UI;

namespace FakeMG.Movement
{
	public class NitroBarUIUpdater : MonoBehaviour
	{
		[SerializeField]
		private Color notFullColor;

		[SerializeField]
		private Color fullColor;

		[SerializeField]
		private Image fillImage;

		private void Start()
		{
		}

		public void ChangeFillAmount(double change, double total)
		{
		}
	}
}

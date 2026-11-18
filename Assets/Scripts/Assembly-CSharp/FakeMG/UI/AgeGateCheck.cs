using FakeMG.Server.SaveLoad;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace FakeMG.UI
{
	public class AgeGateCheck : MonoBehaviour
	{
		[SerializeField]
		private PlayerDataSO playerDataSO;

		[SerializeField]
		private RectTransform ageGateRect;

		[SerializeField]
		private CanvasGroup ageGateCanvasGroup;

		[SerializeField]
		private Text ageGateText;

		[SerializeField]
		private UnityEvent onAgeGatePassed;

		public void Check()
		{
		}

		public void Pass()
		{
		}

		public void SetAge(float age)
		{
		}

		private void PopupUI(CanvasGroup canvasGroup, RectTransform rectTransform)
		{
		}
	}
}

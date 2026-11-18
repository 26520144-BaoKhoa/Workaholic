using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace FakeMG.UI.Tab
{
	public class TabGroup : MonoBehaviour
	{
		[SerializeField]
		private UnityEvent onClick;

		private int _defaultSelectedTab;

		private List<TabButton> _tabButtons;

		private readonly Color _normalColor;

		private readonly Color _pressedColor;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		public void SetDefaultTab(int index)
		{
		}

		public void OnPressed(Image buttonImage)
		{
		}

		private void ResetTabs()
		{
		}
	}
}

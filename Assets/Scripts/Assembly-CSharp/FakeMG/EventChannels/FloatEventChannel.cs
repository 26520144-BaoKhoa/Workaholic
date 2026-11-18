using UnityEngine;
using UnityEngine.Events;

namespace FakeMG.EventChannels
{
	[CreateAssetMenu(menuName = "Event Channels/Float Event")]
	public class FloatEventChannel : ScriptableObject
	{
		public UnityAction<float> OnEventRaised;

		public void RaiseEvent(float value)
		{
		}
	}
}

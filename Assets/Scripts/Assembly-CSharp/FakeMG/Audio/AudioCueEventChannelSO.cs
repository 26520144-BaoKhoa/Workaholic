using UnityEngine;

namespace FakeMG.Audio
{
	[CreateAssetMenu(menuName = "Audio/AudioCueEventChannel")]
	public class AudioCueEventChannelSO : ScriptableObject
	{
		public AudioCuePlayAction OnAudioCuePlayRequested;

		public AudioCueStopAction OnAudioCueStopRequested;

		public AudioCueFinishAction OnAudioCueFinishRequested;

		public AudioCueKey RaisePlayEvent(AudioCueSO audioCue, AudioConfigurationSO audioConfiguration, Vector3 positionInSpace = default(Vector3), Transform parent = null)
		{
			return default;
		}

		public bool RaiseStopEvent(AudioCueKey audioCueKey, AudioCueSO audioCue)
		{
			return false;
		}

		public bool RaiseFinishEvent(AudioCueKey audioCueKey)
		{
			return false;
		}
	}
}

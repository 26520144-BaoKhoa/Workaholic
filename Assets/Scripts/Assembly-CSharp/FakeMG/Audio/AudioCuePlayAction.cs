using UnityEngine;

namespace FakeMG.Audio
{
	public delegate AudioCueKey AudioCuePlayAction(AudioCueSO audioCue, AudioConfigurationSO audioConfiguration, Vector3 positionInSpace, Transform parent);
}

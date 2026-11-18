namespace FakeMG.Audio
{
	public readonly struct AudioCueKey
	{
		public static AudioCueKey Invalid;

		private readonly int _value;

		private readonly AudioCueSO _audioCue;

		internal AudioCueKey(int value, AudioCueSO audioCue)
		{
			_value = 0;
			_audioCue = null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(AudioCueKey x, AudioCueKey y)
		{
			return false;
		}

		public static bool operator !=(AudioCueKey x, AudioCueKey y)
		{
			return false;
		}
	}
}

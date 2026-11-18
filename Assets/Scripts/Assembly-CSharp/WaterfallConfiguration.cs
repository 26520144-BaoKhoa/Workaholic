public class WaterfallConfiguration
{
	public class WaterfallConfigurationBuilder
	{
		private double? ceiling;

		private double? floor;

		internal WaterfallConfigurationBuilder()
		{
		}

		public WaterfallConfigurationBuilder SetCeiling(double ceiling)
		{
			return null;
		}

		public WaterfallConfigurationBuilder SetFloor(double floor)
		{
			return null;
		}

		public WaterfallConfiguration Build()
		{
			return null;
		}
	}

	private readonly double? ceiling;

	private readonly double? floor;

	public double? Ceiling => null;

	public double? Floor => null;

	private WaterfallConfiguration(double? ceiling, double? floor)
	{
	}

	public static WaterfallConfigurationBuilder Builder()
	{
		return null;
	}

	public static WaterfallConfiguration Empty()
	{
		return null;
	}
}

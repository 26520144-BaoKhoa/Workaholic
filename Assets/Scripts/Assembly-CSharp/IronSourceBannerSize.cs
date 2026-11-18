public class IronSourceBannerSize
{
	private int width;

	private int height;

	private string description;

	private bool isAdaptive;

	private ISContainerParams isContainerParams;

	private bool respectAndroidCutouts;

	public static IronSourceBannerSize BANNER;

	public static IronSourceBannerSize LARGE;

	public static IronSourceBannerSize RECTANGLE;

	public static IronSourceBannerSize SMART;

	public string Description => null;

	public int Width => 0;

	public int Height => 0;

	private IronSourceBannerSize()
	{
	}

	public IronSourceBannerSize(int width, int height)
	{
	}

	public IronSourceBannerSize(string description)
	{
	}

	public void SetAdaptive(bool adaptive)
	{
	}

	public bool IsAdaptiveEnabled()
	{
		return false;
	}

	public void setBannerContainerParams(ISContainerParams parameters)
	{
	}

	public ISContainerParams getBannerContainerParams()
	{
		return null;
	}

	public void SetRespectAndroidCutouts(bool respectAndroidCutouts)
	{
	}

	public bool IsRespectAndroidCutoutsEnabled()
	{
		return false;
	}
}

using System;

namespace EpochDateTimeConversions;

public class EpochDateTimeConversions : IEpochDateTimeConversions
{
	public long GetCurrentEpoch()
	{
		return DateTimeOffset.UtcNow.ToUnixTimeSeconds();
	}

	public long DateTimeToEpoch(DateTime dateTime)
	{
		return new DateTimeOffset(DateTime.SpecifyKind(dateTime, DateTimeKind.Utc)).ToUnixTimeSeconds();
	}

	public DateTime EpochToDateTime(long epoch)
	{
		return DateTimeOffset.FromUnixTimeSeconds(epoch).UtcDateTime;
	}

	public long GetCurrentEpochMilliseconds()
	{
		return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
	}

	public long DateTimeToEpochMilliseconds(DateTime dateTime)
	{
		return new DateTimeOffset(DateTime.SpecifyKind(dateTime, DateTimeKind.Utc)).ToUnixTimeMilliseconds();
	}

	public DateTime EpochMillisecondsToDateTime(long epochMilliseconds)
	{
		return DateTimeOffset.FromUnixTimeMilliseconds(epochMilliseconds).UtcDateTime;
	}
}

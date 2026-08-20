using System;
using OutSystems.ExternalLibraries.SDK;

namespace EpochDateTimeConversions;

[OSInterface(Name = "EpochDateTimeConversions", IconResourceName = "EpochDateTimeConversions.epoch.png", Description = "Converts between DateTime and the Unix epoch (seconds or milliseconds since 1970-01-01T00:00:00Z), in both directions. All DateTime values are treated as UTC. Built on .NET 10.")]
public interface IEpochDateTimeConversions
{
	[OSAction(Description = "Returns the current Unix epoch, in whole seconds.", IconResourceName = "EpochDateTimeConversions.epoch.png")]
	long GetCurrentEpoch();

	[OSAction(Description = "Converts a DateTime (treated as UTC) to the Unix epoch, in whole seconds.", IconResourceName = "EpochDateTimeConversions.epoch.png")]
	long DateTimeToEpoch([OSParameter(Description = "The DateTime to convert. Treated as UTC regardless of its Kind.")] DateTime dateTime);

	[OSAction(Description = "Converts a Unix epoch (in whole seconds) to a DateTime (UTC).", IconResourceName = "EpochDateTimeConversions.epoch.png")]
	DateTime EpochToDateTime([OSParameter(Description = "The Unix epoch, in whole seconds since 1970-01-01T00:00:00Z.")] long epoch);

	[OSAction(Description = "Returns the current Unix epoch, in milliseconds.", IconResourceName = "EpochDateTimeConversions.epoch.png")]
	long GetCurrentEpochMilliseconds();

	[OSAction(Description = "Converts a DateTime (treated as UTC) to the Unix epoch, in milliseconds.", IconResourceName = "EpochDateTimeConversions.epoch.png")]
	long DateTimeToEpochMilliseconds([OSParameter(Description = "The DateTime to convert. Treated as UTC regardless of its Kind.")] DateTime dateTime);

	[OSAction(Description = "Converts a Unix epoch (in milliseconds) to a DateTime (UTC).", IconResourceName = "EpochDateTimeConversions.epoch.png")]
	DateTime EpochMillisecondsToDateTime([OSParameter(Description = "The Unix epoch, in milliseconds since 1970-01-01T00:00:00Z.")] long epochMilliseconds);
}

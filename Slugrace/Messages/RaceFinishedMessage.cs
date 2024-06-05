using CommunityToolkit.Mvvm.Messaging.Messages;

namespace Slugrace.Messages;

public class RaceFinishedMessage(RaceStatus value) : ValueChangedMessage<RaceStatus>(value)
{
}


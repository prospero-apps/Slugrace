using CommunityToolkit.Mvvm.Messaging.Messages;

namespace Slugrace.Messages;

public class PlayerNameChangedMessage(string value) : ValueChangedMessage<string>(value)
{
}


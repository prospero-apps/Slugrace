using CommunityToolkit.Mvvm.Messaging.Messages;

namespace Slugrace.Messages;

public class PlayerBetAmountChangedMessage(int value) : ValueChangedMessage<int>(value)
{
}

using CommunityToolkit.Mvvm.Messaging.Messages;

namespace Slugrace.Messages;

public class PlayerInitialMoneyChangedMessage(int? value) : ValueChangedMessage<int?>(value)
{
}


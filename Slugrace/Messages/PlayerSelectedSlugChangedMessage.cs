using CommunityToolkit.Mvvm.Messaging.Messages;
using Slugrace.ViewModels;

namespace Slugrace.Messages;

public class PlayerSelectedSlugChangedMessage(SlugViewModel value) 
    : ValueChangedMessage<SlugViewModel>(value)
{
}

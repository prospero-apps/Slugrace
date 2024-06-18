using CommunityToolkit.Mvvm.ComponentModel;

namespace Slugrace.ViewModels;

public partial class AccidentPopupViewModel : ObservableObject
{
    [ObservableProperty]
    private string affectedSlugImageUrl = string.Empty;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(HeadlineMessage))]
    private string affectedSlugName = string.Empty;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(HeadlineMessage))]
    private string accidentHeadline = string.Empty;

    public string HeadlineMessage => $"{AffectedSlugName} {AccidentHeadline}";

    public void ShowAccidentInfo(AccidentViewModel accidentViewModel)
    {
        if (accidentViewModel.AffectedSlug != null)
        {
            AffectedSlugImageUrl = accidentViewModel.AffectedSlug.ImageUrl;
            AffectedSlugName = accidentViewModel.AffectedSlug.Name;
            AccidentHeadline = accidentViewModel.Headline;
        }        
    }
}

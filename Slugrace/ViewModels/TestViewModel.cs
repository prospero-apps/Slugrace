using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace Slugrace.ViewModels;

public partial class TestViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(LetterCount))]
    string favoriteColor = string.Empty;    

    public int? LetterCount => FavoriteColor?.Length;

    [RelayCommand]
    private void UseFixedColor(string color)
    {
        FavoriteColor = color;
    }
}

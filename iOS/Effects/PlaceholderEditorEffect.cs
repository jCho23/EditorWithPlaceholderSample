using UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using EditorWithPlaceholderSample.iOS.Effects;


[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(PlaceholderEditorEffect), nameof(PlaceholderEditorEffect))]
namespace EditorWithPlaceholderSample.iOS.Effects
{
    public class PlaceholderEditorEffect
    {
        public PlaceholderEditorEffect()
        {
        }
    }
}

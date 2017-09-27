using System;

using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using EditorWithPlaceholderSample.Droid.Effects;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(PlaceholderEditorEffect), nameof(PlaceholderEditorEffect))]
namespace EditorWithPlaceholderSample.Droid.Effects
{
    public class PlaceholderEditorEffect
    {
        public PlaceholderEditorEffect()
        {
        }
    }
}

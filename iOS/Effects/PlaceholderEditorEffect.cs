using UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using EditorWithPlaceholderSample.iOS.Effects;
using EditorWithPlaceholderSample.Controls;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(PlaceholderEditorEffect), nameof(PlaceholderEditorEffect))]
namespace EditorWithPlaceholderSample.iOS.Effects
{

    public class PlaceholderEditorEffect : PlatformEffect
    {
        UILabel placeholderText;
        UITextView nativeTextField;
        EditorWithPlaceholder formsEditor;

        protected override void OnAttached()
        {
            formsEditor = Element as EditorWithPlaceholder;
            nativeTextField = Control as UITextView;

            placeholderText = new UILabel
            {
                LineBreakMode = UILineBreakMode.WordWrap,
                Lines = 1,
                BackgroundColor = UIColor.Clear,
                TextColor = formsEditor.PlaceholderTextColor.ToUIColor(),
                Text = formsEditor.Placeholder
            };

            if (string.IsNullOrEmpty(formsEditor.Text))
                placeholderText.Alpha = 1;
            else
                placeholderText.Alpha = 0;

            nativeTextField.AddSubview(placeholderText);
        }




    }
}
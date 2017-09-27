using System;

using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using EditorWithPlaceholderSample.Droid.Effects;
using EditorWithPlaceholderSample.Controls;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(PlaceholderEditorEffect), nameof(PlaceholderEditorEffect))]
namespace EditorWithPlaceholderSample.Droid.Effects
{
	public class PlaceholderEditorEffect : PlatformEffect
	{
		Android.Graphics.Color backgroundColor;

		public PlaceholderEditorEffect()
		{

		}

		TextView placeholderText;
		EditText nativeTextField;
		EditorWithPlaceholder formsEditor;

		protected override void OnAttached()
		{
			formsEditor = Element as EditorWithPlaceholder;
			nativeTextField = Control as EditText;

			try
			{
				placeholderText = new TextView(Forms.Context)
				{
					Text = formsEditor.Placeholder,

				};
				placeholderText.SetBackgroundColor(Android.Graphics.Color.Transparent);
				placeholderText.SetTextColor(formsEditor.PlaceholderTextColor.ToAndroid());
				placeholderText.SetLines(1);


				backgroundColor = Android.Graphics.Color.White;
				Control.SetBackgroundColor(backgroundColor);

				if (string.IsNullOrEmpty(formsEditor.Text))
					placeholderText.Alpha = 1;
				else
					placeholderText.Alpha = 0;


				////nativeTextField.Add(placeholderText);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
			}
		}
    }
}

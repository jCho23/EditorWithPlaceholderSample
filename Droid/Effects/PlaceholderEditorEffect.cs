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


    }
}

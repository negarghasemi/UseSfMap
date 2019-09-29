using UIKit;
using UseMap.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Entry), typeof(XamAppEntryRenderer))]

namespace UseMap.iOS.Renderers
{
public class XamAppEntryRenderer : EntryRenderer
{
    protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
    {
        base.OnElementChanged(e);

        if (e.NewElement != null) /* e.NewElement is a Xamarin Forms' Entry */
        {
            Control.ClearButtonMode = UITextFieldViewMode.WhileEditing; // Control is UITextField
        }
    }
}
}
using System;
using Xamarin.Forms.Platform.iOS;
using Goody.iOS;
using Xamarin.Forms;
using Goody.RendererPage;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(EntryWithoutBorder))]
namespace Goody.iOS
{
    public class EntryWithoutBorder : EntryRenderer
    {
        public EntryWithoutBorder()
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BorderStyle = UIKit.UITextBorderStyle.None;
            }
        }
    }
}

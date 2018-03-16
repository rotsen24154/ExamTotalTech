using ExamTotalTech.iOS.Helpers;
using ExamTotalTech.iOS.Renderers;
using ExamTotalTech.Views;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(DoctorListPage), typeof(CustomPageRenderer))]
namespace ExamTotalTech.iOS.Renderers
{
    public class CustomPageRenderer : PageRenderer
    {
        List<ToolbarItem> secondaryItems;
        UITableView table;
        private bool isRendered;

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            if (e.NewElement is ContentPage page)
            {
                secondaryItems = page.ToolbarItems.Where(i => i.Order == ToolbarItemOrder.Secondary).ToList();
                secondaryItems.ForEach(t => page.ToolbarItems.Remove(t));
            }
            base.OnElementChanged(e);
        }

        public override void ViewWillAppear(bool animated)
        {
            var element = (ContentPage)Element;
            if (secondaryItems != null && secondaryItems.Count > 0 && !isRendered)
            {
                element.ToolbarItems.Add(new ToolbarItem()
                {
                    Order = ToolbarItemOrder.Primary,
                    Icon = "icon_dots.png",
                    Priority = 1,
                    Command = new Command(() =>
                    {
                        ToolClicked();
                    })
                });
            }
            isRendered = true;
            base.ViewWillAppear(animated);
        }

        private void ToolClicked()
        {
            if (table == null)
            {
                var childRect = new RectangleF((float)View.Bounds.Width - 250, 0, 250, secondaryItems.Count() * 56);
                table = new UITableView(childRect)
                {
                    Source = new TableSource(secondaryItems) 
                };
                Add(table);
                return;
            }
            foreach (var subview in View.Subviews)
            {
                if (subview == table)
                {
                    table.RemoveFromSuperview();
                    return;
                }
            }
            Add(table);
        }
    }
}
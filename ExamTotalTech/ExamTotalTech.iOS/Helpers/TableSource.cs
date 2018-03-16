using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using UIKit;
using Xamarin.Forms;

namespace ExamTotalTech.iOS.Helpers
{
    public class TableSource : UITableViewSource
    {

        // Global variable for the secondary toolbar items and text to display in table row
        List<ToolbarItem> tableItems;
        string[] tableItemTexts;
        string CellIdentifier = "TableCell";

        public TableSource(List<ToolbarItem> items)
        {
            //Set the secondary toolbar items to global variables and get all text values from the toolbar items
            tableItems = items;
            tableItemTexts = items.Select(a => a.Text).ToArray();
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tableItemTexts.Length;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
            string item = tableItemTexts[indexPath.Row];
            if (cell == null)
            { cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier); }
            cell.TextLabel.Text = item;
            return cell;
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 56; // Set default row height.
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            //Used command to excute and deselct the row and removed the table.
            var command = tableItems[0].Command;
            command.Execute(tableItems[0].CommandParameter);
            tableView.DeselectRow(indexPath, true);
            tableView.RemoveFromSuperview();
        }
    }
}

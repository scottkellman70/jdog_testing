using System.Drawing;
using System.Windows.Forms;

namespace SOFDT3
{
    public static class Extensions
    {
        // Return the index of the item that is
        // under the point in screen coordinates.
        public static int IndexFromScreenPoint(this ListBox lst, Point point)
        {
            // Convert the location to the ListBox's coordinates.
            point = lst.PointToClient(point);

            // Return the index of the item at that position.
            return lst.IndexFromPoint(point);
        }
    }
}

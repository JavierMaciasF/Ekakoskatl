using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekakoskatl.BusinessLayer
{
    public abstract class BLBase : IDisposable
    {
        protected CustomPrincipal UserPrincipal { get; set; }

        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        // SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        protected abstract void Clear();

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                //handle.Dispose();
                // Free any other managed objects here.
                //
                Clear();
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }

        ////Buttons for permits
        //public string GenericButton(string id = "", string name = "", string value = "", string type = "", string others = "", string _class = "")
        //{
        //    string _Button = "<input id='" + id + "' type='" + type + "' name='" + name + "' class='btn btn-bloom " + _class + "' value='" + value + "' " + others + "/>";
        //    return _Button;
        //}

        ////Links for permits
        //public string GenericIcon(string id = "", string _class = "", string Image = "", string other = "")
        //{
        //    string _Icon = "<a id='" + id + "' href='#' class='" + _class + "' " + other + "><img src='" + Image + "'></a>";
        //    return _Icon;
        //}

        //public string CreatelinkFontIcon(string id = "", string _class = "", string iconClass = "", string other = "")
        //{
        //    string _Icon = "<a id='" + id + "' href='#' class='" + _class + "' " + other + "><span class='" + iconClass + "'></span></a>";
        //    return _Icon;
        //}

        //public DateTime GetUserDateFormat(DateTime date)
        //{
        //    string DateFormat = date.ToString(UserPrincipal.UserDateFormat).Replace("-", "/");
        //    DateTime DateParse = DateTime.ParseExact(DateFormat, UserPrincipal.UserDateFormat, CultureInfo.InvariantCulture);
        //    return DateParse;
        //}

        //public DateTime GetUserStrDateFormat(string date)
        //{
        //    string DateFormat = date.Replace("-", "/");
        //    DateTime DateParse = DateTime.ParseExact(DateFormat, UserPrincipal.UserDateFormat, CultureInfo.InvariantCulture);
        //    return DateParse;
        //}
    }
}

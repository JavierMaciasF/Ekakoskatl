using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekakoskatl.ViewModel
{
    public abstract class VMBase:IDisposable
    {
        //public string m_LabelSwitchCompanyVM { get; set; }
        //public List<SwitchCompaniesViewModel> m_CompaniesList { get; set; }

        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        //SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        //public string m_DateFormatbvm { get; set; }

        ////SubMenu
        //public SubMenuViewModel m_SubMenu { get; set; }
        ////List Menu Principal
        //public List<CMenuItem> m_ListMenu { get; set; }
        ////List with buttons
        //public List<CMenuItem> m_ListButtons { get; set; }
        ////List with Links
        //public List<CMenuItem> m_ListLinks { get; set; }

        //Date format
        public string m_UserDateFormat { get; set; }

        //m_ListMenu = new List<CMenuItem>();

        //Principal Menu
        public string m_PricipalMenu { get; set; }
        
        //For charts recharge
        //public string m_HtmlCharts { get; set; }

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
    }
}

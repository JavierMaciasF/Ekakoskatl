using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ekakoskatl.Data;

namespace Ekakoskatl.ViewModel.Video
{
    public class PanelVideoViewModel: VMBase
    {

        public List<VideosViewModel> m_ListVideo { get; set; }

        public PanelVideoViewModel()
        {
            InitializerVariable();
        }

        private void InitializerVariable()
        {
            m_ListVideo = new List<VideosViewModel>();
        }

        protected override void Clear()
        {
            m_ListVideo = null;
        }
    }
}

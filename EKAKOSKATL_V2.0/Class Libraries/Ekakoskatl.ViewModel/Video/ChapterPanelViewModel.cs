//using BusinessEntities.BasicEntities;
using Ekakoskatl.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekakoskatl.ViewModel.Video
{
    public class ChapterPanelViewModel: VMBase
    {
        public List<Data.Video> m_ChapterList { get; set; }

        public ChapterPanelViewModel()
        {
            InitializerVariable();
        }

        private void InitializerVariable()
        {
            m_ChapterList = new List<Data.Video>();
        }

        protected override void Clear()
        {
            m_ChapterList = null;
        }
    }
}

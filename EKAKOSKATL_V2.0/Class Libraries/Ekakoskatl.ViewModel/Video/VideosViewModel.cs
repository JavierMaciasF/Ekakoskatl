using Ekakoskatl.Repository.Custom_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekakoskatl.ViewModel.Video
{
    public class VideosViewModel:VMBase
    {
        public System.Guid VideoID { get; set; }
        public string VideoName { get; set; }
        public string GenderNameString { get; set; }
        public byte[] ArrayImage { get; set; }
        public string VideoImage { get; set; }
        public string VideoRoute { get; set; }
        public string VideoGender { get; set; }
        public List<GeneralList> GenderList { get; set; }

        public VideosViewModel()
        {
            InitializerVariable();
        }

        private void InitializerVariable()
        {
            GenderList = new List<GeneralList>();
        }

        protected override void Clear()
        {
            GenderList = null;
        }
    }
}

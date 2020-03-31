using Ekakoskatl.Data;
using Ekakoskatl.Repository.Custom_Repository;
using Ekakoskatl.ViewModel.Video;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekakoskatl.Repository.Repository
{
    public interface IVideoRepository
    {
        IEnumerable<Video> GetVideoList();
    }

    public class VideoRepository
    {
        private EkakoskatlWebEntity DbContext;

        public IEnumerable<Video> GetVideoList()
        {
            DbContext.Configuration.LazyLoadingEnabled = false;
            DbContext.Configuration.ProxyCreationEnabled = false;
            return DbContext.Videos.Include("VideoGender.Gender");
        }
    }
}

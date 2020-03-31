using Ekakoskatl.Data;
using Ekakoskatl.Repository.Custom_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ekakoskatl.ViewModel.Video;
using System.Data.Entity;
using Ekakoskatl.Repository.Repository;

namespace Ekakoskatl.Services.Services
{
    public interface IVideoServices
    {
        IEnumerable<Video> GetVideos();
        Video GetByID(Guid id);
        void InsertVideo(Video video);
        void UpdateVideo(Video video);
        void DeleteVideo(Guid id);
    }

    public class VideoServices: IVideoServices
    {
        private IBaseRepository<Video> baseRepository;
        private IVideoRepository videoRepository;
        //private IBaseRepository<Gender> genderRepository;
        //private IBaseRepository<VideoGender> videogenderRepository;

        public VideoServices(IBaseRepository<Video> baseRepository/*, IBaseRepository<Gender> genderRepository, IBaseRepository<VideoGender> videogenderRepository*/)
        {
            this.baseRepository = baseRepository;
            //this.genderRepository = genderRepository;
            //this.videogenderRepository = videogenderRepository;
        }

        public IEnumerable<Video> GetVideos()
        {
            return baseRepository.GetAll();
        }

        public Video GetByID(Guid id)
        {
            return baseRepository.GetByID(id);
        }

        public void InsertVideo(Video video)
        {
            baseRepository.Insert(video);
        }

        public void UpdateVideo(Video video)
        {
            baseRepository.Update(video);
        }

        public void DeleteVideo(Guid id)
        {
            //UserProfile userProfile = userProfileRepository.Get(id);
            //userProfileRepository.Remove(userProfile);
            //User user = GetUser(id);
            //baseRepository.Remove(user);
            //baseRepository.SaveChanges();
        }

        public PanelVideoViewModel PanelVideo(/*PanelVideoViewModel vm*/)
        {
            var _videos = videoRepository.GetVideoList().ToList();
            //foreach (var item in _videos)
            //{
            //    var query = from vg in item.VideoGenders
            //                join g in item.Gender on person equals pet.Owner
            //                select new { OwnerName = person.FirstName, PetName = pet.Name };
            //    item.VideoGenders.Where(x => x.VideoID == item.VideoID);
            //    //vm.m_ListVideo.Add(item);
            //}
            //vm.m_ListVideo = videoRepository.GetVideoList().ToList();
            return vm;
        }

    }
}

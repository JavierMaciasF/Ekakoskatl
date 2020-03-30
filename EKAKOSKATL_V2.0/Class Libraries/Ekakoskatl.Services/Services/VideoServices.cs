using Ekakoskatl.Data;
using Ekakoskatl.Repository.Custom_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private IBaseRepository<Video> videoRepository;
        //private IBaseRepository<Gender> genderRepository;
        //private IBaseRepository<VideoGender> videogenderRepository;

        public VideoServices(IBaseRepository<Video> videoRepository/*, IBaseRepository<Gender> genderRepository, IBaseRepository<VideoGender> videogenderRepository*/)
        {
            this.videoRepository = videoRepository;
            //this.genderRepository = genderRepository;
            //this.videogenderRepository = videogenderRepository;
        }

        public IEnumerable<Video> GetVideos()
        {
            return videoRepository.GetAll();
        }

        public Video GetByID(Guid id)
        {
            return videoRepository.GetByID(id);
        }

        public void InsertVideo(Video video)
        {
            videoRepository.Insert(video);
        }
        public void UpdateVideo(Video video)
        {
            videoRepository.Update(video);
        }

        public void DeleteVideo(Guid id)
        {
            //UserProfile userProfile = userProfileRepository.Get(id);
            //userProfileRepository.Remove(userProfile);
            //User user = GetUser(id);
            //videoRepository.Remove(user);
            //videoRepository.SaveChanges();
        }
    }
}

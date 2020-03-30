using Ekakoskatl.Data;
using Ekakoskatl.Repository.Custom_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekakoskatl.Services.Services
{
    public interface IVideoGenderServices
    {
        IEnumerable<VideoGender> GetVideoGenders();
        VideoGender GetByID(Guid id);
        void InsertVideoGender(VideoGender videogender);
        void UpdateVideoGender(VideoGender videogender);
        void DeleteVideoGender(Guid id);
    }

    public class VideoGenderServices : IVideoGenderServices
    {
        //private IBaseRepository<Video> videogenderRepository;
        //private IBaseRepository<Gender> videogenderRepository;
        private IBaseRepository<VideoGender> videogenderRepository;

        public VideoGenderServices(/*IBaseRepository<Video> videogenderRepository, IBaseRepository<Gender> videogenderRepository,*/ IBaseRepository<VideoGender> videogenderRepository)
        {
            //this.videogenderRepository = videogenderRepository;
            //this.videogenderRepository = videogenderRepository;
            this.videogenderRepository = videogenderRepository;
        }

        public IEnumerable<VideoGender> GetVideoGenders()
        {
            return videogenderRepository.GetAll();
        }

        public VideoGender GetByID(Guid id)
        {
            return videogenderRepository.GetByID(id);
        }

        public void InsertVideoGender(VideoGender videogender)
        {
            videogenderRepository.Insert(videogender);
        }
        public void UpdateVideoGender(VideoGender videogender)
        {
            videogenderRepository.Update(videogender);
        }

        public void DeleteVideoGender(Guid id)
        {
            //UserProfile userProfile = userProfileRepository.Get(id);
            //userProfileRepository.Remove(userProfile);
            //User user = GetUser(id);
            //videogenderRepository.Remove(user);
            //videogenderRepository.SaveChanges();
        }
    }
}

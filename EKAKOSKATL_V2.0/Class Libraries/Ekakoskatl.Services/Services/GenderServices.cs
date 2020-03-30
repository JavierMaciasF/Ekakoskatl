using Ekakoskatl.Data;
using Ekakoskatl.Repository.Custom_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekakoskatl.Services.Services
{
    public interface IGenderServices
    {
        IEnumerable<Gender> GetGenders();
        Gender GetByID(Guid id);
        void InsertGender(Gender gender);
        void UpdateGender(Gender gender);
        void DeleteGender(Guid id);
    }

    public class GenderServices : IGenderServices
    {
        //private IBaseRepository<Video> genderRepository;
        private IBaseRepository<Gender> genderRepository;
        //private IBaseRepository<VideoGender> videogenderRepository;

        public GenderServices(/*IBaseRepository<Video> genderRepository,*/ IBaseRepository<Gender> genderRepository/*, IBaseRepository<VideoGender> videogenderRepository*/)
        {
            //this.genderRepository = genderRepository;
            this.genderRepository = genderRepository;
            //this.videogenderRepository = videogenderRepository;
        }

        public IEnumerable<Gender> GetGenders()
        {
            return genderRepository.GetAll();
        }

        public Gender GetByID(Guid id)
        {
            return genderRepository.GetByID(id);
        }

        public void InsertGender(Gender gender)
        {
            genderRepository.Insert(gender);
        }
        public void UpdateGender(Gender gender)
        {
            genderRepository.Update(gender);
        }

        public void DeleteGender(Guid id)
        {
            //UserProfile userProfile = userProfileRepository.Get(id);
            //userProfileRepository.Remove(userProfile);
            //User user = GetUser(id);
            //genderRepository.Remove(user);
            //genderRepository.SaveChanges();
        }
    }
}

using Ekakoskatl.Models;
using Ekakoskatl.Data.Infraestucture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekakoskatl.Data.Repositories
{
    public interface IVideoRepository: IRepository<Video>
    {

    }
    public class VideoRepository:IVideoRepository
    {
    }
}

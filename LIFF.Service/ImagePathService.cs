using LIFF.Data.Infrastructure;
using LIFF.Data.Repositories;
using LIFF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Service
{
    public interface IImagePathService
    {
        IEnumerable<ImagePath> GetImagePaths();
        ImagePath GetImagePath(int id);
        void CreateImagePath(ImagePath ImagePath);
        void SaveImagePath();
    }

    public class ImagePathService : IImagePathService
    {
        private readonly IImagePathRepository imagePathRepository;
        private readonly IUnitOfWork unitOfWork;

        public ImagePathService(IImagePathRepository imagePathRepository, IUnitOfWork unitOfWork)
        {
            this.imagePathRepository = imagePathRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IImagePathService Members
        public void CreateImagePath(ImagePath ImagePath)
        {
            imagePathRepository.Add(ImagePath);
        }

        public IEnumerable<ImagePath> GetImagePaths()
        {
            var ImagePaths = imagePathRepository.GetAll();
            return ImagePaths;
        }

        public ImagePath GetImagePath(int id)
        {
            var ImagePath = imagePathRepository.GetById(id);
            return ImagePath;
        }

        public void SaveImagePath()
        {
            unitOfWork.Commit();
        }
        #endregion
    }
}

using AppCore.Business.Models.Results;
using AppCore.DataAccess.EntityFramework;
using AppCore.DataAccess.EntityFramework.Bases;
using Business.Models;
using Business.Services.Bases;
using DataAccess.Contexts;
using DataAccess.Entities;
using DataAccess.Repositories.Bases;

namespace Business.Services
{
    public class KategoriService : IKategoriService
    {
        public RepoBase<Kategori, ETicaretContext> Repo { get; set; } = new Repo<Kategori, ETicaretContext>();
        //public KategoriService(KategoriRepoBase kategoriRepo)
        //{
        //    Repo = kategoriRepo;
        //}
        // program.cs'de IoC container'da yönetilmediği için burada enjekte etmeye gerek kalmadı.
        public Result Add(KategoriModel model)
        {
            throw new NotImplementedException();
        }

        public Result Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Repo.Dispose(); 
        }

        public IQueryable<KategoriModel> Query()
        {
            IQueryable<KategoriModel> query = Repo.Query().OrderBy(k => k.Adi).Select(k => new KategoriModel()
            {
                Id = k.Id,
                Adi = k.Adi,
                Aciklamasi = k.Aciklamasi,
            });
            return query;
        }

        public Result Update(KategoriModel model)
        {
            throw new NotImplementedException();
        }
    }
}

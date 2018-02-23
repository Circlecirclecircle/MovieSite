using Microsoft.AspNetCore.Mvc;
using MovieSite.Models;
using System.Linq;

namespace MovieSite.Controllers
{
    public class ManagerController:Controller
    {
        private readonly MovieDbContext _dbContext;

        public ManagerController(MovieDbContext dbContext)
        {
            _dbContext=dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 电影 列表
        /// </summary>
        public IActionResult List(int pageIndex=1,int pageSize=20)
        {
            var movieList=_dbContext.Movies
                                .OrderByDescending(a=>a.CreateTime)
                                .Skip((pageIndex-1)*pageSize)
                                .Take(pageSize);

            return Json(movieList);
        }

        public IActionResult DataForm()
        {
            return View();
        }

        public IActionResult AddMovie(Movie movie)
        {
            _dbContext.Movies.Add(movie);

            _dbContext.SaveChanges();

            return Json(new OperationResultViewModel { Result = true });
        }

        public async Task<IActionResult> EditMovie(int? id)
        {
            var movie=_dbContext.Movies.SingleOrDefault();

            //https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/crud

            return null;
        }

        public IActionResult DelteMovie()
        {
            return null;
        }
    }
}
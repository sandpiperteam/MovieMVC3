using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieMVC3.Models
{
    public class MovieRepository : IMovieRepository
    {
        private MovieDBEntities movieEntities = new MovieDBEntities();


        public IQueryable<CrewMember> FindCrewMembers(int filmId)
        {
            return from crewmembers in movieEntities.CrewMembers
                   where crewmembers.Film.FilmId == filmId
                   select crewmembers;
        }

        public Film FindByName(string filmName)
        {
            return movieEntities.Films.FirstOrDefault(d => d.Name == filmName);
        }

        public Film FindFilmById(int filmId)
        {
            return movieEntities.Films.Where(f => f.FilmId == filmId).FirstOrDefault();
        }

        public void AddFilm(Film film)
        {
            movieEntities.Films.AddObject(film);
        }

        public void Save()
        {
            movieEntities.SaveChanges();
        }

    }
}
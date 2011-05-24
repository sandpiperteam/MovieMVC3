using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieMVC3.Models
{
    public interface IMovieRepository
    {
        IQueryable<CrewMember> FindCrewMembers(int filmId);

        Film FindByName(string filmName);

        Film FindFilmById(int filmId);

        void AddFilm(Film film);

        void Save();
    }
}

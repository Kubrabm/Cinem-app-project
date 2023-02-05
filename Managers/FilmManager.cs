using Cinem_app_project.Models;
using Cinem_app_project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinem_app_project.Managers
{
    internal class FilmManager : ICrudService, IPrintService
    {
        private Film[] _films = new Film[5];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            {
                if (_currentIndex > 4)
                {
                    Console.WriteLine("You have exceeded the limit! Only 5 movies can be added!");

                    return;
                }

                _films[_currentIndex++] = (Film)entity;
                Console.WriteLine("The movie has been successfully added!");
            }

        }

        public void Delete(int id)
        {
            bool found = false;

            for (int i = 0; i < _films.Length; i++)
            {
                if (_films[i] == null)
                    continue;

                if (id == _films[i].Id)
                {
                    found = true;

                    for (int j = i; j < _films.Length - 1; j++)
                    {
                        _films[j] = _films[j + 1];
                    }
                    _currentIndex--;

                    Console.WriteLine($"{id} Film deleted!");

                    return;
                }
            }

            if (!found)
            {
                Console.WriteLine($"{id} Film not found!");
            }
        }

        public Entity Get(int id)
        {
            {
                foreach (var item in _films)
                {
                    if (item == null)
                        continue;

                    if (item.Id == id)
                    {
                        Console.Write(item);

                        return item;
                    }
                }

                Console.WriteLine("Not found!");

                return null;
            }
            Console.WriteLine("Not found!");

            return null;
        }

        public Entity[] GetAll()
        {
            {
                return _films;
            }
        }

        public void Print()
        {
            foreach (var item in _films)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }


        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _films.Length; i++)
            {
                if (_films[i] == null)
                    continue;

                if (_films[i].Id == id)
                {
                    _films[i] = (Film)entity;
                    Console.WriteLine("Successfully replaced!");
                    return;
                }
            }

            Console.WriteLine("Not found"); ;
        }

    }
}

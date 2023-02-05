using Cinem_app_project.Models;
using Cinem_app_project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinem_app_project.Managers
{
    internal class CinemaManager : ICrudService, IPrintService
    {
        private Cinema[] _cinemas = new Cinema[3];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 2)
            {
                Console.WriteLine("Limiti kecdiniz! Sadece 3 Cinema elave etmek olar!");

                return;
            }

            _cinemas[_currentIndex++] = (Cinema)entity;
            Console.WriteLine("Cinema ugurla elave olundu!");
        }

        public void Delete(int id)
        {
            bool found = false;

            for (int i = 0; i < _cinemas.Length; i++)
            {
                if (_cinemas[i] == null)
                    continue;

                if (id == _cinemas[i].Id)
                {
                    found = true;

                    for (int j = i; j < _cinemas.Length - 1; j++)
                    {
                        _cinemas[j] = _cinemas[j + 1];
                    }
                    _currentIndex--;

                    Console.WriteLine($"{id} id-li Cinema silindi!");

                    return;
                }
            }

            if (!found)
            {
                Console.WriteLine($"{id} id-li Cinema tapilmadi!");
            }
        }
        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _cinemas.Length; i++)
            {
                if (_cinemas[i] == null)
                    continue;

                if (_cinemas[i].Id == id)
                {
                    Console.WriteLine("Ugurla deyishdirildi!");

                    return;
                }
            }

            Console.WriteLine("Not found");
        }
        public Entity Get(int id)
        {
            foreach (var item in _cinemas)
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

        public Entity[] GetAll()
        {
            return _cinemas;
        }

        public void Print()
        {
            foreach (var item in _cinemas)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }


    }
}

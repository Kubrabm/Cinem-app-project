using Cinem_app_project.Models;
using Cinem_app_project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinem_app_project.Managers
{
    internal class HallManager : ICrudService, IPrintService
    {
        private Hall[] _halls = new Hall[3];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 2)
            {
                Console.WriteLine("You have exceeded the limit! Only 5 Teatr Halls can be added!");

                return;
            }

            _halls[_currentIndex++] = (Hall)entity;
            Console.WriteLine("Teatr Hall successfully added!");
        }
        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _halls.Length; i++)
            {
                if (_halls[i] == null)
                    continue;

                if (_halls[i].Id == id)
                {
                    _halls[i] = (Hall)entity;
                    Console.WriteLine("Succesfully replaced!");

                    return;
                }
            }

            Console.WriteLine("Not found");
        }
        public void Delete(int id)
        {
            bool found = false;

            for (int i = 0; i < _halls.Length; i++)
            {
                if (_halls[i] == null)
                    continue;

                if (id == _halls[i].Id)
                {
                    found = true;

                    for (int j = i; j < _halls.Length - 1; j++)
                    {
                        _halls[j] = _halls[j + 1];
                    }
                    _currentIndex--;

                    Console.WriteLine($"{id} Teatr Hall deleted!");

                    return;
                }
            }

            if (!found)
            {
                Console.WriteLine($"{id} Teatr Hall not founded!");
            }
        }

        public Entity? Get(int id)
        {
            foreach (var item in _halls)
            {
                if (item == null)
                    continue;

                if (item.Id == id)
                {
                    Console.Write(item);

                    return item;
                }
            }

            Console.WriteLine("Not founded!");

            return null;
        }

        public Entity[] GetAll()
        {
            return _halls;
        }

        public void Print()
        {
            foreach (var item in _halls)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }
    }
}

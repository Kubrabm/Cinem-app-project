using Cinem_app_project.Models;
using Cinem_app_project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinem_app_project.Managers
{
    internal class SessionsManager : ICrudService, IPrintService
    {
        private Session[] _sessions = new Session[3];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 2)
            {
                Console.WriteLine("You have exceeded the limit! Only 3 Sessions can be added!");
            }
            _sessions[_currentIndex++] = (Session)entity;
            Console.WriteLine("Session successfully added!");
        }

        public void Delete(int id)
        {
            bool found = false;

            for (int i = 0; i < _sessions.Length; i++)
            {
                if (_sessions[i] == null)
                    continue;

                if (id == _sessions[i].Id)
                {
                    found = true;

                    for (int j = i; j < _sessions.Length - 1; j++)
                    {
                        _sessions[j] = _sessions[j + 1];
                    }
                    _currentIndex--;

                    Console.WriteLine($"{id} Session deleted!");

                    return;
                }

                if (!found)
                {
                    Console.WriteLine($"{id} Session not found!");
                }
            }
        }
        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _sessions.Length; i++)
            {
                if (_sessions[i] == null)
                    continue;

                if (_sessions[i].Id == id)
                {
                    _sessions[i] = (Session)entity;
                    Console.WriteLine("Successfully replaced!");
                    return;
                }
            }

            Console.WriteLine("Not found");
        }
        public Entity Get(int id)
        {
            foreach (var item in _sessions)
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
            return _sessions;
        }

        public void Print()
        {
            foreach (var item in _sessions)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }

    }
}

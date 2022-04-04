using Homework.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Models
{
    internal class User
    {
        private static int _id;
        private List<Status> _statuses;

        public int Id { get; }
        public string Username { get; set; }

        public User(string username)
        {
            _id++;
            Id = _id;
            Username = username;
            _statuses = new List<Status>();
        }

        public void ShareStatus(Status status)
        {
            _statuses.Add(status);
        }
        public Status GetStatusById(int? id)
        {
            if (id == null)
                throw new NullReferenceException("id null ola bilmez");

            return _statuses.Find(s => s.Id == id);
        }
        public List<Status> GetAllStatuses()
        {
            List<Status> statusesCopy = new List<Status>(); 
            statusesCopy.AddRange(_statuses);
            return statusesCopy;
        }
        public List<Status> FilterStatusByDate(DateTime dateTime)
        {
            List<Status> fitleredStatuses = _statuses.FindAll(s => s.SharedDate > dateTime);
            if (fitleredStatuses.Count == 0)
                throw new NotFoundException("bele bir status tapilmadi");

            return fitleredStatuses;
        }
    }
}

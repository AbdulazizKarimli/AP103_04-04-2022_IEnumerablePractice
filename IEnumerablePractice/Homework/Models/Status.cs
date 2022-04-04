using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Models
{
    internal class Status
    {
        private static int _id;

        public int Id { get; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime SharedDate { get; }

        public Status(string title, string content)
        {
            _id++;
            Id = _id;
            Title = title;
            Content = content;
            SharedDate = DateTime.Now;
        }

        public string GetStatusInfo()
        {
            return $"Id: {Id} - Title: {Title} - Content: {Content} - shared {(int)(DateTime.Now - SharedDate).TotalSeconds} seconds ago";
        }
    }
}

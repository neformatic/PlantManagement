using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManagment.Presentation.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Project { get; set; }
        public string Task { get; set; }
        public int TaskStatus { get; set; }

        public override string ToString()
        {
            return $"{Id}) Проект: {Project} Задача: {Task}";
        }

    }
}

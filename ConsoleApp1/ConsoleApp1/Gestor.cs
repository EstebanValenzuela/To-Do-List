using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Gestor
    {
        private List<Tarea> tareas = new();
        private int NextID = 1;

        public void AddTask(string Description)
        {
            var task = new Tarea(NextID++, Description);
            tareas.Add(task);
            Console.WriteLine("Tarea agregada correctamente");
        }

        public void TaskList()
        {
            if (!tareas.Any())
            {
                Console.WriteLine("Nothing left to do");
                return;
            }

            foreach (var tarea in tareas)
            {
                Console.WriteLine(tarea);
            }
        }

        public void CompleteTask(int ID)
        {
            var tarea = tareas.FirstOrDefault(t => t.Id == ID);
            if (tarea != null)
            {
                tarea.MarkAsCompleted();
                Console.WriteLine("Task completed");
            }
            else
            {
                Console.WriteLine("Task not completed");
            }
        }

        public void DeleteTask(int ID)
        { 
            var tarea = tareas.FirstOrDefault(t => t.Id == ID);
            if (tarea != null)
            {
                tareas.Remove(tarea);
                Console.WriteLine("Task succesfully deleted");
            }
            else
            {
                Console.WriteLine("Task not found" +
                    "");
            }
        }

    }
}

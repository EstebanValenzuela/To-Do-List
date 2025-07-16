namespace ConsoleApp1
{ 
    public class Tarea
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }

        public Tarea(int id, string description)
        {
            Id = id;
            Description = description;
            Completed = false;
        }

        public void MarkAsCompleted()
        {
            Completed = true;
        }

        public override string ToString()
        {
            return $"{Id}. [{(Completed ? "X" : " ")} {Description}";
        }
    }
}
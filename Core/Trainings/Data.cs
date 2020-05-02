namespace SportClub.Core.Trainings
{
    public class Data
    {
        public Data(string id, string name, string definition, string type)
        {
            Id = id;
            Name = name; 
            Definition = definition;
            Type = type;
        }
        //public Data(string id, string name, string definition, string type) :
        //    this(id, name, definition) => Type = type;

        public string Id;
        public string Name;
        public string Definition;
        public string Type;


    }
}

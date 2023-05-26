namespace Models
{
    public class Document
    {
        public int DocumentId {get; set;}
        public string Type {get; set;}
        public string Value {get; set;}
        public int CarId {get; set;}

        public Document()
        {
            
        }

        protected Document(string Type, string Value, int CarId)
        {
            this.Type = Type;
            this.Value = Value;
            this.CarId = CarId;
        }

        public override string ToString()
        {
            return "Id:" + DocumentId + "\n" +
            " Type:" + Type + "\n" +
            " Value:" + Value + "\n" +
            " CarId:" + CarId;
        }
    }
}
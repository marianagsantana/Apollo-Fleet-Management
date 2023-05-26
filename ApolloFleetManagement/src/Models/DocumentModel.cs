namespace Models
{
    public class Document
    {
        public int DocumentId {get; set;}
        public string Type {get; set;}
        public string Value {get; set;}
        public int idCar {get; set;}

        public DocumentModel()
        {
            
        }

        protected DocumentModel(string Type, string Value, int idCar)
        {
            this.Type = Type;
            this.Value = Value;
            this.idCar = idCar;
        }

        public override string ToString()
        {
            return "Id:" + DocumentId + "\n" +
            " Type:" + Type + "\n" +
            " Value:" + Value + "\n" +
            " idCar:" + idCar;
        }
    }
}
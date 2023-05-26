namespace Models
{
    public class Client
    {
        public int ClientId {get; set;}
        public string Name {get; set;}
        public string Telephone{get; set;}
        public string Address {get; set;}
        public string Document {get; set;}

        public ClientModel()
        {

        }

        protected ClientModel(string Name, string Telephone, string Address, string Document)
        {
            this.Name = Name;
            this.Telephone = Telephone;
            this.Address = Address;
            this.Document = Document;
        }

        public override string ToString()
        {
            return "Id:" + ClientId + "\n" +
            "Name:" + Name + "\n" +
            "Telephone:" + Telephone + "\n" +
            "Address:" + Address + "\n" +
            "Document:" + Document;
        }
    }
}
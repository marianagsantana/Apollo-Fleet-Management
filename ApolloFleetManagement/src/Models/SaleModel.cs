namespace Models
{
    public class Sale
    {
        public int SaleId {get; set;}
        public int idCar {get; set;}
        public int idClient {get; set;}
        public int idSeller {get; set;}

        public virtual Models.Seller Seller;

        public SaleModel()
        {

        }

        protected SaleModel(int idCar, int idClient, int idSeller)
        {
            this.idCar = idCar;
            this.idClient = idClient;
            this.idSeller = idSeller;
        }

        public override string ToString()
        {
            return "Id:" + SaleId + "\n" +
            "Id Car:" + idCar + "\n" +
            "Id Client:" + idClient + "\n" +
            "Id Seller:" + idSeller;
        }
    }
}
namespace Models
{
    public class Sale
    {
        public int SaleId {get; set;}
        public int CarId {get; set;}
        public int ClientId {get; set;}
        public int SellerId {get; set;}

        // public virtual Models.Seller Seller;

        public Sale()
        {

        }

        protected Sale(int CarId, int ClientId, int SellerId)
        {
            this.CarId = CarId;
            this.ClientId = ClientId;
            this.SellerId = SellerId;
        }

        public override string ToString()
        {
            return "Id:" + SaleId + "\n" +
            "Id Car:" + CarId + "\n" +
            "Id Client:" + ClientId + "\n" +
            "Id Seller:" + SellerId;
        }
    }
}
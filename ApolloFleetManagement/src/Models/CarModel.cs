namespace Models
{
    public class Car
    {
        public int CarId { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string licensePlate { get; set; }
        public string bodyworkType  { get; set; }
        public decimal Price { get; set; }
        public string chassisCode { get; set; }
        public string renavanCode { get; set; }
        public string fuelType { get; set; }
        public string transmissionType { get; set; }
        public int carMilage { get; set; }
        public int idModel { get; set; }
        public int idBrand { get; set; }

        public virtual Models.Model Model;
        public virtual Models.Document Document;
    
        public CarModel()
        {

        }

        protected CarModel(int Year, string Color, string licensePlate, string bodyworkType, decimal Price, string chassisCode, string renavanCode, string fuelType, string transmissionType, int carMilage, int idModel, int idBrand)
        {
            this.Year = Year;
            this.Color = Color;
            this.licensePlate = licensePlate;
            this.bodyworkType = bodyworkType;
            this.Price = Price;
            this.chassisCode = chassisCode;
            this.renavanCode = renavanCode;
            this.fuelType = fuelType;
            this.transmissionType = transmissionType;
            this.carMilage = carMilage;
            this.idModel = idModel;
            this.idBrand = idBrand;
        }

        public override string ToString()
        {
            return "Id:" + CarId + "\n" +
            "Year:" + Year + "\n" +
            "Color:" + Color + "\n" +
            "licensePlate:" + licensePlate + "\n" +
            "bodyworkType:" + bodyworkType + "\n" +
            "Price:" + Price + "\n" +
            "chassisCode:" + chassisCode + "\n" +
            "renavanCode:" + renavanCode + "\n" +
            "fuelType:" + fuelType + "\n" +
            "ransmissionType:" + transmissionType + "\n" +
            "carMilage:" + carMilage + "\n" +
            "idModel:" + idModel + "\n" +
            "idBrand:" + idBrand;
        }
    }
}
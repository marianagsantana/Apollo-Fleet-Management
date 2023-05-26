namespace Models
{
    public class Car
    {
        public int CarId { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string LicensePlate { get; set; }
        public string BodyworkType  { get; set; }
        public decimal Price { get; set; }
        public string ChassisCode { get; set; }
        public string RenavanCode { get; set; }
        public string FuelType { get; set; }
        public string TransmissionType { get; set; }
        public int CarMilage { get; set; }
        public int ModelId { get; set; }
        public int BrandId { get; set; }

        // public virtual Models.Model Model;
        // public virtual Models.Document Document;
    
        public Car()
        {

        }

        protected Car(int Year, string Color, string LicensePlate, string BodyworkType, decimal Price, string ChassisCode, string RenavanCode, string FuelType, string TransmissionType, int CarMilage, int ModelId, int BrandId)
        {
            this.Year = Year;
            this.Color = Color;
            this.LicensePlate = LicensePlate;
            this.BodyworkType = BodyworkType;
            this.Price = Price;
            this.ChassisCode = ChassisCode;
            this.RenavanCode = RenavanCode;
            this.FuelType = FuelType;
            this.TransmissionType = TransmissionType;
            this.CarMilage = CarMilage;
            this.ModelId = ModelId;
            this.BrandId = BrandId;
        }

        public override string ToString()
        {
            return "Id:" + CarId + "\n" +
            "Year:" + Year + "\n" +
            "Color:" + Color + "\n" +
            "LicensePlate:" + LicensePlate + "\n" +
            "BodyworkType:" + BodyworkType + "\n" +
            "Price:" + Price + "\n" +
            "ChassisCode:" + ChassisCode + "\n" +
            "RenavanCode:" + RenavanCode + "\n" +
            "FuelType:" + FuelType + "\n" +
            "ransmissionType:" + TransmissionType + "\n" +
            "CarMilage:" + CarMilage + "\n" +
            "ModelId:" + ModelId + "\n" +
            "BrandId:" + BrandId;
        }
    }
}
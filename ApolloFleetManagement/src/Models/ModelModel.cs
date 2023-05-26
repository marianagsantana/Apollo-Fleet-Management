namespace Models
{
    public class Model
    {
        public int ModelId {get; set;}
        public string Name {get; set;}
        public int BrandId {get; set;}

        public Model()
        {

        }

        protected Model(string Name, int BrandId)
        {
            this.Name = Name;
            this.BrandId = BrandId;
        }

        public override string ToString()
        {
            return "Id:" + ModelId + "\n" +
            "Name:" + Name + "\n" +
            "Brand:" + BrandId;
        }
    }
}
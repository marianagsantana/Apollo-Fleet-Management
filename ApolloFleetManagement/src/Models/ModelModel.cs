namespace Models
{
    public class Model
    {
        public int ModelId {get; set;}
        public string Name {get; set;}
        public int idBrand {get; set;}

        public ModelModel()
        {

        }

        protected ModelModel(string Name, int idBrand)
        {
            this.Name = Name;
            this.idBrand = idBrand;
        }

        public override string ToString()
        {
            return "Id:" + ModelId + "\n" +
            "Name:" + Name + "\n" +
            "Brand:" + idBrand;
        }
    }
}
using Repository;

namespace Models
{
    public class Brand
    {
        public int BrandId {get; set;}
        public string Name {get; set;}
    }

    public virtual Models.Car Car;
    
    public BrandModel()
    {

    }

    protected BrandModel(string name)
    {
        this.Name = Name;
    }

    public override string ToString()
    {
        return "Id: " + BrandId + "\n" +
               "Name" + Name;
    }
}
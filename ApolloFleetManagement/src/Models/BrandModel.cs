namespace Models
{
    public class Brand
    {
        public int BrandId {get; set;}
        public string Name {get; set;}
    
    // public virtual Models.Car Car;
    public Brand()
    {

    }

    protected Brand(string Name)
    {
        this.Name = Name;
    }

    public override string ToString()
    {
        return "Id: " + BrandId + "\n" +
               "Name" + Name;
    }
}
}
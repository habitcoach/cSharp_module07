using EF_databaseFirst;

public class Program
{

    public static void Main(string[] args)
    {

        Console.WriteLine("Entity framework demo");

        var db = new StudentDbContext();

        //To create a new db
        //  bool result= db.Database.EnsureCreated();
        // if(result) Console.WriteLine("database created");



        //db.Add(new Student() {  Name = "Ranjith", Age = 20, City = "xyz", Address = "address01" });
        //db.Add(new Student() {  Name = "Name02", Age = 22, City = "xyz02", Address = "address02" });
        //db.Add(new Student() {  Name = "Name03", Age = 23, City = "xyz03", Address = "address03" });
        //db.Add(new Student() { Name = "Name04", Age = 24, City = "xyz04", Address = "address04" });

        // db.SaveChanges();




        var studentsfromDB = db.Students.ToList();
        foreach (var item in studentsfromDB)
        {
            Console.WriteLine(item.Name);
        }


    }


}
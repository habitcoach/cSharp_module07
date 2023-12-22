using Module07_ADOEF;

public class Program { 

    public static void Main(string[] args)
    {

        Console.WriteLine("Entity framework demo");

        var db = new StudentContext();

       // To create a new db
          bool result = db.Database.EnsureCreated();
        if (result) Console.WriteLine("database created");



        //db.Add(new Student() { Name = "Ranjith", Age = 20, City = "xyz", Address = "address01" });
        //db.Add(new Student() { Name = "Name02", Age = 22, City = "xyz02", Address = "address02" });
        //db.Add(new Student() { Name = "Name03", Age = 23, City = "xyz03", Address = "address03" });
        //db.Add(new Student() { Name = "Name04", Age = 24, City = "xyz04", Address = "address04" });

         db.SaveChanges();





        var studentsfromDB = db.Students;
        //foreach (var item in studentsfromDB)
        //{
        //    Console.WriteLine(item.Name);
        //}

        //LINQ
        //Deferred query execution
        // Forced query execution: add to list so that collection will be in-memory
        //var studentsfromdb03 = (from b in db.Students
        //                        where b.City.Contains("xyz0")
        //                        orderby b.Name
        //                        select new { b.Name, b.City }).ToList();

        #region Note
        /*
         Whne you are not adding the ToList(), it is a deferred execution that is execution does'nt 
        happend till you use it.  But when you use debugger and open result view, it will infact run
        the Iernumration hence you will see reult but that does mean it is actually quering data.

        Now when you add toList at the end it will immediated query the database.
         */
        #endregion

        //Same as previous but with lambda function

        var studentsfromdb03 = db.Students
                               .Where(b => b.City.Contains("xyz0"))
                               .OrderBy(b => b.Name)
                               .Select(b => new { b.Name, b.City }).ToList();
                               


        foreach (var student in studentsfromdb03)
        {
            Console.WriteLine("Name: " + student.Name +"City:"+ student.City);
        }


        //Manipulation data

        //var b2 = db.Find<Student>((int)5);

        //if (b2 != null) db.Remove(b2);

        //db.SaveChanges();


        //var studentsfromDB02 = db.Students.ToList();
        //foreach (var item in studentsfromDB02)
        //{
        //    Console.WriteLine("new    " + item.Name);
        //}


    }


}
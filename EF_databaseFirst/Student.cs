using System;
using System.Collections.Generic;

namespace EF_databaseFirst;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public string Address { get; set; } = null!;

    public string City { get; set; } = null!;
}

// auther and the book relashion ships 
// in database yuo need to use join table ( middle table )

// same thing happend with the EF core 

public class Book{ // ----------------------------------------------------->  (1)
    public int Id {get; set;}
    public string Name{ get; set;}

    public List<Book_Auther> Book_Authers {get ;set;} // [+]
}

public class Auther{ // --------------------------------------------------> (2)
    public int Id {get ; set;}
    public string FullName {get ;set;}

    public List<Book_Auther> Book_Authers {get ;set;} // [+]
}

//  create new model 
public class Book_Auther{  // many to many table // ------------------------------------------> (3)
    public int Id {get ; set;}

    public int BookId {get;set;}
    public virtual Book Book {get ;set;}


    public int AutherId { get; set;}
    public virtual Auther Auther {get ; set;}
}


///////////////////////////////////////////////////////////////////////////////////////
///////////////// fluent API .//////////////////////////////////////////////////////

[+] overrite onModelCreating method 

// application db content 

 protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Book_Auther>()
        .hasOne(b => b.book)
        .withMany( ba => ba.Book_Authers )
        .hasForeginKey( bi => bi.BookId );


     modelBuilder.Entity<Book_Auther>()
        .hasOne(b => b.Auther)
        .withMany( ba => ba.Book_Authers )
        .hasForeginKey( bi => bi.AutherId );

    

}

public class Couch{

    public int Id {get; set;}
    public string Name {get ;set;}

    public int? TeamId {get ;set;} // [+]   

}


public class Team{

    
    public int Id {get; set;}
    public string Name {get ;set;}
    public virtual Couch Couch {get; set;} // [+] 

}
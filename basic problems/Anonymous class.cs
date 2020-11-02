
using System; 
  
public class GFG { 
  
  
    static public void mymethod(dynamic val) 
    { 
        Console.WriteLine(val.s_id); 
        Console.WriteLine(val.s_name); 
        Console.WriteLine(val.language); 
    } 
    static public void Main() 
    { 
  
        
        var anony_object = new {s_id = 134,  
                                s_name = "Siya",  
                             language = "Ruby"}; 
        mymethod(anony_object); 
    } 
} 
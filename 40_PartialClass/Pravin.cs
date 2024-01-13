
//Properties

using System;


interface ISudent
{
    void Print();
}


public partial class Student  : ISudent
  {
    //public int RollNumber { get; set; }
    public string Name { get; set; }

    public Student()
    {
        PrintA();
    }

   partial void PrintA();


    //partial void PrintA()
    //{

    //} 
    
    // we can implement method here also and also  in Pawan/another class
    // if PrintA method does not have implementation then 
    //compiler removes its declaration and calls

// we cannot write Public and other access specifier to Partial Method
    //we cannot return type to partial method
    //

// PARTIAL METHOD CAN BE WRITTEN ONLY IN PARTIAL CLASS....



}




//using partial class we can split a class into multiple physical files 
//every part have partial keyword
//we cannot create two times fields/Method with same name
// interface written in Pravin Class and that method written in Pawan class
//


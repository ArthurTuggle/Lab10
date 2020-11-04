using System;

public class Employee{



   String firstname;
   String lastname;
   String id;
   int age;
   String address;
   String phoneNumber;
   String title;
   double yearlySalary;
   String employeeStatus;


   public Employee(){
       firstname = "Unknown";
       lastname = "Unknown";
       id = "Unknown";
       age = 0;
       employeeStatus = "active";
}

   public Employee(String firstname, String lastname, String id, int age, double yearlySalary=0){
       this.firstname = firstname;
       this.lastname = lastname;
       this.id = id;
      if(age<18)
       this.age = 18;
      else
       this.age = age;
      employeeStatus = "active";
      if(yearlySalary<1000)
      this.yearlySalary = 1000;
      else
       this.yearlySalary=yearlySalary;
}
 

   public void Intro(){
      if(yearlySalary==0)
        Console.WriteLine("First Name: "+firstname+"\nLast Name: "+lastname+"\nAge: "+age+"\nID: "+id);
      else
       Console.WriteLine("First Name: "+firstname+"\nLast Name: "+lastname+"\nAge: "+age+"\nID: "+id+"\nYearlySalary: "+yearlySalary);
}

  public void IncreaseSalary(float percent){
  if(percent<0)
   Console.WriteLine("Invalid Input. Yearly salary not updated.");
  else{
    yearlySalary = yearlySalary + (yearlySalary * percent)/100;
    Console.WriteLine("Yearly salary updated to "+yearlySalary);
  }
}

   public void RemoveEmployee(){
     if(employeeStatus=="inactive")
     Console.WriteLine("Employee already inactive");
  else{
    employeeStatus = "inactive";
    Console.WriteLine("Employee removed successfully");
   }
 }
}
public class MainClass
{
            public static void Main()
            {
                Employee e1 = new Employee();
                e1.Intro();

                Employee e2 = new Employee("Robert", "Downey", "12321", 12, 100);
                e2.Intro();

                Employee e3 = new  Employee("John", "Smith", "S0089", 38, 50000);
                e3.Intro();
                e3.IncreaseSalary(-2);
                e3.RemoveEmployee();

                Employee e4 = new Employee("Maria", "Lambert", "S0100", 26, 80000);
                e4.Intro();
                e4.IncreaseSalary(7);
                e4.RemoveEmployee();
                e4.RemoveEmployee();
            }
}
using HR;

// Employee e1=new Employee();
//Console.WriteLine(Employee.name);
//  Console.WriteLine(e1.name);
// e1.name="rode";
// Console.WriteLine(e1.name);
//Employee.name="rode";
// Employee e2=new Employee("rode");
//  Console.WriteLine(e2.name);
// double area=0;
// double circum ;
//  double x=Employee.Calculate(out area,out circum);
// Console.WriteLine(area);
// Console.WriteLine(circum);
// Console.WriteLine(x);

 //int val = 50;  
            Employee e1= new Employee(); // Creating Object  
          //  Console.WriteLine("Value before passing out variable " + val);  
            // e1.Show(out int val); // Passing out argument  
            // Console.WriteLine("Value after recieving the out variable " + val);  
            e1.Show("vaibhav",12.17,100,new Employee(10));
Console.WriteLine(e1.name1);
e1.partial1();
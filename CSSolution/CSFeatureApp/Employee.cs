namespace HR;
public  partial class Employee {
    //ublic const  int name;
        public readonly int name1;

    public Employee(){
    //name++;
    name1++;

    }
public Employee(int name){
    this.name1=name;
}

    public static double  Calculate(out double  area,out double circumference){
        double x=10;
        int radius=5;
        area=3.14*radius*radius;
        circumference=2*3.14*radius;
        return  area;
    }

     public void Show(params object [] names) // Out parameter  
        {  
            foreach(object name in names)
            {
                Console.WriteLine(name);
            }
        }  
}
class Emp {
    public static string name;
    public static void GoToOffice() {
        System.Console.WriteLine(name + "이(가) 출근한다.");
    }
}
class EmpTest {
    static void Main(string[] args)  {
        Emp.name = "홍";
        System.Console.WriteLine(Emp.name);
        Emp.GoToOffice();
        int i = 9;
        System.Console.WriteLine(default(int));
    }
}

//class Program
//{

//public static IEnumerable<int> foo()
//{
//   yield return 1;
//   yield return 2;
//   yield return 3;
//}

//static void Main(string[] args)
//{
//    foreach (int i in foo())
//    {
//        Console.WriteLine(i);
//    }
//}

//}




using ConsoleApp11;

//Student student1 = new Student("Nazim", "Nazimli", new List<int> { 1, 2, 3, 4 });
//Student student2 = new Student("Nazim", "Nazimli", new List<int> { 2, 5, 6, 12 });

////foreach (var item in student1)
////{
////    Console.WriteLine(item);
////}


//Student student3 = new Student();
//student3 = student1;
//student3.Name = "Rakif";
//student3.Surname = "Rakifli";

//Console.WriteLine(student1.Name);
//Console.WriteLine(student1.Surname);





//Teacher teacher1 = new Teacher("Cebiw", "Mellim");
//Teacher teacher2 = new Teacher("Sebiw", "Mellim");

//Teacher teacher3 = new Teacher();
//teacher3 = (Teacher)teacher2.Clone();
//teacher3.Name = "Qudret";
//Console.WriteLine(teacher3);
//Console.WriteLine(teacher2);

//teacher3 = teacher2;

//Console.WriteLine(teacher3);
//teacher3.Name = "Qudret";
//Console.WriteLine(teacher3);
//Console.WriteLine(teacher2);




//Teacher teacher = new Teacher();



//Delegate
//1 funksya icerisinde basqa funksiyani parametr olaraq gondermek ve ya qebul etmek olar
//Delegate ler default olaraq internal olur public etmek olur
//Delegate ler class icerisinde yazildiqda ancaq class icerisinde isleyir 
//Delegate e hansi methodlar elave olnubsa delegate cagrilanda hamisi cagrilir

//delegate void MyDel();
//class Program
//{


//    static void foo()
//    {
//        Console.WriteLine("Foo");
//    }
//    static void bar( ) { 
//        Console.WriteLine("Bar");
//    }
//    static void boo()
//    {
//        Console.WriteLine("Boo");
//    }
//    static void hello(MyDel myDel)
//    {
//        myDel();
//    }
//    static void Main(string[] args)
//    {
//        MyDel myDel = foo;

//        myDel += bar;
//        myDel += boo;

//        myDel -= bar;
//        //myDel();

//        hello(myDel);


//    }




}
















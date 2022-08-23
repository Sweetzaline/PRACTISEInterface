using System;

namespace InterfaceProgram
{
    interface ITestInterface1
    {
        //int x; //cant declare variable in interface
        void Add(int a, int b);
    }

    interface ITestInterface2: ITestInterface1
    {
        void Sub(int a, int b);// ITestInterface2 contains 2 methods: Sub and Add.
    }

    class Check: ITestInterface2
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a-b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("**Interface Application***\n");
            Check obj = new Check();
            obj.Add(2, 4);
            obj.Sub(3, 2);

            ITestInterface2 obj2 = obj;//cant create instance of an interface. But can create parent's reference(created using the child instance), to call the method.
            obj2.Add(2, 3);
            Console.ReadLine();
        }
    }
}

using System;
/*
    interface Companies
    {
        void hiring();
    }
    interface MNC
    {
        void interviewPlace();
    }   
    interface Companies1
    {
        void hiring1();
    }
    class DemoAddress : Companies ,MNC ,Companies1
    {
        public void hiring(){
             Console.WriteLine(" TCS company in bangalore");
        }
        public void hiring1(){
             Console.WriteLine(" Annalect company in bangalore");

        }
        public void interviewPlace(){
            Console.WriteLine(" 1-238/h bangalore in kundahalli colony in presitage TechnoStar ");
        }
    }   
class demo{
    static void Main(string[] args){
        DemoAddress myobj = new DemoAddress();
        myobj.hiring();
        myobj.hiring1();
        myobj.interviewPlace();
    }
}
*/
interface added{
    void add();
}
interface sub{
    void sub();
}
interface multi{
    void multi();
}
class Ari : added ,sub ,multi
{
    int a =10;
    int b= 20;
    public void add()
    {
        Console.WriteLine("The add of two numbers is :"+(a+b));
    }
    public void sub()
    {
        Console.WriteLine("The sub of two numbers is :"+(a-b));
    }
    public void multi()
    {
        Console.WriteLine("The Multi of two numbers is :"+(a*b));
    }
}
class Program{
    static void Main(string[] args){
        Ari myobj =new Ari();
        myobj.add();
        myobj.sub();
        myobj.multi();
    }
}

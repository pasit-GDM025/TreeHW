using System;
class Program{
    public static void Main(){
        Stack<string>stack = new Stack<string>();
        Tree<string>tree = new Tree<string>();
        string RootName = "Admin";
        tree.AddChild(-1,RootName);
        string SiblingName = "";
        string GeneralName = "";
        string MaiyooName = "";
        string HeadName = Console.ReadLine();
        tree.AddChild(0,HeadName);
        int Headcount = int.Parse(Console.ReadLine());
        int count = 0;
        int SiblingCount = 0;
        Manager(ref count, ref Headcount, ref SiblingCount, ref tree, ref GeneralName, ref SiblingName);
        MaiyooName = Console.ReadLine();
    }
    static void Manager(ref int count, ref int Headcount, ref int SiblingCount, ref Tree<string>tree, ref string GeneralName, ref string SiblingName){
        for(int j = 1; j <=Headcount; j++){
            GeneralName = Console.ReadLine();
            tree.AddChild(j,GeneralName);
            count = int.Parse(Console.ReadLine());
            Lower(ref count, ref Headcount, ref SiblingCount, ref tree, ref GeneralName, ref SiblingName);
        }
    }
    static void Lower(ref int count, ref int Headcount, ref int SiblingCount, ref Tree<string>tree, ref string GeneralName, ref string SiblingName){
        for(int i =1;i<=count;i++){
            SiblingName = Console.ReadLine();
            tree.AddSibling(i,SiblingName);
            SiblingCount = int.Parse(Console.ReadLine());
            
        }
    }
}

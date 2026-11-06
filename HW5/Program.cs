using System;
class Program
{
    static void Main(string[] args)
    {
        LibraryMember member1 = new LibraryMember("John", 5);
        LibraryMember member2 = new LibraryMember("Sarah", 10);

        member1.PrintInfo();
        member2.PrintInfo();

        Console.WriteLine($"Total members: {LibraryMember.GetMemberCount()}");
    }
}
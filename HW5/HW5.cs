using System;
public class LibraryMember
{
    public string MemberName { get; set; }
    public int OverdueDays { get; set; }
    private int totalFine;
    private static int memberCount = 0;

    //
    public LibraryMember(string memberName, int overdueDays)
    {
        MemberName = memberName;
        OverdueDays = overdueDays;
        totalFine = 0;

        memberCount++;
    }

    public void CalcTotalFine()
    {
        if (OverdueDays <= 0)
        {
            totalFine = 0;
        }
        else
        {
            totalFine = OverdueDays * 5;

            if (OverdueDays > 7)
            {
                totalFine += 10;
            }
        }
    }

    public void PrintInfo()
    {
        CalcTotalFine();
        Console.WriteLine($"{MemberName} owes ${totalFine} in fines.");
    }

    public static int GetMemberCount()
    {
        return memberCount;
    }
}

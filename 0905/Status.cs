﻿var monster = new Monster();
monster.SetStatus(Monster.Status.A | Monster.Status.B);
Console.WriteLine(monster.CurrentStatus);   // A, B
monster.RemoveStatus(Monster.Status.B);
monster.AddStatus(Monster.Status.C);
Console.WriteLine(monster.CurrentStatus);   // A, C
Console.WriteLine(monster.CheckStatus(Monster.Status.A));   // True
Console.WriteLine(monster.CheckStatus(Monster.Status.B));   // False
Console.WriteLine(monster.CheckStatus(Monster.Status.C));   // True
monster.ToggleStatus(Monster.Status.B);
Console.WriteLine(monster.CurrentStatus);   // All


class Monster
{
    [Flags]
    public enum Status
    {
        None = 0,
        A = 1 << 0,
        B = 1 << 1,
        C = 1 << 2,
        All = A | B | C
    }

    private Status currentStatus;

    public Status CurrentStatus
    {
        get { return currentStatus; }
    }

    public void SetStatus(Status status)
    {
        currentStatus = status;
    }

    public bool CheckStatus(Status status)
    {
        return (currentStatus & status) == status;
    }

    public void AddStatus(Status status)
    {
        currentStatus |= status;
    }

    public void ToggleStatus(Status status)
    {
        currentStatus ^= status;
    }
    public void RemoveStatus(Status status)
    {
        //if((currentStatus & status) != 0)
        //    currentStatus -= status;

        currentStatus &= ~status;
    }
}
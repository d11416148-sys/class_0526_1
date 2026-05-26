using System;
using System.Numerics;

public interface IGroup
{
    public string GetGroup();
}

public interface IData
{
    public string GetData();
}

public interface IName : IData, IGroup
{
    public string GetName();
}

public class Person : IName
{
    public string GetName()
    {
        return "Person";
    }

    public string GetData()
    {
        return "Data";
    }
    public string GetGroup()
    {
        return "Group";
    }
}

public class Student : IData
{
    public string GetData()
    {
        return "Data";
    }
}
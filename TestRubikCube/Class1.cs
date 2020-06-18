using System;
using System.Collections.Generic;
/// <summary>
/// Summary description for Class1
/// </summary>
/// 
public class MaClasse

{
    public MaClasse()
    {
    }

    public MaClasse(string name, string value)
    {
        Name = name;
        Value = value;
    }

    public string Name
    {
        get; set;
    }

    public string Value
    {
        get; set;
    }

    public List<MaClasse> BaseVariable
    {
        get;
        set;
    }
}
public class Class1
{
    public Class1()
    {

    }

    //
    // TODO: Add constructor logic here
    //

    void test()
    {
        var a = new MaClasse();

        var l = new List<MaClasse>() {
            new MaClasse() ,
            new MaClasse()
        };

        a.BaseVariable = l;

        a.BaseVariable.AddRange(l);

        a.BaseVariable.AddRange(new List<MaClasse> {
            new MaClasse("OrderId","1") ,
            new MaClasse("DetailLine", "0")
        });

        (int x, int y) mytuple = (1, 2);

        mytuple.x = 4;
        mytuple.y = 5;

    }

}

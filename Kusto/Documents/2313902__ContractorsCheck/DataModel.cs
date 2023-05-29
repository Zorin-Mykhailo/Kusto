namespace Kusto.ContractorsCheck.T2313902__ContractorsCheck;



/// <summary> Номенклатура </summary>
public class Nmc
{
    public String Title { get; set; }

    public String Name { get; set; }

    public UnitOfMeasure MeasureUnit { get; set; }

    public EActuality Actuality { get; set; }

    public String Remarks { get; set; }

    public InfoOfValidation ValidationInfo { get; set; }

    public InfoOfDuplicate DuplicateInfo { get; set; }

    public Nmc Parent { get; set; }

    public Boolean IsGroup { get; set; }

    public Guid GlobalId { get; set; }

    public User CreationUser { get; set; }

    public DateTime CreationDate { get; set; }

    public User ModificationUser { get; set; }

    public DateTime ModificationDate { get; set;}
}

public enum EActuality
{
    Actual,
    Deprecated
}


/// <summary> Ед. измерения </summary>
public class UnitOfMeasure
{
    public String Title { get; set; }

    public String Name { get; set; }

    public String ShortName { get; set; }

    public Guid GlobalId { get; set; }

    public EActuality Actuality { get; set; }

    public String Remarks { get; set; }

    public InfoOfValidation ValidationInfo { get; set; }

    public InfoOfDuplicate DuplicateInfo { get; set; }

    public Nmc Parent { get; set; }

    public Boolean IsGroup { get; set; }

    public User CreationUser { get; set; }

    public DateTime CreationDate { get; set; }

    public User ModificationUser { get; set; }

    public DateTime ModificationDate { get; set; }

    //TODO UnitOfMeasure
}

public class InfoOfValidation
{
    //todo InfoOfValidation
}

public class InfoOfDuplicate
{
    //todo InfoOfDuplicate
}

public class User { }
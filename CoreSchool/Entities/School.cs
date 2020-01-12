namespace CoreSchool.Entities
{
  class School
  {
    string name;
    public string Name
    {
      get {
        return name;
      }
      set {
        name = value;
      }
    }

    public int CreationDate {
      get;
      set;
    }

    public string Country { get; set; }
    public string City { get; set; }

    public SchoolType Type { get; set; }

    public School(string name, int creationDate) => (Name, CreationDate) = (name, creationDate);

    public School(string name, int creationDate, SchoolType type, string country = "Peru")
    {
      (Name, CreationDate, Type, Country) = (name, creationDate, type, country);
    }

    public override string ToString()
    {
      return $"Name: {name} \nType: {Type}\nCountry: {Country}";
    }
  }
}
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

    public string Contry { get; set; }
    public string City { get; set; }

    public School(string name, int creationDate) => (Name, CreationDate) = (name, creationDate);
  }
}
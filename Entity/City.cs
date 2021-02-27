namespace db_projektarbeit
{
    public class City
    {
        public int Id { get; set; }
        public int Zip { get; set; }
        public string Name { get; set; }
        public string DisplayName => ToString();

        public override string ToString()
        {
            return Zip + " " + Name;
        }
    }
}

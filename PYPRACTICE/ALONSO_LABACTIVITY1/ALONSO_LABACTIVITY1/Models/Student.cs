namespace ALONSO_LABACTIVITY1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }

		// Classic method syntax
		public string FullInfo()
		{
			return Id + " - " + Name + " - " + Course;
		}

		public string Greeting()
		{
			return "Hello, " + Name + "!";
		}

		public string YearLevel()
		{
			return "3rd Year";
		}


	}
}

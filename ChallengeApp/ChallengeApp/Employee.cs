namespace ChallengeApp
{
    public class Employee
    {
        public string name;
        public string surname;
        public int age;
        private List<int> grades = new List<int>();
        public void AddGrade(int number)
        {
            this.grades.Add(number);
        }

        public Employee(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public int result
        {
            get
            {
                return this.grades.Sum();
            }
        }
    }
}

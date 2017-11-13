using System;
namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            TraineeStudent ts = new TraineeStudent("58030207", 500);
            try
            {
                Console.WriteLine("StudentID : " + ts.StudentID);
                Console.WriteLine("Salary by day : " + (ts.Salary >= 300 &
                ts.Salary <= 450 ? Convert.ToString(ts.Salary) : "Error! invalid Salary"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
    class TraineeStudent
    {
        private string getStudentID;
        private float getSalary;
        public TraineeStudent(string StudentID, float Salary)
        {
            
            this.getStudentID = StudentID;
            this.getSalary = Salary;
        }
        public string StudentID
        {
            get { return getStudentID; }
        }
        public float Salary
        {
            get { return getSalary; }
        }
    }
}
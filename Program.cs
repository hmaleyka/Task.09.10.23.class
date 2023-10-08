namespace ClassHometask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string givenName = "Murad";
            string givenSurname = "Aliyev";
            string fullExperience = "java";


            BackEnd job = new BackEnd(name:givenName, surname: givenSurname, experience:fullExperience);


            FrontEnd work = new FrontEnd();
            work.name = " nail";
            work.surname = "heybatov";
            work.experience = "react";
            work.age = 34;
            work.ReactExperienceYear = 7;



            Developer employment = new Developer();
            employment.name = "maleyka";
            employment.surname = "heybatova";
            employment.age = 18;


            job.getFullInfo();
        }
    }
}
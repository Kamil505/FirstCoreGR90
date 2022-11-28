using FirstCoreGR90.Models;

namespace FirstCoreGR90
{
    public class PersonalList
    {
        public static List<Personal> pers = new List<Personal>()
        {
        new Personal
            {
                Id = 1,
                Name="Kamil",
                Surname="Zamanov",
                BirthPlace="Baku",
                Age=31,
                Salary=1000

            },
                   
            new Personal
            {
                Id = 1,
                Name="Shafi",
                Surname="Shafiyev",
                BirthPlace="Qusar",
                Age=31,
                Salary=1000

            },       
            new Personal
            {
               Id = 1,
                Name="Ruslan",
                Surname="Moscow",
                BirthPlace="2323",
                Age=31,
                Salary=1000

            }


        };
    }
}

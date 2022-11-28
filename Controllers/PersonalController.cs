using FirstCoreGR90.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstCoreGR90.Controllers
{
    public class PersonalController : Controller
    {
        public List<Personal> GetAllPeople()
        {
            return PersonalList.pers;
        }
        public Personal GetPersonById(int id)
        {
            var personnal= PersonalList.pers.Where(x => x.Id == id).FirstOrDefault();
            return personnal;
        }

        public Personal Create(int id)
        {
            var personnal = PersonalList.pers.Where(x => x.Id == id).FirstOrDefault();
            return personnal;
        }


    }
}

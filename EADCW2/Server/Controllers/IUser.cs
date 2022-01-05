using EADCW2.Server.Models;
using System.Collections.Generic;

namespace EADCW2.Server.Controllers
{
    public interface IUser
    {
        //create project method
        User create(User user);
        Developer createDev(Developer developer);
        //read project method
        //get project one
        User Get(int id);
        Developer GetDev(int id);
        //get all project
        List<Developer> listOfUsers();
        //get all developers for that specific company id
        List<Developer> listOfDevelopersInCompany(int companyId);
        List<Developer> listOfDevelopersInProject(int projectId);
        //update project method
        User Upate(User user);
        Developer UpateDev(Developer developer);
        //delete project method
        bool DeleteDev(int id);
    }
}

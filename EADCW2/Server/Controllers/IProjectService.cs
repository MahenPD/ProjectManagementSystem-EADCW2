using EADCW2.Server.Models;
using System.Collections.Generic;

namespace EADCW2.Server.Controllers
{
    public interface IProjectService
    {
        //create project method
        Project create(Project project);

        //read project method
        //get project one
        Project Get(int id);
        //get all project
        List<Project> listOfProjects();
        List<Project> listOfProjectsToCompanyIdAsync(int comp_id);
        //update project method
        Project Upate(Project project);

        //delete project method
        bool Delete(int id);
    }
}

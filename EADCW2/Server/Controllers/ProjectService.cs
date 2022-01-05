using EADCW2.Server.Models;
using EADCW2.Server.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EADCW2.Server.Controllers
{
    public class ProjectService : IProjectService
    {
        private readonly ApplicationDbContext _db;

        public ProjectService(ApplicationDbContext db)
        {
            _db = db;
        }
        public Project create(Project project)
        {
            if (project != null)
            {
                _db.Projects.Add(project);
                _db.SaveChanges();
            }

            return project;
        }

        public bool Delete(int id)
        {
            var dbProject = _db.Projects.Find(id);

            if(dbProject != null)
            {
                _db.Remove(dbProject);
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public Project Get(int id)
        {
            return _db.Projects.Find(id);
        }

        public List<Project> listOfProjects()
        {
            return _db.Projects.ToList();
        }

        public List<Project> listOfProjectsToCompanyIdAsync(int comp_id)
        {
            List<Project> list = new List<Project>();

            foreach (var project in _db.Projects)
            {
                if(project.companyProjectId == comp_id)
                {
                    list.Add(project);
                }
            }

            return list;
        }

        public Project Upate(Project project)
        {
            var dbProject = _db.Projects.Find(project.projectId);
            if (dbProject != null)
            {
                dbProject = project;
                _db.SaveChanges();

            }

            return dbProject;
        }
    }
}

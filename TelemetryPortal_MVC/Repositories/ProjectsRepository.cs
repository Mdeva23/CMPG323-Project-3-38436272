using System.Collections.Generic;
using System.Linq;
using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;

public class ProjectsRepository
{
    private readonly ApplicationDbContext _context;

    public ProjectsRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Project> GetAllProjects()
    {
        return _context.Projects.ToList();
    }

    public Project GetProjectById(int id)
    {
        return _context.Projects.Find(id);
    }

    public void AddProject(Project project)
    {
        _context.Projects.Add(project);
        _context.SaveChanges();
    }

    public void UpdateProject(Project project)
    {
        _context.Projects.Update(project);
        _context.SaveChanges();
    }

    public void DeleteProject(int id)
    {
        var project = _context.Projects.Find(id);
        if (project != null)
        {
            _context.Projects.Remove(project);
            _context.SaveChanges();
        }
    }
}

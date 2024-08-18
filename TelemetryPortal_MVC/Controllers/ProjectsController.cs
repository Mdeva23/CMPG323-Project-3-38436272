using Microsoft.AspNetCore.Mvc;
using TelemetryPortal_MVC.Models;  // Adjust to your actual namespace
using TelemetryPortal_MVC;  

namespace YourNamespace.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ProjectsRepository _projectRepository;

        public ProjectController(ProjectsRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public IActionResult Index()
        {
            var projects = _projectRepository.GetAllProjects();
            return View(projects);
        }

        public IActionResult Details(int id)
        {
            var project = _projectRepository.GetProjectById(id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Project project)
        {
            if (ModelState.IsValid)
            {
                _projectRepository.AddProject(project);
                return RedirectToAction(nameof(Index));
            }
            return View(project);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var project = _projectRepository.GetProjectById(id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        [HttpPost]
        public IActionResult Edit(Project project)
        {
            if (ModelState.IsValid)
            {
                _projectRepository.UpdateProject(project);
                return RedirectToAction(nameof(Index));
            }
            return View(project);
        }

        public IActionResult Delete(int id)
        {
            _projectRepository.DeleteProject(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

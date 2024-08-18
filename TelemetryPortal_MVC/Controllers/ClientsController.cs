using Microsoft.AspNetCore.Mvc;
using TelemetryPortal_MVC.Models;
using TelemetryPortal_MVC;

namespace YourNamespace.Controllers
{
    public class ClientController : Controller
    {
        private readonly ClientsRepository _clientRepository;

        public ClientController(ClientsRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public IActionResult Index()
        {
            var clients = _clientRepository.GetAllClients();
            return View(clients);
        }

        public IActionResult Details(int id)
        {
            var client = _clientRepository.GetClientById(id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Client client)
        {
            if (ModelState.IsValid)
            {
                _clientRepository.AddClient(client);
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var client = _clientRepository.GetClientById(id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        [HttpPost]
        public IActionResult Edit(Client client)
        {
            if (ModelState.IsValid)
            {
                _clientRepository.UpdateClient(client);
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

        public IActionResult Delete(int id)
        {
            _clientRepository.DeleteClient(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

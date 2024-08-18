﻿using System.Collections.Generic;
using System.Linq;
using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;

public class ClientsRepository
{
    private readonly ApplicationDbContext _context;

    public ClientsRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Client> GetAllClients()
    {
        return _context.Clients.ToList();
    }

    public Client GetClientById(int id)
    {
        return _context.Clients.Find(id);
    }

    public void AddClient(Client client)
    {
        _context.Clients.Add(client);
        _context.SaveChanges();
    }

    public void UpdateClient(Client client)
    {
        _context.Clients.Update(client);
        _context.SaveChanges();
    }

    public void DeleteClient(int id)
    {
        var client = _context.Clients.Find(id);
        if (client != null)
        {
            _context.Clients.Remove(client);
            _context.SaveChanges();
        }
    }
}
using System;
using HandOver.Client.Models;

namespace HandOver.Client.Clients;

public class UsersClient
{
    private List<User> _users =
    [
        new() {Id = 1, UserName = "Kudy123"},
        new() {Id = 2, UserName = "Deffo.34"},
        new() {Id = 1, UserName = "Clovis_bk"},
        new() {Id = 1, UserName = "Ryan-762"},
    ];

    public List<User> GetUsers()
        => _users;
}

﻿using Microsoft.AspNetCore.Mvc;
using Orderingsystem.Interfaces;
using Orderingsystem.Models;

namespace Orderingsystem.Controllers;

[ApiController]
[Route("user")]

public class UserController : Controller
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("user")]
    public User GetUser(int id)
    {
        return _userService.GetUser(id);
    }
    
    [HttpPost("create")]
    public bool CreateUser(string firstName, string lastName, string username, string email, int phoneNumber, string pass, string pfp, int accessLevel)
    {
        return _userService.CreateUser(firstName, lastName, username, email, phoneNumber, pass, pfp, accessLevel);
    }

    [HttpDelete("delete")]
    public bool DeleteUser(string username)
    {
        return _userService.DeleteUser(username);
    }
}
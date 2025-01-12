﻿namespace Orderingsystem.Interfaces;

public interface IAuthService
{
    public string VerifyCredentials(string user, string pass);
    public bool UpdatePass(string user, string pass, string newPass);
}
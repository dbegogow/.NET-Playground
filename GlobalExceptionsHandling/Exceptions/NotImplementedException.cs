﻿namespace GlobalExceptionsHandling.Exceptions;

public class NotImplementedException : Exception
{
    public NotImplementedException(string msg)
        : base(msg)
    {
    }
}
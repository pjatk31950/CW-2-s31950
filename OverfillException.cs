﻿namespace Task_02;

public class OverfillException : Exception
{
    public OverfillException(string message) : base(message){}
}
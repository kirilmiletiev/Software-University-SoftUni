﻿using System;
using System.Collections.Generic;
using System.Text;

public class InvalidSongException : Exception
{
    private const string Message = "Invalid song.";

    public InvalidSongException() : base(Message)
    {
    }

    public InvalidSongException(string message) : base(message)
    {
    }
}
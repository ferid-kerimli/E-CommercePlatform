﻿namespace NotificationService.Models;

public class EmailRequestModel
{
    public string? ToEmail { get; set; }
    public string? Subject { get; set; }
    public string? Body { get; set; }
}
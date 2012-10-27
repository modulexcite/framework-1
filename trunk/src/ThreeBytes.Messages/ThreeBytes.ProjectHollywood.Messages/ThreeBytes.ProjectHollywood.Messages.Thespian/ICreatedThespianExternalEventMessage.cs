﻿using System;

namespace ThreeBytes.ProjectHollywood.Messages.Thespian
{
    public interface ICreatedThespianExternalEventMessage : IThespianExternalEventBase
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime? DateOfBirth { get; set; }
        string Email { get; set; }
        string Gender { get; set; }
        string Location { get; set; }
        int? Height { get; set; }
        int? Weight { get; set; }
        int? PlayingAge { get; set; }
        string EyeColour { get; set; }
        string HairLength { get; set; }
        string Summary { get; set; }
        string Twitter { get; set; }
        string Facebook { get; set; }
        string Spotlight { get; set; }
        string Imdb { get; set; }
        string ThespianType { get; set; }
        string CreatedBy { get; set; }
    }
}
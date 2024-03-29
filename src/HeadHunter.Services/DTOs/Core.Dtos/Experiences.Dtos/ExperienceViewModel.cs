﻿using HeadHunter.Services.DTOs.Core.Dtos.Companies.Dtos;

namespace HeadHunter.Services.DTOs.Core.Dtos.Experiences.Dtos;

public record ExperienceViewModel(
    UserViewModel User,
    CompaniesViewModel Company,
    string JobTitle,
    string Position,
    DateTime StartTime,
    DateTime? EndTime);
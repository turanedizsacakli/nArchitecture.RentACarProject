﻿using Application.Features.Colors.Dtos;
using Core.Persistence.Paging;

namespace Application.Features.Colors.Models;

public class SpeedListModel : BasePageableModel
{
    public IList<SpeedListDto> Items { get; set; }
}
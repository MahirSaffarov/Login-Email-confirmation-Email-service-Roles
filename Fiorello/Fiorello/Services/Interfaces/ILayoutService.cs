﻿using System;
using Fiorello.ViewModels;

namespace Fiorello.Services.Interfaces
{
	public interface ILayoutService
	{
        Task<LayoutVM> GetAllDatas();
    }
}
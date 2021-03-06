﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shared;
using Shared.Models;

namespace Globomantics.Services
{
    public interface IConferenceService
    {
        Task<IEnumerable<ConferenceModel>> GetAll();

        Task<ConferenceModel> GetById(int id);

        Task<StatisticsModel> GetStatistics();

        Task<ConferenceModel> Add(ConferenceModel model);
    }
}

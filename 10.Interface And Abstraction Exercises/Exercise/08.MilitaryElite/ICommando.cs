﻿using System;
using System.Collections.Generic;
using System.Text;


public interface ICommando : ISpecialisedSoldier
{
    IReadOnlyCollection<IMission> Missions { get; }

    void AddMission(IMission mission);

    void CompleteMission(string missionComplete);
}


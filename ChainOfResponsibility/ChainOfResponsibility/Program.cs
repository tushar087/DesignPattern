﻿using ChainOfResponsibility;

TeamLeader teamLeader = new TeamLeader();
ProjectLeader projectLeader = new ProjectLeader();
HR hr = new HR();
teamLeader.SetNextSupervisor(projectLeader);
projectLeader.SetNextSupervisor(hr);
teamLeader.ApplyLeave("Anurag", 9);
Console.WriteLine();
teamLeader.ApplyLeave("Pranaya", 18);
Console.WriteLine();
teamLeader.ApplyLeave("Priyanka", 30);
Console.WriteLine();
teamLeader.ApplyLeave("Ramesh", 50);
Console.Read();
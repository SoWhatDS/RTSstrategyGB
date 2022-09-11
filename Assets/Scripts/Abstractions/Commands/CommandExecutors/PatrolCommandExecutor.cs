﻿using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace Abstractions.Commands.CommandExecutors
{
    public class PatrolCommandExecutor : CommandExecutorBase<IPatrolCommand>
    {
        public override void ExecuteSpecificCommand(IPatrolCommand command)
        {
            Debug.Log($"Patrol from {command.From} to {command.To}!"); 
        }
    }
}
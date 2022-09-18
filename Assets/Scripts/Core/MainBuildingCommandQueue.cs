using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;
using Zenject;


public class MainBuildingCommandQueue : MonoBehaviour, ICommandsQueue
{
    [Inject] CommandExecutorBase<IProduceUnitCommand> _produceUnitCommandExecutor;
    [Inject] CommandExecutorBase<ISetRallyPointCommand> _setRallyCommandexecutor;

    public void Clear() 
    { 
    
    }

    public async void EnqueueCommand(object command)
    {
        await _produceUnitCommandExecutor.TryExecuteCommand(command);
        await _setRallyCommandexecutor.TryExecuteCommand(command);
    }
}

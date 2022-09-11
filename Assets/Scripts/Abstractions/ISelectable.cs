using UnityEngine;

namespace Abstractions
{
    public interface ISelectable : IHelthHolder
    {
        Sprite Icon { get; }
        Transform PivotPoint { get; }
    }
}
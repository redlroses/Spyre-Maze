﻿using System;
using CodeBase.Logic.Lift.PlateMove;
using CodeBase.Logic.Observer;
using UnityEngine;

namespace CodeBase.Logic.Lift
{
    [RequireComponent(typeof(PlateMovableObserver))]
    public class LiftDestinationMarker : ObserverTarget<PlateMovableObserver, IPlateMovable>
    {
        public event Action<LiftDestinationMarker> Call;

        public CellPosition Position { get; private set; }

        public void Construct(CellPosition cellPosition)
        {
            Position = cellPosition;
        }

        protected override void OnTriggerObserverEntered(IPlateMovable collectible)
        {
            Call?.Invoke(this);
        }
    }
}
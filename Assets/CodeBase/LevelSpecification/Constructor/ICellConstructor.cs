﻿namespace CodeBase.LevelSpecification.Constructor
{
    public interface ICellConstructor
    {
        public void Construct<TCell>(Cell[] cells);
    }
}
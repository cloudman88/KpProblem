﻿using System.Collections.Generic;

namespace KnapsackProblem.Knapsack
{
    class Knapsack
    {
        public int Id;
        public int Capacity;
        public List<Item> PackedItems;
        public int Value;
        public uint Weight;

        public Knapsack(int id,int capcity) 
        {
            Id = id;
            Capacity = capcity;
            Value = 0;
            Weight = 0;
            PackedItems = new List<Item>();
        }
        //public uint GetTotalWeights()
        //{
        //    uint sumWeights = 0;
        //    foreach (var item in PackedItems)
        //    {
        //        sumWeights += item.Weight;
        //    }
        //    return sumWeights;
        //}
        //public int GetTotalValues()
        //{
        //    int sumValues = 0;
        //    foreach (var item in PackedItems)
        //    {
        //        sumValues += item.Constrains[Id-1];
        //    }
        //    return sumValues;
        //}
        
    }
}
﻿using System;
using UnityEngine;

namespace World.Environmental
{
    public class Deposit : MonoBehaviour
    {
        [ReadOnly] public bool hasDeposited;

        public event Action OnDepositMade;
        
        public void DepositItem()
        {
            if (hasDeposited) return;
            
            hasDeposited = true;
            OnDepositMade?.Invoke();
        }
    }
}
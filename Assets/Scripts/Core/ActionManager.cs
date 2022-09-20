using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{ 
    public class ActionManeger : MonoBehaviour
    {
        IAction action;
        public void StartAction(IAction action)
        {
            if (this.action == action) return;
            if (this.action != null)
            {
                this.action.Cancel();

            }
            this.action = action;
        }
    }
}

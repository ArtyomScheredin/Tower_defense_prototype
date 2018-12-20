using System;
using UnityEngine;
public class StepBCDHandler : MonoBehaviour
{
    #region Events
    /// <summary>
    /// Вызывается, когда срабатывает OnTriggerEnter
    /// </summary>
    public EventHandler<StepBCDHandlerArgs> CollisionEnter = delegate { };
    public EventHandler<StepBCDHandlerArgs> CollisionStay = delegate { };
    /// <summary>
    /// Вызывается, когда срабатывает OnTriggerExit
    /// </summary>

    #endregion
    
    private void OnCollisionEnter(Collision other)
    {
       CollisionEnter(this, new StepBCDHandlerArgs() {Collision = other});
    }

    private void OnCollisionStay(Collision other)
    {
        CollisionStay(this, new StepBCDHandlerArgs() {Collision = other}); 
    }

    public class StepBCDHandlerArgs : EventArgs
    {
        public Collider Collider { get; set; }
        public Vector3 Coordinates { get; set; }
        public Collision Collision { get; set; }
    }
}
using UnityEngine;

namespace Game.Gameplay
{
    public abstract class ColorAbility : ScriptableObject, IColorAbility
    {
        public virtual IColorAbilityReceiver Owner { get; protected set; }
        
        protected GameObject _ownerGameObject;

        public virtual void ActivateAbility(GameObject ownerObject)
        {
            if (!ownerObject.TryGetComponent(out IColorAbilityReceiver receiver)) return;

            Owner = receiver;
            _ownerGameObject = ownerObject;
        }

        public virtual void DeactivateAbility()
        {
            
        }
    }
}
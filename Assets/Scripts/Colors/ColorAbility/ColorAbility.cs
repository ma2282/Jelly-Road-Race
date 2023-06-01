using UnityEngine;

namespace Game.Gameplay
{
    public abstract class ColorAbility : ScriptableObject, IColorAbility
    {
        public virtual IColorAbilityReceiver Owner { get; protected set; }
        
        protected GameObject _ownerGameObject;

        public virtual void ActivateAbility(GameObject owner)
        {
            if (!owner.TryGetComponent(out IColorAbilityReceiver receiver)) return;

            Owner = receiver;
            _ownerGameObject = owner;
        }

        public virtual void DeactivateAbility()
        {
            
        }
    }
}
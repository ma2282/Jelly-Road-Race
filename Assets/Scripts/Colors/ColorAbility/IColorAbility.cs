using UnityEngine;

namespace Game.Gameplay
{
    public interface IColorAbility
    {
        IColorAbilityReceiver Owner { get; }
        void ActivateAbility(GameObject ownerObject);
        void DeactivateAbility();
        void RestoreDefaults();
    }
}
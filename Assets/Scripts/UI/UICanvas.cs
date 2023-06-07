using UnityEngine;

namespace Game.Gameplay
{
    public abstract class UICanvas : MonoBehaviour, IUICanvas
    {
        [SerializeField] private string openTriggerName;
        [SerializeField] private string closeTriggerName;
        [SerializeField] protected Animator animator;

        public virtual void Initialize()
        {}

        public virtual void Open()
        {
            if (gameObject.activeInHierarchy) return;
            
            gameObject.SetActive(true);
            if (animator != null)
                animator.SetTrigger(openTriggerName);
            else
                FinishOpen();
        }

        protected virtual void FinishOpen()
        {
        }

        public virtual void Close()
        {
            if (!gameObject.activeInHierarchy) return;
            
            if (animator != null)
                animator.SetTrigger(closeTriggerName);
            else
                FinishClose();
        }

        protected virtual void FinishClose()
        {
            gameObject.SetActive(false);
        }
        
    }
}
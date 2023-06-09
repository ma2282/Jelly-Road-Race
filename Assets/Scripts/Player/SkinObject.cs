using UnityEngine;
using UnityEngine.Events;

namespace Game.Gameplay
{
    public class SkinObject : MonoBehaviour
    {
        [SerializeField] private string moveLeftTriggerName = "MoveLeft";
        [SerializeField] private string moveRightTriggerName = "MoveRight";
        [SerializeField] private SkinType skinType;
        [SerializeField] private Animator animator;
        [SerializeField] private Renderer skinRenderer;
        [SerializeField] private Renderer trailRenderer;

        public bool IsMoving { get; private set; }
        
        public float Speed
        {
            set => animator.speed = value;
        }
        
        public SkinType Type => skinType;
        
        public Renderer Renderer => skinRenderer;
        public Renderer TrailRenderer => trailRenderer;

        public UnityEvent OnMovingEnd;
        

        public void MoveLeft()
        {
            IsMoving = true;
            animator.SetTrigger(moveLeftTriggerName);
        }

        public void MoveRight()
        {
            IsMoving = true;
            animator.SetTrigger(moveRightTriggerName);
        }

        private void EndMoving()
        {
            IsMoving = false;
            OnMovingEnd?.Invoke();
        }

        public void Reset()
        {
            IsMoving = false;
            animator.Play("Idle");
        }
    }
}
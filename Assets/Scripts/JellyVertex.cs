using UnityEngine;

namespace Game.Gameplay
{
    public class JellyVertex
    {
        public readonly int ID;
        
        public Vector3 Position;
        
        private Vector3 Velocity, Force;

        public JellyVertex(int id, Vector3 position)
        {
            ID = id;
            Position = position;
        }

        public void Shake(Vector3 target, float mass, float stiffness, float damping)
        {
            Force = (target - Position) * stiffness;
            Velocity = (Velocity + Force / mass) * damping;
            Position += Velocity;
            if ((Velocity + Force + Force / mass).magnitude < 0.001f)
                Position = target;
        }
    }
}
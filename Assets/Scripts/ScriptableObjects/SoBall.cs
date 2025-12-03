using UnityEngine;

namespace ScriptableObjects
{
    /// <summary>
    /// Holds a reference to balls physic data.
    /// </summary>
    [CreateAssetMenu(fileName = "SO_Ball", menuName = "Scriptable Objects/SO_Ball")]
    public class SoBall : ScriptableObject
    {
        [Header("Bounciness")]
        [Range(0f, 1f)] public float bounciness = 0.5f;
        public float friction = 0.4f;

        [Header("Weight / Gravity")]
        public float gravityScale = 1f;
        public float mass = 1f;
    }
}

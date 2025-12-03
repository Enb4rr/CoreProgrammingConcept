using ScriptableObjects;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [Header("Bounciness")]
    [SerializeField][Range(0f, 1f)] private float bounciness = 0.5f;
    [SerializeField] private float friction = 0.4f;

    [Header("Weight / Gravity")]
    [SerializeField] private float gravityScale = 1f;
    [SerializeField] private float mass = 1f;

    [Header("Components")]
    [SerializeField] private PhysicsMaterial pMat;
    [SerializeField] SoBall heavyProfile;
    [SerializeField] SoBall bouncyProfile;
    private Rigidbody rb;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        UpdatePhysics("bouncy");
    }
    
    /// <summary>
    /// Updates ball physics depending on input
    /// </summary>
    /// <param name="profile"></param>
    public void UpdatePhysics(string profile)
    {
        switch (profile)
        {
            case "bouncy":
                pMat.bounciness = bouncyProfile.bounciness;
                pMat.dynamicFriction = bouncyProfile.friction;
                pMat.staticFriction = bouncyProfile.friction;
                rb.mass = bouncyProfile.mass;
                break;
            case "heavy":
                pMat.bounciness = heavyProfile.bounciness;
                pMat.dynamicFriction = heavyProfile.friction;
                pMat.staticFriction = heavyProfile.friction;
                rb.mass = heavyProfile.mass;
                break;
        }
    }
}

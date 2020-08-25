using UnityEngine;

namespace PlayerAttributes
{
    public class PlayerCamera : MonoBehaviour
    {
        [SerializeField]
        private CapsuleCollider capsuleCollider;
        private readonly Quaternion rotation = Quaternion.Euler(0, 0, 0);

        private void FixedUpdate()
        {
            transform.SetPositionAndRotation(capsuleCollider.transform.position, rotation);
        }
    }
}

using UnityEngine;

namespace PlayerAttributes
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody player;
        [SerializeField]
        private float forwardForce;
        [SerializeField]
        private float sidewaysForce;

        private bool isMovementLeft = false;
        private bool isMovementRight = false;


        public void ButtonMovementLeftDown() { isMovementLeft = true; }
        public void ButtonMovementLeftUp() { isMovementLeft = false; }
        public void ButtonMovementRightDown() { isMovementRight = true; }
        public void ButtonMovementRightUp() { isMovementRight = false; }

        private void FixedUpdate()
        {
            //Constant Forward Force
            player.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);

            if (isMovementLeft == true)
                player.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

            if (isMovementRight == true)
                player.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}

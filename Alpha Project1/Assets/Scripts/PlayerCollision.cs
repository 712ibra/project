using UnityEngine;

public class PlayerCollision : MonoBehaviour{

    public PlayerController movement;

    public void onCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
         
        {
            movement.enabled = false;
            FindObjectOfType<Manager>().EndGame();

        }

    }
    public ParticleSystem explosionParticle;
    public void OnCollisionEnter (Collision collision other) {

        if (other.gameObject.CompareTag("Ground")) {
isOnGround = true;
} else if (other.gameObject.CompareTag("Obstacle")) {
explosionParticle.Play（）；｝｝

}
}

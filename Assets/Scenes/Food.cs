using UnityEngine;

public class Food : MonoBehaviour
{
// define the boundries for where the food can spawn??
    public BoxCollider2D gridArea;

    private void Start()
    {
        RandomizePosition(); 
    }

    private void RandomizePosition()
    {
        Bounds bounds = this.gridArea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }
// recognize when snake collides with food
    private void OnTriggerEnter2D(Collider2D other)
    {
 // to check what other object did it collide with, on unity, tag the snake as the player, so whenever the player aka the snake collides with the food, the food respawns in a different location
        if(other.tag == "Player") {
            RandomizePosition();
        }
    }
    
}

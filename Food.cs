using UnityEngine;

public class Food : MonoBehaviour
{
    public BoxCollider2D gridArea;  //Area where use to random food position
    public BoxCollider2D gridArea2; //Area where use to random food position
    public BoxCollider2D gridArea3; //Area where use to random food position
    public BoxCollider2D gridArea4; //Area where use to random food position

    int gridNumber;

    private void Start()
    {
        RandomizePosition();
    }

    private void RandomizePosition()  //Random position of food in gridArea
    {
        int gridNumber = Random.Range(1, 20); //Random number for choose gridArea to reposition

        if (gridNumber <= 5)
        {
            Bounds bounds = this.gridArea.bounds;

            float x = Random.Range(bounds.min.x, bounds.max.x);
            float y = Random.Range(bounds.min.y, bounds.max.y);

            this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
        }
        else if(gridNumber <= 10)
        {
            Bounds bounds = this.gridArea2.bounds;

            float x = Random.Range(bounds.min.x, bounds.max.x);
            float y = Random.Range(bounds.min.y, bounds.max.y);

            this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
        }
        else if (gridNumber <= 15)
        {
            Bounds bounds = this.gridArea3.bounds;

            float x = Random.Range(bounds.min.x, bounds.max.x);
            float y = Random.Range(bounds.min.y, bounds.max.y);

            this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
        }
        else
        {
            Bounds bounds = this.gridArea4.bounds;

            float x = Random.Range(bounds.min.x, bounds.max.x);
            float y = Random.Range(bounds.min.y, bounds.max.y);

            this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)  //Change position of food when player hit
    {
        if(other.tag == "Player")
        {
            RandomizePosition();
        }

    }
}

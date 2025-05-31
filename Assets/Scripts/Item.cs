using UnityEngine;

public enum ItemType { Cherry, Gem }

public class Item : MonoBehaviour
{
    public ItemType itemType;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (itemType == ItemType.Cherry)
        {
            collision.GetComponent<Player>().speed += 5;
            Destroy(gameObject);
        }
        else if (itemType == ItemType.Gem)
        {
            GameManager.instance.ScoreUp();
            Destroy(gameObject);
        }
    }
}

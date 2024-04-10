using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Ships : MonoBehaviour
{
    [SerializeField] int damage;
    [SerializeField] float speed;

    public GameObject effecto;

    private void Update()
    {
        transform.Translate(Vector2.left * speed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Instantiate(effecto, transform.position, Quaternion.identity);
            //Player player = other.GetComponent<Player>();
            //Instantiate(player.effect, transform.position, Quaternion.identity);
            other.GetComponent<Player>().health -= damage;
            Destroy(gameObject);
        }
    }
}

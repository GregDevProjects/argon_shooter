using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject deathFx;
    [SerializeField] Transform parent;
    [SerializeField] int scorePerHit = 5;
    [SerializeField] int maxHits = 2;
    ScoreBoard scoreBoard;
    // Start is called before the first frame update
    void Start()
    {
        scoreBoard = FindObjectOfType<ScoreBoard>();
        //if using an asset pack, add the box collider here
    }

    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name);
        if (other.gameObject.name == "LaserShot(Clone)")
        {
            maxHits--;
            if (maxHits <= 0)
            {
                onDestroyedByPlayer();
            }
            
        }
    }

    private void onDestroyedByPlayer()
    {
        scoreBoard.ScoreHit(scorePerHit);
        GameObject fx = Instantiate(deathFx, gameObject.transform.position, Quaternion.identity);
        fx.transform.parent = parent;
        GameObject.Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //print(collision.gameObject.name);
    }

}

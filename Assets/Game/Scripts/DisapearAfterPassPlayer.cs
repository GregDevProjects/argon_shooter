using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapearAfterPassPlayer : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] int offsetAfterPass = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x - offsetAfterPass > gameObject.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}

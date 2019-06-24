using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class CannonBehavior : MonoBehaviour {

	//public Transform m_cannonRot;
	public Transform m_muzzle;
	public GameObject m_shotPrefab;
    private bool canShoot = true;
    [SerializeField] float timeBetweenShots = 1f;
	//public Texture2D m_guiTexture;

	// Use this for initialization
	void Start () 
	{
	
	}


	
	// Update is called once per frame
	void Update () 
	{
		if (CrossPlatformInputManager.GetButton("Fire1"))
		{
            if (!canShoot)
            {
                return;
            }
            //m_muzzle.transform.Rotate(0, 90, 0);
            GameObject go = GameObject.Instantiate(m_shotPrefab, m_muzzle.position, m_muzzle.rotation) as GameObject;
			GameObject.Destroy(go, 1f);
            canShoot = false;
            Invoke("enableShot", timeBetweenShots);
		}
	}

    void enableShot()
    {
        canShoot = true;
    }

	void OnGUI()
	{
		//GUI.DrawTexture(new Rect(0f, 0f, m_guiTexture.width / 2, m_guiTexture.height / 2), m_guiTexture);
	}
}

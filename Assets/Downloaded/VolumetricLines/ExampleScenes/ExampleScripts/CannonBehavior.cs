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

    [SerializeField] public GameObject crosshair;
    [SerializeField] public GameObject player;

    private Vector3 shootPosition;
    // Use this for initialization
    void Start () 
	{
	
	}
    
	// Update is called once per frame
	void Update () 
	{
        // test_cube.transform.position = new Vector3(gameObject.transform.position.x +300, gameObject.transform.position.y, gameObject.transform.position.z);
        ShowCrosshair();

        if (CrossPlatformInputManager.GetButton("Fire1"))
		{
            
            if (!canShoot)
            {
                return;
            }

            GameObject go = GameObject.Instantiate(m_shotPrefab, m_muzzle.position, m_muzzle.rotation) as GameObject;
            go.transform.LookAt(crosshair.transform);
            GameObject.Destroy(go, 1f);
            canShoot = false;
            Invoke("enableShot", timeBetweenShots);
		}
	}

    void ShowCrosshair()
    {
#pragma warning disable IDE0018 // Inline variable declaration
        RaycastHit hit;
#pragma warning restore IDE0018 // Inline variable declaration
        Ray castPoint = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity))
        {
            if (hit.collider.gameObject == crosshair || hit.collider.gameObject == player)
            {
                return;
            }
            crosshair.transform.position = hit.point;
            shootPosition = hit.point;
        }
    }

    void enableShot()
    {
        canShoot = true;
    }

}

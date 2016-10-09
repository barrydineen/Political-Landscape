using UnityEngine;
using System.Collections;

public class CollisionZone4 : MonoBehaviour {

    // Use this for initialization
    public GameObject goMountain;
    public GameObject goHill;
    public GameObject goFlat;
    public GameObject goLake;
    public GameObject goHole;

    public  bool GrowCompete = false;
    public bool GrowBegin = false;

    public Material Mat_Mountain_01;
    public Material Mat_Mountain_02;
    public Material Mat_Mountain_03;


    float currentScale = 0f;

    // Use this for initialization
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            GrowBegin = true;
            activateRenderer();
            assignMaterial();
            //scaleMountain();
       
        }

        if(GrowBegin && !GrowCompete)
        {
            //print("growBegin");
            
            goMountain.transform.localScale += new Vector3(0, 0, 0.03f);
            currentScale += 0.03f;

           if (currentScale >= 2f)
           {
                GrowCompete = true;
           }

        }


    }

 
    void activateRenderer()
    {
        Renderer MountainRenderer = goMountain.GetComponent<Renderer>();

        if (MountainRenderer.enabled == false)
        {
            MountainRenderer.enabled = true;
        }
        

    }

    void assignMaterial()
    {
        Renderer MountainRenderer = goMountain.GetComponent<Renderer>();
        MountainRenderer.material = Mat_Mountain_01;



    }

    void scaleMountain()
    {

    }

    void onCollisionEnter(Collision collision)
    {
      
    }
}

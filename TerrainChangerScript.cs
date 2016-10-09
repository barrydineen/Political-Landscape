using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TerrainChangerScript : MonoBehaviour {

    // Use this for initialization
    public List<GameObject> goMountainList = new List<GameObject>();
    public List<Material> MountainMaterialList = new List<Material>();
    public List<Material> SkyboxMatList = new List<Material>();
    public GameObject goHill;
    public GameObject goFlat;
    public GameObject goLake;
    public GameObject goHole;

    public  bool GrowCompete = false;
    public bool GrowBegin = false;
    public bool animate = false;
    public GameObject targetZone = null;

    //public Material Mat_Mountain_01;
    //public Material Mat_Mountain_02;
    //public Material Mat_Mountain_03;


    public float currentScale = 0f;
    float growScaleLimit = 1f;
    float growRate = .03f;
    // Use this for initialization
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Alpha1))
        //{
        //    changeTerrain(0, 0);
        //}

        if (animate & currentScale <= growScaleLimit)
        {
                targetZone.transform.parent.localScale += new Vector3(0, growRate, 0);
                //Debug.Log(targetZone.transform.parent.localScale);
                currentScale += growRate;
        }
        else { 
            currentScale = 0;
            animate = false;
            targetZone = null;
        }
        


    }

    // terrain zone # , value
    public void changeTerrain(int i, int val1)
    {
        Debug.Log(i);
        Debug.Log(val1);
        animate = true;
        targetZone = goMountainList[i];
        targetZone.GetComponent<Renderer>().enabled = true;
        targetZone.GetComponent<Renderer>().material = MountainMaterialList[val1];

        //update skybox 
        RenderSettings.skybox = SkyboxMatList[val1];
        DynamicGI.UpdateEnvironment();

        
        
    }

    public void changeTerrain(GameObject zone, int i, int val1)
    {
        targetZone = zone.transform.GetChild(i).gameObject;
        //targetZone = goMountainList[i];
        targetZone.GetComponent<Renderer>().enabled = true;
        targetZone.GetComponent<Renderer>().material = MountainMaterialList[val1];

        //update skybox 
        RenderSettings.skybox = SkyboxMatList[val1];
        DynamicGI.UpdateEnvironment();

        animate = true;

    }


    //void activateRenderer()
    //{
    //    Renderer MountainRenderer = goMountain.GetComponent<Renderer>();

    //    if (MountainRenderer.enabled == false)
    //    {
    //        MountainRenderer.enabled = true;
    //    }


    //}

    //void assignMaterial()
    //{
    //    Renderer MountainRenderer = goMountain.GetComponent<Renderer>();
    //    MountainRenderer.material = Mat_Mountain_01;



    //}

}

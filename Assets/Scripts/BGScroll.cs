using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{
    public float scroll_speed = 0.1f;
    private MeshRenderer mesh_Renderer;

    [SerializeField]
   // float timeToBoost = 5f;
   // float nextBoost;


    // Start is called before the first frame update
    void Awake()
    {
        mesh_Renderer = GetComponent<MeshRenderer>();
    }
    void start()
    {
     //   nextBoost = Time.unscaledTime + timeToBoost;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Time.time * scroll_speed;
        Vector2 offset = new Vector2(x, 0);
        mesh_Renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
      //  if (Time.unscaledTime > nextBoost)
      //      BoostTime();
    }
    //void BoostTime()
   // {
   //     nextBoost = Time.unscaledTime + timeToBoost;
   //     Time.timeScale += 0.10f;
   // }

}

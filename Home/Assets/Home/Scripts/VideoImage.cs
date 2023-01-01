using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoImage : MonoBehaviour
{
    public GameObject video;

    public bool acik = false;
    // Start is called before the first frame update
    void Start()
    {

       
       video.SetActive(false);
    
       //video.GetComponent<AudioSource>().SetActive(tru) = new Color32(255, 255, 255, 200);





    }

    // Update is called once per frame
    void Update()
    {


    }
     public void openPanel()
    {

        acik = !acik;
        if (acik)
        {
            
      
            video.SetActive(true);


        }
        else
            {
             video.SetActive(false);
        }


    }


 



}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvIc : MonoBehaviour
{
    public GameObject Panel, Model, buton, butonac;

    public bool acik = false;
    // Start is called before the first frame update
    void Start()
    {


       







    }

    // Update is called once per frame
    void Update()
    {


    }
    public void openPanel()
    {

        StartCoroutine("yanipsönme");



    }


    public IEnumerator yanipsönme()
    {



        acik = !acik;
        if (acik)
        {


            butonac.SetActive(true);

            Panel.SetActive(true);

            Model.SetActive(true);
            yield return new WaitForSeconds(0.1f);

            buton.SetActive(false);

        }



    }



}
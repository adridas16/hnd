using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using TMPro;



public class GameControler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText ;
    [SerializeField] private float gametimer = 30f;
    int numeroMoles;
    

    public GameObject moleContainer;
    private Wakamole [] moles;
    [SerializeField] float ShowMoleTimer=1.5f;
    // Start is called before the first frame update
    void Start()
    {
        numeroMoles = moleContainer.transform.childCount;
        moles = new Wakamole[numeroMoles];
        for(int i = 0; i < numeroMoles; i++)
        {
            moles[i] = moleContainer.transform.GetChild(i).GetComponent<Wakamole>();
        }
        Debug.Log("number of moles" + moles.Length);
    }

    // Update is called once per frame
    void Update()
    {
        gametimer-=Time.deltaTime;
        if(gametimer > 0f)
        {
            ShowMoleTimer-=Time.deltaTime;
            timerText.text = ("WACK A MOLE ") + MathF.Floor(gametimer);
            if (ShowMoleTimer < 0f)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
            {
                
                moles[UnityEngine.Random.Range(0,moles.Length)].ShowMole();    
                ShowMoleTimer = 1.5f;
                Debug.Log(ShowMoleTimer+ gameObject.name);
            }
            
            
        }
        else
        {
            timerText.text = ("GAME OVER");
        }
    }
}

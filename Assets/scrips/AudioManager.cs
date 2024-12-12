using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource[] audiomanager;
    int randomNumber;
    // Start is called before the first frame update
    private void Awake()
    {
        randomNumber = Random.Range(0, 3);
        if (randomNumber == 0)
        {
            audiomanager[0].enabled = true;
        }
        else if (randomNumber == 1) 
        {
           audiomanager[1].enabled = true;
        }
        else
        {
            audiomanager[2].enabled = true;
        }
       
    }
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

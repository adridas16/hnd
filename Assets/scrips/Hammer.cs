using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    private bool hammerIsUp = true;
    private float hammerDownAngle = 180;
    private float hammerUpAngle = 90;
    private Quaternion hammerDownRotation;//hammer X(0) cuando esta abajo
    private Quaternion hammerupRotation;//hammer X(90) cuando esta arriba
    private float hammerDownMaxTime = 0.25f;
    // Start is called before the first frame update
    void Start()
    {
        hammerDownRotation= Quaternion.Euler(hammerDownAngle,transform.rotation.y,transform.rotation.z);
        hammerupRotation= Quaternion.Euler(hammerUpAngle,transform.rotation.y,transform.rotation.z);
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (hammerIsUp)
            {
                SwingHammer(hammerUp: false, hammerRotation:hammerDownRotation);
            }
            else
            {
                SwingHammer(hammerUp:true, hammerRotation: hammerupRotation);
            }
        }

        if (!hammerIsUp)
        {
            hammerDownMaxTime-= Time.deltaTime; 
            if(hammerDownMaxTime <= 0f)
            {
                SwingHammer(hammerUp: true, hammerRotation: hammerupRotation);
            }
        }
    }

    void SwingHammer(bool hammerUp,Quaternion hammerRotation)
    {
        hammerIsUp= hammerUp;

        transform.rotation= hammerRotation;

        if (hammerIsUp)
        {
            hammerDownMaxTime = 0.25f;
        }
    }
}

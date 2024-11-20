using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wakamole : MonoBehaviour
{
    [SerializeField] private float visibleHeigth = 0.27f;
    [SerializeField] private float hiddenHeigth = 0.13f;
    private Vector3 myNewXYZPosition;
    public float speedMole = 4f;
    public float HideMoleTimer = 1.5f;
    // Start is called before the first frame update
    private void Awake()
    {

        myNewXYZPosition = transform.localPosition;
    
    }
    void Start()    
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition=Vector3.Lerp(transform.localPosition,myNewXYZPosition,speedMole*Time.deltaTime);

        HideMoleTimer -= Time.deltaTime;
        if (HideMoleTimer < 0)
        {
            HideMole();
            HideMoleTimer = 1.5f;
        }
    }
    public void HideMole()
    {
       myNewXYZPosition=new Vector3(transform.localPosition.x,hiddenHeigth,transform.localPosition.z);
    }
    public void ShowMole()
    {
        myNewXYZPosition = new Vector3(transform.localPosition.x,visibleHeigth,transform.localPosition.z);  
        HideMoleTimer=1.5f;
    }
}

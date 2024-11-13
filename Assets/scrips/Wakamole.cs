using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wakamole : MonoBehaviour
{
    [SerializeField] private float visibleHeigth = 0.27f;
    [SerializeField] private float hiddenHeigth = 0.13f;
    private Vector3 myNewXYZPosition;
    // Start is called before the first frame update
    private void Awake()
    {
        HideMole();
        transform.localPosition = myNewXYZPosition;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HideMole()
    {
        transform.localPosition=new Vector3(transform.localPosition.x,hiddenHeigth,transform.localPosition.z);
    }
}

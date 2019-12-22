using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class topkontrol : MonoBehaviour {

    Rigidbody fizik;
    public int hiz;
    int sayac = 0;
    public Text sayacText;
    public Text OyunBittiText;
   


	void Start () {
        fizik = GetComponent<Rigidbody>();
        sayacText.text = "SAYAC=0";
    }
	
	
	void FixedUpdate () {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");
        //Debug.Log("yatay="+ yatay +"dikey=" + dikey);
        Vector3 vec = new Vector3(yatay,0,dikey);

        fizik.AddForce(vec*hiz);
	}
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="hedef")
        {
            Destroy(other.gameObject);
            sayac++;
            sayacText.text = "SAYAC= " + sayac;
        }

        if(sayac==6)
        {
            OyunBittiText.text = "OYUN BITTI";
        }
        
    } 
    
}

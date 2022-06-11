using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
public class test : MonoBehaviour
{
	public Transform Player;
    public GameObject obj;
    public int counter;

    void Start()
		{
            counter = 0;
		}


  public void hideObj() {
      print("hide cube");
    //  myCube.SetActive(false);
  }

  public void showObj() {
      print("show cube");
     // myCube.SetActive(true);
  }

  void OnMouseOver() {
      
      if (Player)
				{
					float dist = Vector3.Distance(Player.position, transform.position);
					if (dist < 15)
					{
                        //HIDE
                        
                            if (Input.GetMouseButtonDown(0))
							{
                                 counter = counter + 1;
                                if (counter == 10) {
                                    obj.SetActive(true);
                                }
							}
                        
                       
                    
                    }
                }
        }	      
    }
}

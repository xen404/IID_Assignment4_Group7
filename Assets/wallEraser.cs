using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
public class wallEraser : MonoBehaviour
{
	public Transform Player;
    public List<GameObject> objectsToErase;
    public List<GameObject> objectsToMakeTransparent;
    public List<GameObject> infoBoards;
    public List<GameObject> infoButtons;
    public GameObject easterEgg;
    public bool show;
    public int counter;

    void Start()
		{
			show = true;
            counter = 0;
		}


  public void hideCube() {
      print("hide cube");
    //  myCube.SetActive(false);
      show = false;
  }

  public void showCube() {
      print("show cube");
     // myCube.SetActive(true);
      show = true;
  }

  void OnMouseOver() {
      
      if (Player)
				{
					float dist = Vector3.Distance(Player.position, transform.position);
					if (dist < 15)
					{
                        //HIDE
                        if(show == true) {
                            if (Input.GetMouseButtonDown(0))
							{
                                show = false;
                                objectsToErase.ForEach(obj => obj.SetActive(false));
                               
                                infoButtons.ForEach(obj => obj.SetActive(true));
                                // Make transparent
                                objectsToMakeTransparent.ForEach(obj => changeTransparencyLvl(obj, 0.2f));
                                if (counter == 5) {
                                    easterEgg.SetActive(true);
                                }
							}
                        } else {
                            //SHOW
                            if (Input.GetMouseButtonDown(0))
							{
                                show = true;
                                objectsToErase.ForEach(obj => obj.SetActive(true));
                                 infoBoards.ForEach(obj => obj.SetActive(false));
                                infoButtons.ForEach(obj => obj.SetActive(false));
                                //Make not transparent 
                                objectsToMakeTransparent.ForEach(obj => changeTransparencyLvl(obj, 1));    
                  
							}
                        }
                    
                    }
                }
  }

  public void changeTransparencyLvl(GameObject obj, float alphaVal) {
      Material mat = obj.GetComponent<Renderer>().material;
      Color oldColor = mat.color;
      Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphaVal);
      mat.SetColor("_Color", newColor);
  }
		
     
        
    }
}


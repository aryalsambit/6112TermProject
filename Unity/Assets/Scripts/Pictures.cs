using UnityEngine;
using System.Collections;

public class Pictures : MonoBehaviour 
{
	public UIAtlas atlas;	
	public UISprite picture;		
	public GameObject window;	
	
	private bool off = false;
	private BetterList<string> pictures;	
	private int index = 0;
	private Vector3 move = Vector3.zero;
	
	void Start()
	{
		pictures = atlas.GetListOfSprites();		
	}
	
	void Update()
	{
		window.transform.position = new Vector3(window.transform.position.x, 0, 0);
			
		if(off && Mathf.Abs(window.transform.position.x) > 5)
		{		
			index++;
			picture.spriteName = pictures[index % pictures.size];
			move = Vector3.zero;
			off = false;
		}
		
		if(!Input.GetMouseButton(0))
		{
			window.transform.position = Vector3.MoveTowards(window.transform.position, move, Time.deltaTime * 10);
		}
		else
		{
			if(Input.mousePosition.x < Screen.width / 5 && !off)
			{
				move = new Vector3(-500, 0, 0);
				off = true;
			}
			else if(Input.mousePosition.x > Screen.width - Screen.width / 5 && !off)
			{
				move = new Vector3(500, 0, 0);
				off = true;				
			}
		}
	}	
}

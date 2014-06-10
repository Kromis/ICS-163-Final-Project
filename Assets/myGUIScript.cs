using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class myGUIScript : MonoBehaviour {

	public GUISkin myGUISkin;
	public List<string> debugs;

	private string world_name;
	private string world_password;
	private string player_name;
	private string player_password;
	private string enter_code;


	public bool expand = false;

	public int stroke_name;
	private Color pen_color;


	//ColorPicker[] color_picker;

	//private MyNetworkHelper network_helper;
	// Use this for initialization
	void Start () {
		if(this.myGUISkin == null)
		{
			addDebug("please assign a GUISkin on the editor!");
			this.enabled = false;
			return;
		}

		//network_helper = GameObject.Find ("myNetworkHelper").GetComponentInChildren<MyNetworkHelper> ();

		world_name = "WorldName";
		world_password = "WorldPW";
		player_name = "PlayerName";
		player_password = "PlayerPW";
		enter_code = "Enter Code";
		stroke_name = 0;

		//color_picker = GameObject.FindObjectsOfType<ColorPicker> ();

		//foreach( ColorPicker elem in color_picker){
			//elem.useExternalDrawer = true;
		//}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		GUI.skin = this.myGUISkin;
		expand = GUI.Toggle (new Rect (Screen.width/2, 0, Screen.width/2, 150), expand, "Expand");
		if(expand)
		{


			if(GUI.Button (new Rect(0, 0, Screen.width/2, 150), "Fetch Status"))
			{
			}



			world_name = GUI.TextField (new Rect (0, 600, Screen.width/2, 150), world_name);
			world_password = GUI.TextField (new Rect (0, 750, Screen.width/2, 150), world_password);
			player_name = GUI.TextField (new Rect (0, 900, Screen.width/2, 150), player_name);
			player_password = GUI.TextField (new Rect (0, 1050, Screen.width/2, 150), player_password);
			enter_code = GUI.TextField (new Rect (0, 1200, Screen.width/2, 150), enter_code);

			if (GUI.Button (new Rect (Screen.width/2, 600, Screen.width/2, 150), "PlaceTower")) 
			{
			}
			if (GUI.Button (new Rect (Screen.width/2, 750, Screen.width/2, 150), "UploadTower")) 
			{
			}
			if (GUI.Button (new Rect (Screen.width/2, 900, Screen.width/2, 150), "PlaceBomb")) 
			{
			}
			if (GUI.Button (new Rect (Screen.width/2, 1050, Screen.width/2, 150), "UploadBomb")) 
			{
			}
			if (GUI.Button (new Rect (Screen.width/2, 1200, Screen.width/2, 150), "UploadCode")) 
			{
			}
			if (GUI.Button (new Rect (0, 1350, Screen.width, 150), "LeederBored")) 
			{
			}
		}
		/*
		if (GUI.Button (new Rect (0, 400, 100, 200), "Green")) 
		{
			pen_color = new Color (0.25f, 1.0f, 0.30f);
			addDebug ("New color" + pen_color);
		}
		if (GUI.Button (new Rect (100, 400, 100, 200), "Red")) 
		{
			pen_color = new Color (0.5f, 0.15f, 0.15f);
			addDebug ("New color" + pen_color);
		}
		if (GUI.Button (new Rect (200, 400, 100, 200), "Blue")) 
		{
			pen_color = new Color (0.20f, 0.22f, 0.70f);
			addDebug ("New color" + pen_color);
		}

		if (GUI.Button (new Rect (300, 400, 100, 200), "Brown")) 
		{
			pen_color = new Color (0.40f, 0.10f, 0.12f);
			addDebug ("New color" + pen_color);
		}

		if (GUI.Button (new Rect (400, 400, 100, 200), "Purple")) 
		{
			pen_color = new Color (0.20f, 0.0f, 0.45f);
			addDebug ("New color" + pen_color);
		}

		if (GUI.Button (new Rect (500, 400, 100, 200), "Yellow")) 
		{
			pen_color = new Color (0.90f, 0.70f, 0.10f);
			addDebug ("New color" + pen_color);
		}
		if (GUI.Button (new Rect (600, 400, 100, 200), "Random")) 
		{
			float temp1 = Random.Range(0.0f, 1.0f);
			float temp2 = Random.Range(0.0f, 1.0f);
			float temp3 = Random.Range(0.0f, 1.0f);
			pen_color = new Color(temp1, temp2, temp3, 1.0f);
			addDebug("New color" + pen_color);
		}



		//foreach (ColorPicker cp in color_picker){
		//	cp._DrawGUI ();
		//}

		bool oldPenDown = pen_down;

		pen_down = GUI.Toggle (new Rect (0, 600, Screen.width, 200), pen_down, "Pen_Down");

		if (GUI.changed) {
			if(oldPenDown != pen_down){
				if(!pen_down)
				{

					network_helper.addStrokeColor(stroke_name.ToString(), pen_color);
					stroke_name++;
					addDebug("colorChanged, new Stroke: " + stroke_name.ToString());

				}
				//something
			}

		}

		if (GUI.Button (new Rect (0, 800, Screen.width, 200), "Upload") && !pen_down) {
			//upload date
			addDebug("Uploaded");
			network_helper.uploadPoints(group_name, drawing_name);

			//network_helper.addStrokeColor ("Stroke Name", pen_color);
			//chaning color deciding when to upload
		}

		//addDebug (pen_down.ToString());
		int tempy = 1000;
		foreach (string d in debugs) {
						GUI.Label (new Rect (0, tempy, Screen.width, 200), d);
						tempy += 200;
				}
		while (debugs.Count > 4) {
						debugs.RemoveAt (0);
				}

	*/
	}
	/*
	void OnSetColor(Color color)
	{
		pen_color = color;
		addDebug ("New color" + color);
	}
	void OnGetColor(ColorPicker picker)
	{
		picker.NotifyColor (pen_color);
	}
*/

	public void addDebug(string e){
				debugs.Add (e);
				Debug.Log (e);
	}
}

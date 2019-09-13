using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;	

public class EarthTextScript : MonoBehaviour {

	string myTxt ;
	public Text textBox ;
	public Text textBox2 ;

	// Use this for initialization
	void Start () {
		if (gameObject.name == "Mercury") {
			myTxt = "Murcury\nNamed for: Messenger of the Roman gods\nDiameter: 3,031 miles (4,878 km)\nOrbit: 88 Earth days\nDay: 58.6 Earth days";
		} else if (gameObject.name == "Venus") {
			myTxt = "Venus\nNamed for: Roman goddess of love and beauty\nDiameter: 7,521 miles (12,104 km)\nOrbit: 225 Earth days\nDay: 241 Earth days";
		} else if (gameObject.name == "Earth") {
			myTxt = "Earth\nThe planet Where we live\nDiameter: 7,926 miles (12,760 km)\nOrbit: 365.24 days\nDay: 23 hours, 56 minutes";
		} else if (gameObject.name == "Mars") {
			myTxt = "Mars\nNamed for: Roman god of war\nDiameter: 4,217 miles (6,787 km)\nOrbit: 687 Earth days\nDay: Just more than one Earth day (24 hours, 37 minutes)";
		} else if (gameObject.name == "Jupiter") {
			myTxt = "Jupiter\nNamed for: Ruler of the Roman gods\nDiameter: 86,881 miles (139,822 km)\nOrbit: 11.9 Earth years\nDay: 9.8 Earth hours";
		} else if (gameObject.name == "Saturn") {
			myTxt = "Saturn\nNamed for: Roman god of agriculture\nDiameter: 74,900 miles (120,500 km)\nOrbit: 29.5 Earth years\nDay: About 10.5 Earth hours";
		} else if (gameObject.name == "Uranus") {
			myTxt = "Uranus\nNamed for: Personification of heaven in ancient myth\nDiameter: 31,763 miles (51,120 km)\nOrbit: 84 Earth years\nDay: 18 Earth hours";
		} else if (gameObject.name == "Neptune") {
			myTxt = "Neptune\nNamed for: Roman god of water\nDiameter: 30,775 miles (49,530 km)\nOrbit: 165 Earth years\nDay: 19 Earth hours";
		} else if (gameObject.name == "Pluto") {
			myTxt = "Pluto\nNamed for: Roman god of the underworld, Hades\nDiameter: 1,430 miles (2,301 km)\nOrbit: 248 Earth years\nDay: 6.4 Earth day";
		}else if (gameObject.name == "Sun") {
			myTxt = "Sun\nThe star at the center of the Solar System\nAge:\t4.6 Billion Years\nDiameter:\t1,392,684 km\nSurface Temperature:\t5,500 °C";
		}
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void changeText(){
		textBox.text = myTxt;
		textBox2.text = myTxt;
	}
	public void removeText(){
		textBox.text = "" ;
		textBox2.text = "" ;
	}
}

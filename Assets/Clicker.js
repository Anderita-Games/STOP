#pragma strict
var main : UnityEngine.UI.Text;
var counter : int;

function Start () {

}

function Update () {
	if (Input.GetMouseButtonDown(0)) {
		PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 1);
		counter ++;

	}
	

	if (counter == 1 && PlayerPrefs.GetInt("Score") >= 1) {
		main.text = "Why are you back again?!?!? You have already tapped me " + PlayerPrefs.GetInt("Score") + " times!!!";
	}else if (counter == 2) {
		main.text = "Why Bro";
	}else if (counter == 5) {
		main.text = "ur not funny";
	}else if (counter == 7) {
		main.text = "do you think that you are cool?";
	}else if (counter == 8) {
		main.text = "Guess what?";
	}else if (counter == 9) {
		main.text = "you aren't!";
	}else if (counter == 10) {
		main.text = "Tap me 10 more times";
	}else if (counter == 20) {
		main.text = "Now you have annoyed me twice as many times as before!";
	}else if (counter == 25) {
		main.text = ">:(";
	}else if (counter == 30) {
		main.text = "Don't tap me anymore!";
	}else if (counter == 35) {
		main.text = "I am warning you!";
	}else if (counter == 40) {
		main.text = "Final Chance!";
	}else if (counter == 41) {
		main.text = "No way you will tap me one more time";
	}else if (counter == 42) {
		main.text = "Bye Bye";
		Wait ();
		Application.Quit();
	}
}

function Wait () {
	yield WaitForSeconds (1);
}

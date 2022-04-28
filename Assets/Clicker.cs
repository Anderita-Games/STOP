using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Clicker : MonoBehaviour
{
    public UnityEngine.UI.Text main;
    public int counter;
    public virtual void Start()
    {
    }

    public virtual void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 1);
            this.counter++;
        }
        if ((this.counter == 1) && (PlayerPrefs.GetInt("Score") >= 1))
        {
            this.main.text = ("Why are you back again?!?!? You have already tapped me " + PlayerPrefs.GetInt("Score")) + " times!!!";
        }
        else
        {
            if (this.counter == 2)
            {
                this.main.text = "Why Bro";
            }
            else
            {
                if (this.counter == 5)
                {
                    this.main.text = "ur not funny";
                }
                else
                {
                    if (this.counter == 7)
                    {
                        this.main.text = "do you think that you are cool?";
                    }
                    else
                    {
                        if (this.counter == 8)
                        {
                            this.main.text = "Guess what?";
                        }
                        else
                        {
                            if (this.counter == 9)
                            {
                                this.main.text = "you aren't!";
                            }
                            else
                            {
                                if (this.counter == 10)
                                {
                                    this.main.text = "Tap me 10 more times";
                                }
                                else
                                {
                                    if (this.counter == 20)
                                    {
                                        this.main.text = "Now you have annoyed me twice as many times as before!";
                                    }
                                    else
                                    {
                                        if (this.counter == 25)
                                        {
                                            this.main.text = ">:(";
                                        }
                                        else
                                        {
                                            if (this.counter == 30)
                                            {
                                                this.main.text = "Don't tap me anymore!";
                                            }
                                            else
                                            {
                                                if (this.counter == 35)
                                                {
                                                    this.main.text = "I am warning you!";
                                                }
                                                else
                                                {
                                                    if (this.counter == 40)
                                                    {
                                                        this.main.text = "Final Chance!";
                                                    }
                                                    else
                                                    {
                                                        if (this.counter == 41)
                                                        {
                                                            this.main.text = "No way you will tap me one more time";
                                                        }
                                                        else
                                                        {
                                                            if (this.counter == 42)
                                                            {
                                                                this.main.text = "Bye Bye";
                                                                this.StartCoroutine(this.Wait());
                                                                Application.Quit();
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    public virtual IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
    }

}
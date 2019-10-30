using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//https://docs.unity3d.com/2018.4/Documentation/ScriptReference/UI.Image.html
public class DayNight : MonoBehaviour
{
  private float currentTime;
  private bool isDay;
  private bool transition = false;
  public int dayDuration = 10;//how long day lasts in seconds
  public int nightDuration = 10;//how long night lasts in seconds
  public bool startDay = true; //start the game in day or night?
  public float transitionSpeed = 2f; //length of dawn and dusk transition in ~seconds
  [Range(1,100)]
  public int maxDark = 50;//max percentage of the alpha channel
  public Image image;
  private Color color;
  private float dark;

  void Start(){
    currentTime = 0f;
    if (startDay){
      isDay = true;
      color = new Color (0f,0f,0f,0f);//overlay is clear
      image.color = color;
    }
    else{
      isDay = false;
      color = new Color (0f,0f,0f,maxDark/100f);//overlay is dark
      image.color = color;
    }
    dark = (maxDark/100f)/(transitionSpeed*10f);
  }

  void Update(){
    currentTime += Time.deltaTime;
    if (isDay && currentTime>dayDuration && !transition){//trigger dusk
      isDay = false;
      transition = true;
    }
    else if (!isDay && currentTime>nightDuration && !transition){//trigger dawn
      isDay = true;
      transition = true;
    }
    else if (transition){
      transition = dawnDusk(transition);
      if (!transition){
        currentTime = Time.deltaTime;//reset timer when transition is complete
      }
    }
  }
  private bool dawnDusk(bool running){
    if (isDay){//dawn
      image.color = new Color(0f,0f,0f,image.color.a-dark);
      if (image.color.a <0.01){
        running = false;
        image.color = new Color (0f,0f,0f,0f);//close enough - set to 0
      }
    }
    else{//dusk
      image.color = new Color(0f,0f,0f,image.color.a+dark);
      if (image.color.a >= (maxDark/100f)){
        running = false;
      }
    }
    return running;
  }
}

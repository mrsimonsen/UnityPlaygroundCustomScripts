using UnityEngine;
//https://answers.unity.com/questions/983470/unity-2d-daynight.html

[AddComponentMenu("Playground/Day & Night Timer")]
public class DayNight : MonoBehaviour{
  private int currentTime = 0f; //game time starts at 0
  private bool isDay; //is it day or night
  public bool startDay = true; //start the game in day or night?
  public int dayLength = 10; //length of the day
  public int nightLength = 10; //length of the night
  public int transitionSpeed = 2; //length of dawn and dusk
  public float maxDark = 0.5f;

  /*
  create a top layer that is transparent black
  0 opacity during the day
  max opacity during the night
  positive transition for dawn
  negative transition for dusk
  */

}

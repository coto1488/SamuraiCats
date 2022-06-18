using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class settings : MonoBehaviour
{
   public AudioMixer audioMixer;

   public void SetVolume(float volume){
     audioMixer.SetFloat("volume", volume);
   }
   public void Scenes(int number)
   {
        SceneManager.LoadScene(number);
   }
}

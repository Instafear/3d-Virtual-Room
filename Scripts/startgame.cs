using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class startgame : MonoBehaviour
{
 public void start_game()
    {
        SceneManager.LoadScene("mainscene");
    }
}

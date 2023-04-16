using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 namespace UdemyDeneme01.Uis
{

    public class MenuCanvas : MonoBehaviour
    {
        public void StartButtonClick()
        {

            GameManager.Instance.StartGame();

        }
        public void ExitButtonClick()
        {
            GameManager.Instance.ExitGame();


        }


    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goclassRoom : MonoBehaviour
{
    public static int oneclass;
    public static int twoclass;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void goClassRoom()
    {
        
        if (oneclass == 7 && twoclass == 2)
        {
            SceneManager.LoadScene("7-2");
        }
        if (oneclass == 7 && twoclass == 3)
        {
            SceneManager.LoadScene("7-3");
        }
        if (oneclass == 7 && twoclass == 4)
        {
            SceneManager.LoadScene("7-4");
        }
        if (oneclass == 7 && twoclass == 5)
        {
            SceneManager.LoadScene("7-5");

        }
        if (oneclass == 7 && twoclass == 6)
        {
            SceneManager.LoadScene("7-6");

        }

        // 나눔관

        if (oneclass == 5 && twoclass == 1)
        {
            SceneManager.LoadScene("5-1");
        }
        if (oneclass == 5 && twoclass == 2)
        {
            SceneManager.LoadScene("5-2");

        }
        if (oneclass == 5 && twoclass == 3)
        {
            SceneManager.LoadScene("5-3");
        }
        if (oneclass == 5 && twoclass == 4)
        {
            SceneManager.LoadScene("5-4");
        }
        if (oneclass == 5 && twoclass == 5)
        {
            SceneManager.LoadScene("5-5");
        }
        if (oneclass == 5 && twoclass == 6)
        {
            SceneManager.LoadScene("5-6");
        }
        if (oneclass == 5 && twoclass == 7)
        {
            SceneManager.LoadScene("5-");
        }

        if (oneclass == 8 && twoclass == 1)
        {
            SceneManager.LoadScene("8-1");
        }
        if (oneclass == 8 && twoclass == 2)
        {
            SceneManager.LoadScene("8-2");
        }
        if (oneclass == 8 && twoclass == 3)
        {
            SceneManager.LoadScene("8-3");
        }
        if (oneclass == 8 && twoclass == 4)
        {
            SceneManager.LoadScene("8-4");
        }
        if (oneclass == 8 && twoclass == 5)
        {
            SceneManager.LoadScene("8-5");
        }
        if (oneclass == 8 && twoclass == 6)
        {
            SceneManager.LoadScene("8-6");

        }


        //봉사관

        if (oneclass == 2 && twoclass == 8)
        {
            SceneManager.LoadScene("2-B2");
        }

        if (oneclass == 2 && twoclass == 7)
        {
            SceneManager.LoadScene("2-B1");
        }

        if (oneclass == 2 && twoclass == 1)
        {
            SceneManager.LoadScene("2-1");
        }

        if (oneclass == 2 && twoclass == 2)
        {
            SceneManager.LoadScene("2-2");
        }

        if (oneclass == 2 && twoclass == 3)
        {
            SceneManager.LoadScene("2-3");
        }

        if (oneclass == 2 && twoclass == 4)
        {
            SceneManager.LoadScene("2-4");
        }

        if (oneclass == 2 && twoclass == 5)
        {
            SceneManager.LoadScene("2-5");
        }

        // 6호관 
        // 6-B1
        if (oneclass == 6 && twoclass == 7)
        {
            SceneManager.LoadScene("6-B1");
        }

        // 6-1 
        if (oneclass == 6 && twoclass == 1)
        {
            SceneManager.LoadScene("6-1");
        }

        // 6-2 
        if (oneclass == 6 && twoclass == 2)
        {
            SceneManager.LoadScene("6-2");
        }

        // 6-3
        if (oneclass == 6 && twoclass == 3)
        {
            SceneManager.LoadScene("6-3");
        }

        // 6-4
        if (oneclass == 6 && twoclass == 4)
        {
            SceneManager.LoadScene("6-4");
        }

        // 6-5
        if (oneclass == 6 && twoclass == 5)
        {
            SceneManager.LoadScene("6-5");
        }

        // 6-6
        if (oneclass == 6 && twoclass == 6)
        {
            SceneManager.LoadScene("6-6");
        }

        // 1호관

        if (oneclass == 1 && twoclass == 1)
        {
            SceneManager.LoadScene("1-1");
        }

        if (oneclass == 1 && twoclass == 2)
        {
            SceneManager.LoadScene("1-2");
        }
        if (oneclass == 1 && twoclass == 3)
        {
            SceneManager.LoadScene("1-3");
        }

        if (oneclass == 1 && twoclass == 4)
        {
            SceneManager.LoadScene("1-4");
        }

        if (oneclass == 1 && twoclass == 5)
        {
            SceneManager.LoadScene("1-5");

        }

        if (oneclass == 1 && twoclass == 6)
        {
            SceneManager.LoadScene("1-6");

        }

        if (oneclass == 1 && twoclass == 9)
        {
            SceneManager.LoadScene("1-6,PH");

        }


        //3호과
        if (oneclass == 3 && twoclass == 7)
        {
            SceneManager.LoadScene("3-B1");
        }

        if (oneclass == 3 && twoclass == 1)
        {
            SceneManager.LoadScene("3-1");

        }

        if (oneclass == 3 && twoclass == 2)
        {
            SceneManager.LoadScene("3-2");
        }

        if (oneclass == 3 && twoclass == 3)
        {
            SceneManager.LoadScene("3-3");
        }

        if (oneclass == 3 && twoclass == 4)
        {
            SceneManager.LoadScene("3-4");
        }

        if (oneclass == 3 && twoclass == 5)
        {
            SceneManager.LoadScene("3-5");
        }
    }
}

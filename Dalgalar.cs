using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dalgalar : MonoBehaviour
{
    public GameObject dalga;
    public GameObject dalgaNokta1;
    public GameObject dalgaNokta2;
    public GameObject dalgaNokta3;
    public GameObject dalgaNokta4;
    void Start()
    {

    }

    void Update()
    {
        //var randomNumber = randomNumberGenerator();
        //print(randomNumber);
        //if (randomNumber == 0)
        //{
        //    GameObject clone1 = Instantiate(dalga, dalgaNokta1.transform.position, Quaternion.identity) as GameObject;
        //}

        //else if (randomNumber == 1)
        //{
        //    var clone = Instantiate(dalga, dalgaNokta2.transform.position, Quaternion.identity);
           
        //}
        //else if(randomNumber == 2)
        //{
        //    var clone = Instantiate(dalga, dalgaNokta3.transform.position, Quaternion.identity);
        //}
        //else if(randomNumber == 3)
        //{
        //    var clone = Instantiate(dalga, dalgaNokta4.transform.position, Quaternion.identity);
        //}
    }
    public  int randomNumberGenerator()
    {
        int randomDalga = Random.Range(0, 4);
        return randomDalga;
    }
}

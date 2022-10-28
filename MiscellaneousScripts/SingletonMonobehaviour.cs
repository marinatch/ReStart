using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMonobehaviour<T> : MonoBehaviour where T:MonoBehaviour
{
    //<T> using Generics
    private static T instance; //static field can be accessed directly by just using the script name

    public static T Instance
    {
        get
        {
            return instance;
        }
    }

    protected virtual void Awake()
    {
        //if the singleton objects does not exist in the instance  create it, if it does do not create another, destroy it. So we don't end up with double objects
        if(instance == null)
        {
            instance = this as T;
        }
        else
        {
            Destroy(gameObject);
        }
    }

}

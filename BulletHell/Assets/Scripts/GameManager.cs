using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Singleton;

    private static GameManager Instance()
    {
        return Singleton;
    }

    private List<IUpdater> UpdateList = new List<IUpdater>();

    private void Awake()
    {
        Singleton = this;
        new TAccessor<MovementModule>();
<<<<<<< HEAD
        
        
=======
>>>>>>> parent of caab6bf (Push Gun + Bullet)
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateList.Add(new MovementSystem());
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var u in UpdateList )
        {
            u.SystemUpdate();
        }
    }
}

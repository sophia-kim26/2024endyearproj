using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class PerfectVisibility : MonoBehaviour
{
    public SpriteRenderer sprender;
    public void on(){
        sprender.enabled = true;
    }
    public void off(){
        sprender.enabled = false;
    }
}

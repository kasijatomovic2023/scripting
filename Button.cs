using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Button:MonoBehavior

public Animator button;
public Animatior toOpen;

void Start()
{
    button.enabled = false
 }

private void OnTriggerEnter(Collider other)
{
    button.enabled = true;
    toOpen.enabled = true;
    }
}


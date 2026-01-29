using UnityEngine;

public class HandRaisingStarter : MonoBehaviour
{
    public Animator anim;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            anim.speed = 0.3f; // rallenta animazione
            anim.Play("Hand Raising", 0, 0f);
        }
    }
}

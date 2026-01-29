using UnityEngine;

public class HandRaisingStarter : MonoBehaviour
{
    public Animator anim;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
{
    anim.SetTrigger("StartHandRising"); 
}
    }
}

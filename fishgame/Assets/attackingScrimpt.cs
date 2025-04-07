using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class attackingScrimpt : MonoBehaviour
{
    public Animator animator;
    public TextMeshProUGUI text;

    public int fish;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            Debug.Log("elkgfh");
            animator.SetTrigger("New Trigger");
        }
        text.text = fish.ToString();
    }
}

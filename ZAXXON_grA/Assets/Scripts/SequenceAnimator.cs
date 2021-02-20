using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceAnimator : MonoBehaviour
{
    List<Animator> _animators;
    [SerializeField] float waitBetween;
    [SerializeField] float waitEnd;
    // Start is called before the first frame update
    void Start()
    {
        _animators = new List<Animator>(GetComponentsInChildren<Animator>());
        StartCoroutine("DoAnimation");
    }

    // Update is called once per frame
    IEnumerator DoAnimation()
    {
        while(true)
        {
            foreach(var animator in _animators)
            {
                animator.SetTrigger("DoAnimation");
                yield return new WaitForSeconds(waitBetween);
            }
            yield return new WaitForSeconds(waitEnd);
        }
    }
}

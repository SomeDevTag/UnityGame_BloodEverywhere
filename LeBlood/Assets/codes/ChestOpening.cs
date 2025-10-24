using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ChestOpening : MonoBehaviour
{
        SpriteRenderer sprite;
        public Animator animator;
        public int size;
        public GameObject[] items;
        float timmy;
         Color white = new Color (1, 1, 1, 1); 
         Color minus = new Color (0, 0, 0, 0.1f); 
         public bool it = false;
    //    public ParticleSystem particles;
       
    // Start is called before the first frame update
    void Start()
    {
      sprite = GetComponent<SpriteRenderer>();
      gameObject.GetComponent<ParticleSystem>().Stop(); 
      //   animator.SetBool("bop", true);
    }


    public void open(){
      if(it){
            staticinfo.spawning = true;
            staticinfo.startTime = Time.time;
      }
    
       GameObject Item = Instantiate(items[Random.Range(0,size)], transform.position, transform.rotation);
          gameObject.GetComponent<Collider2D>().enabled = false;
         gameObject.GetComponent<ParticleSystem>().Play(); 
         gameObject.GetComponent<AudioSource>().Play();
          animator.SetBool("bop", true);
         transform.DOScale(1.7f, 0.2f).OnComplete(() => transform.DOScale(1.2f, 0.1f)).SetEase(Ease.InOutSine);

      GetComponent<SpriteRenderer>().DOFade(0, 0.7f).SetEase(Ease.InOutSine).OnComplete(() => Destroy(gameObject));
    }

   
 
}

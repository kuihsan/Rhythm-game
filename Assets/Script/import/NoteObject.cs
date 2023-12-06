using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;
    public KeyCode keyToPress;
    public GameObject hitEffect, goodEffect, perfectEffect, missEffect;
    private bool obtained;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame

    private void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed)
            {
                gameObject.SetActive(false);
            }
        }
    }
    //private void Update()
    //{
    //    if (Input.GetKeyDown(keyToPress))
    //    {
    //        if (canBePressed)
    //        {
    //            gameObject.SetActive(false);
    //            obtained = true;
    //            // GameManager.instance.NoteHit();

    //            if (Mathf.Abs(transform.position.y) > 1.50 || (transform.position.y) < 0.25)
    //            {
    //                Debug.Log("Hit");
    //                GameManager.instance.NormalHit();
    //                Instantiate(hitEffect, transform.position, hitEffect.transform.rotation);
    //            }
    //            else if (Mathf.Abs(transform.position.y) > 1.10 || (transform.position.y) < 0.7)
    //            {
    //                Debug.Log("Good");
    //                GameManager.instance.GoodHit();
    //                Instantiate(goodEffect, transform.position, goodEffect.transform.rotation);
    //            }
    //            else
    //            {
    //                Debug.Log("Perfect");
    //                GameManager.instance.PerfectHit();
    //                Instantiate(perfectEffect, transform.position, perfectEffect.transform.rotation);
    //            }
    //        }
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (gameObject.activeSelf)
        {
            if (other.tag == "Activator")
            {
                canBePressed = false;
                if (!obtained)
                {
                    GameManager.instance.NoteMissed();
                    Instantiate(missEffect, transform.position, missEffect.transform.rotation);
                }
            }
            //GameManager.instance.NoteMissed();
        }
    }
}
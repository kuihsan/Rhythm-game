using UnityEngine;
using UnityEngine.UIElements;

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
                obtained = true;
                // GameManager.instance.NoteHit();

                if (Mathf.Abs(transform.position.z) > 0.5)
                {
                    Debug.Log("Hit");
                    GameManager.instance.NormalHit();
                    Instantiate(hitEffect, new Vector3(transform.position.x, transform.position.y+1, transform.position.z), hitEffect.transform.rotation);
                }
                else if (Mathf.Abs(transform.position.z) > 0.25f)
                {
                    Debug.Log("Good");
                    GameManager.instance.GoodHit();
                    Instantiate(goodEffect, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), goodEffect.transform.rotation);
                }
                else
                {
                    Debug.Log("Perfect");
                    GameManager.instance.PerfectHit();
                    Instantiate(perfectEffect, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), perfectEffect.transform.rotation);
                }
            }
        }
    }

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
                    Instantiate(missEffect, new Vector3(transform.position.x, transform.position.y+1, transform.position.z), missEffect.transform.rotation);
                }
            }
            //GameManager.instance.NoteMissed();
        }
    }
}
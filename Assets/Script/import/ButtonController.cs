using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private MeshFilter theSR;
    public Mesh defaultImage;
    public Mesh pressedImage;

    public KeyCode keyToPress;

    // Start is called before the first frame update
    private void Start()
    {
        theSR = GetComponent<MeshFilter>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            theSR.mesh = pressedImage;
        }
        if (Input.GetKeyUp(keyToPress))
        {
            theSR.mesh = defaultImage;
        }
    }
}
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private MeshFilter theSR;
    private MeshRenderer meshRenderer;

    public Mesh defaultMesh;
    public Mesh pressedMesh;

    public Material[] defaultMaterials; // Array of materials for the default state
    public Material[] pressedMaterials; // Array of materials for the pressed state

    public KeyCode keyToPress;

    // Start is called before the first frame update
    private void Start()
    {
        theSR = GetComponent<MeshFilter>();
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.materials = defaultMaterials; // Set the default materials initially
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            theSR.mesh = pressedMesh;
            meshRenderer.materials = pressedMaterials; // Change materials when pressed
        }
        if (Input.GetKeyUp(keyToPress))
        {
            theSR.mesh = defaultMesh;
            meshRenderer.materials = defaultMaterials; // Change materials back to default when released
        }
    }
}
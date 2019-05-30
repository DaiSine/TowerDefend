using UnityEngine;
public class TowerBase : MonoBehaviour
{
    void Start()
    {
       // Debug.Log("touch start");
        transform.GetComponent<MeshRenderer>().material.color = Color.yellow;
        
    }

    void Update()
    {
        
    
    }

    public void OnMouseDown()
    {
        Debug.Log("touch start");
        transform.GetComponent<MeshRenderer>().material.color = Color.red;
        Global.GetInstance().GetEvent().Invoke(EventEnum.BuildMenu, gameObject);

    }
    public void OnMouseUp()
    {
        transform.GetComponent<MeshRenderer>().material.color = Color.yellow;
    }
}

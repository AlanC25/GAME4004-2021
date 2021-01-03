using UnityEngine;
using UnityEngine.SceneManagement;

public class ArmyBaseTrigger : MonoBehaviour
{
    public string levelToLoad;
    public GameObject hoverCar, armyBase;
    Collider carCollider, baseCollider;
    // Start is called before the first frame update
    void Start()
    {
        if (hoverCar != null)
            carCollider = hoverCar.GetComponent<Collider>();

        if (armyBase != null)
            baseCollider = armyBase.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (baseCollider.bounds.Intersects(carCollider.bounds))
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}

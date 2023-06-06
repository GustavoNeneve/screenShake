using UnityEngine;

public class DemoCameraShake : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            CameraShake.instance.Shake(CameraShake.Strength.weakShake);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            CameraShake.instance.Shake(CameraShake.Strength.mediumShake);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            CameraShake.instance.Shake(CameraShake.Strength.strongShake);
        }
    }
}

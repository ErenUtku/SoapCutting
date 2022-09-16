using UnityEngine;

public class KnifeDrag : MonoBehaviour
{
    public float dragSpeed = 2;
    private Vector3 _dragOrigin;

    private Vector3 _target;
    public bool isDragActive;
    void Update()
    {
        if (isDragActive)
        {
            if (Input.GetMouseButtonDown(0))
            {
                _dragOrigin = Input.mousePosition;
                return;
            }

            if (!Input.GetMouseButton(0)) return;

            var pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - _dragOrigin);

            _target = new Vector3(0, 0, pos.y * dragSpeed);

            if (pos != Vector3.zero && pos.y < 0)
            {
                transform.Translate(_target, Space.World);
            }
        }

    }

    public void DraggingActivation(bool value)
    {
        isDragActive = value;
    }


}
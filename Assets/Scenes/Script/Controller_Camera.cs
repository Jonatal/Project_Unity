using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Camera : MonoBehaviour
{

    public float ZoomMax;
    public float ZoomMin;
    public float sensitivity;

    private Camera _camera;

    private Touch _touchA;
    private Touch _touchB;
    private Vector2 _touchADirection;
    private Vector2 _touchBDirection;

    private float _dstBtwTouchesPosition;
    private float _dstBtwTouchesPositionB;
    private float _zoom;

    // Start is called before the first frame update
    private void Awake()
    {
        _camera = Camera.main;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.touchCount == 2)
        {
            _touchA = Input.GetTouch(0);
            _touchB = Input.GetTouch(1);
            _touchADirection = _touchA.position - _touchA.deltaPosition;
            _touchBDirection = _touchB.position - _touchB.deltaPosition;

            _dstBtwTouchesPosition = Vector2.Distance(_touchA.position, _touchB.position);
            _dstBtwTouchesPositionB = Vector2.Distance(_touchADirection, _touchBDirection);

            _zoom = _dstBtwTouchesPosition - _dstBtwTouchesPositionB;

            var currentZoom = _camera.orthographicSize - _zoom * sensitivity;

            _camera.orthographicSize = Mathf.Clamp(currentZoom, ZoomMin, ZoomMax);

            if (_touchBDirection != _touchB.position)
            {
                var angle = Vector3.SignedAngle(_touchB.position - _touchA.position, _touchBDirection - _touchADirection, _camera.transform.forward);
                
                _camera.transform.RotateAround(_camera.transform.position, - _camera.transform.forward, angle);
            }
        }
    }
}

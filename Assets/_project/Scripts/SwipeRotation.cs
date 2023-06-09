using UnityEngine;
using UnityEngine.AI;

public class SwipeRotation : MonoBehaviour
{
    private Vector2 startSwipePos;
    private bool isSwiping = false;
    public float rotationSpeed = 5f;

    private void Update()
    {
        CheckTouch();

        // ������� ������ ��� ������
        if (isSwiping)
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                Vector2 currentSwipePos = touch.position;

                float swipeDelta = currentSwipePos.x - startSwipePos.x;

                // ������� ������ ������ ��� Y
                transform.Rotate(Vector3.up, swipeDelta * rotationSpeed * Time.deltaTime);
            }
        }
    }

    private void CheckTouch()
    {
        // ����������� ������ ������
        if (Input.GetMouseButton(0))
        {
            Touch touch = Input.GetTouch(0);

            isSwiping = true;
            if (touch.phase == TouchPhase.Began)
            {
            }
            // ����������� ��������� ������
            else if (touch.phase == TouchPhase.Ended)
            {
                isSwiping = false;
            }
        }
    }
}
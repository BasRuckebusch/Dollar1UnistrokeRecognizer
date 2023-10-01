using UnityEngine;
using UnityEngine.Events;

public class InputHandler : MonoBehaviour
{
	public UnityEvent OnDrawingStart;
	public UnityEvent OnDrawingEnd;
	public UnityEvent<Vector2> OnDrawingUpdate;

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			OnDrawingStart.Invoke();
		}
		else if (Input.GetMouseButtonUp(0))
		{
			OnDrawingEnd.Invoke();
		}

		if (Input.GetMouseButton(0))
		{
			Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			OnDrawingUpdate.Invoke(mousePosition);
		}
	}
}

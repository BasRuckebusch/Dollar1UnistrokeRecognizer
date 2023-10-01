using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GestureTextUpdater : MonoBehaviour
{
	[SerializeField] private TMP_Text  gestureTextField;
	[SerializeField] private TMP_Text scoreTextField;

	private void Start()
	{
		GestureManager.Instance.OnGestureRecognized.AddListener(UpdateTextFields);
	}

	private void OnDisable()
	{
		GestureManager.Instance.OnGestureRecognized.RemoveListener(UpdateTextFields);
	}

	// This method will be called when the OnGestureRecognized event is triggered
	private void UpdateTextFields(string gesture, float score, Color color)
	{
		// Update the text fields with the provided values
		gestureTextField.text = "Gesture: " + gesture;
		scoreTextField.text = "Score: " + (score * 100f).ToString("F0") + "%";
	}
}

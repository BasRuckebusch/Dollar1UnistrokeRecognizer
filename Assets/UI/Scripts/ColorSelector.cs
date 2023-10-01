using UnityEngine;
using UnityEngine.UI;

public class ColorSelector : MonoBehaviour
{
	[SerializeField] private Image colorDisplay;
	[SerializeField] private Slider redSlider;
	[SerializeField] private Slider greenSlider;
	[SerializeField] private Slider blueSlider;

	public void UpdateColor()
	{
		Color selectedColor = new Color(redSlider.value, greenSlider.value, blueSlider.value);
		colorDisplay.color = selectedColor;
		GestureManager.Instance.templateColor = selectedColor;
	}
}

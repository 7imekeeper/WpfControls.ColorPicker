using System.Windows;

namespace WpfControls
{
	public class ColorSlider : ValueSlider
	{
		static ColorSlider()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(ColorSlider), new FrameworkPropertyMetadata(typeof(ColorSlider)));
		}
	}
}

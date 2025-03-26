namespace MauiApp1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
	}
	
	public class CustomLabel : Label
	{
		internal ColorHelper ColorHelper;

		public static readonly BindableProperty LabelBackgroundColorProperty =
			BindableProperty.Create(
				propertyName: nameof(LabelBackgroundColor),
				returnType: typeof(Color),
				declaringType: typeof(CustomLabel),
				defaultValue: Colors.Transparent,
				propertyChanged: OnLabelBackgroundColorChanged);

		public CustomLabel()
		{
			this.ColorHelper = new ColorHelper();
		}

		public Color LabelBackgroundColor
		{
			get => (Color)GetValue(LabelBackgroundColorProperty);
			set => SetValue(LabelBackgroundColorProperty, value);
		}

		private static void OnLabelBackgroundColorChanged(BindableObject bindable, object oldValue, object newValue)
		{
			if (bindable is CustomLabel customLabel)
			{
				customLabel.BackgroundColor = customLabel.ColorHelper.Color;
			}
		}
	}

	public class ColorHelper
	{
		public Color Color { get; set; } = Colors.Yellow;
	}
}


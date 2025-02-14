using System.Linq;
using Bindables.Test;
using NUnit.Framework;

namespace Bindables.Wpf.Test.AttachedProperty;

[TestFixture]
public class SimpleProperty : WpfTestBase
{
	private const string SourceCode = @"
using System.Windows;
using Bindables.Wpf;

public partial class WpfClass
{
	private static readonly string DefaultValue = ""Test"";

	[AttachedProperty(typeof(int))]
	public static readonly DependencyProperty Example1Property;

	[AttachedProperty(typeof(int), OnPropertyChanged = nameof(PropertyChangedCallback))]
	public static readonly DependencyProperty Example2Property;

	[AttachedProperty(typeof(string), DefaultValueField = nameof(DefaultValue))]
	public static readonly DependencyProperty Example3Property;

	[AttachedProperty(typeof(string), Options = FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)]
	public static readonly DependencyProperty Example4Property;

	[AttachedProperty(typeof(string), OnPropertyChanged = nameof(PropertyChangedCallback), DefaultValueField = nameof(DefaultValue))]
	public static readonly DependencyProperty Example5Property;

	[AttachedProperty(typeof(string), OnPropertyChanged = nameof(PropertyChangedCallback), DefaultValueField = nameof(DefaultValue), Options = FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)]
	public static readonly DependencyProperty Example6Property;

	[AttachedProperty(typeof(int), OnCoerceValue = nameof(CoerceValueCallback))]
	public static readonly DependencyProperty Example7Property;

	[AttachedProperty(typeof(int), OnPropertyChanged = nameof(PropertyChangedCallback), OnCoerceValue = nameof(CoerceValueCallback))]
	public static readonly DependencyProperty Example8Property;

	[AttachedProperty(typeof(string), OnCoerceValue = nameof(CoerceValueCallback), DefaultValueField = nameof(DefaultValue))]
	public static readonly DependencyProperty Example9Property;

	[AttachedProperty(typeof(string), OnPropertyChanged = nameof(PropertyChangedCallback), OnCoerceValue = nameof(CoerceValueCallback), DefaultValueField = nameof(DefaultValue))]
	public static readonly DependencyProperty Example10Property;

	[AttachedProperty(typeof(string), OnCoerceValue = nameof(CoerceValueCallback), DefaultValueField = nameof(DefaultValue), Options = FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)]
	public static readonly DependencyProperty Example11Property;

	[AttachedProperty(typeof(string), OnPropertyChanged = nameof(PropertyChangedCallback), OnCoerceValue = nameof(CoerceValueCallback), DefaultValueField = nameof(DefaultValue), Options = FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)]
	public static readonly DependencyProperty Example12Property;

	private static void PropertyChangedCallback(DependencyObject obj, DependencyPropertyChangedEventArgs args)
	{
	}

	private static object CoerceValueCallback(DependencyObject obj, object value)
	{
		return """";
	}
}";

	private const string ExpectedSourceCode = @"
// Generated by Bindables
using System.Windows;

public partial class WpfClass
{
    public static int GetExample1(DependencyObject target)
    {
        return (int)target.GetValue(Example1Property);
    }

    public static void SetExample1(DependencyObject target, int value)
    {
        target.SetValue(Example1Property, value);
    }

    public static int GetExample2(DependencyObject target)
    {
        return (int)target.GetValue(Example2Property);
    }

    public static void SetExample2(DependencyObject target, int value)
    {
        target.SetValue(Example2Property, value);
    }

    public static string GetExample3(DependencyObject target)
    {
        return (string)target.GetValue(Example3Property);
    }

    public static void SetExample3(DependencyObject target, string value)
    {
        target.SetValue(Example3Property, value);
    }

    public static string GetExample4(DependencyObject target)
    {
        return (string)target.GetValue(Example4Property);
    }

    public static void SetExample4(DependencyObject target, string value)
    {
        target.SetValue(Example4Property, value);
    }

    public static string GetExample5(DependencyObject target)
    {
        return (string)target.GetValue(Example5Property);
    }

    public static void SetExample5(DependencyObject target, string value)
    {
        target.SetValue(Example5Property, value);
    }

    public static string GetExample6(DependencyObject target)
    {
        return (string)target.GetValue(Example6Property);
    }

    public static void SetExample6(DependencyObject target, string value)
    {
        target.SetValue(Example6Property, value);
    }

    public static int GetExample7(DependencyObject target)
    {
        return (int)target.GetValue(Example7Property);
    }

    public static void SetExample7(DependencyObject target, int value)
    {
        target.SetValue(Example7Property, value);
    }

    public static int GetExample8(DependencyObject target)
    {
        return (int)target.GetValue(Example8Property);
    }

    public static void SetExample8(DependencyObject target, int value)
    {
        target.SetValue(Example8Property, value);
    }

    public static string GetExample9(DependencyObject target)
    {
        return (string)target.GetValue(Example9Property);
    }

    public static void SetExample9(DependencyObject target, string value)
    {
        target.SetValue(Example9Property, value);
    }

    public static string GetExample10(DependencyObject target)
    {
        return (string)target.GetValue(Example10Property);
    }

    public static void SetExample10(DependencyObject target, string value)
    {
        target.SetValue(Example10Property, value);
    }

    public static string GetExample11(DependencyObject target)
    {
        return (string)target.GetValue(Example11Property);
    }

    public static void SetExample11(DependencyObject target, string value)
    {
        target.SetValue(Example11Property, value);
    }

    public static string GetExample12(DependencyObject target)
    {
        return (string)target.GetValue(Example12Property);
    }

    public static void SetExample12(DependencyObject target, string value)
    {
        target.SetValue(Example12Property, value);
    }

    static WpfClass()
    {
        Example1Property = DependencyProperty.RegisterAttached(
            ""Example1"",
            typeof(int),
            typeof(WpfClass),
            new FrameworkPropertyMetadata());
        
        Example2Property = DependencyProperty.RegisterAttached(
            ""Example2"",
            typeof(int),
            typeof(WpfClass),
            new FrameworkPropertyMetadata(PropertyChangedCallback));
        
        Example3Property = DependencyProperty.RegisterAttached(
            ""Example3"",
            typeof(string),
            typeof(WpfClass),
            new FrameworkPropertyMetadata(DefaultValue));
        
        Example4Property = DependencyProperty.RegisterAttached(
            ""Example4"",
            typeof(string),
            typeof(WpfClass),
            new FrameworkPropertyMetadata(default, (FrameworkPropertyMetadataOptions)256));
        
        Example5Property = DependencyProperty.RegisterAttached(
            ""Example5"",
            typeof(string),
            typeof(WpfClass),
            new FrameworkPropertyMetadata(DefaultValue, PropertyChangedCallback));
        
        Example6Property = DependencyProperty.RegisterAttached(
            ""Example6"",
            typeof(string),
            typeof(WpfClass),
            new FrameworkPropertyMetadata(DefaultValue, (FrameworkPropertyMetadataOptions)256, PropertyChangedCallback));
        
        Example7Property = DependencyProperty.RegisterAttached(
            ""Example7"",
            typeof(int),
            typeof(WpfClass),
            new FrameworkPropertyMetadata(default, CoerceValueCallback));
        
        Example8Property = DependencyProperty.RegisterAttached(
            ""Example8"",
            typeof(int),
            typeof(WpfClass),
            new FrameworkPropertyMetadata(PropertyChangedCallback, CoerceValueCallback));
        
        Example9Property = DependencyProperty.RegisterAttached(
            ""Example9"",
            typeof(string),
            typeof(WpfClass),
            new FrameworkPropertyMetadata(DefaultValue, default, CoerceValueCallback));
        
        Example10Property = DependencyProperty.RegisterAttached(
            ""Example10"",
            typeof(string),
            typeof(WpfClass),
            new FrameworkPropertyMetadata(DefaultValue, PropertyChangedCallback, CoerceValueCallback));
        
        Example11Property = DependencyProperty.RegisterAttached(
            ""Example11"",
            typeof(string),
            typeof(WpfClass),
            new FrameworkPropertyMetadata(DefaultValue, (FrameworkPropertyMetadataOptions)256, default, CoerceValueCallback));
        
        Example12Property = DependencyProperty.RegisterAttached(
            ""Example12"",
            typeof(string),
            typeof(WpfClass),
            new FrameworkPropertyMetadata(DefaultValue, (FrameworkPropertyMetadataOptions)256, PropertyChangedCallback, CoerceValueCallback));
        
    }
}";

	[Test]
	public void Test()
	{
		TestResult result = Generate<AttachedPropertyGenerator>(SourceCode);
		CheckResult(result);

		Assert.That(result.SyntaxTrees, Has.Count.EqualTo(1));
		Assert.That(result.SyntaxTrees.Single().ToString().Trim(), Is.EqualTo(ExpectedSourceCode.Trim()));
	}
}

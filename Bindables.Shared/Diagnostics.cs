using Microsoft.CodeAnalysis;

namespace Bindables;

public class Diagnostics
{
	public static readonly DiagnosticDescriptor ClassDoesNotInheritFromDependencyObject = new(
		"BN001",
		"Class does not inherit from DependencyObject",
		"Class '{0}' does not inherit from DependencyObject",
		"Code Generation",
		DiagnosticSeverity.Error,
		true);

	public static readonly DiagnosticDescriptor ClassShouldNotHaveStaticConstructor = new(
		"BN002",
		"Class should not have static constructor",
		"Class '{0}' should not have static constructor as it will be used to initialize the DependencyProperty fields",
		"Code Generation",
		DiagnosticSeverity.Error,
		true);

	public static readonly DiagnosticDescriptor ClassShouldBePartial = new(
		"BN003",
		"Class should be partial",
		"Class '{0}' should be partial",
		"Code Generation",
		DiagnosticSeverity.Error,
		true);

	public static readonly DiagnosticDescriptor IncorrectFieldType = new(
		"BN004",
		"Incorrect field type",
		"Type of field '{0}' has to be {1}",
		"Code Generation",
		DiagnosticSeverity.Error,
		true);

	public static readonly DiagnosticDescriptor IncorrectFieldName = new(
		"BN005",
		"Incorrect field name",
		"Name of field '{0}' has to end with Property",
		"Code Generation",
		DiagnosticSeverity.Error,
		true);

	public static readonly DiagnosticDescriptor IncorrectReadOnlyFieldName = new(
		"BN006",
		"Incorrect field name",
		"Name of field '{0}' has to end with PropertyKey",
		"Code Generation",
		DiagnosticSeverity.Error,
		true);

	public static readonly DiagnosticDescriptor MissingPropertyChangedMethod = new(
		"BN007",
		"Missing PropertyChanged method",
		"The property changed callback method 'static void {0}(DependencyObject, DependencyPropertyChangedEventArgs)' is not found",
		"Code Generation",
		DiagnosticSeverity.Error,
		true);

	public static readonly DiagnosticDescriptor IncorrectPropertyChangedMethodSignature = new(
		"BN008",
		"Incorrect PropertyChanged method signature",
		"The signature of method '{0}' has to be 'static void {0}(DependencyObject, DependencyPropertyChangedEventArgs)'",
		"Code Generation",
		DiagnosticSeverity.Error,
		true);

	public static readonly DiagnosticDescriptor MissingDefaultValueField = new(
		"BN009",
		"Missing default value field",
		"The default value field 'static {1} {0}' is not found",
		"Code Generation",
		DiagnosticSeverity.Error,
		true);

	public static readonly DiagnosticDescriptor IncorrectDefaultValueFieldDefinition = new(
		"BN010",
		"Incorrect default value field definition",
		"Default value field '{0}' should be static and of type '{1}'",
		"Code Generation",
		DiagnosticSeverity.Error,
		true);
}
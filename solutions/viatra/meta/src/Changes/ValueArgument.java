/**
 */
package Changes;


/**
 * <!-- begin-user-doc -->
 * A representation of the model object ' <em> <b>Value Argument </b> </em>'.
 * <!-- end-user-doc -->
 *
 * <p>
 * The following features are supported:
 * </p>
 * <ul>
 *   <li>{@link Changes.ValueArgument#getValue <em>Value </em>} </li>
 * </ul>
 *
 * @see Changes.ChangesPackage#getValueArgument()
 * @model
 * @generated
 */
public interface ValueArgument extends OperationArgument {
	/**
	 * Returns the value of the ' <em> <b>Value </b> </em>' attribute.
	 * <!-- begin-user-doc -->
	 * <p>
	 * If the meaning of the ' <em>Value </em>' attribute isn't clear,
	 * there really should be more of a description here...
	 * </p>
	 * <!-- end-user-doc -->
	 * @return the value of the ' <em>Value </em>' attribute.
	 * @see #setValue(String)
	 * @see Changes.ChangesPackage#getValueArgument_Value()
	 * @model required="true"
	 * @generated
	 */
	String getValue();

	/**
	 * Sets the value of the '{@link Changes.ValueArgument#getValue <em>Value </em>}' attribute.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @param value the new value of the ' <em>Value </em>' attribute.
	 * @see #getValue()
	 * @generated
	 */
	void setValue(String value);

} // ValueArgument

/**
 */
package atl.research.class_;

import org.eclipse.emf.ecore.EObject;

/**
 * <!-- begin-user-doc -->
 * A representation of the model object ' <em> <b>Named Elt </b> </em>'.
 * <!-- end-user-doc -->
 *
 * <p>
 * The following features are supported:
 * </p>
 * <ul>
 *   <li>{@link atl.research.class_.NamedElt#getName <em>Name </em>} </li>
 * </ul>
 *
 * @see atl.research.class_.Class_Package#getNamedElt()
 * @model abstract="true"
 * @generated
 */
public interface NamedElt extends EObject {
	/**
	 * Returns the value of the ' <em> <b>Name </b> </em>' attribute.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @return the value of the ' <em>Name </em>' attribute.
	 * @see #setName(String)
	 * @see atl.research.class_.Class_Package#getNamedElt_Name()
	 * @model unique="false"
	 * @generated
	 */
	String getName();

	/**
	 * Sets the value of the '{@link atl.research.class_.NamedElt#getName <em>Name </em>}' attribute.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @param value the new value of the ' <em>Name </em>' attribute.
	 * @see #getName()
	 * @generated
	 */
	void setName(String value);

} // NamedElt

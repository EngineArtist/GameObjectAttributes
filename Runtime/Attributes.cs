using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System;


namespace EngineArtist {


public enum AttributeType {
    None,
    Int,
    Float,
    String,
    Vector2,
    Vector3,
    Vector4,
    Color,
    Rect,
    //Matrix4x4,
    Object,
    GameObject,
    Component,
}


public static class AttributeTypeExtensions {
    public static Type ToType(this AttributeType t) {
        switch (t) {
            case AttributeType.Int: return typeof(int);
            case AttributeType.Float: return typeof(float);
            case AttributeType.String: return typeof(string);
            case AttributeType.Vector2: return typeof(Vector2);
            case AttributeType.Vector3: return typeof(Vector3);
            case AttributeType.Vector4: return typeof(Vector4);
            case AttributeType.Color: return typeof(Color);
            case AttributeType.Rect: return typeof(Rect);
            //case AttributeType.Matrix4x4: return typeof(Matrix4x4);
            case AttributeType.Object: return typeof(UnityEngine.Object);
            case AttributeType.GameObject: return typeof(GameObject);
            case AttributeType.Component: return typeof(Component);
            default: return null;
        }
    }

    public static AttributeType ToAttributeType(this Type t) {
        if      (t == null) return AttributeType.None;
        else if (t == typeof(int)) return AttributeType.Int;
        else if (t == typeof(float)) return AttributeType.Float;
        else if (t == typeof(string)) return AttributeType.String;
        else if (t == typeof(Vector2)) return AttributeType.Vector2;
        else if (t == typeof(Vector3)) return AttributeType.Vector3;
        else if (t == typeof(Vector4)) return AttributeType.Vector4;
        else if (t == typeof(Color)) return AttributeType.Color;
        else if (t == typeof(Rect)) return AttributeType.Rect;
        //else if (t == typeof(Matrix4x4)) return AttributeType.Matrix4x4;
        else if (t == typeof(UnityEngine.Object)) return AttributeType.Object;
        else if (t == typeof(GameObject)) return AttributeType.GameObject;
        else if (t == typeof(Component)) return AttributeType.Component;
        else return AttributeType.None;
    }
}


public interface IAttribute {
    AttributeType Type {get;}
    object Value {get; set;}
    int Int {get; set;}
    float Float {get; set;}
    string String {get; set;}
    Vector2 Vector2 {get; set;}
    Vector3 Vector3 {get; set;}
    Vector4 Vector4 {get; set;}
    Color Color {get; set;}
    Rect Rect {get; set;}
    //Matrix4x4 Matrix4x4 {get; set;}
    UnityEngine.Object Object {get; set;}
    GameObject GameObject {get; set;}
    Component Component {get; set;}
}


[Serializable]
public class AttributeInt: IAttribute {
    public int _value;

    public AttributeType Type {get => AttributeType.Int;}
    public object Value {get => (object)_value; set => _value = (int)value;}
    public int Int {get => _value; set => _value = value;}
    public float Float {get => (float)_value; set => _value = (int)value;}
    public string String {get => null; set {}}
    public Vector2 Vector2 {get => default(Vector2); set {}}
    public Vector3 Vector3 {get => default(Vector3); set {}}
    public Vector4 Vector4 {get => default(Vector4); set {}}
    public Color Color {get => default(Color); set {}}
    public Rect Rect {get => default(Rect); set {}}
    public Matrix4x4 Matrix4x4 {get => default(Matrix4x4); set {}}
    public UnityEngine.Object Object {get => null; set {}}
    public GameObject GameObject {get => null; set {}}
    public Component Component {get => null; set {}}
}


[Serializable]
public class AttributeFloat: IAttribute {
    public float _value;

    public AttributeType Type {get => AttributeType.Float;}
    public object Value {get => (object)_value; set => _value = (float)value;}
    public int Int {get => (int)_value; set => _value = (float)value;}
    public float Float {get => _value; set => _value = value;}
    public string String {get => null; set {}}
    public Vector2 Vector2 {get => default(Vector2); set {}}
    public Vector3 Vector3 {get => default(Vector3); set {}}
    public Vector4 Vector4 {get => default(Vector4); set {}}
    public Color Color {get => default(Color); set {}}
    public Rect Rect {get => default(Rect); set {}}
    public Matrix4x4 Matrix4x4 {get => default(Matrix4x4); set {}}
    public UnityEngine.Object Object {get => null; set {}}
    public GameObject GameObject {get => null; set {}}
    public Component Component {get => null; set {}}
}


[Serializable]
public class AttributeString: IAttribute {
    public string _value;

    public AttributeType Type {get => AttributeType.String;}
    public object Value {get => (object)_value; set => _value = (string)value;}
    public int Int {get => int.MinValue; set {}}
    public float Float {get => float.NaN; set {}}
    public string String {get => _value; set => _value = value;}
    public Vector2 Vector2 {get => default(Vector2); set {}}
    public Vector3 Vector3 {get => default(Vector3); set {}}
    public Vector4 Vector4 {get => default(Vector4); set {}}
    public Color Color {get => default(Color); set {}}
    public Rect Rect {get => default(Rect); set {}}
    public Matrix4x4 Matrix4x4 {get => default(Matrix4x4); set {}}
    public UnityEngine.Object Object {get => null; set {}}
    public GameObject GameObject {get => null; set {}}
    public Component Component {get => null; set {}}
}


[Serializable]
public class AttributeVector2: IAttribute {
    public Vector2 _value;

    public AttributeType Type {get => AttributeType.Vector2;}
    public object Value {get => (object)_value; set => _value = (Vector2)value;}
    public int Int {get => int.MinValue; set {}}
    public float Float {get => float.NaN; set {}}
    public string String {get => null; set {}}
    public Vector2 Vector2 {get => _value; set => _value = value;}
    public Vector3 Vector3 {get => _value; set => _value = value;}
    public Vector4 Vector4 {get => _value; set => _value = value;}
    public Color Color {get => default(Color); set {}}
    public Rect Rect {get => default(Rect); set {}}
    public Matrix4x4 Matrix4x4 {get => default(Matrix4x4); set {}}
    public UnityEngine.Object Object {get => null; set {}}
    public GameObject GameObject {get => null; set {}}
    public Component Component {get => null; set {}}
}


[Serializable]
public class AttributeVector3: IAttribute {
    public Vector3 _value;

    public AttributeType Type {get => AttributeType.Vector3;}
    public object Value {get => (object)_value; set => _value = (Vector3)value;}
    public int Int {get => int.MinValue; set {}}
    public float Float {get => float.NaN; set {}}
    public string String {get => null; set {}}
    public Vector2 Vector2 {get => _value; set => _value = value;}
    public Vector3 Vector3 {get => _value; set => _value = value;}
    public Vector4 Vector4 {get => _value; set => _value = value;}
    public Color Color {get => default(Color); set {}}
    public Rect Rect {get => default(Rect); set {}}
    public Matrix4x4 Matrix4x4 {get => default(Matrix4x4); set {}}
    public UnityEngine.Object Object {get => null; set {}}
    public GameObject GameObject {get => null; set {}}
    public Component Component {get => null; set {}}
}


[Serializable]
public class AttributeVector4: IAttribute {
    public Vector4 _value;

    public AttributeType Type {get => AttributeType.Vector4;}
    public object Value {get => (object)_value; set => _value = (Vector4)value;}
    public int Int {get => int.MinValue; set {}}
    public float Float {get => float.NaN; set {}}
    public string String {get => null; set {}}
    public Vector2 Vector2 {get => _value; set => _value = value;}
    public Vector3 Vector3 {get => _value; set => _value = value;}
    public Vector4 Vector4 {get => _value; set => _value = value;}
    public Color Color {get => default(Color); set {}}
    public Rect Rect {get => default(Rect); set {}}
    public Matrix4x4 Matrix4x4 {get => default(Matrix4x4); set {}}
    public UnityEngine.Object Object {get => null; set {}}
    public GameObject GameObject {get => null; set {}}
    public Component Component {get => null; set {}}
}


[Serializable]
public class AttributeColor: IAttribute {
    public Color _value;

    public AttributeType Type {get => AttributeType.Color;}
    public object Value {get => (object)_value; set => _value = (Color)value;}
    public int Int {get => int.MinValue; set {}}
    public float Float {get => float.NaN; set {}}
    public string String {get => null; set {}}
    public Vector2 Vector2 {get => default(Vector2); set {}}
    public Vector3 Vector3 {get => default(Vector3); set {}}
    public Vector4 Vector4 {get => default(Vector4); set {}}
    public Color Color {get => _value; set => _value = value;}
    public Rect Rect {get => default(Rect); set {}}
    public Matrix4x4 Matrix4x4 {get => default(Matrix4x4); set {}}
    public UnityEngine.Object Object {get => null; set {}}
    public GameObject GameObject {get => null; set {}}
    public Component Component {get => null; set {}}
}


[Serializable]
public class AttributeRect: IAttribute {
    public Rect _value;

    public AttributeType Type {get => AttributeType.Rect;}
    public object Value {get => (object)_value; set => _value = (Rect)value;}
    public int Int {get => int.MinValue; set {}}
    public float Float {get => float.NaN; set {}}
    public string String {get => null; set {}}
    public Vector2 Vector2 {get => default(Vector2); set {}}
    public Vector3 Vector3 {get => default(Vector3); set {}}
    public Vector4 Vector4 {get => default(Vector4); set {}}
    public Color Color {get => default(Color); set {}}
    public Rect Rect {get => _value; set => _value = value;}
    public Matrix4x4 Matrix4x4 {get => default(Matrix4x4); set {}}
    public UnityEngine.Object Object {get => null; set {}}
    public GameObject GameObject {get => null; set {}}
    public Component Component {get => null; set {}}
}


[Serializable]
public class AttributeObject: IAttribute {
    public UnityEngine.Object _value;

    public AttributeType Type {get => AttributeType.Object;}
    public object Value {get => (object)_value; set => _value = (UnityEngine.Object)value;}
    public int Int {get => int.MinValue; set {}}
    public float Float {get => float.NaN; set {}}
    public string String {get => null; set {}}
    public Vector2 Vector2 {get => default(Vector2); set {}}
    public Vector3 Vector3 {get => default(Vector3); set {}}
    public Vector4 Vector4 {get => default(Vector4); set {}}
    public Color Color {get => default(Color); set {}}
    public Rect Rect {get => default(Rect); set {}}
    public Matrix4x4 Matrix4x4 {get => default(Matrix4x4); set {}}
    public UnityEngine.Object Object {get => _value; set => _value = value;}
    public GameObject GameObject {get => null; set {}}
    public Component Component {get => null; set {}}
}


[Serializable]
public class AttributeGameObject: IAttribute {
    public GameObject _value;

    public AttributeType Type {get => AttributeType.GameObject;}
    public object Value {get => (object)_value; set => _value = (GameObject)value;}
    public int Int {get => int.MinValue; set {}}
    public float Float {get => float.NaN; set {}}
    public string String {get => null; set {}}
    public Vector2 Vector2 {get => default(Vector2); set {}}
    public Vector3 Vector3 {get => default(Vector3); set {}}
    public Vector4 Vector4 {get => default(Vector4); set {}}
    public Color Color {get => default(Color); set {}}
    public Rect Rect {get => default(Rect); set {}}
    public Matrix4x4 Matrix4x4 {get => default(Matrix4x4); set {}}
    public UnityEngine.Object Object {get => _value; set {}}
    public GameObject GameObject {get => _value; set => _value = value;}
    public Component Component {get => null; set {}}
}


[Serializable]
public class AttributeComponent: IAttribute {
    public Component _value;

    public AttributeType Type {get => AttributeType.Component;}
    public object Value {get => (object)_value; set => _value = (Component)value;}
    public int Int {get => int.MinValue; set {}}
    public float Float {get => float.NaN; set {}}
    public string String {get => null; set {}}
    public Vector2 Vector2 {get => default(Vector2); set {}}
    public Vector3 Vector3 {get => default(Vector3); set {}}
    public Vector4 Vector4 {get => default(Vector4); set {}}
    public Color Color {get => default(Color); set {}}
    public Rect Rect {get => default(Rect); set {}}
    public Matrix4x4 Matrix4x4 {get => default(Matrix4x4); set {}}
    public UnityEngine.Object Object {get => _value; set {}}
    public GameObject GameObject {get => null; set {}}
    public Component Component {get => _value; set => _value = value;}
}


[Serializable]
public struct Attribute {
    public string name;
    public AttributeType type;
    [SerializeReference] public IAttribute _value;

    public string Name {get => name; set => name = value;}
    public AttributeType Type {get => _value.Type;}
    public object Value {get => _value.Value; set => _value.Value = value;}
    public int Int {get => _value.Int; set => _value.Int = value;}
    public float Float {get => _value.Float; set => _value.Float = value;}
    public string String {get => _value.String; set => _value.String = value;}
    public Vector2 Vector2 {get => _value.Vector2; set => _value.Vector2 = value;}
    public Vector3 Vector3 {get => _value.Vector3; set => _value.Vector3 = value;}
    public Vector4 Vector4 {get => _value.Vector4; set => _value.Vector4 = value;}
    public Color Color {get => _value.Color; set => _value.Color = value;}
    public Rect Rect {get => _value.Rect; set => _value.Rect = value;}
    //public Matrix4x4 Matrix4x4 {get => _value.Matrix4x4; set => _value.Matrix4x4 = value;}
    public UnityEngine.Object Object {get => _value.Object; set => _value.Object = value;}
    public GameObject GameObject {get => _value.GameObject; set => _value.GameObject = value;}
    public Component Component {get => _value.Component; set => _value.Component = value;}
}


public class Attributes: MonoBehaviour {
    public List<Attribute> attributes;
}


public static class AttributeExtensions {
    public static IAttribute Get(this GameObject gobj, string name) {
        var attr = gobj.GetComponent<Attributes>();
        if (attr == null) return null;
        for (int i = 0; i < attr.attributes.Count; ++i) {
            if (attr.attributes[i].name == name) {
                return attr.attributes[i]._value;
            }
        }
        return null;
    }

    public static T Get<T>(this GameObject gobj, string name) {
        var attr = gobj.GetComponent<Attributes>();
        if (attr == null) return default(T);
        for (int i = 0; i < attr.attributes.Count; ++i) {
            if (attr.attributes[i].name == name) {
                return (T)attr.attributes[i].Value;
            }
        }
        return default(T);
    }

    public static void Set(this GameObject gobj, string name, object value) {
        var attr = gobj.GetComponent<Attributes>();
        if (attr == null) return;
        for (int i = 0; i < attr.attributes.Count; ++i) {
            if (attr.attributes[i].name == name) {
                attr.attributes[i]._value.Value = value;
            }
        }
    }

    public static void Set<T>(this GameObject gobj, string name, T value) {
        var attr = gobj.GetComponent<Attributes>();
        if (attr == null) return;
        for (int i = 0; i < attr.attributes.Count; ++i) {
            if (attr.attributes[i].name == name) {
                attr.attributes[i]._value.Value = value;
            }
        }
    }
}


[CustomPropertyDrawer(typeof(Attribute))]
public class AttributeDrawer: PropertyDrawer {
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
        if (property.isExpanded) {
            var attrType = (AttributeType)property.FindPropertyRelative("type").enumValueIndex;
            switch (attrType) {
                case AttributeType.Int: {return 54f;}
                case AttributeType.Float: {return 54f;}
                case AttributeType.String: {return 54f;}
                case AttributeType.Vector2: {return 54f;}
                case AttributeType.Vector3: {return 54f;}
                case AttributeType.Vector4: {return 54f;}
                case AttributeType.Color: {return 54f;}
                case AttributeType.Rect: {return 76f;}
                //case AttributeType.Matrix4x4: {return 76f;}
                case AttributeType.Object: {return 54f;}
                case AttributeType.GameObject: {return 54f;}
                case AttributeType.Component: {return 54f;}
                default: {return 38f;}
            }
        }
        else return 16f;
    }

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
        EditorGUI.BeginProperty(position, label, property);
        var _name = property.FindPropertyRelative("name");
        var foldoutLabel = _name.stringValue;
        if (foldoutLabel == null || foldoutLabel == "") foldoutLabel = "Unnamed attribute";
        property.isExpanded = EditorGUI.Foldout(new Rect(position.x, position.y, property.isExpanded ? 19f: position.width, 16f), property.isExpanded, property.isExpanded ? "": foldoutLabel, true, EditorStyles.foldout);
        if (property.isExpanded) {
            _name.stringValue = EditorGUI.TextField(new Rect(position.x, position.y, position.width, 16f), _name.stringValue);
            var _type = property.FindPropertyRelative("type");
            var attrType = (AttributeType)_type.enumValueIndex;
            var selType = (AttributeType)EditorGUI.EnumPopup(new Rect(position.x, position.y + 16f, position.width, 16f), "Type", attrType);
            var _value = property.FindPropertyRelative("_value");
            if (selType != attrType) {
                _type.enumValueIndex = (int)selType;
                switch ((AttributeType)_type.enumValueIndex) {
                    case AttributeType.None: {
                        _value.managedReferenceValue = null;
                        break;
                    }
                    case AttributeType.Int: {
                        _value.managedReferenceValue = new AttributeInt();
                        break;
                    }
                    case AttributeType.Float: {
                        _value.managedReferenceValue = new AttributeFloat();
                        break;
                    }
                    case AttributeType.String: {
                        _value.managedReferenceValue = new AttributeString();
                        break;
                    }
                    case AttributeType.Vector2: {
                        _value.managedReferenceValue = new AttributeVector2();
                        break;
                    }
                    case AttributeType.Vector3: {
                        _value.managedReferenceValue = new AttributeVector3();
                        break;
                    }
                    case AttributeType.Vector4: {
                        _value.managedReferenceValue = new AttributeVector4();
                        break;
                    }
                    case AttributeType.Color: {
                        _value.managedReferenceValue = new AttributeColor();
                        break;
                    }
                    case AttributeType.Rect: {
                        _value.managedReferenceValue = new AttributeRect();
                        break;
                    }
                    //case AttributeType.Matrix4x4: {
                    //    _value.managedReferenceValue = new AttributeMatrix4x4();
                    //    break;
                    //}
                    case AttributeType.Object: {
                        _value.managedReferenceValue = new AttributeObject();
                        break;
                    }
                    case AttributeType.GameObject: {
                        _value.managedReferenceValue = new AttributeGameObject();
                        break;
                    }
                    case AttributeType.Component: {
                        _value.managedReferenceValue = new AttributeComponent();
                        break;
                    }
                }
                property.serializedObject.ApplyModifiedPropertiesWithoutUndo();
                EditorUtility.SetDirty(property.serializedObject.targetObject);
            }
            switch (selType) {
                case AttributeType.None: {
                    break;
                }
                case AttributeType.Int: {
                    var i = _value.FindPropertyRelative("_value");
                    i.intValue = EditorGUI.IntField(new Rect(position.x, position.y + 34f, position.width, 16f), "Value", i.intValue);
                    break;
                }
                case AttributeType.Float: {
                    var f = _value.FindPropertyRelative("_value");
                    f.floatValue = EditorGUI.FloatField(new Rect(position.x, position.y + 34f, position.width, 16f), "Value", f.floatValue);
                    break;
                }
                case AttributeType.String: {
                    var str = _value.FindPropertyRelative("_value");
                    str.stringValue = EditorGUI.TextField(new Rect(position.x, position.y + 34f, position.width, 16f), "Value", str.stringValue);
                    break;
                }
                case AttributeType.Vector2: {
                    var vec2 = _value.FindPropertyRelative("_value");
                    vec2.vector2Value = EditorGUI.Vector2Field(new Rect(position.x, position.y + 34f, position.width, 16f), "Value", vec2.vector2Value);
                    break;
                }
                case AttributeType.Vector3: {
                    var vec3 = _value.FindPropertyRelative("_value");
                    vec3.vector3Value = EditorGUI.Vector3Field(new Rect(position.x, position.y + 34f, position.width, 16f), "Value", vec3.vector3Value);
                    break;
                }
                case AttributeType.Vector4: {
                    var vec4 = _value.FindPropertyRelative("_value");
                    vec4.vector4Value = EditorGUI.Vector4Field(new Rect(position.x, position.y + 34f, position.width, 16f), "Value", vec4.vector4Value);
                    break;
                }
                case AttributeType.Color: {
                    var col = _value.FindPropertyRelative("_value");
                    col.colorValue = EditorGUI.ColorField(new Rect(position.x, position.y + 34f, position.width, 16f), "Value", col.colorValue);
                    break;
                }
                case AttributeType.Rect: {
                    var rect = _value.FindPropertyRelative("_value");
                    rect.rectValue = EditorGUI.RectField(new Rect(position.x, position.y + 34f, position.width, 32f), "Value", rect.rectValue);
                    break;
                }
                case AttributeType.Object: {
                    var obj = _value.FindPropertyRelative("_value");
                    obj.objectReferenceValue = EditorGUI.ObjectField(new Rect(position.x, position.y + 34f, position.width, 16f), "Value", obj.objectReferenceValue, typeof(UnityEngine.Object), true);
                    break;
                }
                case AttributeType.GameObject: {
                    EditorGUI.PropertyField(new Rect(position.x, position.y + 34f, position.width, 16f), _value.FindPropertyRelative("_value"));
                    break;
                }
                case AttributeType.Component: {
                    var comp = _value.FindPropertyRelative("_value");
                    comp.objectReferenceValue = EditorGUI.ObjectField(new Rect(position.x, position.y + 34f, position.width, 16f), "Value", comp.objectReferenceValue, typeof(Component), true);
                    break;
                }
            }
        }
        EditorGUI.EndProperty();
    }
}


}
using UnityEngine;
using System;


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
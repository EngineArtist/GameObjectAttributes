using UnityEngine;
using System;


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
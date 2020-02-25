using UnityEngine;
using System;


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
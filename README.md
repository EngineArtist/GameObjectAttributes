# GameObject Attributes

A Component for Unity GameObjects that allows users to store named values to them in UnityEditor.

## Requirements

- Unity 2019.3 or newer

## Installing

Installation happens through Unity's Package Manager. Open the Package Manager -window, click the plus-icon in the top-left corner and select 'Add package from git URL'. In the field, type:
https://github.com/EngineArtist/GameObjectAttributes.git
Now the package should show up in the list of packages and be installed automatically.

## Usage

Once the package has been installed, a new GameObject Component called Attributes should now be available. Select a GameObject you want to add named attributes to and click the Add Component -button in the Inspector. Write 'Attributes' in the search field and select the Attributes -component.

Now that the component has been attached to your GameObject, you can add named fields by opening the Attributes-list and adding elements to it. Each element has a name, a type and a value. Current supported types are:
- int
- float
- string
- Vector2
- Vector3
- Vector4
- Color
- Rect
- Unity.Object
- GameObject
- Component (any type of Unity Component)

## Bugs and limitations

Currently there's a limitation in Unity that has to do with how Prefabs store their fields and changes to them, and this affects Attributes. If you make a Prefab with the Attributes-component, and then make an instance of that prefab, it works fine. However, if you then change the _type_ of an Attribute in the _instance_, that change won't be registered and the Prefab will revert the type back to the original. Changing _values_ works perfectly though.

It's a known limitation and it's on the public issue tracker: https://issuetracker.unity3d.com/issues/cannot-override-type-of-serializedreference-fields-in-prefab-instances?_ga=2.198508135.919109584.1582621529-1278524159.1573762794

## Author

Miika Vihersaari <miika.vihersaari@gmail.com>

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

## Acknowledgements

- Thanks to Unity for making a great engine and editor!
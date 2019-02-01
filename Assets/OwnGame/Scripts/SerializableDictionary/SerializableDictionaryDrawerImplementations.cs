using UnityEngine;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
 
// ---------------
//  String => Int
// ---------------
[UnityEditor.CustomPropertyDrawer(typeof(StringIntDictionary))]
public class StringIntDictionaryDrawer : SerializableDictionaryDrawer<string, int> {
    protected override SerializableKeyValueTemplate<string, int> GetTemplate() {
        return GetGenericTemplate<SerializableStringIntTemplate>();
    }
}
internal class SerializableStringIntTemplate : SerializableKeyValueTemplate<string, int> {}

// ---------------
//  String => String
// ---------------
[UnityEditor.CustomPropertyDrawer(typeof(StringStringDictionary))]
public class StringStringDictionaryDrawer : SerializableDictionaryDrawer<string, string> {
    protected override SerializableKeyValueTemplate<string, string> GetTemplate() {
        return GetGenericTemplate<SerializableStringStringTemplate>();
    }
}
internal class SerializableStringStringTemplate : SerializableKeyValueTemplate<string, string> {}
 
// ---------------
//  GameObject => Float
// ---------------
[UnityEditor.CustomPropertyDrawer(typeof(GameObjectFloatDictionary))]
public class GameObjectFloatDictionaryDrawer : SerializableDictionaryDrawer<GameObject, float> {
    protected override SerializableKeyValueTemplate<GameObject, float> GetTemplate() {
        return GetGenericTemplate<SerializableGameObjectFloatTemplate>();
    }
}
internal class SerializableGameObjectFloatTemplate : SerializableKeyValueTemplate<GameObject, float> {}
#endif
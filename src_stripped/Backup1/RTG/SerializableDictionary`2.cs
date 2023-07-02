// Decompiled with JetBrains decompiler
// Type: RTG.SerializableDictionary`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  [Serializable]
  public class SerializableDictionary<SerializedKeyType, SerializedValueType> : 
    ISerializationCallbackReceiver
  {
    private System.Collections.Generic.Dictionary<SerializedKeyType, SerializedValueType> _dictionary;
    [SerializeField]
    private List<SerializedKeyType> _serializedKeys;
    [SerializeField]
    private List<SerializedValueType> _serializedValues;

    public System.Collections.Generic.Dictionary<SerializedKeyType, SerializedValueType> Dictionary
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SerializedValueType this[SerializedKeyType index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnBeforeSerialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnAfterDeserialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(SerializedKeyType key, SerializedValueType value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsKey(SerializedKeyType key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Copy(
      SerializableDictionary<SerializedKeyType, SerializedValueType> other)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveNullKeys() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializableDictionary() => throw null;
  }
}

// Decompiled with JetBrains decompiler
// Type: DebugDataContextEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class DebugDataContextEntry
{
  public string key;
  public DebugDataContextEntryType valueType;
  private int lastValueType;
  public bool isWritable;
  public string stringValue;
  public bool boolValue;
  public int intValue;
  public float floatValue;
  public Color colorValue;
  public Vector3 vector3Value;
  public Quaternion quaternionValue;
  public string enumValue;
  public IPropertyWritable Property;
  private Action PropertyValidate;

  public object Value
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ValidateProperty() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IPropertyWritable MakeProperty(out Action validate) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DebugDataContextEntry() => throw null;
}

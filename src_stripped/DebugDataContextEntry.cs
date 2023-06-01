// Decompiled with JetBrains decompiler
// Type: DebugDataContextEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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

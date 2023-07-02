// Decompiled with JetBrains decompiler
// Type: DebugDataContextEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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

// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.SerializedControllerProperty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  [Serializable]
  public class SerializedControllerProperty
  {
    public SerializedControlerPropertyType SerializedControlerPropertyType;
    public string PropertyName;
    public string PropertyDescription;
    public string PropertyInfo;
    public int IntValue;
    public int IntMinValue;
    public int IntMaxValue;
    public float FloatValue;
    public float FloatMinValue;
    public float FloatMaxValue;
    public Color ColorValue;
    public bool BoolValue;
    public Texture2D TextureValue;
    public List<string> StringList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedControllerProperty(SerializedControllerProperty original) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedControllerProperty() => throw null;
  }
}

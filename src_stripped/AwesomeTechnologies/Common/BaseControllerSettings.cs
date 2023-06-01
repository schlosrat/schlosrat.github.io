// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Common.BaseControllerSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Common
{
  [Serializable]
  public class BaseControllerSettings
  {
    [SerializeField]
    public List<SerializedControllerProperty> ControlerPropertyList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddFloatProperty(
      string id,
      string description,
      string info,
      float defaultValue,
      float minValue,
      float maxValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddLabelProperty(string text) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddTextureProperty(
      string id,
      string description,
      string info,
      Texture2D defaultValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddRgbaSelectorProperty(
      string id,
      string description,
      string info,
      int defaultValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddColorProperty(string id, string description, string info, Color defaultValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddBooleanProperty(string id, string description, string info, bool defaultValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetIntPropertyValue(string propertyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetFloatPropertyValue(string propertyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Color GetColorPropertyValue(string propertyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetBooleanPropertyValue(string propertyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Texture2D GetTexturePropertyValue(string propertyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BaseControllerSettings() => throw null;
  }
}

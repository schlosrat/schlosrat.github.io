// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.Binding.ContextNestedHierarchyExample
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Iteration.UI.Binding
{
  public class ContextNestedHierarchyExample : MonoBehaviour
  {
    public ContextBindRoot listBindRoot;
    public List<ContextNestedHierarchyExample.ObjectInput> inputs;
    private ContextNestedHierarchyExample.ObjectData rootObject;
    private Dictionary<string, ContextNestedHierarchyExample.ObjectData> _nameObjectScratch;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ParseInspectorInputsToContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ParseContextToInspector() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContextNestedHierarchyExample() => throw null;

    [Serializable]
    public struct ObjectInput
    {
      public string name;
      public string parent;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ObjectInput(string name, string parent = null) => throw null;
    }

    public class ObjectData : ApiDataContext
    {
      [DataProperty("name")]
      public Property<string> name;
      [DataProperty("parent")]
      public PropertyReadonly<ContextNestedHierarchyExample.ObjectData> parent;
      [DataProperty("haveParent")]
      public PropertyReadonly<bool> haveParent;
      [DataList("children")]
      public ContextListProperty<ContextNestedHierarchyExample.ObjectData> children;
      [DataProperty("haveChildren")]
      public PropertyReadonly<bool> haveChildren;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ObjectData(string name, ContextNestedHierarchyExample.ObjectData parent = null) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetParent(ContextNestedHierarchyExample.ObjectData newParent) => throw null;

      [DataAction("addChild")]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public void DebugAddChild() => throw null;

      [DataAction("deleteChildAt")]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public void DebugDeleteChild(int index) => throw null;
    }
  }
}

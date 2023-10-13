// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ObjectComponentDefRegistry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public class ObjectComponentDefRegistry
  {
    private static ObjectComponentDefRegistry gInstance;
    public const int OBJECT_COMPONENT_DEF_LOOKUP_ID_NONE = 0;
    private List<ObjectComponent> _objectComponentList;

    public static ObjectComponentDefRegistry Instance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int NumRegisteredObjectComponents
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectComponentDefRegistry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~ObjectComponentDefRegistry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Empty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterObjectComponents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterObjectComponents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectComponent FindObjectComponentByIndex(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectComponent FindObjectComponentBySystemType(Type systemType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectComponent FindObjectComponentBySystemTypeString(string systemTypeString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterObjectComponent(ObjectComponent objectComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterObjectComponent(ObjectComponent objectComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterObjectComponent(Type systemType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterObjectComponent(string systemTypeString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoopThroughAllRegisteredObjectComponents(
      ObjectComponentDefRegistry.LoopThroughObjectComponentsCallback callback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetObjectComponentDefLookupId(ObjectComponent objectComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectComponent FindObjectComponentDefByObjectComponentDefLookupId(
      int objectComponentDefLookupId)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetFormatString(bool multiline) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ObjectComponentDefRegistry() => throw null;

    public delegate void LoopThroughObjectComponentsCallback(
      ObjectComponent objectComponent,
      int componentIndex);
  }
}

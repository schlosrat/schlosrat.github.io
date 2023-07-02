// Decompiled with JetBrains decompiler
// Type: KSP.Messages.SelectedDiscoverableProperty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages.PropertyWatchers;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Messages
{
  [Serializable]
  public struct SelectedDiscoverableProperty
  {
    [SerializeField]
    private string _discoveryName;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SelectedDiscoverableProperty(string propertyDiscoveryName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SelectedDiscoverableProperty(System.Type discoverablePropertyType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeForType<T>() where T : PropertyWatcher, new() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public System.Type GetStoredType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SelectedDiscoverableProperty CreateFor<T>() where T : PropertyWatcher, new() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SelectedDiscoverableProperty CreateFor(string discoveryName) => throw null;
  }
}

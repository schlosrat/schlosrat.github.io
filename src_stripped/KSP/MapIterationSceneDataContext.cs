// Decompiled with JetBrains decompiler
// Type: KSP.MapIterationSceneDataContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api;
using KSP.Api.CoreTypes;
using KSP.Map;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;

namespace KSP
{
  public class MapIterationSceneDataContext : DebugUIContextInstanced
  {
    public MapItemType mapItemType;
    public ContextBindRoot entryBindRoot;
    private MapItemType lastItemType;
    private Property<MapItemType> itemTypes;
    private string typeKey;

    private IDataContext TestDataContext
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapIterationSceneDataContext() => throw null;
  }
}

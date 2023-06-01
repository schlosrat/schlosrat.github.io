// Decompiled with JetBrains decompiler
// Type: RTG.SceneRaycastHit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace RTG
{
  public class SceneRaycastHit
  {
    private GameObjectRayHit _objectHit;
    private XZGridRayHit _gridHit;

    public bool WasAnythingHit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool WasAnObjectHit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool WasGridHit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameObjectRayHit ObjectHit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public XZGridRayHit GridHit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SceneRaycastHit(GameObjectRayHit objectRayHit, XZGridRayHit gridRayHit) => throw null;
  }
}

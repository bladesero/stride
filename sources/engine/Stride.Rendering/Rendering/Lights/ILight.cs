// Copyright (c) Stride contributors (https://stride3d.net) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

using Stride.Engine;

namespace Stride.Rendering.Lights
{
    /// <summary>
    /// Base interface for all lights.
    /// </summary>
    public interface ILight
    {
        bool Update(RenderLight light);
    }
}
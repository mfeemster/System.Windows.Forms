// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Drawing.Drawing2D
{
    public sealed class GraphicsContainer : MarshalByRefObject
    {
        internal GraphicsContainer(int graphicsContainer) => nativeGraphicsContainer = graphicsContainer;

        internal int nativeGraphicsContainer;
    }
}

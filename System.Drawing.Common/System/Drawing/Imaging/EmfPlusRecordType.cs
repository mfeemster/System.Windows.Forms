// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Drawing.Imaging
{
    /// <summary>
    /// Specifies the methods available in a metafile to read and write graphic commands.
    /// </summary>
    public enum EmfPlusRecordType
    {
        WmfRecordBase = 0x00010000,
        WmfSetBkColor = WmfRecordBase | 0x201,
        WmfSetBkMode = WmfRecordBase | 0x102,
        WmfSetMapMode = WmfRecordBase | 0x103,
        WmfSetROP2 = WmfRecordBase | 0x104,
        WmfSetRelAbs = WmfRecordBase | 0x105,
        WmfSetPolyFillMode = WmfRecordBase | 0x106,
        WmfSetStretchBltMode = WmfRecordBase | 0x107,
        WmfSetTextCharExtra = WmfRecordBase | 0x108,
        WmfSetTextColor = WmfRecordBase | 0x209,
        WmfSetTextJustification = WmfRecordBase | 0x20A,
        WmfSetWindowOrg = WmfRecordBase | 0x20B,
        WmfSetWindowExt = WmfRecordBase | 0x20C,
        WmfSetViewportOrg = WmfRecordBase | 0x20D,
        WmfSetViewportExt = WmfRecordBase | 0x20E,
        WmfOffsetWindowOrg = WmfRecordBase | 0x20F,
        WmfScaleWindowExt = WmfRecordBase | 0x410,
        WmfOffsetViewportOrg = WmfRecordBase | 0x211,
        WmfScaleViewportExt = WmfRecordBase | 0x412,
        WmfLineTo = WmfRecordBase | 0x213,
        WmfMoveTo = WmfRecordBase | 0x214,
        WmfExcludeClipRect = WmfRecordBase | 0x415,
        WmfIntersectClipRect = WmfRecordBase | 0x416,
        WmfArc = WmfRecordBase | 0x817,
        WmfEllipse = WmfRecordBase | 0x418,
        WmfFloodFill = WmfRecordBase | 0x419,
        WmfPie = WmfRecordBase | 0x81A,
        WmfRectangle = WmfRecordBase | 0x41B,
        WmfRoundRect = WmfRecordBase | 0x61C,
        WmfPatBlt = WmfRecordBase | 0x61D,
        WmfSaveDC = WmfRecordBase | 0x01E,
        WmfSetPixel = WmfRecordBase | 0x41F,
        WmfOffsetCilpRgn = WmfRecordBase | 0x220,
        WmfTextOut = WmfRecordBase | 0x521,
        WmfBitBlt = WmfRecordBase | 0x922,
        WmfStretchBlt = WmfRecordBase | 0xB23,
        WmfPolygon = WmfRecordBase | 0x324,
        WmfPolyline = WmfRecordBase | 0x325,
        WmfEscape = WmfRecordBase | 0x626,
        WmfRestoreDC = WmfRecordBase | 0x127,
        WmfFillRegion = WmfRecordBase | 0x228,
        WmfFrameRegion = WmfRecordBase | 0x429,
        WmfInvertRegion = WmfRecordBase | 0x12A,
        WmfPaintRegion = WmfRecordBase | 0x12B,
        WmfSelectClipRegion = WmfRecordBase | 0x12C,
        WmfSelectObject = WmfRecordBase | 0x12D,
        WmfSetTextAlign = WmfRecordBase | 0x12E,
        WmfChord = WmfRecordBase | 0x830,
        WmfSetMapperFlags = WmfRecordBase | 0x231,
        WmfExtTextOut = WmfRecordBase | 0xA32,
        WmfSetDibToDev = WmfRecordBase | 0xD33,
        WmfSelectPalette = WmfRecordBase | 0x234,
        WmfRealizePalette = WmfRecordBase | 0x035,
        WmfAnimatePalette = WmfRecordBase | 0x436,
        WmfSetPalEntries = WmfRecordBase | 0x037,
        WmfPolyPolygon = WmfRecordBase | 0x538,
        WmfResizePalette = WmfRecordBase | 0x139,
        WmfDibBitBlt = WmfRecordBase | 0x940,
        WmfDibStretchBlt = WmfRecordBase | 0xb41,
        WmfDibCreatePatternBrush = WmfRecordBase | 0x142,
        WmfStretchDib = WmfRecordBase | 0xf43,
        WmfExtFloodFill = WmfRecordBase | 0x548,
        WmfSetLayout = WmfRecordBase | 0x149, // META_SETLAYOUT
        WmfDeleteObject = WmfRecordBase | 0x1f0,
        WmfCreatePalette = WmfRecordBase | 0x0f7,
        WmfCreatePatternBrush = WmfRecordBase | 0x1f9,
        WmfCreatePenIndirect = WmfRecordBase | 0x2fa,
        WmfCreateFontIndirect = WmfRecordBase | 0x2fb,
        WmfCreateBrushIndirect = WmfRecordBase | 0x2fc,
        WmfCreateRegion = WmfRecordBase | 0x6ff,

        // Since we have to enumerate GDI records right along with GDI+ records,
        // we list all the GDI records here so that they can be part of the
        // same enumeration type which is used in the enumeration callback.

        EmfHeader = 1,
        EmfPolyBezier = 2,
        EmfPolygon = 3,
        EmfPolyline = 4,
        EmfPolyBezierTo = 5,
        EmfPolyLineTo = 6,
        EmfPolyPolyline = 7,
        EmfPolyPolygon = 8,
        EmfSetWindowExtEx = 9,
        EmfSetWindowOrgEx = 10,
        EmfSetViewportExtEx = 11,
        EmfSetViewportOrgEx = 12,
        EmfSetBrushOrgEx = 13,
        EmfEof = 14,
        EmfSetPixelV = 15,
        EmfSetMapperFlags = 16,
        EmfSetMapMode = 17,
        EmfSetBkMode = 18,
        EmfSetPolyFillMode = 19,
        EmfSetROP2 = 20,
        EmfSetStretchBltMode = 21,
        EmfSetTextAlign = 22,
        EmfSetColorAdjustment = 23,
        EmfSetTextColor = 24,
        EmfSetBkColor = 25,
        EmfOffsetClipRgn = 26,
        EmfMoveToEx = 27,
        EmfSetMetaRgn = 28,
        EmfExcludeClipRect = 29,
        EmfIntersectClipRect = 30,
        EmfScaleViewportExtEx = 31,
        EmfScaleWindowExtEx = 32,
        EmfSaveDC = 33,
        EmfRestoreDC = 34,
        EmfSetWorldTransform = 35,
        EmfModifyWorldTransform = 36,
        EmfSelectObject = 37,
        EmfCreatePen = 38,
        EmfCreateBrushIndirect = 39,
        EmfDeleteObject = 40,
        EmfAngleArc = 41,
        EmfEllipse = 42,
        EmfRectangle = 43,
        EmfRoundRect = 44,
        EmfRoundArc = 45,
        EmfChord = 46,
        EmfPie = 47,
        EmfSelectPalette = 48,
        EmfCreatePalette = 49,
        EmfSetPaletteEntries = 50,
        EmfResizePalette = 51,
        EmfRealizePalette = 52,
        EmfExtFloodFill = 53,
        EmfLineTo = 54,
        EmfArcTo = 55,
        EmfPolyDraw = 56,
        EmfSetArcDirection = 57,
        EmfSetMiterLimit = 58,
        EmfBeginPath = 59,
        EmfEndPath = 60,
        EmfCloseFigure = 61,
        EmfFillPath = 62,
        EmfStrokeAndFillPath = 63,
        EmfStrokePath = 64,
        EmfFlattenPath = 65,
        EmfWidenPath = 66,
        EmfSelectClipPath = 67,
        EmfAbortPath = 68,
        EmfReserved069 = 69,
        EmfGdiComment = 70,
        EmfFillRgn = 71,
        EmfFrameRgn = 72,
        EmfInvertRgn = 73,
        EmfPaintRgn = 74,
        EmfExtSelectClipRgn = 75,
        EmfBitBlt = 76,
        EmfStretchBlt = 77,
        EmfMaskBlt = 78,
        EmfPlgBlt = 79,
        EmfSetDIBitsToDevice = 80,
        EmfStretchDIBits = 81,
        EmfExtCreateFontIndirect = 82,
        EmfExtTextOutA = 83,
        EmfExtTextOutW = 84,
        EmfPolyBezier16 = 85,
        EmfPolygon16 = 86,
        EmfPolyline16 = 87,
        EmfPolyBezierTo16 = 88,
        EmfPolylineTo16 = 89,
        EmfPolyPolyline16 = 90,
        EmfPolyPolygon16 = 91,
        EmfPolyDraw16 = 92,
        EmfCreateMonoBrush = 93,
        EmfCreateDibPatternBrushPt = 94,
        EmfExtCreatePen = 95,
        EmfPolyTextOutA = 96,
        EmfPolyTextOutW = 97,
        EmfSetIcmMode = 98,  // EMR_SETICMMODE,
        EmfCreateColorSpace = 99,  // EMR_CREATECOLORSPACE,
        EmfSetColorSpace = 100, // EMR_SETCOLORSPACE,
        EmfDeleteColorSpace = 101, // EMR_DELETECOLORSPACE,
        EmfGlsRecord = 102, // EMR_GLSRECORD,
        EmfGlsBoundedRecord = 103, // EMR_GLSBOUNDEDRECORD,
        EmfPixelFormat = 104, // EMR_PIXELFORMAT,
        EmfDrawEscape = 105, // EMR_RESERVED_105,
        EmfExtEscape = 106, // EMR_RESERVED_106,
        EmfStartDoc = 107, // EMR_RESERVED_107,
        EmfSmallTextOut = 108, // EMR_RESERVED_108,
        EmfForceUfiMapping = 109, // EMR_RESERVED_109,
        EmfNamedEscpae = 110, // EMR_RESERVED_110,
        EmfColorCorrectPalette = 111, // EMR_COLORCORRECTPALETTE,
        EmfSetIcmProfileA = 112, // EMR_SETICMPROFILEA,
        EmfSetIcmProfileW = 113, // EMR_SETICMPROFILEW,
        EmfAlphaBlend = 114, // EMR_ALPHABLEND,
        EmfSetLayout = 115, // EMR_SETLAYOUT,
        EmfTransparentBlt = 116, // EMR_TRANSPARENTBLT,
        EmfReserved117 = 117,
        EmfGradientFill = 118, // EMR_GRADIENTFILL,
        EmfSetLinkedUfis = 119, // EMR_RESERVED_119,
        EmfSetTextJustification = 120, // EMR_RESERVED_120,
        EmfColorMatchToTargetW = 121, // EMR_COLORMATCHTOTARGETW,
        EmfCreateColorSpaceW = 122, // EMR_CREATECOLORSPACEW,
        EmfMax = 122,
        EmfMin = 1,

        // That is the END of the GDI EMF records.

        // Now we start the list of EMF+ records.  We leave quite
        // a bit of room here for the addition of any new GDI
        // records that may be added later.

        EmfPlusRecordBase = 0x00004000,
        Invalid = EmfPlusRecordBase,
        Header,
        EndOfFile,

        Comment,

        GetDC,    // the application grabbed the metafile dc

        MultiFormatStart,
        MultiFormatSection,
        MultiFormatEnd,

        // For all Persistent Objects
        Object,
        // Drawing Records
        Clear,
        FillRects,
        DrawRects,
        FillPolygon,
        DrawLines,
        FillEllipse,
        DrawEllipse,
        FillPie,
        DrawPie,
        DrawArc,
        FillRegion,
        FillPath,
        DrawPath,
        FillClosedCurve,
        DrawClosedCurve,
        DrawCurve,
        DrawBeziers,
        DrawImage,
        DrawImagePoints,
        DrawString,

        // Graphics State Records
        SetRenderingOrigin,
        SetAntiAliasMode,
        SetTextRenderingHint,
        SetTextContrast,
        SetInterpolationMode,
        SetPixelOffsetMode,
        SetCompositingMode,
        SetCompositingQuality,
        Save,
        Restore,
        BeginContainer,
        BeginContainerNoParams,
        EndContainer,
        SetWorldTransform,
        ResetWorldTransform,
        MultiplyWorldTransform,
        TranslateWorldTransform,
        ScaleWorldTransform,
        RotateWorldTransform,
        SetPageTransform,
        ResetClip,
        SetClipRect,
        SetClipPath,
        SetClipRegion,
        OffsetClip,

        DrawDriverString,

        Total,

        Max = Total - 1,
        Min = Header
    }
}

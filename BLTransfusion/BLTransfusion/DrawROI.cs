using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HalconDotNet;

namespace BLTransfusion
{
    public class DrawROI
    {
        public static RectangleInfo DrawRectangle(HWindow windowHandle)
        {
            double hv_Row1, hv_Column1, hv_Row2, hv_Column2;
            windowHandle.SetLineWidth(2);
            windowHandle.SetDraw("margin");
            windowHandle.SetColor("red");

            windowHandle.DrawRectangle1(out hv_Row1, out hv_Column1, out hv_Row2, out hv_Column2);

            HObject ho_Rectangle;
            HOperatorSet.GenRectangle1(out ho_Rectangle, hv_Row1, hv_Column1, hv_Row2, hv_Column2);

            windowHandle.SetLineWidth(3);
            windowHandle.SetDraw("margin");
            windowHandle.SetColor("blue");
            windowHandle.DispObj(ho_Rectangle);

            var rectInfo = new RectangleInfo()
            {
                RowTop = hv_Row1,
                ColumnLeft = hv_Column1,
                RowBottom = hv_Row2,
                ColumnRight = hv_Column2,
            };
            return rectInfo;
        }
    }
}

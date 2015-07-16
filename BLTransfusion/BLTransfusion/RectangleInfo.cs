using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace BLTransfusion
{
    public class RectangleInfo : INotifyPropertyChanged
    {
        public override string ToString()
        {
            return string.Format(
@"RowTop = {0}
ColumnLeft= {1}
RowBottom = {2}
ColumnRight = {3}", this.RowTop, this.ColumnLeft, this.RowBottom, this.ColumnRight);
        }

        //ROI Retangle
        private double rowTop;
        public double RowTop
        {
            get { return rowTop; }
            set { rowTop = value; OnPropertyChanged("RowTop"); }
        }

        private double columnLeft;
        public double ColumnLeft
        {
            get { return columnLeft; }
            set { columnLeft = value; OnPropertyChanged("ColumnLeft"); }
        }

        private double rowBottom;
        public double RowBottom
        {
            get { return rowBottom; }
            set { rowBottom = value; OnPropertyChanged("RowBottom"); }
        }
        private double columnRight;
        public double ColumnRight
        {
            get { return columnRight; }
            set { columnRight = value; OnPropertyChanged("ColumnRight"); }
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}

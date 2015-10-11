using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Linq;

namespace BLTransfusion.Model
{
    public class ModelInfo : INotifyPropertyChanged
    {
        public override string ToString()
        {
            return string.Format("RowTop = {0}\r\nColumnLeft= {1}\r\nRowBottom = {2}\r\nColumnRight = {3}", this.RowTop, this.ColumnLeft, this.RowBottom, this.ColumnRight);
        }

        public virtual XElement ToXElement()
        {
            var element = new XElement("ModelInfo");

            //icXElement.Add(new XAttribute("Label", this.Label.ToString()));    

            element.Add(new XElement("RowTop", this.RowTop.ToString()));
            element.Add(new XElement("RowBottom", this.RowBottom.ToString()));

            element.Add(new XElement("ColumnLeft", this.ColumnLeft.ToString()));
            element.Add(new XElement("ColumnRight", this.ColumnRight.ToString()));

            return element;
        }

        public virtual bool FromXElement(XElement element)
        {
            try
            {
                //this.Label = icXElement.Attribute("Label").Value;

                this.RowTop = double.Parse(element.Element("RowTop").Value);
                this.RowBottom = double.Parse(element.Element("RowBottom").Value);
                this.ColumnLeft = double.Parse(element.Element("ColumnLeft").Value);
                this.ColumnRight = double.Parse(element.Element("ColumnRight").Value);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public string Label
        {
            get
            {
                return this.ToString();
            }
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

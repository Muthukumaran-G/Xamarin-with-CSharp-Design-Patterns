using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace XamDesignPattern
{
    public class AdaptorViewModel
    {
        public ObservableCollection<string> Collection { get; set; }

        public AdaptorViewModel()
        {
            Collection = new ObservableCollection<string>();
            Shapes shape = new Shapes();
            Collection.Add(shape.DrawShape(new Circle())); 
            Collection.Add(shape.DrawShape(new Square()));
            Collection.Add(shape.DrawShape(new Oval()));
        }
    }

    public class Shapes
    {
        public string DrawShape(IDraw obj)
        {
            return DrawAdaptor.Draw(obj);
        }
    }

    class DrawAdaptor : IDraw
    {
        public string Draw() { return null; }
        public static string Draw(IDraw obj)
        {
            return obj.Draw();
        }
    }
}

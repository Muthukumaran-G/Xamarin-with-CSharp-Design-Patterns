using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace XamDesignPattern
{
    public class CompositeViewModel
    {
        public ObservableCollection<string> Collection { get; set; }

        public CompositeViewModel()
        {
            ArrayList list = new ArrayList();
            IDraw circle = new Circle();
            IDraw square = new Square();
            IDraw oval = new Oval();
            list.Add(circle);
            list.Add(square);
            list.Add(oval);
            Collection = new ObservableCollection<string>();

            for (int i = 0; i < list.Count; i++)
            {
                Collection.Add((list[i] as IDraw).Draw());
            }
        }
    }

    public interface IDraw
    {
        string Draw();
    }

    public class Circle : IDraw
    {
        public string Draw()
        {
            return "Circle Drawn";
        }
    }

    public class Square : IDraw
    {
        public string Draw()
        {
            return "Square Drawn";
        }
    }
    
    public class Oval : IDraw
    {
        public string Draw()
        {
            return "Oval Drawn";
        }
    }
}

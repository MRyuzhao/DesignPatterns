using System;
using System.Collections;
using System.Collections.Generic;

namespace Composite_10
{
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual MenuComponent GetChild(int i)
        {
            throw new NotSupportedException();
        }

        public virtual IEnumerator<MenuComponent> CreateEnumerator()
        {
            return new NullEnumerator();
        }

        public virtual string Name => throw new NotSupportedException();
        public virtual string Description => throw new NotSupportedException();
        public virtual double Price => throw new NotSupportedException();
        public virtual bool IsVegetarian => throw new NotSupportedException();

        public virtual void Print()
        {
            throw new NotSupportedException();
        }
    }

    public class NullEnumerator : IEnumerator<MenuComponent>
    {
        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {

        }

        public MenuComponent Current => null;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}
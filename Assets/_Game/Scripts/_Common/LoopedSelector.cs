using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is a collection of items where you can loop through to get
/// the current selection. This would come in handy if you want to rotate
/// selection through a list of items
/// </summary>
/// <typeparam name="T"></typeparam>
public class LoopedSelector<T>
{
    // we kind of want a queue, but we may need to remove objects from the middle
    // so we'll be faking it with a List
    List<T> _items = new List<T>();

    int _selectionIndex = 0;
    public T CurrentSelection => _items[_selectionIndex];

    public bool HasItems()
    {
        if (_items.Count >= 0)
            return true;
        else
            return false;
    }

    public void Add(T item)
    {
        _items.Add(item);
    }

    // look through Unit List and remove the requested unit
    public void Remove(T item)
    {
        // if no items, or item not contained in list
        if (!HasItems() || !_items.Contains(item))
        {
            Debug.LogWarning("Cannot remove item, not in list");
            return;
        }

        _items.Remove(item);
    }

    public T SelectNext()
    {
        if (!HasItems())
        {
            Debug.LogWarning("Cannot retrieve item, nothing in list");
            return default(T);
        }
            
        // if we're at the end of our index range, loop back to beginning
        if(_selectionIndex >= _items.Count - 1)
        {
            _selectionIndex = 0;
        }
        // otherwise increase it
        else
        {
            _selectionIndex++;
        }

        return _items[_selectionIndex];
    }

    public T SelectPrevious()
    {
        if (!HasItems())
        {
            Debug.LogWarning("Cannot retrieve item, nothing in list");
            return default(T);
        }

        if (_selectionIndex <= 0)
            _selectionIndex = _items.Count - 1;
        else
            _selectionIndex--;

        return _items[_selectionIndex];
    }
}



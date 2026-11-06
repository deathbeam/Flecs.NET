using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Flecs.NET.Utilities;

/// <summary>
///     An unmanaged alternative to <see cref="List{T}"/>.
/// </summary>
/// <typeparam name="T"></typeparam>
internal unsafe struct NativeList<T> : IEnumerable<T>, IDisposable where T : unmanaged
{
    /// <summary>
    ///     Data storage for the <see cref="NativeList{T}"/>.
    /// </summary>
    public T* Data { get; private set; }

    /// <summary>
    ///     The capacity of the <see cref="NativeList{T}"/>.
    /// </summary>
    public int Capacity { get; private set; }

    /// <summary>
    ///     The current count of the <see cref="NativeList{T}"/>.
    /// </summary>
    public int Count { get; private set; }

    /// <summary>
    ///     Represents whether or not the <see cref="NativeList{T}"/> is null.
    /// </summary>
    public readonly bool IsNull => Data == null;

    /// <summary>
    ///     Creates an <see cref="NativeList{T}"/> with the specified capacity.
    /// </summary>
    /// <param name="capacity"></param>
    public NativeList(int capacity)
    {
        if (capacity <= 0)
        {
            Data = null;
            Capacity = default;
            Count = default;
        }

        Data = Memory.AllocZeroed<T>(capacity);
        Capacity = capacity;
        Count = 0;
    }

    /// <summary>
    ///     Gets a managed reference to the object at the specified index.
    /// </summary>
    /// <param name="index"></param>
    /// <exception cref="ArgumentException"></exception>
    public readonly ref T this[int index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if ((uint)index >= (uint)Count || index < 0)
                throw new ArgumentException($"List index {index} is out of range.", nameof(index));

            return ref Data[index];
        }
    }

    /// <summary>
    ///     Disposes the <see cref="NativeList{T}"/> and frees resources.
    /// </summary>
    public void Dispose()
    {
        if (Data == null)
            return;

        Memory.Free(Data);
        Data = null;
    }

    /// <summary>
    ///     Adds an item to the <see cref="NativeList{T}"/>.
    /// </summary>
    /// <param name="item"></param>
    public void Add(T item)
    {
        if (Count == Capacity)
            EnsureCapacity(Count + 1);

        Data[Count++] = item;
    }

    /// <summary>
    ///     Ensures that the list has the specified capacity.
    /// </summary>
    /// <param name="newCapacity"></param>
    public void EnsureCapacity(int newCapacity)
    {
        if (Capacity >= newCapacity)
            return;

        int nextPowOf2 = Utils.NextPowOf2(newCapacity);
        Data = Memory.Realloc(Data, nextPowOf2);
        Capacity = nextPowOf2;
    }

    /// <summary>
    ///     Ensures that the list has the specified count.
    /// </summary>
    /// <param name="newCount"></param>
    public void EnsureCount(int newCount)
    {
        EnsureCapacity(newCount);

        if (newCount <= Count)
            return;

        for (; Count < newCount; Count++)
            Data[Count] = default;
    }

    /// <summary>
    ///     Returns the zero-based index of the first occurrence of a value in the <see cref="NativeList{T}"/>.
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public int IndexOf(T item)
    {
        for (int i = 0; i < Count; i++)
            if (EqualityComparer<T>.Default.Equals(Data[i], item))
                return i;

        return -1;
    }

    /// <summary>
    ///     Removes the first occurrence of a value from the <see cref="NativeList{T}"/> by replacing it with the last item.
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public bool Remove(T item)
    {
        int index = IndexOf(item);
        if (index == -1)
            return false;

        Data[index] = Data[--Count];
        return true;
    }

    /// <summary>
    ///     Returns an enumerator that iterates through the <see cref="NativeList{T}"/>.
    /// </summary>
    /// <returns></returns>
    public Enumerator GetEnumerator()
    {
        return new Enumerator(this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <summary>
    ///     Enumerates the elements of a <see cref="NativeList{T}"/>.
    /// </summary>
    public struct Enumerator : IEnumerator<T>
    {
        private readonly NativeList<T> _list;
        private readonly int _length;
        private int _currentIndex;

        internal Enumerator(NativeList<T> list)
        {
            _list = list;
            _length = list.Count;
            _currentIndex = -1;
        }

        object IEnumerator.Current => Current;

        /// <summary>
        ///     Current item.
        /// </summary>
        public T Current => _list.Data[_currentIndex];

        /// <summary>
        ///     Moves to the next index of the <see cref="NativeList{T}"/>.
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            _currentIndex++;
            return _currentIndex < _length;
        }

        /// <summary>
        ///     Resets the index of the enumerator.
        /// </summary>
        public void Reset()
        {
            _currentIndex = -1;
        }

        /// <summary>
        /// </summary>
        public void Dispose()
        {
        }
    }
}
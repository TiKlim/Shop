﻿using System;

namespace Shop;

public class Type
{
    private int _id;
    private string _type;

    public Type(int id2, string type)
    {
        Id = id2;
        Type1 = type;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Type1
    {
        get => _type;
        set => _type = value ?? throw new ArgumentNullException(nameof(value));
    }
}
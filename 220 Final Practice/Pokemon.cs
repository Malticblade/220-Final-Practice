using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Pokemon : ICloneable
{
    public Pokemon() { }

    public Pokemon(int ID, string Name, string Type, int HP, double Height, double Weight)
    {
        _pokeName = Name;
        _pokeType = Type;
        _pokeHP = HP;
        _pokeHeight = Height;
        _pokeWeigh = Weight;

    }
    
    private string _pokeName;
    public string Name
    {
        get { return _pokeName; }
        set { _pokeName = value; }
    }
    private string _pokeType;
    public string Type
    {
        get { return _pokeType; }
        set { _pokeType = value; }
    }
    private int _pokeHP;
    public int HP
    {
        get { return _pokeHP; }
        set { _pokeHP = value; }
    }
    private double _pokeHeight;
    public double Height
    {
        get { return _pokeHeight; }
        set { _pokeHeight = value; }
    }
    private double _pokeWeigh;
    public double Weight
    {
        get { return _pokeWeigh; }
        set { _pokeWeigh = value; }
    }
    public object Clone()
    {
        Pokemon p = new Pokemon();
        p.Name = this.Name;
        p.Type = this.Type;
        p.HP = this.HP;
        p.Height = this.Height;
        p.Weight = this.Weight;
        return p;
    }
}


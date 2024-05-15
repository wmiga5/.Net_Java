package org.example;

public class item
{
   public int wartosc;
    public int waga;
    public int index;
    public item(int wartosc, int waga,int index)
    {
        this.wartosc = wartosc;
        this.waga = waga;
        this.index = index;
    }
    @Override
    public String toString()
    {
        StringBuilder sb=new StringBuilder();
        sb.append(index+". wartosc: "+wartosc);
        sb.append("----waga: "+waga+"\n");
        return sb.toString();
    }

}

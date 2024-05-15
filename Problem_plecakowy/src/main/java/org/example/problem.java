package org.example;

import java.beans.PropertyEditorSupport;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class problem {
    public int ilosc;
    public int ziarno;
    public int dolna_granica;
    public int gorna_granica;
    public List<item> rzeczy=new ArrayList<item>();
  public problem(int ilosc,int ziarno,int dolna_granica,int gorna_granica)
    {
        this.ilosc=ilosc;
        this.ziarno=ziarno;
        this.dolna_granica=dolna_granica;
        this.gorna_granica=gorna_granica;

        Random rand = new Random(ziarno);

        for(int i=0;i<ilosc;i++)
        {
            rzeczy.add(new item(rand.nextInt(gorna_granica-dolna_granica+1)+dolna_granica,
                    rand.nextInt(gorna_granica-dolna_granica+1)+dolna_granica,i));
        }



    }

    public List<item> rozwiazuj(int rozmiar)
    {
        List<item> zwracam=new ArrayList<>();

        List<item> posortowana=new ArrayList<item>(rzeczy);
        posortowana.sort((a, b) -> Double.compare((double) b.wartosc/b.waga,(double)a.wartosc/a.waga));
        ;
        for(int i=0;i<posortowana.size();i++)
        {

            while (rozmiar>=posortowana.get(i).waga)
            {
                zwracam.add(posortowana.get(i));
                rozmiar-=posortowana.get(i).waga;
            }

        }


        return zwracam;
    }

    @Override
    public String toString()
    {
        StringBuilder sb=new StringBuilder();
        sb.append("ilosc: "+ilosc);
        sb.append("\nziarno: "+ziarno);
        sb.append("\ndolna_granica: "+dolna_granica);
        sb.append("\ngorna_granica: "+gorna_granica);
        for(item i:rzeczy)
        {
            sb.append("\nrzeczy: "+i);
        }

        return sb.toString();
    }



}

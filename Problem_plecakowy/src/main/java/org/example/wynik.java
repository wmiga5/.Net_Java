package org.example;

import java.util.ArrayList;
import java.util.List;

public class wynik {
    public List<item> wyniki;

    public wynik(List<item> wyniki) {this.wyniki=wyniki;}
    @Override
    public String toString()
    {
        StringBuilder sb=new StringBuilder();
        sb.append("wyniki:\n");
        for(item i:wyniki)
        {
            sb.append("\t"+i+"\n");
        }
        return sb.toString();
    }
}

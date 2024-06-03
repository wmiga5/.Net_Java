package org.example;

import org.junit.Assert;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class problemTest {

    @Test
        public void Czy_jeden()
    {
        problem pr1=new problem(1,1,1,2);
        Assert.assertTrue(!pr1.rozwiazuj(10).isEmpty());
    }
    @Test
        public void Czy_puste()
    {
        problem pr1=new problem(1,1,10,11);
        Assert.assertTrue(pr1.rozwiazuj(1).isEmpty());
    }
    @Test
        public void Czy_dobrze_losuje()
    {
        problem pr1=new problem(1,1,1,5);
        for (item i:pr1.rzeczy)
        {
            Assert.assertTrue(i.waga>=1&&i.waga<=5);
            Assert.assertTrue(i.wartosc>=1&&i.wartosc<=5);
        }
    }
    @Test
        public void Czy_dobrze_rozwiazuje()
    {   int suma=0;
        problem pr1=new problem(5,1,1,5);
        for(item i:pr1.rozwiazuj(10))
        {
            suma+=i.wartosc;
        }
        Assert.assertTrue(suma==25);
    }

}
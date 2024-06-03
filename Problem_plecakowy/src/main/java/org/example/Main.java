package org.example;

import java.util.Scanner;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
    int ilosc;
    int wielkosc_plecaka;
    int ziarno;
    int dolna=1;
    int gorna=5;
    Scanner sc = new Scanner(System.in);
        System.out.println("Podaj ilosc przedmiotów do wygenerowania");
    ilosc=sc.nextInt();
        System.out.println("Podaj rozmiar plecaka");
    wielkosc_plecaka=sc.nextInt();
        System.out.println("Podaj ziarno");
    ziarno=sc.nextInt();

    problem Problemik=new problem(ilosc, ziarno, dolna, gorna);

    System.out.println(Problemik.toString());
    wynik rozwiazanie=new wynik( Problemik.rozwiazuj(wielkosc_plecaka));

    System.out.println(rozwiazanie.toString());

    }
}
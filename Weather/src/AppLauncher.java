import javax.swing.*;
//Klasa podstawowa odpalająca wszystko
//Obrazki, które są w projekcie pobrałem z internetu

public class AppLauncher {
    public static void main(String[] args) {
        SwingUtilities.invokeLater(new Runnable() {
            @Override
            public void run() {
                new WeatherAppGui().setVisible(true);
             //   System.out.println(WeatherApp.getLocationData("Tokyo"));


               // System.out.println(WeatherApp.get_current_Time());


            }
        });
    }
}

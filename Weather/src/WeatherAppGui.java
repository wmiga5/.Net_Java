import org.json.simple.JSONObject;

import javax.imageio.ImageIO;
import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;

public class WeatherAppGui extends JFrame {
    private JSONObject weather_data;

    public WeatherAppGui()
    {
        super("Weather App");

        setDefaultCloseOperation(EXIT_ON_CLOSE);

        setSize(450, 650);

        setLocationRelativeTo(null);


        setLayout(null);


        setResizable(false);


        addGuiComponents();

    }
    private void addGuiComponents()
    {
        JTextField search_text_field = new JTextField();

        search_text_field.setBounds(15,15,351,45);


        search_text_field.setFont(new Font("Dialog",Font.PLAIN,24));

        add(search_text_field);


        JLabel weather_condition_image=new JLabel(loadImage("assets/cloudy.png"));
        weather_condition_image.setBounds(0,125,450,217);
        add(weather_condition_image);


        JLabel temperature_text=new JLabel("10 C");

        temperature_text.setBounds(0,350,450,54);
        temperature_text.setFont(new Font("Dialog",Font.BOLD,48));
        temperature_text.setHorizontalAlignment(SwingConstants.CENTER);
        add(temperature_text);


        JLabel weather_condition_description=new JLabel("Cloudy");
        weather_condition_description.setBounds(0,405,450,36);
        weather_condition_description.setFont(new Font("Dialog",Font.PLAIN,32));
        weather_condition_description.setHorizontalAlignment(SwingConstants.CENTER);
        add(weather_condition_description);

        JLabel humidity_image=new JLabel(loadImage("assets/humidity.png"));
        humidity_image.setBounds(15,500,74,66);
        add(humidity_image);

        JLabel humidity_text=new JLabel("<html><b>Humidity</b> 100%</html>");
        humidity_text.setBounds(90,500,85,55);
        humidity_text.setFont(new Font("Dialog",Font.PLAIN,16));

        add(humidity_text);

        JLabel wind_speed_image=new JLabel(loadImage("assets/windspeed.png"));

        wind_speed_image.setBounds(220,500,74,66);
        add(wind_speed_image);

        JLabel wind_speed_text=new JLabel("<html><b>Windspeed</b> 15km</html>");
        wind_speed_text.setBounds(310,500,85,55);
        wind_speed_text.setFont(new Font("Dialog",Font.PLAIN,16));
        add(wind_speed_text);

        JButton search_button = new JButton(loadImage("assets/search.png"));
        search_button.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
        search_button.setBounds(375,13,47,45);
        search_button.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String user_input=search_text_field.getText();

                if(user_input.replaceAll("\\s","").length()<=0)
                {
                    return;
                }
                weather_data=WeatherApp.getWeatherData(user_input);


                String weather_condition=(String) weather_data.get("weather_condition");


                switch(weather_condition){
                    case "Clear":
                        weather_condition_image.setIcon(loadImage("assets/clear.png"));
                        break;
                    case "Cloudy":
                        weather_condition_image.setIcon(loadImage("assets/cloudy.png"));
                        break;
                    case "Rain":
                        weather_condition_image.setIcon(loadImage("assets/rain.png"));
                        break;
                    case "Snow":
                        weather_condition_image.setIcon(loadImage("assets/snow.png"));
                        break;
                }

                double temperature=(double) weather_data.get("temperature");
                temperature_text.setText(temperature+" C");

               weather_condition_description.setText(weather_condition);

               long humidity=(long) weather_data.get("humidity");
               humidity_text.setText("<html><b>Humidity</b> "+humidity+"%</html>");

                double wind_speed=(double) weather_data.get("wind_speed");
                wind_speed_text.setText("<html><b>Windspeed</b> "+wind_speed+"km/h</html>");

            }
        });
        add(search_button);


    }

    private  ImageIcon loadImage(String resourcePath)
    {
        try{
            BufferedImage image= ImageIO.read(new File(resourcePath));
            return new ImageIcon(image);
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }
        System.out.println("Couldn't load image");
        return null;
    }

}

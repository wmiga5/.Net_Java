import org.jfree.chart.axis.DateAxis;
import org.json.simple.JSONObject;
import org.jfree.chart.ChartFactory;
import org.jfree.chart.ChartPanel;
import org.jfree.chart.JFreeChart;
import org.jfree.chart.plot.PlotOrientation;
import org.jfree.chart.plot.XYPlot;
import org.jfree.chart.renderer.xy.XYDotRenderer;
import org.jfree.data.xy.XYSeries;
import org.jfree.data.xy.XYSeriesCollection;

import javax.imageio.ImageIO;
import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;
import java.time.LocalDateTime;
import java.time.ZoneOffset;
import java.util.Date;
import java.util.List;
import org.jfree.chart.axis.NumberAxis;
//Wizualna część apki
public class WeatherAppGui extends JFrame {
    private JSONObject weather_data;
    private SqlConnection sqlConnection = new SqlConnection();
    private List<SqlConnection.pomiar> pomiary;
    private ChartPanel chartPanel;
    //Konstruktor, tworzy okno i zaciąga dane poraz pierwszy
    public WeatherAppGui() {
        super("Weather App");
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setSize(1100, 800);
        setLocationRelativeTo(null);
        setLayout(null);
        setResizable(false);
        addGuiComponents();
        pomiary = sqlConnection.get_pomiar(1);
        addChartComponent();
    }
    //Dodaje komponenty do okna
    private void addGuiComponents() {
        //Pole tekstowe
        JTextField search_text_field = new JTextField();
        search_text_field.setBounds(15, 15, 351, 45);
        search_text_field.setFont(new Font("Dialog", Font.PLAIN, 24));
        add(search_text_field);
        //Guzik wyszukania
        JButton search_button = new JButton(loadImage("assets/search.png"));
        search_button.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
        search_button.setBounds(375, 13, 47, 45);
        //Obrazek
        JLabel weather_condition_image = new JLabel(loadImage("assets/cloudy.png"));
        weather_condition_image.setBounds(0, 125, 450, 217);
        add(weather_condition_image);

        //Tekst
        JLabel weather_condition_description = new JLabel("Cloudy");
        weather_condition_description.setBounds(0, 405, 450, 36);
        weather_condition_description.setFont(new Font("Dialog", Font.PLAIN, 32));
        weather_condition_description.setHorizontalAlignment(SwingConstants.CENTER);
        add(weather_condition_description);
        //Tekst
        JLabel temperature_text = new JLabel("10 C");
        temperature_text.setBounds(0, 350, 450, 54);
        temperature_text.setFont(new Font("Dialog", Font.BOLD, 48));
        temperature_text.setHorizontalAlignment(SwingConstants.CENTER);
        add(temperature_text);

        //Obrazek
        JLabel humidity_image = new JLabel(loadImage("assets/humidity.png"));
        humidity_image.setBounds(15, 500, 74, 66);
        add(humidity_image);
        //Tekst
        JLabel humidity_text = new JLabel("<html><b>Humidity</b> 100%</html>");
        humidity_text.setBounds(90, 500, 85, 55);
        humidity_text.setFont(new Font("Dialog", Font.PLAIN, 16));
        add(humidity_text);
        //Obrazek
        JLabel wind_speed_image = new JLabel(loadImage("assets/windspeed.png"));
        wind_speed_image.setBounds(220, 500, 74, 66);
        add(wind_speed_image);
        //Tekst
        JLabel wind_speed_text = new JLabel("<html><b>Windspeed</b> 15km</html>");
        wind_speed_text.setBounds(310, 500, 85, 55);
        wind_speed_text.setFont(new Font("Dialog", Font.PLAIN, 16));
        add(wind_speed_text);

        //Obsługa guzika
        search_button.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String user_input = search_text_field.getText();
                if (user_input.replaceAll("\\s", "").length() <= 0) {
                    return;
                }
                weather_data = WeatherApp.get_weather_data(user_input);
                String weather_condition = (String) weather_data.get("weather_condition");
                switch (weather_condition) {
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

                double temperature = (double) weather_data.get("temperature");
                temperature_text.setText(temperature + " C");
                weather_condition_description.setText(weather_condition);

                long humidity = (long) weather_data.get("humidity");
                humidity_text.setText("<html><b>Humidity</b> " + humidity + "%</html>");

                double wind_speed = (double) weather_data.get("wind_speed");
                wind_speed_text.setText("<html><b>Windspeed</b> " + wind_speed + "km/h</html>");
            }
        });
        add(search_button);
    }
    //Dodajemy wykres
    private void addChartComponent() {
        JPanel chartContainer = new JPanel();
        chartContainer.setBounds(450, 125, 600, 500);
        chartContainer.setLayout(new BorderLayout());

        XYSeriesCollection data_set = new XYSeriesCollection();
        JFreeChart chart = ChartFactory.createScatterPlot(
                "Weather Data", "Time", "Value", data_set, PlotOrientation.VERTICAL, true, true, false);

        chartPanel = new ChartPanel(chart);
        chartContainer.add(chartPanel, BorderLayout.CENTER);
        //Dodanie wyboru parametru oraz urządzenia
        JComboBox<String> parameter_selector = new JComboBox<>(new String[]{"Temperature", "Humidity", "Insolation"});
        parameter_selector.setBounds(450, 15, 150, 30);
        parameter_selector.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String selectedParameter = (String) parameter_selector.getSelectedItem();
                update_chart(data_set, selectedParameter);
            }
        });
        add(parameter_selector);
        JComboBox<Integer> device_selector = new JComboBox<>();
        for (Integer i : sqlConnection.get_device_id()) {
            device_selector.addItem(i);
        }
        device_selector.setBounds(700, 15, 150, 30);
        device_selector.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                Integer selected_device = (Integer) device_selector.getSelectedItem(); // Correct variable name
                updatePomiary(selected_device);
                update_chart(data_set, parameter_selector.getSelectedItem().toString());
            }
        });
        add(device_selector);

        add(chartContainer);
        update_chart(data_set, "Temperature");
    }
    //Pobranie pomiarów w razie zmianny urządzenia
    private void updatePomiary(int device_id)
    {
        pomiary = sqlConnection.get_pomiar(device_id);
    }
    //Odświeżenie wykresu w przypadku zmiany oglądanych parametrów
    private void update_chart(XYSeriesCollection dataset, String parameter) {
        dataset.removeAllSeries();
        XYSeries series = new XYSeries(parameter);

        for (SqlConnection.pomiar pomiar : pomiary) {
            LocalDateTime dateTime = pomiar.getDateTime();
            double value = 0;
            switch (parameter) {
                case "Temperature":
                    value = pomiar.getTemperature();
                    break;
                case "Humidity":
                    value = pomiar.getHumidity();
                    break;
                case "Insolation":
                    value = pomiar.getInsolation();
                    break;
            }
            Date date = Date.from(dateTime.toInstant(ZoneOffset.UTC));
            series.add(date.getTime(), value);
        }

        dataset.addSeries(series);
        XYPlot plot = (XYPlot) chartPanel.getChart().getPlot();
        DateAxis dateAxis = new DateAxis("Time");
        plot.setDomainAxis(dateAxis);

        XYDotRenderer renderer = new XYDotRenderer();
        renderer.setDotWidth(5);
        renderer.setDotHeight(5);
        plot.setRenderer(renderer);

        NumberAxis yAxis = (NumberAxis) plot.getRangeAxis();
        switch (parameter) {
            case "Temperature":
                yAxis.setRange(pomiary.stream().mapToDouble(SqlConnection.pomiar::getTemperature).min().orElse(0.0)
                        ,pomiary.stream().mapToDouble(SqlConnection.pomiar::getTemperature).max().orElse(100.0));
                break;
            case "Humidity":
                yAxis.setRange(pomiary.stream().mapToDouble(SqlConnection.pomiar::getHumidity).min().orElse(0.0)
                        ,pomiary.stream().mapToDouble(SqlConnection.pomiar::getHumidity).max().orElse(100.0));
                break;
            case "Insolation":
                yAxis.setRange(pomiary.stream().mapToDouble(SqlConnection.pomiar::getInsolation).min().orElse(0.0)
                        ,pomiary.stream().mapToDouble(SqlConnection.pomiar::getInsolation).max().orElse(100.0));
                break;
        }


    }
    //Funkcja ładująca obrazek
    private ImageIcon loadImage(String resourcePath) {
        try {
            BufferedImage image = ImageIO.read(new File(resourcePath));
            return new ImageIcon(image);
        } catch (IOException e) {
            e.printStackTrace();
        }
        System.out.println("Couldn't load image");
        return null;
    }


}

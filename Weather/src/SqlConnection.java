import java.sql.*;
import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;
//Klasa odpowiedzialna za podłączenie z bazą danych
public class SqlConnection {

    private static String DB_URL = "jdbc:mysql://127.0.0.1:3306/szklarnia_v3";
    private static String USER = "root";
    private static String PASSWORD = "";
    //Klasa przechowująca pomiar, w praktyce jest taka sam jak w bazie danych
    public static class pomiar {
        private int id;
        private int deviceId;
        private LocalDateTime dateTime;
        private double temperature;
        private double humidity;
        private double insolation;
        //Konstruktor
        public pomiar(int id, int deviceId, LocalDateTime dateTime, float temperature, float humidity, float insolation) {
            this.id = id;
            this.deviceId = deviceId;
            this.dateTime = dateTime;
            this.temperature = temperature;
            this.humidity = humidity;
            this.insolation = insolation;
        }
        @Override
        public String toString() {
            return "Measurement{" +
                    "id=" + id +
                    ", deviceId=" + deviceId +
                    ", dateTime='" + dateTime + '\'' +
                    ", temperature=" + temperature +
                    ", humidity=" + humidity +
                    ", insolation=" + insolation +
                    '}';

        }
        //Dostępowe funkcje
        public LocalDateTime getDateTime(){return dateTime;}
        public double getTemperature(){return temperature;}
        public double getHumidity(){return humidity;}
        public double getInsolation(){return insolation;}

    }
    //Podłącza się do serwera bazy danych, obsługuje błąd
    public Connection getConnection() throws SQLException {
        return DriverManager.getConnection(DB_URL,USER,PASSWORD);
    }
    //Odczytuje liste urządzeń z bazy danych
    public List<Integer> get_device_id()
    {
        List<Integer> result = new ArrayList<>();

        String query="SELECT serial_number FROM urzadzenie";

        try
        {
            Connection conn=getConnection();
            PreparedStatement ps=conn.prepareStatement(query);

            ResultSet rs=ps.executeQuery();
            while (rs.next())
            {
                result.add(rs.getInt("serial_number"));
            }
        }
        catch (SQLException e)
        {
            e.printStackTrace();
        }
        return result;
    }
    //Odczytuje pomiary z bazy danych
    public List<pomiar> get_pomiar(int device_id)
    {
        List<pomiar> pomiary = new ArrayList<>();
        String query="SELECT * FROM pomiar WHERE device_id=?";
        try
        {
            Connection conn =getConnection();
            PreparedStatement ps = conn.prepareStatement(query);
            ps.setInt(1,device_id);
            ResultSet rs = ps.executeQuery();
            while (rs.next())
            {
                int id = rs.getInt("Id");
                int devId = rs.getInt("Device_id");
                Timestamp time = rs.getTimestamp("date_time");
                LocalDateTime dateTime = time.toLocalDateTime();
                float temperature = rs.getFloat("Temperature");
                float humidity = rs.getFloat("Humidity");
                float insolation = rs.getFloat("Insolation");

                pomiar pomiar_now=new pomiar(id,devId,dateTime,temperature,humidity,insolation);
                pomiary.add(pomiar_now);

            }

        }
        catch (SQLException e)
        {
            e.printStackTrace();
        }
        return pomiary;
    }
}

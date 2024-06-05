import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;

import java.net.HttpURLConnection;
import java.net.URL;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.Scanner;
//Klasa obsługująca API
public class WeatherApp {
    public static JSONObject get_weather_data(String location)
    {
        JSONArray location_data= get_location_data(location);

        JSONObject location_paramether=(JSONObject)location_data.get(0);
        double latitude=(Double)location_paramether.get("latitude");
        double longitude=(Double)location_paramether.get("longitude");


        String url_string="https://api.open-meteo.com/v1/forecast?latitude="+latitude+"&longitude="
                +longitude+"&hourly=temperature_2m,relative_humidity_2m,weather_code,wind_speed_10m";

        try{
                HttpURLConnection conn =fetch_api_response(url_string);

                if(conn.getResponseCode()!=200)
                {
                    System.out.println("Error: Could not connect to API");
                    return null;
                }
                StringBuilder result_json=new StringBuilder();
                Scanner scanner=new Scanner(conn.getInputStream());
                while(scanner.hasNext())
                {
                    result_json.append(scanner.nextLine());
                }
            scanner.close();


                conn.disconnect();
                //Odkowowanie JSONA
                JSONParser parser=new JSONParser();
                JSONObject result_json_object=(JSONObject)parser.parse(String.valueOf(result_json));

                JSONObject hourly=(JSONObject)result_json_object.get("hourly");

                JSONArray time=(JSONArray) hourly.get("time");
                int index=find_index_of_time(time);

                JSONArray temperature_data=(JSONArray) hourly.get("temperature_2m");
                double temperature=(Double)temperature_data.get(index);

                JSONArray weather_code=(JSONArray) hourly.get("weather_code");
                String weather_condition=convert_weather_code((long) weather_code.get(index));

                JSONArray relative_humidity=(JSONArray) hourly.get("relative_humidity_2m");

                long humidity=(Long)relative_humidity.get(index);

                JSONArray wind_speed_data=(JSONArray) hourly.get("wind_speed_10m");
                double wind_speed=(Double)wind_speed_data.get(index);

                JSONObject weather_data=new JSONObject();
                weather_data.put("temperature",temperature);
                weather_data.put("weather_condition",weather_condition);
                weather_data.put("humidity",humidity);
                weather_data.put("wind_speed",wind_speed);
                return weather_data;
        }
        catch(Exception e) {
            e.printStackTrace();
        }

        return null;
    }
    public static JSONArray get_location_data(String location)
    {
        location=location.replaceAll(" ","+");
        String url_string="https://geocoding-api.open-meteo.com/v1/search?name="
        +location+"&count=10&language=en&format=json";

        try{
            HttpURLConnection conn= fetch_api_response(url_string);
            if(conn.getResponseCode()!=200)
            {
                System.out.println("Error: Could not connect to API");
                return null;
            }
            else {
                StringBuilder result_json=new StringBuilder();
                Scanner scanner=new Scanner(conn.getInputStream());

                while (scanner.hasNext()){
                    result_json.append(scanner.nextLine());
                }
                scanner.close();

                conn.disconnect();

                JSONParser parser=new JSONParser();
                JSONObject result_obj=(JSONObject) parser.parse(String.valueOf(result_json));


                return (JSONArray) result_obj.get("results");

            }

        }catch (Exception e)
        {
            e.printStackTrace();
        }
        return null;
    }
    private static HttpURLConnection fetch_api_response(String url_string)
    {
        try {
            URL url = new URL(url_string);
            HttpURLConnection conn=(HttpURLConnection) url.openConnection();

            conn.setRequestMethod("GET");

            conn.connect();
            return conn;
         }
        catch (Exception e)
        {
            e.printStackTrace();
        }
        return null;
    }
    private static int find_index_of_time(JSONArray time_list)
    {
        String current_time=get_current_Time();
        for(int i=0;i<time_list.size();i++)
        {
            String time=(String)time_list.get(i);
            if(time.equals(current_time))
            {
                return i;
            }
        }
        return 0;
    }
    public static String get_current_Time()
    {
        LocalDateTime current_date_time= LocalDateTime.now();
        DateTimeFormatter formatter=DateTimeFormatter.ofPattern("yyyy-MM-dd'T'HH':00'");

        return current_date_time.format(formatter);
    }


    private static String convert_weather_code(long weather_code)
    {
        String weather_condition="";
        if(weather_code==0L)
        {
            weather_condition="Clear";
        } else if (weather_code<=3L&&weather_code>0L) {
            weather_condition="Cloudy";

        }
        else if((weather_code>=51L&&weather_code<=67L)||(weather_code>=80L&&weather_code<=99L))
        {
            weather_condition="Rain";
        }
        else if(weather_code>=71L&&weather_code<=77L)
        {
            weather_condition="Snow";
        }
        return weather_condition;
    }

}

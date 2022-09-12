using Newtonsoft.Json.Linq;

var client = new HttpClient();

//var server = "https://api.openweathermap.org/data/2.5/weather?lat=33.416717&lon=-78.77146&appid=9c8e7b682ff697f406da2117299f305c&units=imperial"; 
//string weather = client.GetStringAsync(server).Result;

//var weatherObject = JObject.Parse(weather);

//Console.WriteLine($"Current weather at North Atlantic Ocean is:");
//Console.WriteLine($"{weatherObject["main"]["temp"]} Fahrenheit");
//Console.WriteLine(weatherObject["weather"][0]["main"]);


var APIkey = "9c8e7b682ff697f406da2117299f305c";

Console.WriteLine("What city would you like to know the weather for? ");
var cityName = Console.ReadLine();

string weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={APIkey}&units=imperial";
var weatherCity = client.GetStringAsync(weatherURL).GetAwaiter().GetResult();
var weatherObject1 = JObject.Parse(weatherCity);


Console.WriteLine(weatherObject1["main"]["temp"]);











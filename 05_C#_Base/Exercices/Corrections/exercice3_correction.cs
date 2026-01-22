
Console.WriteLine("Veuillez entrer un degree en celcius");
float celsius = float.Parse(Console.ReadLine());

float celciusToFahrenheit(float c)
{
    float fahrenheit = (c * 9 / 5) + 32;
    return fahrenheit; 
}

Console.WriteLine($"Conversion : {celsius} C° <=> {celciusToFahrenheit(celsius)} F°");
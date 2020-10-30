using System;

namespace ConversorTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            //Temperaturas conversorTemperatura = new Temperaturas();

            Console.WriteLine("---Conversor de temperatura---");

            //Celsius to fahre
            Console.WriteLine("");
            Console.WriteLine("Conversor de Celsius to Fahre.");
            Console.Write("Digite a temperatura em graus Celsius: ");
            decimal celsius1 = Convert.ToDecimal(Console.ReadLine());
            decimal fahre1 = ConverterCelsius1(celsius1);
            Console.WriteLine($"A temperatura {celsius1}°C em graus Fahre é:  {fahre1}°F");

            //Celsius to Kelvin
            Console.WriteLine("");
            Console.WriteLine("Conversor de Celsius to Kelvin");
            Console.Write("Digite a temperatura em graus Celsius: ");
            decimal celsius2 = Convert.ToDecimal(Console.ReadLine());
            decimal kelvin = ConverterCelsius2(celsius2);
            Console.WriteLine($"A temperatura {celsius2}°C, em graus Kelvin é:  {kelvin}K");

            //Celsius to Rankine
            Console.WriteLine("");
            Console.WriteLine("Conversor de Celsius to Rankine");
            Console.Write("Digite a temperatura em graus Celsius: ");
            decimal celsius3 = Convert.ToDecimal(Console.ReadLine());
            decimal rankine = ConverterCelsius3(celsius3);
            Console.WriteLine($"A temperatura {celsius3}°C, em graus Rankine é:  {rankine}°Ra");

            //Fahre to Celsius
            Console.WriteLine("");
            Console.WriteLine("Conversor de Fahre to Celsius");
            Console.Write("Digite a temperatura em graus Fahre: ");
            decimal fahre2 = Convert.ToDecimal(Console.ReadLine());
            decimal celsius4 = ConverterFahre1(fahre2);
            Console.WriteLine($"A temperatura {fahre2}°F, em graus Celsius é: {celsius4}°C");

            //Fahre to Kelvin
            Console.WriteLine("");
            Console.WriteLine("Conversor de Fahre to Kelvin");
            Console.Write("Digite a temperatura em graus Fahre: ");
            decimal fahre3 = Convert.ToDecimal(Console.ReadLine());
            decimal kelvin1 = ConverterFahre2(fahre3);
            Console.WriteLine($"A temperatura {fahre3}°F, em graus Kelvin é: {kelvin1}K");


            //Fahre to Rankine
            Console.WriteLine("");
            Console.WriteLine("Conversor de Fahre to Rankine");
            Console.Write("Digite a temperatura em graus Fahre: ");
            decimal fahre4 = Convert.ToDecimal(Console.ReadLine());
            decimal rankine1 = ConverterFahre3(fahre4);
            Console.WriteLine($"A temperatura {fahre4}°F, em graus Rankine é: {rankine1}°Ra");


            //Kelvin to Celsius
            Console.WriteLine("");
            Console.WriteLine("Conversor de Kelvin to Celsius");
            Console.Write("Digite a temperatura em Kelvin: ");
            decimal kelvin2 = Convert.ToDecimal(Console.ReadLine());
            decimal celsius5 = ConverterKelvin(kelvin2);
            Console.WriteLine($"A temperatura {kelvin2}K, em graus Celsius é: {celsius5}°C");

            //Kelvin to Fahre
            Console.WriteLine("");
            Console.WriteLine("Conversor de Kelvin to Fahre");
            Console.Write("Digite a temperatura em Kelvin: ");
            decimal kelvin3 = Convert.ToDecimal(Console.ReadLine());
            decimal fahre5 = ConverterKelvinToFahre(kelvin3);
            Console.WriteLine($"A temperatura {kelvin3}K, em graus Fahre é: {fahre5}°F");


            //Kelvin to Rankine
            Console.WriteLine("");
            Console.WriteLine("Conversor de Kelvin to Rankine");
            Console.Write("Digite a temperatura em Kelvin: ");
            decimal kelvin4 = Convert.ToDecimal(Console.ReadLine());
            decimal rankine2 = ConverterKelvinToRankine(kelvin4);
            Console.WriteLine($"A temperatura {kelvin4}K, em graus Rankine é: {rankine2}°Ra");


            //Rankine to Celsius
            Console.WriteLine("");
            Console.WriteLine("Conversor de Rankine to Celsius");
            Console.Write("Digite a temperatura em graus Rankine: ");
            decimal rankine3 = Convert.ToDecimal(Console.ReadLine());
            decimal celsius6 = ConverterRankineToCelsius(rankine3);
            Console.WriteLine($"A temperatura {rankine3}°Ra, em graus Celsius é: {celsius6}°C");

            //Rankine to Fahre
            Console.WriteLine("");
            Console.WriteLine("Conversor de Rankine to Fahre");
            Console.Write("Digite a temperatura em graus Rankine: ");
            decimal rankine4 = Convert.ToDecimal(Console.ReadLine());
            decimal fahre6 = ConverterRankineToFahre(rankine4);
            Console.WriteLine($"A temperatura {rankine4}°Ra, em graus Fahre é: {fahre6}°F");


            //Rankine to Kelvin
            Console.WriteLine("");
            Console.WriteLine("Conversor de Rankine to Kelvin: ");
            Console.Write("Digite a temperatura em graus Rankine: ");
            decimal rankine5 = Convert.ToDecimal(Console.ReadLine());
            decimal kelvin5 = ConverterRankineToKelvin(rankine5);
            Console.WriteLine($"A temperatura {rankine5}°Ra, em graus Kelvin é: {kelvin5}K");

            //Encerrar
            Console.WriteLine("");
            Console.WriteLine("Tecle ENTER para encerrar.");
            Console.ReadLine();
        }

        static decimal ConverterCelsius1(decimal celsius1) //Função calculando celsius to fahre
        {
            decimal temperaturaCelsiusToFahre = (celsius1 * 1.8m + 32); //O literal com o m M sufixo é do tipo decimal
            return temperaturaCelsiusToFahre;
        }

        static decimal ConverterCelsius2(decimal celsius2) //Função calculando celsius to kelvin
        {
            decimal temperaturaCelsiusToKelvin = celsius2 + 273.15m; 
            return temperaturaCelsiusToKelvin;
        }

        static decimal ConverterCelsius3(decimal celsius3) //Função calculando celsius to rankine
        {
            decimal temperaturaCelsiusToRankine = (celsius3 + 273.15m) * 1.8m;
            return temperaturaCelsiusToRankine;
        }

        static decimal ConverterFahre1(decimal fahre1) //Função calculando fahre to celsius
        {
            decimal temperaturaFahreToCelsius = (fahre1 - 32) / 1.8m;
            return temperaturaFahreToCelsius;
        }

        static decimal ConverterFahre2(decimal fahre3) //Função calculando fahre to kelvin
        {
            decimal temperaturaFahreToKelvin = (fahre3 + 459.67m) / 1.8m;
            return temperaturaFahreToKelvin;
        }

        static decimal ConverterFahre3(decimal fahre4) //Função calculando fahre to rankine
        {
            decimal temperaturaFahreToRankine = (fahre4 + 459.67m);
            return temperaturaFahreToRankine;
        }

        static decimal ConverterKelvin(decimal kelvin2) //Função calculando kelvin to celsius
        {
            decimal temperaturaKelvinToCelsius = (kelvin2 - 273.15m);
            return temperaturaKelvinToCelsius;
        }

        static decimal ConverterKelvinToFahre(decimal kelvin3) //Função calculando kelvin to fahre
        {
            decimal temperaturaKelvinToFahre = (kelvin3 * 1.8m - 459.889m);
            return temperaturaKelvinToFahre;
        }

        static decimal ConverterKelvinToRankine(decimal kelvin4) //Função calculando kelvin to rankine
        {
            decimal temperaturaKelvinToRankine = (kelvin4 * 1.8m);
            return temperaturaKelvinToRankine;
        }

        static decimal ConverterRankineToCelsius(decimal rankine3)   //Função calculando rankine to celsius
        {
            decimal temperaturaRankineToCelsius = (rankine3 / 1.8m) - 273.15m;
            return temperaturaRankineToCelsius;
        }

        static decimal ConverterRankineToFahre(decimal rankine4)  //Função calculando rankine to fahre
        {
            decimal temperaturaRankineToFahre = rankine4 - 459.67m;
            return temperaturaRankineToFahre;
        }

        static decimal ConverterRankineToKelvin(decimal rankine5)  //Função calculando rankine to kelvin
        {
            decimal temperaturaRankineTokelvin = rankine5 / 1.8m;
            return temperaturaRankineTokelvin;
        }

    }
}

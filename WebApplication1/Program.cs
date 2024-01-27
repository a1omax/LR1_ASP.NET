var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Company company = new Company();
company.Capitalisation = 17114;
company.Name = "IBM";
company.Adress = "1 Orchard Road, Armonk, New York";
company.Year = 1911;

Random random = new Random();
int randomValue = random.Next(0, 101);


app.MapGet("/", () => "Company name: " + company.Name + " \nRandom value from 0 to 100: " + randomValue);
app.Run();

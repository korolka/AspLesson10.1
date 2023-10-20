//Задание
//Подключите к серверу три типа файлов конфигурации: xml, json и ini.
//В каждом из них будет записана информация о компаниях MicrosoftComp, AppleComp и Google.
//В качестве обязательного параметра должно быть количество сотрудников данных компаний.
//Создайте сервис, который будет анализировать количество сотрудников,
//записанное в упомянутых выше файлах конфигурации, и выводить название компании, у которой этот показатель выше

//Задание 1
//Создайте json-файл конфигурации, в котором в нескольких полях будет записаны некоторые данные о Вас. Выведите их в окно браузера

//Задание 2
//Создайте небольшой сервис с жизненным циклом Transient.
//Сервис должен анализировать текущее время на сервере и, в зависимости от результата,
//в форме http-ответа возвращать строку «сейчас день» (если время между 12 и 16 часами),
//«сейчас вечер» (если между 16 и полночью), «сейчас ночь» (от полночи до 4 утра) и,
//соответственно, «сейчас утро» (от 4 до 12)
using AspLesson10._1.Services;

namespace AspLesson10._1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddTransient<IWorkerCount,WorkerCount>();
            builder.Services.AddTransient<ITimeNow,TimeNow>();
            builder.Services.AddControllersWithViews();
            builder.Configuration.AddJsonFile("App_Data/MyData.json");
            builder.Configuration.AddJsonFile("App_Data/MicrosoftWorkers.json");
            builder.Configuration.AddXmlFile("App_Data/AppleWorkers.xml");
            var app = builder.Build();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
            
            app.Run();
        }
    }
}
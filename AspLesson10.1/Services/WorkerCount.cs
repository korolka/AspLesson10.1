using AspLesson10._1.Models;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace AspLesson10._1.Services
{
    public class WorkerCount : IWorkerCount
    {
        public SomeCompany Count(IConfiguration configuration)
        {
            MicrosoftComp microsoftComp = configuration.GetSection("MicrosoftComp").Get<MicrosoftComp>();
            AppleComp appleComp = new AppleComp() {Country = configuration["Country"],Name = configuration["Name"], Workers = int.Parse(configuration["Workers"]) };
            if (appleComp.Workers > microsoftComp.Workers)
                return appleComp;
            else if (microsoftComp.Workers > appleComp.Workers)
                return microsoftComp;
            return null;
        }
    }
}

using BlazorMovies.Client.Helpers;
using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Repository
{
    public class PersonRepository : IPersonRepository
    {

        private readonly IHttpService httpService;

        private string url = "api/people";

        public PersonRepository (IHttpService httpService)
        {

            this.httpService = httpService;
        }

        public async Task<List<Person>> GetPeople()
        {
            var response = await httpService.Get<List<Person>>(url);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;


        }



        public async Task CreatePerson(Person person)
        {
            var response = await httpService.Post(url, person);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }


        }


    }
}

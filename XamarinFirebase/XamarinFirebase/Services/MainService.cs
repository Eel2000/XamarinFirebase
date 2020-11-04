using Firebase.Database;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinFirebase.Models;

namespace XamarinFirebase.Services
{
    public class MainService
    {
        private JsonSerializer _serializer = new JsonSerializer();
        private static MainService _mainService;

        public static MainService mainService
        {
            get
            {
                if (_mainService == null)
                    _mainService = new MainService();
                return _mainService;
            }
        }

        FirebaseClient firebase;

        public MainService()
        {
            firebase = new FirebaseClient("https://test-4139a.firebaseio.com/");
        }

        public async Task<bool> AddNew(string nom, string prenom)
        {
            var result = await firebase
                .Child("RegisterEmployeeTable")
                .PostAsync(new Parent() { Id = Guid.NewGuid().ToString(), Nom = nom, Prenom = prenom });

            if (result.Object != null)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public async Task<bool> AddEnfant(string nom, string prenom)
        {
            var result = await firebase
                .Child("EnfantTb")
                .PostAsync(new Enfant() { Id = Guid.NewGuid().ToString(), Nom = nom, Prenom = prenom });

            if (result.Object != null)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public async Task<List<Parent>> GetParents()
        {
            var GetClients = (await firebase
               .Child("RegisterEmployeeTable")
               .OnceAsync<Parent>()).Select(item => new Parent
               {
                   Nom = item.Object.Nom,
                   Prenom = item.Object.Prenom,
               }).ToList();
            return GetClients;
        }
    }
}

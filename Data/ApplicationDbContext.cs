﻿using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks; 

namespace Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        private DataAutogenerator.NetCore.DataAutogenerator _dataAutogenerator = new DataAutogenerator.NetCore.DataAutogenerator ();
        private Random _rand = new Random ();

        public ApplicationDbContext () { }
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
               : base(options)
        {
        }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=aspnet-WebApplication75-Mvc-Samochody;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating (ModelBuilder builder)
        {
            CreateInitialData(builder);
            base.OnModelCreating(builder);
        }


        public DbSet<PhotoUser> PhotosUser { get; set; }
        public DbSet<LoggingError> LoggingErrors { get; set; }



        private void CreateInitialData (ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>()
                .HasMany(h => h.PhotosUser).WithOne(w => w.User).HasForeignKey(f => f.UserId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<ApplicationUser>()
                .HasMany(h => h.LoggingErrors).WithOne(w => w.User).HasForeignKey(f => f.UserId).OnDelete(DeleteBehavior.ClientNoAction);


              



            // ROLES  
            ApplicationRole personelRole = new ApplicationRole()
            {
                Id = Guid.NewGuid ().ToString (),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                Name = "Personel",
                NormalizedName = "Personel",
            };
            ApplicationRole adminRole = new ApplicationRole()
            {
                Id = Guid.NewGuid ().ToString (),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                Name = "Administrator",
                NormalizedName = "Administrator"
            };

            builder.Entity<ApplicationRole>().HasData(personelRole, adminRole);



            // USERS  

            string photoUser = "https://th.bing.com/th?q=User+ICO&w=120&h=120&c=1&rs=1&qlt=90&cb=1&dpr=1.6&pid=InlineBlock&mkt=pl-PL&cc=PL&setlang=pl&adlt=moderate&t=1&mw=247";

            PasswordHasher <ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser> ();

            var administratorUser = new ApplicationUser ()
            {
                Id = Guid.NewGuid ().ToString (),
                Email = "admin@admin.pl",
                UserName = "admin@admin.pl",
                Imie = _dataAutogenerator.Imie(),
                Nazwisko = _dataAutogenerator.Nazwisko (),
                Ulica = _dataAutogenerator.Ulica (),
                NumerUlicy = _dataAutogenerator.Number ().ToString (),
                Miejscowosc = _dataAutogenerator.Nazwisko (),
                KodPocztowy = "12-222",
                Kraj = "Polska",
                Telefon = "235235235",
                DataUrodzenia = DateTime.Now.AddYears(-_rand.Next(20,50)),
                EmailConfirmed = true,
                NormalizedUserName =  "admin@admin.pl".ToUpper(),
                NormalizedEmail = "admin@admin.pl".ToUpper(),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid ().ToString (),
                DataDodania = DateTime.Now,
            };
            administratorUser.PasswordHash = passwordHasher.HashPassword(administratorUser, "SDG%$@5423sdgagSDert");
            ApplicationUserRole applicationUserRoleAdmin = new ApplicationUserRole ()
            {
                UserId = administratorUser.Id,
                RoleId = adminRole.Id
            };
             


            var pracownik1User = new ApplicationUser ()
            {
                Id = Guid.NewGuid ().ToString (),
                Email = "pracownik1@pracownik1.pl",
                UserName = "pracownik1@pracownik1.pl",
                Imie = _dataAutogenerator.Imie(),
                Nazwisko = _dataAutogenerator.Nazwisko (),
                Ulica = _dataAutogenerator.Ulica (),
                NumerUlicy = _dataAutogenerator.Number ().ToString (),
                Miejscowosc = _dataAutogenerator.Nazwisko (),
                KodPocztowy = "12-222",
                Kraj = "Polska",
                Telefon = "235235235",
                DataUrodzenia = DateTime.Now.AddYears(-_rand.Next(20,50)),
                EmailConfirmed = true,
                NormalizedUserName =  "pracownik1@pracownik1.pl".ToUpper(),
                NormalizedEmail = "pracownik1@pracownik1.pl".ToUpper(),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid ().ToString (),
                DataDodania = DateTime.Now,
            };
            pracownik1User.PasswordHash = passwordHasher.HashPassword(pracownik1User, "SDG%$@5423sdgagSDert");
            ApplicationUserRole applicationUserRolePracownik1User = new ApplicationUserRole ()
            {
                UserId = pracownik1User.Id,
                RoleId = personelRole.Id
            };



            var pracownik2User = new ApplicationUser ()
            {
                Id = Guid.NewGuid ().ToString (),
                Email = "pracownik2@pracownik2.pl",
                UserName = "pracownik2@pracownik2.pl",
                Imie = _dataAutogenerator.Imie(),
                Nazwisko = _dataAutogenerator.Nazwisko (),
                Ulica = _dataAutogenerator.Ulica (),
                NumerUlicy = _dataAutogenerator.Number ().ToString (),
                Miejscowosc = _dataAutogenerator.Nazwisko (),
                KodPocztowy = "12-222",
                Kraj = "Polska",
                Telefon = "235235235",
                DataUrodzenia = DateTime.Now.AddYears(-_rand.Next(20,50)),
                EmailConfirmed = true,
                NormalizedUserName =  "pracownik2@pracownik2.pl".ToUpper(),
                NormalizedEmail = "pracownik2@pracownik2.pl".ToUpper(),
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid ().ToString (),
                DataDodania = DateTime.Now,
            };
            pracownik2User.PasswordHash = passwordHasher.HashPassword(pracownik2User, "SDG%$@5423sdgagSDert");
            ApplicationUserRole applicationUserRolePracownik2User = new ApplicationUserRole ()
            {
                UserId = pracownik2User.Id,
                RoleId = personelRole.Id
            };

             
            // dodanie danych do bazy
            builder.Entity<ApplicationUser>().HasData(administratorUser, pracownik1User, pracownik2User);
            builder.Entity<ApplicationUserRole>().HasData(applicationUserRoleAdmin, applicationUserRolePracownik1User, applicationUserRolePracownik2User);


            // dodanie zdjęć do użytkowników
            PhotoUser photoUserAdmin = new PhotoUser ()
            {
                PhotoUserId = Guid.NewGuid ().ToString (),
                PhotoData = GetImageBytesAsync (photoUser),
                UserId = administratorUser.Id,
            };
            PhotoUser photoUserPracownik1 = new PhotoUser ()
            {
                PhotoUserId = Guid.NewGuid ().ToString (),
                PhotoData = GetImageBytesAsync (photoUser),
                UserId = pracownik1User.Id,
            };
            PhotoUser photoUserPracownik2 = new PhotoUser ()
            {
                PhotoUserId = Guid.NewGuid ().ToString (),
                PhotoData = GetImageBytesAsync (photoUser),
                UserId = pracownik2User.Id,
            };
            builder.Entity <PhotoUser>().HasData(photoUserAdmin, photoUserPracownik1, photoUserPracownik2);




            List <string> photos = new List<string> ()
            {
                "https://webimage.pl/pics/838/4/s9788381414838.webp",
                "https://webimage.pl/pics/876/4/s9788381414876.webp",
                "https://webimage.pl/pics/511/0/s9788381180511.webp",
                "https://webimage.pl/pics/776/5/s9788327105776.webp",
                "https://webimage.pl/pics/202/5/s9788381185202.webp",
                "https://webimage.pl/pics/878/4/s9788381184878.webp",
                "https://webimage.pl/pics/189/5/s9788381185189.webp",
                "https://webimage.pl/pics/448/5/s9788327105448.webp",
                "https://webimage.pl/pics/056/6/s9788327106056.webp",
                "https://webimage.pl/pics/555/4/s9788381414555.webp",
                "https://webimage.pl/pics/984/4/s9788381184984.webp",
                "https://webimage.pl/pics/800/2/s9788374202800.webp",
                "https://webimage.pl/pics/179/6/s9788327106179.webp",
            };



        }



        /// <summary>
        /// Zamienia zdjęcie pobrane z sieci na byte[]
        /// </summary>
        private byte[] GetImageBytesAsync (string imageUrl)
        {
            using (var httpClient = new HttpClient())
            {
                byte[] imageBytes;

                using (var response = httpClient.GetAsync(imageUrl).Result)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        imageBytes = response.Content.ReadAsByteArrayAsync().Result;
                    }
                    else
                    {
                        imageBytes = new byte[0];
                    }
                }

                return imageBytes;
            }
        }

    }
}

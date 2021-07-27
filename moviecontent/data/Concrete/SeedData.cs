using System;
using System.Collections.Generic;
using System.Linq;
using entity;
using Microsoft.EntityFrameworkCore;

namespace data.Concrete
{
    public static class SeedData
    {
        
        public static void seed(){

            var repo = new MovieRepository();
            var context = new ShopContext();

                if(context.Database.GetPendingMigrations().Count() == 0){
                    
                    if(context.directors.Count()==0 && context.movies.Count()==0 &&  context.players.Count()==0 &&  context.categories.Count()==0  ){

                        var directors = new Director[]{
                            new Director(){Name="Togan Gökbakar",Age=37,Birthday = new DateTime(1984,5,29),Imdb=4.5,PhotoUrl="togan.jpeg"},
                            new Director(){Name="Gary Ross",Age=64,Birthday = new DateTime(1956,11,3),Imdb=8.7,PhotoUrl="garry.jpeg"},
                            new Director(){Name="Jean-Pierre Jeunet",Age=67,Birthday = new DateTime(1953,9,3),Imdb=9.0,PhotoUrl="jean.jpeg"},
                            new Director(){Name="Cem Yılmaz",Age=48,Birthday = new DateTime(1973,04,23),Imdb=7.4,PhotoUrl="yılmaz.jpeg"},
                            new Director(){Name="Tim Burton",Age=62,Birthday = new DateTime(1958,8,25),Imdb=8.3,PhotoUrl="timburton.jpeg"},
                            new Director(){Name="Bret Retner",Age=36,Birthday = new DateTime(1985,7,13),Imdb=8.2,PhotoUrl="bret.jpeg"},
                            new Director(){Name="Wes Craven",Age=81,Birthday = new DateTime(1938,8,2),Imdb=8.0,PhotoUrl="wes.jpeg"},
                            new Director(){Name="Todd Philips",Age=50,Birthday = new DateTime(1970,12,20),Imdb=8.3,PhotoUrl="todd.jpeg"},
                            new Director(){Name="Ridley Scott",Age=83,Birthday = new DateTime(1937,11,30),Imdb=8.8,PhotoUrl="ridley.jpeg"},
                            new Director(){Name="David Yates",Age=57,Birthday = new DateTime(1963,10,8),Imdb=9.3,PhotoUrl="yates.jpeg"},
                            new Director(){Name="Vin Diesel",Age=53,Birthday = new DateTime(1967,7,20),Imdb=9.0,PhotoUrl="vin.jpeg"},
                            new Director(){Name="Çağan Irmak",Age=51,Birthday = new DateTime(1970,4,4),Imdb=8.1,PhotoUrl="cagan.jpeg"},
                            new Director(){Name="Jon Favreau",Age=54,Birthday = new DateTime(1966,10,19),Imdb=8.1,PhotoUrl="jon.jpeg"},
                            new Director(){Name="Andy Muschietti",Age=47,Birthday = new DateTime(1973,08,26),Imdb=8.5,PhotoUrl="andy.jpeg"},
                            new Director(){Name="Chad Stahelski",Age=52,Birthday = new DateTime(1968,09,20),Imdb=9.3,PhotoUrl="chad.jpeg"},
                            new Director(){Name="Mikael Håfström",Age=61,Birthday = new DateTime(1984,5,29),Imdb=9.0,PhotoUrl="mikael.jpeg"},
                            new Director(){Name="Espen Sandberg",Age=50,Birthday = new DateTime(1971,06,17),Imdb=8.1,PhotoUrl="espen.jpeg"},
                            new Director(){Name="James Wan",Age=44,Birthday = new DateTime(1977,02,26),Imdb=8.5,PhotoUrl="wan.jpeg"},
                            new Director(){Name="Guy Ritchie",Age=52,Birthday = new DateTime(1968,09,10),Imdb=7.9,PhotoUrl="guy.jpeg"},
                            new Director(){Name="Murat Aslan",Age=37,Birthday = new DateTime(1984,05,12),Imdb=7.6,PhotoUrl="aslan.jpeg"},
                            new Director(){Name="Lana Wachowski",Age=56,Birthday = new DateTime(1965,06,21),Imdb=8.7,PhotoUrl="lana.jpeg"},
                            new Director(){Name="Andrew Adamson",Age=54,Birthday = new DateTime(1966,1,1),Imdb=8.2,PhotoUrl="adamson.jpeg"},
                            new Director(){Name="George Miller",Age=76,Birthday = new DateTime(1945,3,3),Imdb=7.1,PhotoUrl="miller.jpeg"},
                            new Director(){Name="Roel Reiné",Age=50,Birthday = new DateTime(1970,7,15),Imdb=6.7,PhotoUrl="roel.jpeg",},
                            new Director(){Name="Sam Raimi",Age=61,Birthday = new DateTime( 1959,10,23),Imdb=9.2,PhotoUrl="raimi.jpeg"},
                            new Director(){Name="John Lasseter",Age=64,Birthday = new DateTime(1957,01,12),Imdb=7.9,PhotoUrl="lasseter.jpeg"},
                            new Director(){Name="Ang Lee",Age=66,Birthday = new DateTime(1954,10,23),Imdb=8.2,PhotoUrl="ang.jpeg"},
                            new Director(){Name="Christopher Nolan",Age=50,Birthday = new DateTime(1970,7,30),Imdb=8.0,PhotoUrl="nolan.jpeg"},
                            new Director(){Name="John G. Avildsen",Age=86,Birthday = new DateTime(1935,12,21),Imdb=8.3,PhotoUrl="avildsen.jpeg"},
                            new Director(){Name="George Lucas",Age=77,Birthday = new DateTime(1944 ,5,14),Imdb=7.8,PhotoUrl="lucas.jpeg"},
                            new Director(){Name="Antoine Fuqua",Age=55,Birthday = new DateTime( 1966,1,19),Imdb=8.1,PhotoUrl="fuqua.jpeg"},
                            new Director(){Name="James Cameron",Age=66,Birthday = new DateTime(1954,08,16),Imdb=8.7,PhotoUrl="cameron.jpeg"},
                            new Director(){Name="Michael Bay",Age=56,Birthday = new DateTime(1965,02,17),Imdb=8.4,PhotoUrl="bay.jpeg"},
                            new Director(){Name="Wolfgang Petersen",Age=80,Birthday = new DateTime(1941,3,14),Imdb=7.1,PhotoUrl="petersen.jpeg"},
                            new Director(){Name="James McTeigue",Age=53,Birthday = new DateTime(1967,12,29),Imdb=7.5,PhotoUrl="mc.jpeg"},
                            new Director(){Name="Ömer Faruk Sorak",Age=57,Birthday = new DateTime(1964,04,27),Imdb=6.2,PhotoUrl="sorak.jpeg"},
                            new Director(){Name="Peter Jackson",Age=60,Birthday = new DateTime(1961,10,31),Imdb=8.7,PhotoUrl="pjackson.jpeg"},
                            new Director(){Name="Martin Scorsese",Age=78,Birthday = new DateTime(1942,11,17),Imdb=8.1,PhotoUrl="scorsese.jpeg"},
                            new Director(){Name="Martin Campbell",Age=77,Birthday = new DateTime(1943,10,24),Imdb=8.0,PhotoUrl="campbell.jpeg"},


                        };

                        var movies = new Movie[]{
                            new Movie(){Name = "Recep İvedik", ReleaseTime = new DateTime(2008,2,21),Imdb=4.5,PhotoUrl="recep.jpeg",director= directors[0]},
                            new Movie(){Name = "Açlık Oyunları", ReleaseTime = new DateTime(2012,3,21),Imdb=8.7,PhotoUrl="aclıkoyunları.jpeg",director= directors[1]},
                            new Movie(){Name = "Amelie", ReleaseTime = new DateTime(2001,11,23),Imdb=9.0,PhotoUrl="amelie.jpeg",director= directors[2]},
                            new Movie(){Name = "Arog", ReleaseTime = new DateTime(2008,12,5),Imdb=7.4,PhotoUrl="arog.jpeg",director= directors[3]},
                            new Movie(){Name = "Batman", ReleaseTime = new DateTime(1989,06,23),Imdb=8.3,PhotoUrl="batman.jpeg",director= directors[4]},
                            new Movie(){Name = "Bitirim İkili", ReleaseTime = new DateTime(1998,07,24),Imdb=8.2,PhotoUrl="bitirimikili.jpeg",director= directors[5]},
                            new Movie(){Name = "Cığlık", ReleaseTime = new DateTime(2004,05,01),Imdb=8.0,PhotoUrl="ciğlık.jpeg",director= directors[6]},
                            new Movie(){Name = "Felekten Bir Gece", ReleaseTime = new DateTime(2011,09,05),Imdb=8.3,PhotoUrl="felektenbirgece.jpeg",director= directors[7]},
                            new Movie(){Name = "Gladyatör", ReleaseTime = new DateTime(2007,01,20),Imdb=8.8,PhotoUrl="gladyator.jpeg",director= directors[8]},
                            new Movie(){Name = "Harry Potter", ReleaseTime = new DateTime(2008,05,16),Imdb=9.3,PhotoUrl="harrypotter.jpeg",director= directors[9]},
                            new Movie(){Name = "Hızlı ve Öfkeli", ReleaseTime = new DateTime(2011,05,06),Imdb=9.0,PhotoUrl="hızlıveofkeli.jpeg",director= directors[10]},
                            new Movie(){Name = "Issız Adam", ReleaseTime = new DateTime(2003,02,12),Imdb=8.1,PhotoUrl="ıssızadam.jpeg",director= directors[11]},
                            new Movie(){Name = "Ironman", ReleaseTime = new DateTime(2014,03,11),Imdb=8.1,PhotoUrl="ironman.jpeg",director= directors[12]},
                            new Movie(){Name = "It", ReleaseTime = new DateTime(2013,03,08),Imdb=8.5,PhotoUrl="it.jpeg",director= directors[13]},
                            new Movie(){Name = "John Wick", ReleaseTime = new DateTime(2005,07,29),Imdb=7.9,PhotoUrl="johnwick.jpeg",director= directors[14]},
                            new Movie(){Name = "Kaçış Planı", ReleaseTime = new DateTime(2010,12,19),Imdb=7.6,PhotoUrl="kacısplanı.jpeg",director= directors[15]},
                            new Movie(){Name = "Karayip Korsanları", ReleaseTime = new DateTime(2008,11,03),Imdb=8.7,PhotoUrl="karayipkorsanları.jpeg",director= directors[16]},
                            new Movie(){Name = "Korku Seansı", ReleaseTime = new DateTime(2011,02,11),Imdb=8.2,PhotoUrl="korkuseansı.jpeg",director= directors[17]},
                            new Movie(){Name = "Kral Arthur", ReleaseTime = new DateTime(2016,12,28),Imdb=7.1,PhotoUrl="kralarthur.jpeg",director= directors[18]},
                            new Movie(){Name = "Maskeli Beşler", ReleaseTime = new DateTime(2008,01,07),Imdb=6.7,PhotoUrl="maskelibesler.jpeg",director= directors[19]},
                            new Movie(){Name = "Matrix", ReleaseTime = new DateTime(2003,04,09),Imdb=9.2,PhotoUrl="matrix.jpeg",director= directors[20]},
                            new Movie(){Name = "Narnia", ReleaseTime = new DateTime(2006,03,18),Imdb=7.9,PhotoUrl="narnia.jpeg",director= directors[21]},
                            new Movie(){Name = "Neşeli Ayaklar", ReleaseTime = new DateTime(2012,01,21),Imdb=8.2,PhotoUrl="neseliayaklar.jpeg",director= directors[22]},
                            new Movie(){Name = "Ölüm Yarışı", ReleaseTime = new DateTime(2009,06,07),Imdb=7.1,PhotoUrl="olumyarısı.jpeg",director= directors[23]},
                            new Movie(){Name = "Örümcek Adam", ReleaseTime = new DateTime(2013,12,21),Imdb=7.6,PhotoUrl="orumcekadam.jpeg",director= directors[24]},
                            new Movie(){Name = "Oyuncak Hikayesi", ReleaseTime = new DateTime(2013,01,11),Imdb=8.2,PhotoUrl="oyuncakhikayesi.jpeg",director= directors[25]},
                            new Movie(){Name = "Pi'nin Yaşamı", ReleaseTime = new DateTime(2009,08,06),Imdb=8.0,PhotoUrl="pininyasamı.jpeg",director= directors[26]},
                            new Movie(){Name = "Prestij", ReleaseTime = new DateTime(2010,05,09),Imdb=8.3,PhotoUrl="prestij.jpeg",director= directors[27]},
                            new Movie(){Name = "Rocky", ReleaseTime = new DateTime(2008,01,08),Imdb=7.6,PhotoUrl="rocky.jpeg",director= directors[28]},
                            new Movie(){Name = "Shrek", ReleaseTime = new DateTime(2014,05,24),Imdb=7.8,PhotoUrl="shrek.jpeg",director= directors[21]},
                            new Movie(){Name = "Star Wars", ReleaseTime = new DateTime(2009,03,23),Imdb=9.1,PhotoUrl="starwars.jpeg",director= directors[29]},
                            new Movie(){Name = "Testere", ReleaseTime = new DateTime(2001,04,22),Imdb=8.1,PhotoUrl="testere.jpeg",director= directors[17]},
                            new Movie(){Name = "Tetikçi", ReleaseTime = new DateTime(2002,11,23),Imdb=7.7,PhotoUrl="tetikci.jpeg",director= directors[30]},
                            new Movie(){Name = "Titanik", ReleaseTime = new DateTime(2003,12,13),Imdb=8.7,PhotoUrl="titanik.jpeg",director= directors[31]},
                            new Movie(){Name = "Transformers", ReleaseTime = new DateTime(2004,01,07),Imdb=8.4,PhotoUrl="transformers.jpeg",director= directors[32]},
                            new Movie(){Name = "Truva", ReleaseTime = new DateTime(2012,08,16),Imdb=7.1,PhotoUrl="truva.jpeg",director= directors[33]},
                            new Movie(){Name = "VForVendetta", ReleaseTime = new DateTime(2011,07,14),Imdb=7.5,PhotoUrl="vforvendetta.jpeg",director= directors[34]},
                            new Movie(){Name = "Yahşi Batı", ReleaseTime = new DateTime(2007,03,04),Imdb=6.2,PhotoUrl="yahsıbatı.jpeg",director= directors[35]},
                            new Movie(){Name = "Yüzüklerin Efendisi", ReleaseTime = new DateTime(2018,07,24),Imdb=8.7,PhotoUrl="yüzüklerinefendisi.jpeg",director= directors[36]},
                            new Movie(){Name = "Zindan Adası", ReleaseTime = new DateTime(1998,06,21),Imdb=8.1,PhotoUrl="zindanadası.jpeg",director= directors[37]},
                            new Movie(){Name = "Zorro", ReleaseTime = new DateTime(2008,05,11),Imdb=8.0,PhotoUrl="zorro.jpeg",director= directors[38]}
                        };

                        var categories = new Category[]{
                            new Category(){CategoryName = "Korku"},
                            new Category(){CategoryName = "Animasyon"},
                            new Category(){CategoryName = "Aksiyon"},
                            new Category(){CategoryName = "Bilim-kurgu"},
                            new Category(){CategoryName = "Komedi"},
                            new Category(){CategoryName = "Fantastik"},
                            new Category(){CategoryName = "Gerilim"},
                            new Category(){CategoryName = "Macera"},
                            new Category(){CategoryName = "Savaş"},
                            new Category(){CategoryName = "Hüzün ve Romatik"},

                        };

                    var variable = new List<CategoryMovie>{
                        new CategoryMovie(){category = categories[4],movie=movies[0]},
                        new CategoryMovie(){category = categories[2],movie=movies[1]},
                        new CategoryMovie(){category = categories[8],movie=movies[1]},
                        new CategoryMovie(){category = categories[3],movie=movies[1]},
                        new CategoryMovie(){category = categories[3],movie=movies[2]},
                        new CategoryMovie(){category = categories[3],movie=movies[3]},
                        new CategoryMovie(){category = categories[4],movie=movies[3]},
                        new CategoryMovie(){category = categories[2],movie=movies[4]},
                        new CategoryMovie(){category = categories[3],movie=movies[4]},
                        new CategoryMovie(){category = categories[8],movie=movies[4]},
                        new CategoryMovie(){category = categories[7],movie=movies[4]},
                        new CategoryMovie(){category = categories[2],movie=movies[5]},
                        new CategoryMovie(){category = categories[5],movie=movies[5]},
                        new CategoryMovie(){category = categories[6],movie=movies[5]},
                        new CategoryMovie(){category = categories[7],movie=movies[5]},
                        new CategoryMovie(){category = categories[0],movie=movies[6]},
                        new CategoryMovie(){category = categories[7],movie=movies[6]},
                        new CategoryMovie(){category = categories[6],movie=movies[6]},
                        new CategoryMovie(){category = categories[0],movie=movies[7]},
                        new CategoryMovie(){category = categories[7],movie=movies[7]},
                        new CategoryMovie(){category = categories[2],movie=movies[8]},
                        new CategoryMovie(){category = categories[8],movie=movies[8]},
                        new CategoryMovie(){category = categories[7],movie=movies[8]},
                        new CategoryMovie(){category = categories[2],movie=movies[9]},
                        new CategoryMovie(){category = categories[3],movie=movies[9]},
                        new CategoryMovie(){category = categories[4],movie=movies[9]},
                        new CategoryMovie(){category = categories[6],movie=movies[9]},
                        new CategoryMovie(){category = categories[2],movie=movies[10]},
                        new CategoryMovie(){category = categories[3],movie=movies[10]},
                        new CategoryMovie(){category = categories[7],movie=movies[10]},
                        new CategoryMovie(){category = categories[9],movie=movies[11]},
                        new CategoryMovie(){category = categories[1],movie=movies[12]},
                        new CategoryMovie(){category = categories[2],movie=movies[12]},
                        new CategoryMovie(){category = categories[3],movie=movies[12]},
                        new CategoryMovie(){category = categories[5],movie=movies[12]},
                        new CategoryMovie(){category = categories[0],movie=movies[13]},
                        new CategoryMovie(){category = categories[2],movie=movies[13]},
                        new CategoryMovie(){category = categories[3],movie=movies[13]},
                        new CategoryMovie(){category = categories[6],movie=movies[13]},
                        new CategoryMovie(){category = categories[2],movie=movies[14]},
                        new CategoryMovie(){category = categories[8],movie=movies[14]},
                        new CategoryMovie(){category = categories[2],movie=movies[15]},
                        new CategoryMovie(){category = categories[7],movie=movies[15]},
                        new CategoryMovie(){category = categories[2],movie=movies[16]},
                        new CategoryMovie(){category = categories[7],movie=movies[16]},
                        new CategoryMovie(){category = categories[0],movie=movies[17]},
                        new CategoryMovie(){category = categories[2],movie=movies[17]},
                        new CategoryMovie(){category = categories[3],movie=movies[17]},
                        new CategoryMovie(){category = categories[6],movie=movies[17]},
                        new CategoryMovie(){category = categories[7],movie=movies[18]},
                        new CategoryMovie(){category = categories[2],movie=movies[19]},
                        new CategoryMovie(){category = categories[4],movie=movies[19]},
                        new CategoryMovie(){category = categories[2],movie=movies[20]},
                        new CategoryMovie(){category = categories[3],movie=movies[20]},
                        new CategoryMovie(){category = categories[5],movie=movies[20]},
                        new CategoryMovie(){category = categories[8],movie=movies[21]},
                        new CategoryMovie(){category = categories[2],movie=movies[21]},
                        new CategoryMovie(){category = categories[1],movie=movies[22]},
                        new CategoryMovie(){category = categories[4],movie=movies[22]},
                        new CategoryMovie(){category = categories[2],movie=movies[23]},
                        new CategoryMovie(){category = categories[7],movie=movies[23]},
                        new CategoryMovie(){category = categories[1],movie=movies[24]},
                        new CategoryMovie(){category = categories[2],movie=movies[24]},
                        new CategoryMovie(){category = categories[3],movie=movies[24]},
                        new CategoryMovie(){category = categories[1],movie=movies[25]},
                        new CategoryMovie(){category = categories[7],movie=movies[25]},
                        new CategoryMovie(){category = categories[9],movie=movies[26]},
                        new CategoryMovie(){category = categories[9],movie=movies[27]},
                        new CategoryMovie(){category = categories[8],movie=movies[28]},
                        new CategoryMovie(){category = categories[2],movie=movies[28]},
                        new CategoryMovie(){category = categories[1],movie=movies[29]},
                        new CategoryMovie(){category = categories[3],movie=movies[29]},
                        new CategoryMovie(){category = categories[5],movie=movies[29]},
                        new CategoryMovie(){category = categories[1],movie=movies[30]},
                        new CategoryMovie(){category = categories[3],movie=movies[30]},
                        new CategoryMovie(){category = categories[5],movie=movies[30]},
                        new CategoryMovie(){category = categories[0],movie=movies[31]},
                        new CategoryMovie(){category = categories[2],movie=movies[31]},
                        new CategoryMovie(){category = categories[3],movie=movies[31]},
                        new CategoryMovie(){category = categories[6],movie=movies[31]},
                        new CategoryMovie(){category = categories[2],movie=movies[32]},
                        new CategoryMovie(){category = categories[6],movie=movies[32]},
                        new CategoryMovie(){category = categories[8],movie=movies[32]},
                        new CategoryMovie(){category = categories[2],movie=movies[33]},
                        new CategoryMovie(){category = categories[7],movie=movies[33]},
                        new CategoryMovie(){category = categories[1],movie=movies[34]},
                        new CategoryMovie(){category = categories[3],movie=movies[34]},
                        new CategoryMovie(){category = categories[7],movie=movies[35]},
                        new CategoryMovie(){category = categories[7],movie=movies[36]},
                        new CategoryMovie(){category = categories[4],movie=movies[37]},
                        new CategoryMovie(){category = categories[7],movie=movies[37]},
                        new CategoryMovie(){category = categories[1],movie=movies[38]},
                        new CategoryMovie(){category = categories[7],movie=movies[38]},
                        new CategoryMovie(){category = categories[2],movie=movies[39]},
                        new CategoryMovie(){category = categories[8],movie=movies[40]},
                        


                    };

                    var players = new Player[]{
                            new Player(){Name="Şahan Gökbakar",Age=40,Birthday = new DateTime(1980,10,22),Imdb=4.5,PhotoUrl="sahan.jpeg"},
                            new Player(){Name="Jennifer Lawrence",Age=30,Birthday = new DateTime(1990,8,15),Imdb=8.5,PhotoUrl="lawrence.jpeg"},
                            new Player(){Name="Audrey Tautou",Age=44,Birthday = new DateTime(1976 ,8,9),Imdb=7.1,PhotoUrl="audrey.jpeg"},
                            new Player(){Name="Cem Yılmaz",Age=48,Birthday = new DateTime(1973,04,23),Imdb=7.4,PhotoUrl="yılmaz.jpeg"},
                            new Player(){Name="Robert Pattinson",Age=35,Birthday = new DateTime(1986,5,13),Imdb=7.9,PhotoUrl="pattinson.jpeg"},
                            new Player(){Name="Jackie Chan",Age=67,Birthday = new DateTime(1954,4,7),Imdb=8.9,PhotoUrl="chan.jpeg"},
                            new Player(){Name="Neve Campbell",Age=47,Birthday = new DateTime(1973,10,3),Imdb=8.1,PhotoUrl="neve.jpeg"},
                            new Player(){Name="Phil Wenneck ",Age=40,Birthday = new DateTime(1980,2,20),Imdb=8.0,PhotoUrl="wenneck.jpeg"},
                            new Player(){Name="Russell Crowe",Age=37,Birthday = new DateTime(1984,5,29),Imdb=7.7,PhotoUrl="crowe.jpeg"},
                            new Player(){Name="Daniel Radcliffe",Age=31,Birthday = new DateTime(1989,7,23),Imdb=8.0,PhotoUrl="radcliffe.jpeg"},
                            new Player(){Name="Vin Diesel",Age=53,Birthday = new DateTime(1967,7,20),Imdb=9.0,PhotoUrl="vin.jpeg"},
                            new Player(){Name="Cemal Hünal",Age=44,Birthday = new DateTime(1976,10,2),Imdb=5.6,PhotoUrl="cemal.jpeg"},
                            new Player(){Name="Robert Downey",Age=56,Birthday = new DateTime(1965,4,4),Imdb=8.4,PhotoUrl="downey.webp"},
                            new Player(){Name="Jaeden Martell",Age=18,Birthday = new DateTime(2003,1,4),Imdb=7.4,PhotoUrl="martell.jpeg"},
                            new Player(){Name="Keanu Reeves",Age=56,Birthday = new DateTime(1964,9,2),Imdb=8.3,PhotoUrl="reeves.jpeg"},
                            new Player(){Name="Sylvester Stallone",Age=75,Birthday = new DateTime(1946,7,2),Imdb=8.1,PhotoUrl="stallone.jpeg"},
                            new Player(){Name="Johnny Depp",Age=58,Birthday = new DateTime(1963,6,9),Imdb=9.2,PhotoUrl="depp.jpeg"},
                            new Player(){Name="Vera Farmiga",Age=47,Birthday = new DateTime(1973,8,6),Imdb=7.6,PhotoUrl="farmiga.jpeg"},
                            new Player(){Name="Charlie Hunnam",Age=41,Birthday = new DateTime(1980,4,10),Imdb=7.8,PhotoUrl="hunnam.jpeg"},
                            new Player(){Name="Şafak Sezer",Age=50,Birthday = new DateTime(1970,10,10),Imdb=7.0,PhotoUrl="sezer.jpeg"},
                            new Player(){Name="Anna Popplewell",Age=32,Birthday = new DateTime(1988,12,16),Imdb=7.7,PhotoUrl="popplewel.jpeg"},
                            new Player(){Name="Animasyon",Age=0,Birthday = new DateTime(2000,1,1),Imdb=4.5,PhotoUrl="neseliayaklar.jpeg"},
                            new Player(){Name="Jason Statham",Age=53,Birthday = new DateTime(1967,7,26),Imdb=9.0,PhotoUrl="statham.jpeg"},
                            new Player(){Name="Willem Dafoe",Age=65,Birthday = new DateTime(1955,7,22),Imdb=8.5,PhotoUrl="dafoe.jpeg"},
                            new Player(){Name="Animasyon",Age=0,Birthday = new DateTime(2000,1,1),Imdb=4.5,PhotoUrl="oyuncakhikayesi.jpeg"},
                            new Player(){Name="Suraj Sharma",Age=28,Birthday = new DateTime(1993,3,21),Imdb=7.5,PhotoUrl="sharma.jpeg"},
                            new Player(){Name="Hugh Jackman",Age=52,Birthday = new DateTime(1968,10,12),Imdb=47.5,PhotoUrl="jackman.jpeg"},
                            new Player(){Name="Sylvester Stallone",Age=75,Birthday = new DateTime(1946,7,2),Imdb=9.5,PhotoUrl="stallone.jpeg"},
                            new Player(){Name="Animasyon",Age=0,Birthday = new DateTime(2000,1,1),Imdb=4.5,PhotoUrl="shrek.jpeg"},
                            new Player(){Name="Animasyon",Age=0,Birthday = new DateTime(2000,1,1),Imdb=4.5,PhotoUrl="starwars.jpeg"},
                            new Player(){Name="Tobin Bell",Age=78,Birthday = new DateTime(1942,8,7),Imdb=7.8,PhotoUrl="bell.jpeg"},
                            new Player(){Name="Leonardo DiCaprio",Age=46,Birthday = new DateTime(1974,11,11),Imdb=9.5,PhotoUrl="leonardo.jpeg"},
                            new Player(){Name="Animasyon",Age=0,Birthday = new DateTime(2000,1,1),Imdb=4.5,PhotoUrl="transformers.jpeg"},
                            new Player(){Name="Brad Pitt",Age=57,Birthday = new DateTime(1963,12,18),Imdb=9.5,PhotoUrl="pitt.jpeg"},
                            new Player(){Name="Natalie Portman",Age=40,Birthday = new DateTime(1981,6,9),Imdb=7.5,PhotoUrl="portman.jpeg"},
                            new Player(){Name="Elijah Wood",Age=40,Birthday = new DateTime(1981,1,28),Imdb=6.5,PhotoUrl="wood.jpeg"},
                            new Player(){Name="Antonio Banderas",Age=60,Birthday = new DateTime(1960,8,10),Imdb=7.1,PhotoUrl="banderas.webp"},


                    };

                 

                    var movpla = new List<MoviePlayer>{
                        new MoviePlayer(){movie = movies[0],player=players[0]},
                        new MoviePlayer(){movie = movies[1],player=players[1]},
                        new MoviePlayer(){movie = movies[2],player=players[2]},
                        new MoviePlayer(){movie = movies[3],player=players[3]},
                        new MoviePlayer(){movie = movies[4],player=players[4]},
                        new MoviePlayer(){movie = movies[5],player=players[5]},
                        new MoviePlayer(){movie = movies[6],player=players[6]},
                        new MoviePlayer(){movie = movies[7],player=players[7]},
                        new MoviePlayer(){movie = movies[8],player=players[8]},
                        new MoviePlayer(){movie = movies[9],player=players[9]},
                        new MoviePlayer(){movie = movies[10],player=players[10]},
                        new MoviePlayer(){movie = movies[11],player=players[11]},
                        new MoviePlayer(){movie = movies[12],player=players[12]},
                        new MoviePlayer(){movie = movies[13],player=players[13]},
                        new MoviePlayer(){movie = movies[14],player=players[14]},
                        new MoviePlayer(){movie = movies[15],player=players[15]},
                        new MoviePlayer(){movie = movies[16],player=players[16]},
                        new MoviePlayer(){movie = movies[17],player=players[17]},
                        new MoviePlayer(){movie = movies[18],player=players[18]},
                        new MoviePlayer(){movie = movies[19],player=players[19]},
                        new MoviePlayer(){movie = movies[20],player=players[14]},
                        new MoviePlayer(){movie = movies[21],player=players[20]},
                        new MoviePlayer(){movie = movies[22],player=players[21]},
                        new MoviePlayer(){movie = movies[23],player=players[22]},
                        new MoviePlayer(){movie = movies[24],player=players[23]},
                        new MoviePlayer(){movie = movies[25],player=players[24]},
                        new MoviePlayer(){movie = movies[26],player=players[25]},
                        new MoviePlayer(){movie = movies[27],player=players[26]},
                        new MoviePlayer(){movie = movies[28],player=players[27]},
                        new MoviePlayer(){movie = movies[29],player=players[28]},
                        new MoviePlayer(){movie = movies[30],player=players[29]},
                        new MoviePlayer(){movie = movies[31],player=players[30]},
                        new MoviePlayer(){movie = movies[32],player=players[23]},
                        new MoviePlayer(){movie = movies[33],player=players[31]},
                        new MoviePlayer(){movie = movies[34],player=players[32]},
                        new MoviePlayer(){movie = movies[35],player=players[33]},
                        new MoviePlayer(){movie = movies[36],player=players[34]},
                        new MoviePlayer(){movie = movies[37],player=players[3]},
                        new MoviePlayer(){movie = movies[38],player=players[35]},
                        new MoviePlayer(){movie = movies[39],player=players[35]},
                        new MoviePlayer(){movie = movies[40],player=players[35]},
                    };

                    context.categories.AddRange(categories);

                    context.SaveChanges();

                    context.players.AddRange(players);

                    context.SaveChanges();

                    context.directors.AddRange(directors);

                    context.SaveChanges();

                    context.movies.AddRange(movies);

                    context.SaveChanges();

                    context.AddRange(movpla);

                    context.SaveChanges();
                    
                    context.AddRange(variable);
                    
                    context.SaveChanges();


                    }

                  

                }
            

        }

    }
}
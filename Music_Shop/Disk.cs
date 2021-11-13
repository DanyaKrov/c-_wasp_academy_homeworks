using System;
using System.Collections.Generic;
using System.Linq;

namespace Music_Shop
{
    public interface IStoreItem
    {
        public double Price { set; get;}
        public void DiscountPrice(int percent);
    }
    public class Disk
    {
        public string name, genre;
        public int burnCount;
        public Disk(string name, string genre)
        {
            this.name = name;
            this.genre = genre;
        }
        public virtual int DiskSize
        {
            get { return 0; }
        }

        public double Price { get; set; }

        public virtual void Burn(params string[] list1)
        {
            name = list1[0];
            genre = list1[1];
            burnCount += list1.Length;
        }
        public void DiscountPrice(int percent)
        {
            Price = Convert.ToDouble(100 - percent) * Price / 100.0;
        }

        public virtual string ToString()
        {
            return $"{name} - {genre} - {burnCount}";
        }
    }
    public class Audio : Disk
    {
        public string artist, recordingStudio;
        public int songsNumber;
        public Audio(string name, string genre, string artist, string recordingStudio, int songsNumber) : base(name, genre)
        {
            this.artist = artist;
            this.recordingStudio = recordingStudio;
            this.songsNumber = songsNumber;
        }
        public string Name
        {
            get { return name; }
        }
        public override int DiskSize
        {
            get { return songsNumber * 8; }
        }
        public override void Burn(params string[] list1)
        {
            name = list1[0];
            genre = list1[1];
            artist = list1[2];
            recordingStudio = list1[3];
            int.TryParse(list1[4], out songsNumber);
            burnCount += list1.Length;
        }
        public override string ToString()
        {
            return $"{name} - {genre} - {artist} - {recordingStudio} - {songsNumber} - {burnCount}";
        }
    }
    public class DVD : Disk
    {
        public string producer, filmCompany;
        public int minutesCount;
        public DVD(string name, string genre, string producer, string filmCompany, int minutesCount) : base(name, genre)
        {
            this.producer = producer;
            this.filmCompany = filmCompany;
            this.minutesCount = minutesCount;
        }
        public string Name
        {
            get { return name; }
        }
        public override int DiskSize
        {
            get { return (minutesCount / 64) * 2; }
        }
        public override void Burn(params string[] list1)
        {
            name = list1[0];
            genre = list1[1];
            producer = list1[2];
            filmCompany = list1[3];
            int.TryParse(list1[4], out minutesCount);
            burnCount += list1.Length;
        }
        public override string ToString()
        {
            return $"{name} - {genre} - {producer} - {filmCompany} - {minutesCount} - {burnCount}";
        }
    }
    public class Store
    {
        public string storeName, address;
        public List<Audio> audios = new List<Audio>();
        public List<DVD> dvds = new List<DVD>();
        public Store(string storeName, string address)
        {
            this.storeName = storeName;
            this.address = address;
        }
        public List<Audio> GetAudios
        {
            set { audios = value; }
            get { return audios; }
        }
        public List<DVD> GetDVDs
        {
            set { dvds = value; }
            get { return dvds; }
        }
        public static Store operator +(Store store, DVD dvd)
        {
            store.dvds.Add(dvd);
            return store;
        }
        public static Store operator -(Store store, DVD dvd)
        {
            store.dvds.Remove(dvd);
            return store;
        }
        public static Store operator +(Store store, Audio audio)
        {
            store.audios.Add(audio);
            return store;
        }
        public static Store operator -(Store store, Audio audio)
        {
            store.audios.Remove(audio);
            return store;
        }
        public string ToString()
        {
            string string_ans = "";
            foreach (Audio audio in audios)
            {
                string_ans += $"{audio.ToString()}\n";
            }
            foreach (DVD dvd in dvds)
            {
                string_ans += $"{dvd.ToString()}\n";
            }
            return string_ans;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Store store = new Store("Cool shop name", "Asovsky");
            store += new Audio("Ti_gorish_kak_ogon", "Rap", "Slava_Bebrou", "Moscow", 23);
            store += new Audio("Snova_ia_napivays", "Rap", "Slava_Bebrou", "Moscow", 27);
            store += new DVD("Gentelmen", "Criminal", "Guy Riche", "Miramax", 160);
            store += new DVD("Agents ANKL", "Spy-thriller", "Guy Riche", "Miramax", 160);
            store.GetAudios[0].Burn(new string[] { "Ti_gorish_kak_ogon", "Rap", "Slava_Bebrou", "Moscow", "23" });
            Console.WriteLine(store.ToString());
            foreach (Audio audio in store.GetAudios)
            {
                Console.WriteLine(audio.Name + audio.DiskSize);
            }
            foreach (DVD dvd in store.GetDVDs)
            {
                Console.WriteLine(dvd.Name + dvd.DiskSize);
            }
        }
    }
}
